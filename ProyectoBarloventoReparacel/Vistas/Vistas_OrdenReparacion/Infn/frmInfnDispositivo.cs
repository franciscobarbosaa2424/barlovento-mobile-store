using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Modificar;
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

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Informacion
{
    public partial class frmInfnDispositivo : Form
    {
        private string tema;
        string tipo_cliente;
        public frmInfnDispositivo()
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
            dtgv_propietario.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
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
            dtgv_dispositivo.Columns["Observacion"].HeaderText = "Observación";
            dtgv_dispositivo.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivo.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivo.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
            dtgv_dispositivo.Columns["btnVerContraseña"].DisplayIndex = 15;
            dtgv_dispositivo.Columns["btnVerPatron"].DisplayIndex = 16;

        }

        public void ModificarDispositivo()
        {
            DataGridViewRow filaSeleccionada = dtgv_dispositivo.SelectedRows[0];

            int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
            string tipo = Convert.ToString(filaSeleccionada.Cells["TipoDispositivo"].Value);
            string marca = Convert.ToString(filaSeleccionada.Cells["Marca"].Value);
            string modelo = Convert.ToString(filaSeleccionada.Cells["Modelo"].Value);
            string numero_de_serie = Convert.ToString(filaSeleccionada.Cells["NumeroDeSerie"].Value);
            string observacion = Convert.ToString(filaSeleccionada.Cells["Observacion"].Value);
            int id_cliente = Convert.ToInt32(filaSeleccionada.Cells["ClienteId"].Value);
            string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
            string contraseña = Convert.ToString(filaSeleccionada.Cells["Contraseña"].Value);
            string patron = Convert.ToString(filaSeleccionada.Cells["Patron"].Value);

            frmModificarDispositivo frmModificarDispositivo = new frmModificarDispositivo();
            frmModificarDispositivo.CargarDispositivo(id, tipo, marca, modelo, numero_de_serie, observacion, id_cliente, tipo_cliente, contraseña, patron);
            frmModificarDispositivo.Show();
        }

        public bool DispositivoTieneOrden(int idDispositivo)
        {
            int cantidad_ordenes = 0;
            string consulta_dispositivos_orden = @"
                SELECT COUNT(*)
                FROM  ORDEN_DE_REPARACION
                WHERE idDispositivo  =" + idDispositivo + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_dispositivos_orden);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cantidad_ordenes = Convert.ToInt32(row[0]);
            }

            if (cantidad_ordenes > 0)
            {
                return true;
            }
            return false;
        }

        public void EliminarDispositivo()
        {
            if (dtgv_dispositivo.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivo.SelectedRows[0];
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este dispositivo? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();

                    if (DispositivoTieneOrden(idDispositivo))
                    {
                        string consulta_dispositivos_orden = $"DELETE FROM ORDEN_DE_REPARACION WHERE idDispositivo = {idDispositivo}";
                        conexion.Selección(consulta_dispositivos_orden);
                    }

                    string consulta = $"DELETE FROM DISPOSITIVO_CLIENTE WHERE idDispositivo = {idDispositivo}";
                    conexion.Selección(consulta);

                    MessageBox.Show("El dispositivo ha sido eliminado exitosamente.",
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
                    "Por favor, selecciona un dispositivo para eliminar.",
                    "Eliminar Dispositivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
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

        public void HistorialOrdenes()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;
            DataGridViewRow filaSeleccionada = dtgv_dispositivo.SelectedRows[0];
            int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);


            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.MostrarDispositivosDtgv(id);
            }
        }
        #endregion

        #region Botones
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarDispositivo();
        }

        private void btn_historial_ordenes_Click(object sender, EventArgs e)
        {
            HistorialOrdenes();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarDispositivo();
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void frmInfnDispositivo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    EliminarDispositivo();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    HistorialOrdenes();
                    e.Handled = true;
                    break;

                case Keys.F3:
                    ModificarDispositivo();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        #endregion

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




        private void frmInfnDispositivo_Load(object sender, EventArgs e)
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
