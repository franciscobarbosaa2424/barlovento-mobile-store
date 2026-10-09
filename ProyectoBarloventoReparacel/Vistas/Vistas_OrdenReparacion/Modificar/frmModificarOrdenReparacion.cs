using ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.WhatsApp;
using System.Drawing.Imaging;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Imagen;
using System.Windows.Forms.DataVisualization.Charting;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using Guna.UI2.WinForms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Modificar
{
    public partial class frmModificarOrdenReparacion : Form
    {
        int id_orden;
        int id_cliente;
        int id_dispositivo;
        private List<byte[]> imagenesSeleccionadas = new List<byte[]>();
        public frmModificarOrdenReparacion()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };

            #region Metodos Enter KeyPress
            this.tb_falla.KeyPress += new KeyPressEventHandler(tb_falla_KeyPress);
            this.cb_estado.KeyPress += new KeyPressEventHandler(cb_estado_KeyPress);
            this.btn_agregar_imagen.KeyPress += new KeyPressEventHandler(btn_agregar_imagen_KeyPress);
            this.btn_modificar.KeyPress += new KeyPressEventHandler(btn_modificar_KeyPress);
            #endregion

        }

        #region Botones
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarOrden();
        }

        private void btn_agregar_imagen_Click(object sender, EventArgs e)
        {
            AgregarImagen();
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

        private void frmModificarOrdenReparacion_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    AgregarImagen();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    ModificarOrden();
                    e.Handled = true;
                    break;

               

                default:
                    break;
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

        private void cb_estado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_modificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        #region Metodos auxiliares
        private void AbrirFormularioVerImagen(byte[] imagen)
        {
            // Crear una instancia del segundo formulario (Formulario B)
            frmVerImagen frmVerImagen = new frmVerImagen(imagen);
            frmVerImagen.ShowDialog(); // Mostrar el formulario modalmente
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

        private void EliminarImagen(Label lbl, byte[] imagen)
        {
            // Eliminar imagen de la lista
            imagenesSeleccionadas.Remove(imagen);

            // Eliminar Label del FlowLayoutPanel
            flowLayoutPanel1.Controls.Remove(lbl);
        }

        public void ModificarOrden()
        {
            int idOrden = id_orden;
            string falla = tb_falla.Text;
            string estado = cb_estado.Text;

            Orden_De_Reparacion_Controladora orden_De_Reparacion_Controladora = new Orden_De_Reparacion_Controladora();
            OrdenDeReparacion ordenDeReparacion = new OrdenDeReparacion(
               idOrden,
               falla,
               estado,
               imagenesSeleccionadas
            );

            // Llamada para dar de alta la orden de reparación con múltiples imágenes
            if (orden_De_Reparacion_Controladora.ModificarOrdenDeReparacion(ordenDeReparacion))
            {
                frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

                if (frmOrdenReparacionHome != null)
                {
                    // Si el formulario ya está abierto, utiliza la instancia existente
                    frmOrdenReparacionHome.CargarOrdenes();
                }

                MessageBox.Show("La órden de reparación ha sido modificada exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (estado == "Terminado")
                {
                    var resultado = MessageBox.Show(
              "¿Quieres enviar un mensaje a WhatsApp?.",
              "Confirmar envio",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        EnviarMensaje();
                    }
                }
            }
        }

        private void EnviarMensaje()
        {
            int idCliente = id_cliente;
            frmMensajeWhatsApp frmMensajeWhatsApp = new frmMensajeWhatsApp();
            frmMensajeWhatsApp.setDatosTextBox(idCliente);
            frmMensajeWhatsApp.ShowDialog();
        }

        public void CargarDatosDtgv(int pIdOrden, int pDispositivoId, int pIdCliente, string pTipoCliente, string pFalla, string pEstado)
        {
            if (pTipoCliente == "PERSONA")
            {
                CargarDispositivo(pDispositivoId);
                CargarPersona(pIdCliente);
            }
            else if (pTipoCliente == "EMPRESA")
            {
                CargarDispositivo(pDispositivoId);
                CargarEmpresa(pIdCliente);
            }
            CargarImagenesOrdenReparacion(pIdOrden);
            id_cliente = pIdCliente;
            id_orden = pIdOrden;
            id_dispositivo = pDispositivoId;
            tb_falla.Text = pFalla;
            cb_estado.Text = pEstado;
        }

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
        }

        private void CargarEmpresa(int pIdCliente)
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



        }

        private void CargarPersona(int pIdCliente)
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


        }

        private void EliminarImagenBaseDeDatos(Label lbl, int imagenID, byte[] imagen)
        {
            try
            {
                // Consulta para eliminar la imagen de la base de datos
                string consultaEliminar = $"DELETE FROM Imagenes WHERE ImagenID = {imagenID}";
                Conexion conexion = new Conexion();
                conexion.Consulta(consultaEliminar);

                // Eliminar imagen de la lista
                imagenesSeleccionadas.Remove(imagen);

                // Eliminar Label del FlowLayoutPanel
                flowLayoutPanel1.Controls.Remove(lbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] ConvertirImagen(string filePath)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image img = Image.FromFile(filePath);
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void CargarImagenesOrdenReparacion(int idOrden)
        {
            // Consulta para obtener las imágenes de la orden de reparación
            string consulta = $"SELECT ImagenID, Imagen FROM Imagenes WHERE OrdenDeReparacionID = {idOrden}";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];

            // Limpiar el FlowLayoutPanel antes de cargar las imágenes
            flowLayoutPanel1.Controls.Clear();
            imagenesSeleccionadas.Clear();

            foreach (DataRow row in dt.Rows)
            {
                byte[] imagenBytes = (byte[])row["Imagen"];
                imagenesSeleccionadas.Add(imagenBytes);

                // Mostrar el nombre de la imagen en el FlowLayoutPanel
                Label lblFileName = new Label();
                lblFileName.Text = "Imagen guardada";  // Puedes ajustar este texto según tus necesidades
                lblFileName.AutoSize = true;
                lblFileName.ForeColor = Color.DimGray;

                // Crear un ContextMenuStrip para eliminar la imagen
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem eliminarItem = new ToolStripMenuItem("Eliminar de la base de datos");
                int imagenID = (int)row["ImagenID"];
                eliminarItem.Click += (s, ev) => EliminarImagenBaseDeDatos(lblFileName, imagenID, imagenBytes);
                contextMenu.Items.Add(eliminarItem);

                ToolStripMenuItem verItem = new ToolStripMenuItem("Ver imagen");
                verItem.Click += (s, ev) => AbrirFormularioVerImagen(imagenBytes); // Abrir el formulario para ver la imagen
                contextMenu.Items.Add(verItem);

                // Asignar el ContextMenuStrip al Label
                lblFileName.ContextMenuStrip = contextMenu;

                // Agregar el Label al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(lblFileName);
            }
        }


        #endregion

        private void frmModificarOrdenReparacion_Load(object sender, EventArgs e)
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
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(128, 141, 124);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_modificar.Image = Properties.Resources.icono_modificar_claro;
            this.btn_agregar_imagen.Image = Properties.Resources.icono_agregar_imagen_claro;

            this.lb_titulo.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_3.ForeColor = Color.White;
            this.lb_4.ForeColor = Color.White;
            this.lb_5.ForeColor = Color.White;

            this.tb_falla.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_falla.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_falla.ForeColor = Color.White;

            this.cb_estado.FillColor = Color.FromArgb(128, 141, 124);
            this.cb_estado.BorderColor = Color.FromArgb(95, 111, 101);
            this.cb_estado.ForeColor = Color.White;

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
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(35, 36, 40);

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
  
            this.btn_modificar.Image = Properties.Resources.icono_modificar;
            this.btn_agregar_imagen.Image = Properties.Resources.icono_agregar_imagen;

            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.lb_3.ForeColor = Color.DimGray;
            this.lb_4.ForeColor = Color.DimGray;
            this.lb_5.ForeColor = Color.DimGray;
   
            this.tb_falla.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_falla.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_falla.ForeColor = Color.FromArgb(125, 137, 149);
            this.cb_estado.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_estado.BorderColor = Color.FromArgb(18, 18, 18);
            this.cb_estado.ForeColor = Color.FromArgb(125, 137, 149);

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



    }
}