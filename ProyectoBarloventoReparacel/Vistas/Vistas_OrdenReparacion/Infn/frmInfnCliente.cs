using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_AMBCliente.Alta;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseña;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.InformacionPropietario
{
    public partial class frmInfnCliente : Form
    {
        private string tema;
        string tipo_cliente;
        public frmInfnCliente()
        {
            InitializeComponent();
            this.KeyPreview = true;
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
        public void EliminarPropietario()
        {
            if (dtgv_propietario.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_propietario.SelectedRows[0];
                int idPropietario = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este cliente? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();

                    if (ClienteTieneOrden(idPropietario))
                    {
                        string consulta_clientes_orden = $"DELETE FROM ORDEN_DE_REPARACION WHERE clienteId = {idPropietario}";
                        conexion.Selección(consulta_clientes_orden);
                    }
                    if(ClienteTieneDispositivo(idPropietario))
                    {
                        string consulta_clientes_orden = $"DELETE FROM DISPOSITIVO_CLIENTE WHERE clienteId = {idPropietario}";
                        conexion.Selección(consulta_clientes_orden);
                    }

                    string consulta = $"DELETE FROM CLIENTE WHERE ID = {idPropietario}";
                    conexion.Selección(consulta);

                    MessageBox.Show("El cliente ha sido eliminado exitosamente.",
                        "Eliminación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                    RecargarDtgvHome();
                    RecargarAgregarOrden();
                }
            }
            else
            {
                MessageBox.Show(
                    "Por favor, selecciona un cliente para eliminar.",
                    "Eliminar Cliente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        public bool ClienteTieneOrden(int pIdPropietario)
        {
            int cantidad_clientes = 0;
            string consulta_clientes_orden = @"
                SELECT COUNT(*)
                FROM  ORDEN_DE_REPARACION
                WHERE clienteId  =" + pIdPropietario + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_clientes_orden);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cantidad_clientes = Convert.ToInt32(row[0]);
            }

            if (cantidad_clientes > 0)
            {
                return true;
            }
            return false;
        }

        public bool ClienteTieneDispositivo(int pIdPropietario)
        {
            int cantidad_dispositivos = 0;
            string consulta_dispositivos_orden = @"
                SELECT COUNT(*)
                FROM  DISPOSITIVO_CLIENTE
                WHERE clienteId  =" + pIdPropietario + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_dispositivos_orden);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cantidad_dispositivos = Convert.ToInt32(row[0]);
            }

            if (cantidad_dispositivos > 0)
            {
                return true;
            }
            return false;
        }

        public void RecargarDtgvHome()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.CargarOrdenes();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.CargarOrdenes();
            }
        }

        public void RecargarAgregarOrden()
        {
            // Verifica si el formulario ya está abierto

            frmAgregarOrdenReparacion frmAgregarOrdenReparacion = Application.OpenForms["frmAgregarOrdenReparacion"] as frmAgregarOrdenReparacion;

            if (frmAgregarOrdenReparacion != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmAgregarOrdenReparacion.Close();
            }
        }

        public void CargarDatosDtgv(int pIdCliente, string pTipoCliente)
        {
            if (pTipoCliente == "PERSONA")
            {
                tipo_cliente = "PERSONA";
                CargarPersona(pIdCliente);
                CargarDispositivos(pIdCliente);
            }
            else if (pTipoCliente == "EMPRESA")
            {
                tipo_cliente = "EMPRESA";
                CargarEmpresa(pIdCliente);
                CargarDispositivos(pIdCliente);
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

        private void CargarDispositivos(int idCliente)
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
            CLIENTE c ON dc.clienteId = c.ID WHERE dc.ClienteId =" + idCliente + ";";

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

            dtgv_dispositivo.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivo.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivo.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivo.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
            dtgv_dispositivo.Columns["btnVerContraseña"].DisplayIndex = 15;
            dtgv_dispositivo.Columns["btnVerPatron"].DisplayIndex = 16;
            dtgv_dispositivo.Columns["Observacion"].HeaderText = "Observación";

        }

        public void HistorialOrdenes()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;
            DataGridViewRow filaSeleccionada = dtgv_propietario.SelectedRows[0];
            string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
            int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);


            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.HistorialPropietarioDtgv(id, tipo_cliente);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.HistorialPropietarioDtgv(id, tipo_cliente);
            }
        }

        public void ModificarPropietario()
        {
            DataGridViewRow filaSeleccionada = dtgv_propietario.SelectedRows[0];
            frmModificarCliente frmModificarCliente = new frmModificarCliente();
            if (tipo_cliente == "EMPRESA")
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                long rut = Convert.ToInt64(filaSeleccionada.Cells["Rut"].Value);
                string razon_social = Convert.ToString(filaSeleccionada.Cells["RazonSocial"].Value);
                string correo = Convert.ToString(filaSeleccionada.Cells["Correo"].Value);
                int contacto_1 = Convert.ToInt32(filaSeleccionada.Cells["Contacto1"].Value);
                int contacto_2 = Convert.ToInt32(filaSeleccionada.Cells["Contacto2"].Value);
                string departamento = Convert.ToString(filaSeleccionada.Cells["Departamento"].Value);
                string localidad = Convert.ToString(filaSeleccionada.Cells["Localidad"].Value);

                frmModificarCliente.CargarDatosEmpresa(id, rut, razon_social, correo, contacto_1, contacto_2, localidad, departamento);
                frmModificarCliente.Show();
            }
            else if (tipo_cliente == "PERSONA")
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                int documento = Convert.ToInt32(filaSeleccionada.Cells["Documento"].Value);
                string nombre = Convert.ToString(filaSeleccionada.Cells["NombreCompleto"].Value);
                string correo = Convert.ToString(filaSeleccionada.Cells["Correo"].Value);
                int contacto_1 = Convert.ToInt32(filaSeleccionada.Cells["Contacto1"].Value);
                int contacto_2 = Convert.ToInt32(filaSeleccionada.Cells["Contacto2"].Value);
                string departamento = Convert.ToString(filaSeleccionada.Cells["Departamento"].Value);
                string localidad = Convert.ToString(filaSeleccionada.Cells["Localidad"].Value);

                frmModificarCliente.CargarDatosPersona(id, documento, nombre, correo, contacto_1, contacto_2, localidad, departamento);
                frmModificarCliente.Show();
            }
        }

        #endregion

        #region Botones

        private void btn_historial_ordenes_Click(object sender, EventArgs e)
        {
            HistorialOrdenes();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarPropietario(); 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarPropietario();
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void frmInfnCliente_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    EliminarPropietario();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    HistorialOrdenes();
                    e.Handled = true;
                    break;

                case Keys.F3:
                    ModificarPropietario();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        #endregion

        private void frmInfnCliente_Load(object sender, EventArgs e)
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


            this.panel_dtgv_dispositivo.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(128, 141, 124);



            this.lb_titulo.ForeColor = Color.White;
            this.lb_dispositivo.ForeColor = Color.White;
            this.lb_propietario.ForeColor = Color.White;


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
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
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

            this.btn_eliminar.Image = Properties.Resources.icono_eliminar_claro;
            this.btn_historial_ordenes.Image = Properties.Resources.icono_dtgv_orden_claro;
            this.btn_modificar.Image = Properties.Resources.icono_modificar_claro;
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.BackColor = Color.Black;

            this.btn_eliminar.Image = Properties.Resources.icono_eliminar;
            this.btn_historial_ordenes.Image = Properties.Resources.icono_dtgv_orden;
            this.btn_modificar.Image = Properties.Resources.icono_modificar;


            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv_dispositivo.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(35, 36, 40);


            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_propietario.ForeColor = Color.DimGray;
            this.lb_dispositivo.ForeColor = Color.DimGray;


            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;

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
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
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
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }
    }
}
