using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseña;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Imagen;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Modificar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Infn
{
    public partial class frmInfnOrden : Form
    {
        private string tema;
        string tipo_cliente;
        private List<byte[]> imagenesSeleccionadas = new List<byte[]>();
        public frmInfnOrden()
        {
            InitializeComponent();
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };

            DataGridViewImageColumn ver_contraseña = new DataGridViewImageColumn
            {
                Name = "btnVerContraseña",
                HeaderText = "Contraseña",
                Width = 10,
                Image = Properties.Resources.icono_dtgv_contraseña,
            };

            DataGridViewImageColumn ver_patron = new DataGridViewImageColumn
            {
                Name = "btnVerPatron",
                HeaderText = "Patrón",
                Width = 10,
                Image = Properties.Resources.icono_dtgv_contraseña,
            };

            dtgv_dispositivo.Columns.Add(ver_contraseña);
            dtgv_dispositivo.Columns.Add(ver_patron);
        }

        #region Metodos auxiliares
        public void CargarFechasOrden(int pIdOrden)
        {
            dtgv_fechas.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            fechaIngreso AS FechaIngreso,
            fechaEgreso AS FechaEgreso
            FROM 
            ORDEN_DE_REPARACION WHERE idOrden = " + pIdOrden + ";";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_fechas.DataSource = dt;

            dtgv_fechas.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_fechas.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
        }

        public void CargarFalla(int pIdOrden)
        {
            dtgv_falla.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            falla AS Falla
            FROM 
            ORDEN_DE_REPARACION WHERE idOrden = " + pIdOrden + ";";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_falla.DataSource = dt;

            dtgv_falla.Columns["Falla"].HeaderText = "Falla del dispositivo";
            dtgv_falla.Columns["Falla"].DisplayIndex = 0;
            CargarImagenesOrdenReparacion(pIdOrden);
        }

        public void CargarDatosFacturacion(int pIdOrden)
        {
            dtgv_datos_facturacion.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            total AS Total,
            presupuesto AS Presupuesto,
            manoDeObra AS ManoDeObra,
            materiales AS Materiales
            FROM 
            ORDEN_DE_REPARACION WHERE idOrden = " + pIdOrden + ";";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_datos_facturacion.DataSource = dt;

            dtgv_datos_facturacion.Columns["Presupuesto"].HeaderText = "Presupuesto";
            dtgv_datos_facturacion.Columns["Presupuesto"].DisplayIndex = 0;

            dtgv_datos_facturacion.Columns["ManoDeObra"].HeaderText = "Mano de obra";
            dtgv_datos_facturacion.Columns["ManoDeObra"].DisplayIndex = 1;

            dtgv_datos_facturacion.Columns["Materiales"].HeaderText = "Materiales";
            dtgv_datos_facturacion.Columns["Materiales"].DisplayIndex = 2;

            dtgv_datos_facturacion.Columns["Total"].HeaderText = "Total ($)";
            dtgv_datos_facturacion.Columns["Total"].DisplayIndex = 3;

        }

        public void MostrarDatosDtgv(int pIdCliente, string pTipoCliente, int pIdDispositivo)
        {
            if (pTipoCliente == "PERSONA")
            {
                tipo_cliente = "PERSONA";
                CargarPersona(pIdCliente);
                CargarDispositivo(pIdDispositivo);
            }
            else if (pTipoCliente == "EMPRESA")
            {
                tipo_cliente = "EMPRESA";
                CargarEmpresa(pIdCliente);
                CargarDispositivo(pIdDispositivo);

            }
        }

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
            CORREO AS Correo
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;

            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;
            dtgv_propietario.Columns["TipoCliente"].Visible = false;
            dtgv_propietario.Columns["RazonSocial"].HeaderText = "Razon Social";
            dtgv_propietario.Columns["Rut"].HeaderText = "Rut";
            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto ";
            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";


        }

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
            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto";
            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_propietario.Columns["Contacto2"].Width = 120;
            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";

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
            dc.CONTRASEÑA AS Contraseña,
            dc.PATRON AS Patron,
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
            dtgv_dispositivo.Columns["Patron"].Visible = false;
            dtgv_dispositivo.Columns["Contraseña"].Visible = false;

            dtgv_dispositivo.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivo.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivo.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivo.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
            dtgv_dispositivo.Columns["btnVerContraseña"].DisplayIndex = 15;
            dtgv_dispositivo.Columns["btnVerPatron"].DisplayIndex = 16;
            dtgv_dispositivo.Columns["Observacion"].HeaderText = "Observación";

        }

        #endregion

        public void CargarTemaClaro()
        {
            tema = "Claro";
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
        

            this.panel_dtgv_falla.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_dispositivo.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_facturacion.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_fechas.FillColor = Color.FromArgb(128, 141, 124);


            this.lb_titulo.ForeColor = Color.White;


            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
          

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


            this.dtgv_datos_facturacion.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_datos_facturacion.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_datos_facturacion.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_datos_facturacion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_datos_facturacion.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_datos_facturacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_datos_facturacion.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_datos_facturacion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.dtgv_falla.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_falla.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_falla.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_falla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_falla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_falla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_falla.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_falla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

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

            this.dtgv_fechas.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_fechas.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_fechas.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_fechas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_fechas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_fechas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_fechas.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_fechas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv_falla.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_dispositivo.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_facturacion.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_fechas.FillColor = Color.FromArgb(35, 36, 40);

            this.lb_titulo.ForeColor = Color.DimGray;

         


            this.cntb_cerrar_formulario.FillColor = Color.Black;
         

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

            this.dtgv_datos_facturacion.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_datos_facturacion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_datos_facturacion.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_datos_facturacion.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_datos_facturacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_datos_facturacion.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_datos_facturacion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);

            this.dtgv_falla.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_falla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_falla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_falla.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_falla.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_falla.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_falla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);


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

            this.dtgv_fechas.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_fechas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_fechas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_fechas.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_fechas.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_fechas.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_fechas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
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
                ToolStripMenuItem verItem = new ToolStripMenuItem("Ver imagen");
                verItem.Click += (s, ev) => AbrirFormularioVerImagen(imagenBytes); // Abrir el formulario para ver la imagen
                contextMenu.Items.Add(verItem);

                // Asignar el ContextMenuStrip al Label
                lblFileName.ContextMenuStrip = contextMenu;

                // Agregar el Label al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(lblFileName);
            }
        }

        private void AbrirFormularioVerImagen(byte[] imagen)
        {
            // Crear una instancia del segundo formulario (Formulario B)
            frmVerImagen frmVerImagen = new frmVerImagen(imagen);
            frmVerImagen.ShowDialog(); // Mostrar el formulario modalmente
        }


        private void frmInfnOrden_Load(object sender, EventArgs e)
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

        private void dtgv_dispositivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnVerContraseña" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivo.SelectedRows[0];
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                frmContAdmin frmContAdmin = new frmContAdmin();
                frmContAdmin.CargarContraseña(idDispositivo);
                frmContAdmin.ShowDialog();
            }
            if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnVerPatron" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivo.SelectedRows[0];
                string patron = Convert.ToString(filaSeleccionada.Cells["Patron"].Value);
                frmContAdmin frmContAdmin = new frmContAdmin();
                frmContAdmin.CargarPatron(patron);
                frmContAdmin.ShowDialog();

            }
        }

        private void dtgv_dispositivo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {
                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnVerContraseña")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña_claro;
                    }
                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnVerPatron")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña_claro;
                    }
                }
                else if (tema == "Oscuro")
                {
                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnVerContraseña")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña;
                    }
                    if (dtgv_dispositivo.Columns[e.ColumnIndex].Name == "btnVerPatron")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña;
                    }
                }
            }
        }
    }
}
