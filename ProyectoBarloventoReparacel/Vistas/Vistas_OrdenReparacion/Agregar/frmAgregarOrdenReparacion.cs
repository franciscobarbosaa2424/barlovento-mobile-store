using ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras;
using ProyectoBarloventoReparacel.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.SeleccionarPOrden;
using ProyectoBarloventoReparacel.Persistencia;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.InformacionPropietario;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Informacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Imagen;
using Guna.UI2.WinForms;


namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion
{
    public partial class frmAgregarOrdenReparacion : Form
    {
        private string tema;
        private string tipo_cliente;
        int id_dispositivo;
        int id_cliente;
        string numero_de_serie;

        private List<byte[]> imagenesSeleccionadas = new List<byte[]>();
        public frmAgregarOrdenReparacion()
        {
            InitializeComponent();
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            DataGridViewImageColumn mas_informacion_propietario = new DataGridViewImageColumn
            {
                Name = "btnMasInformacion",
                HeaderText = " ",
                Image = Properties.Resources.icono_dtgv_informacion,
            };

            dtgv_propietario.Columns.Add(mas_informacion_propietario);

            DataGridViewImageColumn mas_informacion_dispositivo = new DataGridViewImageColumn
            {
                Name = "btnMasInformacion",
                HeaderText = " ",
                Image = Properties.Resources.icono_dtgv_informacion,
            };

            dtgv_dispositivo.Columns.Add(mas_informacion_dispositivo);

            this.KeyPreview = true;

            #region Metodos Enter KeyPress
            this.btn_agregar_imagen.KeyPress += new KeyPressEventHandler(btn_agregar_imagen_KeyPress);
            this.btn_agregar.KeyPress += new KeyPressEventHandler(btn_agregar_KeyPress);
            this.btn_seleccionar_dispositivo.KeyPress += new KeyPressEventHandler(btn_agregar_dispositivo_KeyPress);
            this.btn_agregar_dispositivo.KeyPress += new KeyPressEventHandler(btn_agregar_dispositivo_KeyPress);
            this.tb_falla.KeyPress += new KeyPressEventHandler(tb_falla_KeyPress);
            #endregion

        }


        #region Metodos auxiliares
        // Comprobamos si hay algun campo vacio 
        private bool FaltaDatos()
        {
            
            if (
                this.tb_falla.Text == "" ||
                this.id_cliente == 0 ||
                this.id_dispositivo == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Obtener datos dado un numero de serie 
        public void DatosDadoNumeroDeSerie(string pNumeroDeSerie)
        {
            numero_de_serie = pNumeroDeSerie;
            string consulta_id_dispositivo = @"
                SELECT idDispositivo
                FROM DISPOSITIVO_CLIENTE
                WHERE numero_de_serie = '" + pNumeroDeSerie + "';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_id_dispositivo);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                id_dispositivo = Convert.ToInt32(row[0]);
            }

            string consulta_id_cliente = @"
                SELECT ClienteId
                FROM DISPOSITIVO_CLIENTE
                WHERE idDispositivo =" + id_dispositivo + ";";

            DataSet ds2 = conexion.Selección(consulta_id_cliente);
            DataTable dt2 = ds2.Tables[0];

            if (dt2.Rows.Count > 0)
            {
                DataRow row = dt2.Rows[0];
                id_cliente = Convert.ToInt32(row[0]);
            }

            string consulta_tipo_cliente = @"
                SELECT TIPO_CLIENTE
                FROM CLIENTE
                WHERE ID =" + id_cliente + ";";

            DataSet ds3 = conexion.Selección(consulta_tipo_cliente);
            DataTable dt3 = ds3.Tables[0];

            if (dt3.Rows.Count > 0)
            {
                DataRow row = dt3.Rows[0];
                tipo_cliente = Convert.ToString(row[0]);
            }

            MostrarDatosDtgv(id_dispositivo, id_cliente, tipo_cliente);
        }

        // Mostrar los datos en los Dtgv
        public void MostrarDatosDtgv(int pDispositivoId, int pIdCliente, string pTipoCliente)
        {
            if(pTipoCliente == "PERSONA")
            {
                CargarDispositivo(pDispositivoId);
                CargarPersona(pIdCliente);
            }
            else if(pTipoCliente == "EMPRESA")
            {
                CargarDispositivo(pDispositivoId);
                CargarEmpresa(pIdCliente);
            }
         
            id_cliente = pIdCliente;
            id_dispositivo = pDispositivoId;
        }

        // Convertir la imagen 
        private byte[] ConvertirImagen(string filePath)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image img = Image.FromFile(filePath);
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        // Eliminar una imagen
        private void EliminarImagen(Label lbl, byte[] imagen)
        {
            // Eliminar imagen de la lista
            imagenesSeleccionadas.Remove(imagen);

            // Eliminar Label del FlowLayoutPanel
            flowLayoutPanel1.Controls.Remove(lbl);
        }

        // Cargar un Dispositivo especifico
        private void CargarDispositivo(int idDispositivo)
        {
            dtgv_dispositivo.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            dc.idDispositivo AS Id,
            dc.clienteId AS ClienteId,
            dc.TIPO_DISPOSITIVO AS TipoDispositivo,
            dc.MARCA AS Marca,
            dc.MODELO AS Modelo,
            dc.NUMERO_DE_SERIE AS NumeroDeSerie,
            dc.OBSERVACION AS Observacion,
            c.NOMBRE_COMPLETO AS Nombre,
            c.DOCUMENTO AS Documento,
            c.RUT as Rut,
            c.CORREO as Correo,
            c.LOCALIDAD AS Localidad,
            c.DEPARTAMENTO AS Departamento,
            c.CONTACTO_1 AS Contacto1,
            c.CONTACTO_2 AS Contacto2,
            c.TIPO_CLIENTE AS TipoCliente,
            c.RAZON_SOCIAL AS RazonSocial
            FROM 
            DISPOSITIVO_CLIENTE dc
            JOIN 
            CLIENTE c ON dc.clienteId = c.ID WHERE dc.idDispositivo =" + idDispositivo + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_dispositivo.DataSource = dt;


            dtgv_dispositivo.Columns["Id"].Visible = false;
            dtgv_dispositivo.Columns["Observacion"].Visible = false;
            dtgv_dispositivo.Columns["Nombre"].Visible = false;
            dtgv_dispositivo.Columns["RazonSocial"].Visible = false;
            dtgv_dispositivo.Columns["Correo"].Visible = false;
            dtgv_dispositivo.Columns["Rut"].Visible = false;
            dtgv_dispositivo.Columns["Localidad"].Visible = false;
            dtgv_dispositivo.Columns["Departamento"].Visible = false;
            dtgv_dispositivo.Columns["Contacto1"].Visible = false;
            dtgv_dispositivo.Columns["Contacto2"].Visible = false;
            dtgv_dispositivo.Columns["ClienteId"].Visible = false;
            dtgv_dispositivo.Columns["Documento"].Visible = false;
            dtgv_dispositivo.Columns["TipoCliente"].Visible = false;

            dtgv_dispositivo.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivo.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivo.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivo.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";

            dtgv_dispositivo.Columns["btnMasInformacion"].Width = 50;
            dtgv_dispositivo.Columns["btnMasInformacion"].DisplayIndex = 10;
        }

        // Cargar una Empresa especifico
        public void CargarEmpresa(int pIdCliente)
        {
            dtgv_propietario.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            RUT AS Rut,
            RAZON_SOCIAL AS RazonSocial,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            FECHA_AUD AS FechaRegistro,
            HORA_AUD AS HoraRegistro,
            CORREO AS Correo
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;

            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;

            dtgv_propietario.Columns["TipoCliente"].Visible = false;

            dtgv_propietario.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";

            dtgv_propietario.Columns["FechaRegistro"].Visible = false;

            dtgv_propietario.Columns["HoraRegistro"].HeaderText = "Hora de ing.";

            dtgv_propietario.Columns["HoraRegistro"].Visible = false;

            dtgv_propietario.Columns["RazonSocial"].HeaderText = "Razon Social";

            dtgv_propietario.Columns["Rut"].HeaderText = "Rut";

            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";

            dtgv_propietario.Columns["Departamento"].Visible = false;

            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";

            dtgv_propietario.Columns["Localidad"].Visible = false;

            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto ";

            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_propietario.Columns["Contacto2"].Visible = false;

            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";

            dtgv_propietario.Columns["btnMasInformacion"].Width = 50;
            dtgv_propietario.Columns["btnMasInformacion"].DisplayIndex = 11;
        }

        // Cargar una Persona especifica
        public void CargarPersona(int pIdCliente)
        {
            dtgv_propietario.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            NOMBRE_COMPLETO AS NombreCompleto,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;

            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;

            dtgv_propietario.Columns["TipoCliente"].HeaderText = "Tipo cliente";
            dtgv_propietario.Columns["TipoCliente"].Visible = false;

            dtgv_propietario.Columns["NombreCompleto"].HeaderText = "Nombre";

            dtgv_propietario.Columns["Documento"].HeaderText = "Documento";

            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";

            dtgv_propietario.Columns["Departamento"].Visible = false;

            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";

            dtgv_propietario.Columns["Localidad"].Visible = false;

            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto";

            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";

            dtgv_propietario.Columns["Contacto2"].Width = 120;

            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";

            dtgv_propietario.Columns["Correo"].Visible = false;

            dtgv_propietario.Columns["btnMasInformacion"].Width = 50;
            dtgv_propietario.Columns["btnMasInformacion"].DisplayIndex = 9;
        }

        // Agregar una nueva orden de reparación
        public void AgregarOrden()
        {
            if (FaltaDatos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos antes de continuar.",
            "Datos Incompletos",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            }
            else
            {
                DateTime fechaIngreso = DateTime.Now;
                int idDispositivo = id_dispositivo;
                int idCliente = id_cliente;
                string falla = tb_falla.Text;
                string estado = "Pendiente";

                Orden_De_Reparacion_Controladora orden_De_Reparacion_Controladora = new Orden_De_Reparacion_Controladora();
                OrdenDeReparacion ordenDeReparacion = new OrdenDeReparacion(
                   fechaIngreso,
                   idCliente,
                   idDispositivo,
                   falla,
                   estado,
                   imagenesSeleccionadas // Pasar la lista de imágenes seleccionadas
                );


                if (orden_De_Reparacion_Controladora.AltaOrdenDeReparacion(ordenDeReparacion))
                {
                    frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

                    if (frmOrdenReparacionHome != null)
                    {
                        // Si el formulario ya está abierto, utiliza la instancia existente
                        frmOrdenReparacionHome.CargarOrdenes();
                    }

                    MessageBox.Show("La órden de reparación ha sido ingresada exitosamente.", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar la  órden de reparación. Por favor, intente nuevamente.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Agregar una nueva imagen a la orden de reparación
        public void AgregarImagen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // Permitir selección múltiple
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Filtrar solo imágenes
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (string fileName in ofd.FileNames)
                {
                    // Convertir la imagen a byte[] y agregarla a la lista
                    byte[] imagen = ConvertirImagen(fileName);
                    imagenesSeleccionadas.Add(imagen);

                    // Mostrar el nombre de la imagen en el FlowLayoutPanel
                    Label lblFileName = new Label();
                    lblFileName.Text = System.IO.Path.GetFileName(fileName);
                    lblFileName.AutoSize = true;
                    lblFileName.ForeColor = Color.DimGray; // Opcional: Ajustar color del texto

                    // Crear un ContextMenuStrip para eliminar la imagen o verla
                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                    ToolStripMenuItem eliminarItem = new ToolStripMenuItem("Eliminar");
                    eliminarItem.Click += (s, ev) => EliminarImagen(lblFileName, imagen);
                    contextMenu.Items.Add(eliminarItem);

                    ToolStripMenuItem verItem = new ToolStripMenuItem("Ver imagen");
                    verItem.Click += (s, ev) => AbrirFormularioVerImagen(imagen); // Abrir el formulario para ver la imagen
                    contextMenu.Items.Add(verItem);

                    // Asignar el ContextMenuStrip al Label
                    lblFileName.ContextMenuStrip = contextMenu;

                    flowLayoutPanel1.Controls.Add(lblFileName);
                }
            }
        }

        private void AbrirFormularioVerImagen(byte[] imagen)
        {
            // Crear una instancia del segundo formulario (Formulario B)
            frmVerImagen frmVerImagen = new frmVerImagen(imagen);
            frmVerImagen.ShowDialog(); // Mostrar el formulario modalmente
        }

        // Seleccionar un dispositivo ya ingresado
        public void SeleccionarDispositivo()
        {
            frmSeleccionarDispositivoOrden frmSeleccionarDispositivoOrden = new frmSeleccionarDispositivoOrden();
            frmSeleccionarDispositivoOrden.ShowDialog();
            this.Close();
        }

        // Agregar un nuevo dispositivo
        public void AgregarDispositivo()
        {
            frmAgregarDispositivo frmAgregarDispositivo = new frmAgregarDispositivo();
            frmAgregarDispositivo.Show();
            this.Close();
        }

        #endregion

        #region Botones 
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            AgregarOrden();
        }

        private void btn_agregar_imagen_Click_1(object sender, EventArgs e)
        {
            AgregarImagen();
        }

        private void btn_seleccionar_dispositivo_Click_1(object sender, EventArgs e)
        {
            SeleccionarDispositivo();
        }

        private void btn_agregar_dispositivo_Click(object sender, EventArgs e)
        {
            AgregarDispositivo();
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void tb_falla_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (255) */
            int maxCaracteres = 255;

            /* Verificamos si el texto ingresado supera el limite */
            if (tb_falla.Text.Length > maxCaracteres)
            {
                tb_falla.Text = tb_falla.Text.Substring(0, maxCaracteres);
                tb_falla.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
            }
        }

        private void dtgv_dispositivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la columna clicada es la del botón (btnInformacion)
            if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnMasInformacion" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivo.Rows[e.RowIndex];
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                int id = Convert.ToInt32(filaSeleccionada.Cells["ClienteId"].Value);
                int id_dispositivo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                frmInfnDispositivo frmInformacionDispositivo = new frmInfnDispositivo();
                frmInformacionDispositivo.MostrarDatosDtgv(id, tipo_cliente, id_dispositivo);
                frmInformacionDispositivo.Show();
            }
        }

        private void dtgv_propietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la columna clicada es la del botón (btnInformacion)
            if (dtgv_propietario.Columns[e.ColumnIndex].Name == "btnMasInformacion" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_propietario.Rows[e.RowIndex];
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                frmInfnCliente frmInformacionCliente = new frmInfnCliente();
                frmInformacionCliente.CargarDatosDtgv(id, tipo_cliente);
                frmInformacionCliente.Show();
            }
        }

        private void frmAgregarOrdenReparacion_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    AgregarDispositivo();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    SeleccionarDispositivo();
                    e.Handled = true;
                    break;

                case Keys.F3:
                    AgregarImagen();
                    e.Handled = true;
                    break;

                case Keys.F4:
                    AgregarOrden();
                    e.Handled = true;
                    break;


                default:
                    break;
            }
        }

        private void btn_agregar_dispositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_seleccionar_dispositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_falla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_agregar_imagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_agregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        private void frmAgregarOrdenReparacion_Load(object sender, EventArgs e)
        {
            // Aplicar el tema guardado
            if (Properties.Settings.Default.TemaOscuro)
            {
                CargarTemaOscuro();
            }
            else
            {
                CargarTemaClaro();
            }
        }

        public void CargarTemaClaro()
        {
            tema = "Claro";
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(128, 141, 124);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_agregar.Image = Properties.Resources.icono_agregar_claro;
            this.btn_agregar_imagen.Image = Properties.Resources.icono_agregar_imagen_claro;
            this.btn_seleccionar_dispositivo.Image = Properties.Resources.icono_seleccionar_claro;
            this.btn_agregar_dispositivo.Image = Properties.Resources.icono_agregar_claro;

            this.lb_titulo.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_3.ForeColor = Color.White;
            this.lb_4.ForeColor = Color.White;
          

            this.tb_falla.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_falla.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_falla.ForeColor = Color.White;

            this.dtgv_dispositivo.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivo.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivo.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_dispositivo.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_dispositivo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.dtgv_propietario.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_propietario.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_propietario.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_propietario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_propietario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(35, 36, 40);

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;

            this.btn_agregar.Image = Properties.Resources.icono_agregar;
            this.btn_agregar_imagen.Image = Properties.Resources.icono_agregar_imagen;
            this.btn_seleccionar_dispositivo.Image = Properties.Resources.icono_seleccionar;
            this.btn_agregar_dispositivo.Image = Properties.Resources.icono_agregar;

            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.lb_3.ForeColor = Color.DimGray;
            this.lb_4.ForeColor = Color.DimGray;
           

            this.tb_falla.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_falla.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_falla.ForeColor = Color.FromArgb(125, 137, 149);
          
            this.dtgv_dispositivo.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivo.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_dispositivo.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_dispositivo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);


            this.dtgv_propietario.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_propietario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_propietario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
        }

        private void dtgv_dispositivo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {

                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnMasInformacion")
                    {
                        e.Value = Properties.Resources.icono_dtgv_informacion_claro;
                    }
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                }
                else if (tema == "Oscuro")
                {
                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnMasInformacion")
                    {
                        e.Value = Properties.Resources.icono_dtgv_informacion;
                    }
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }

        private void dtgv_propietario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {

                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnMasInformacion")
                    {
                        e.Value = Properties.Resources.icono_dtgv_informacion_claro;
                    }
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                }
                else if (tema == "Oscuro")
                {
                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnMasInformacion")
                    {
                        e.Value = Properties.Resources.icono_dtgv_informacion;
                    }
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }
    }
}
