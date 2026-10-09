using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Clientes;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Modificar;
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
using ProyectoBarloventoReparacel.Properties;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseña;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Patron;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseñaPatron;

namespace ProyectoBarloventoReparacel.Vistas
{
    public partial class frmDispositivosHome : Form
    {
        private string tema;
        public frmDispositivosHome()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            this.KeyPreview = true;

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

            dtgv_dispositivos.Columns.Add(ver_contraseña);
            dtgv_dispositivos.Columns.Add(ver_patron);
        }

        private void frmDispositivosHome_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
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
            this.panel_opciones.FillColor = Color.FromArgb(128, 141, 124);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_opciones_menu.FillColor = Color.FromArgb(95, 111, 101);

            this.dtgv_dispositivos.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivos.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivos.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_dispositivos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_dispositivos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.btn_inicio.Image = Resources.icono_inicio_menu_claro;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu_claro;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu_claro;
            this.btn_clientes.Image = Resources.icono_clientes_menu_claro;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu_claro;
            this.btn_movimientos.Image = Resources.icono_movimientos_claro;
         

            this.btn_inicio.ForeColor = Color.White;
            this.btn_ajustes.ForeColor = Color.White;
            this.btn_clientes.ForeColor = Color.White;
            this.btn_ordenes.ForeColor = Color.White;
            this.btn_dispositivos.ForeColor = Color.White;
         
            this.btn_movimientos.ForeColor = Color.White;

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_maximizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.lb_titulo.ForeColor = Color.White;
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_orden_asc_desc.Image = Resources.icono_orden_asc_desc_claro;
            this.btn_eliminar.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_agregar.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_modificar.FillColor = Color.FromArgb(128, 141, 124);

            this.btn_eliminar.Image = Resources.icono_eliminar_claro;
            this.btn_agregar.Image = Resources.icono_agregar_claro;
            this.btn_modificar.Image = Resources.icono_modificar_claro;

            this.tb_buscar.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_buscar.ForeColor = Color.White;
            this.tb_buscar.FocusedState.ForeColor = Color.White;
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.PlaceholderForeColor = Color.White;
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_opciones.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_eliminar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_agregar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_modificar.FillColor = Color.FromArgb(35, 36, 40);
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
            this.cntb_maximizar_formulario.FillColor = Color.Black;
            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_opciones_menu.FillColor = Color.FromArgb(18, 18, 18);

            this.dtgv_dispositivos.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivos.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;


            this.tb_buscar.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.PlaceholderForeColor = Color.Gray;


            foreach (DataGridViewRow row in dtgv_dispositivos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_dispositivos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);

            this.lb_titulo.ForeColor = Color.DimGray;
            this.btn_inicio.Image = Resources.icono_inicio_menu;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu;
            this.btn_clientes.Image = Resources.icono_clientes_menu;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu;
            this.btn_movimientos.Image = Resources.icono_movimientos;

            this.btn_inicio.ForeColor = Color.Gray;
            this.btn_ajustes.ForeColor = Color.Gray;
            this.btn_clientes.ForeColor = Color.Gray;
            this.btn_ordenes.ForeColor = Color.Gray;
            this.btn_dispositivos.ForeColor = Color.Gray;
          
            this.btn_movimientos.ForeColor = Color.Gray;
            this.btn_orden_asc_desc.Image = Resources.icono_orden_asc_desc;
           
            this.btn_eliminar.Image = Resources.icono_eliminar;
            this.btn_agregar.Image = Resources.icono_agregar;
            this.btn_modificar.Image = Resources.icono_modificar;
        }

        #region Eventos y validaciones TextBox
        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            string dato = "%" + tb_buscar.Text + "%";
            BuscarDispositivo(dato);

            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 100;

            // Verificamos si el texto ingresado supera el limite
            if (tb_buscar.Text.Length > maximo_caracteres)
            {
                tb_buscar.Text = tb_buscar.Text.Substring(0, maximo_caracteres);
                tb_buscar.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void frmDispositivosHome_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    EliminarDispositivo();
                    break;

                case Keys.F2:
                    AgregarDispositivo();
                    break;

                case Keys.F3:
                    ModificarDispositivo();
                    break;

                default:
                    break;
            }
        }

        private void dtgv_dispositivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_dispositivos.Columns[e.ColumnIndex].Name == "btnVerContraseña" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivos.SelectedRows[0];
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                frmContAdmin frmContAdmin = new frmContAdmin();
                frmContAdmin.CargarContraseña(idDispositivo);
                frmContAdmin.ShowDialog();
            }
            if (dtgv_dispositivos.Columns[e.ColumnIndex].Name == "btnVerPatron" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivos.SelectedRows[0];
                string patron = Convert.ToString(filaSeleccionada.Cells["Patron"].Value);
                frmContAdmin frmContAdmin = new frmContAdmin();
                frmContAdmin.CargarPatron(patron);
                frmContAdmin.ShowDialog();
               
            }
        }

        #endregion

        #region Metodos auxiliares
        public void ModificarDispositivo()
        {
            if (dtgv_dispositivos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivos.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string tipo = Convert.ToString(filaSeleccionada.Cells["TipoDispositivo"].Value);
                string marca = Convert.ToString(filaSeleccionada.Cells["Marca"].Value);
                string modelo = Convert.ToString(filaSeleccionada.Cells["Modelo"].Value);
                string numero_de_serie = Convert.ToString(filaSeleccionada.Cells["NumeroDeSerie"].Value);
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                string observacion = Convert.ToString(filaSeleccionada.Cells["Observacion"].Value);
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells["clienteId"].Value);
                string patron = Convert.ToString(filaSeleccionada.Cells["Patron"].Value);
                string contraseña = Convert.ToString(filaSeleccionada.Cells["Contraseña"].Value);

                frmModificarDispositivo frmModificarDispositivo = new frmModificarDispositivo();
                frmModificarDispositivo.CargarDispositivo(id, tipo, marca, modelo, numero_de_serie, observacion, idCliente, tipo_cliente, contraseña, patron);
                frmModificarDispositivo.Show();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para modificar.");
            }

        }

        public void CargarDispositivos()
        {
            dtgv_dispositivos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            dc.idDispositivo AS Id,
            dc.clienteId AS ClienteId,
            dc.TIPO_DISPOSITIVO AS TipoDispositivo,
            dc.MARCA AS Marca,
            dc.MODELO AS Modelo,
            dc.PATRON AS Patron,
            dc.CONTRASEÑA AS Contraseña,
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
            CLIENTE c ON dc.clienteId = c.ID;";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_dispositivos.DataSource = dt;


            dtgv_dispositivos.Columns["Id"].Visible = false;
            dtgv_dispositivos.Columns["Nombre"].Visible = false;
            dtgv_dispositivos.Columns["RazonSocial"].Visible = false;
            dtgv_dispositivos.Columns["Correo"].Visible = false;
            dtgv_dispositivos.Columns["Localidad"].Visible = false;
            dtgv_dispositivos.Columns["Departamento"].Visible = false;
            dtgv_dispositivos.Columns["Contacto1"].Visible = false;
            dtgv_dispositivos.Columns["Contacto2"].Visible = false;
            dtgv_dispositivos.Columns["ClienteId"].Visible = false;
            dtgv_dispositivos.Columns["TipoCliente"].Visible = false;
            dtgv_dispositivos.Columns["Patron"].Visible = false;
            dtgv_dispositivos.Columns["Contraseña"].Visible = false;

            dtgv_dispositivos.Columns["Observacion"].HeaderText = "Observación";
            dtgv_dispositivos.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivos.Columns["Documento"].HeaderText = "Documento Dueño";
            dtgv_dispositivos.Columns["Rut"].HeaderText = "Rut Dueño";
            dtgv_dispositivos.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivos.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivos.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
            dtgv_dispositivos.Columns["btnVerContraseña"].DisplayIndex = 15;
            dtgv_dispositivos.Columns["btnVerPatron"].DisplayIndex = 16;
        }

        public void EliminarDispositivo()
        {
            if (dtgv_dispositivos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivos.SelectedRows[0];
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este dispositivo? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();

                    // Primero, verifica si el dispositivo tiene órdenes de reparación
                    if (DispositivoTieneOrden(idDispositivo))
                    {
                        // Obtiene las órdenes relacionadas con el dispositivo
                        List<int> ordenes = ObtenerOrdenesPorDispositivo(idDispositivo);

                        // Elimina las imágenes asociadas a cada orden
                        foreach (int idOrden in ordenes)
                        {
                            if (OrdenTieneImagen(idOrden))
                            {
                                string consulta_imagenes = $"DELETE FROM Imagenes WHERE OrdenDeReparacionID = {idOrden}";
                                conexion.Selección(consulta_imagenes);
                            }

                            // Elimina la orden de reparación después de eliminar las imágenes
                            string consulta_orden = $"DELETE FROM ORDEN_DE_REPARACION WHERE idOrden = {idOrden}";
                            conexion.Selección(consulta_orden);
                        }
                    }

                    // Finalmente, elimina el dispositivo
                    string consulta_dispositivo = $"DELETE FROM DISPOSITIVO_CLIENTE WHERE idDispositivo = {idDispositivo}";
                    conexion.Selección(consulta_dispositivo);

                    MessageBox.Show("El dispositivo ha sido eliminado exitosamente.",
                        "Eliminación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDispositivos();
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

        private List<int> ObtenerOrdenesPorDispositivo(int idDispositivo)
        {
            List<int> ordenes = new List<int>();
            string consulta_ordenes = $"SELECT idOrden FROM ORDEN_DE_REPARACION WHERE idDispositivo = {idDispositivo}";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_ordenes);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                int idOrden = Convert.ToInt32(row["idOrden"]);
                ordenes.Add(idOrden);
            }

            return ordenes;
        }


        // Identificar si una orden de reparación tiene imagenes para luego eliminarlas
        private bool OrdenTieneImagen(int idOrden)
        {
            int cantidad_imagenes = 0;
            string consulta_imagenes_orden = @"
                SELECT COUNT(*)
                FROM Imagenes
                WHERE OrdenDeReparacionID  =" + idOrden + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_imagenes_orden);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cantidad_imagenes = Convert.ToInt32(row[0]);
            }

            if (cantidad_imagenes > 0)
            {
                return true;
            }
            return false;
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

        private void BuscarDispositivo(string pDato)
        {
            string consulta = @"
           SELECT 
            dc.idDispositivo AS Id,
            dc.clienteId AS ClienteId,
            dc.TIPO_DISPOSITIVO AS TipoDispositivo,
            dc.MARCA AS Marca,
            dc.MODELO AS Modelo,
            dc.PATRON AS Patron,
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
            CLIENTE c ON dc.clienteId = c.ID WHERE"
            + " MARCA LIKE '" + pDato.ToString()
            + "' OR NUMERO_DE_SERIE LIKE '" + pDato.ToString()
            + "' OR MODELO LIKE '" + pDato.ToString() + "';";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_dispositivos.DataSource = dt;

            dtgv_dispositivos.Columns["Observacion"].HeaderText = "Observación";
            dtgv_dispositivos.Columns["btnVerContraseña"].DisplayIndex = 15;
            dtgv_dispositivos.Columns["Patron"].Visible = false;
            dtgv_dispositivos.Columns["btnVerPatron"].DisplayIndex = 16;

        }

        public void AgregarDispositivo()
        {
            frmAgregarDispositivo frmAgregarDispositivo = new frmAgregarDispositivo();
            frmAgregarDispositivo.Show();
        }

        #endregion

        #region Botones
        private void btn_orden_asc_desc_Click(object sender, EventArgs e)
        {
            if (btn_orden_asc_desc.Checked)
            {
                DataTable dt = (DataTable)dtgv_dispositivos.DataSource;
                dt.DefaultView.Sort = "Id DESC";
                dtgv_dispositivos.DataSource = dt;
            }
            else
            {
                DataTable dt = (DataTable)dtgv_dispositivos.DataSource;
                dt.DefaultView.Sort = "Id ASC";
                dtgv_dispositivos.DataSource = dt;
            }
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            ModificarDispositivo();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarDispositivo();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarDispositivo();
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
          
        }

        private void cntb_cerrar_formulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ordenes_Click_1(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            frmClientesHome frmClientesHome = new frmClientesHome();
            frmClientesHome.Show();
            this.Close();
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            frmMovimientosHome frmMovimientosHome = new frmMovimientosHome();
            frmMovimientosHome.Show();
            this.Close();
        }

        private void btn_dispositivos_Click_1(object sender, EventArgs e)
        {
            frmDispositivosHome frmDispositivosHome = new frmDispositivosHome();
            frmDispositivosHome.Show();
            this.Close();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void cntb_maximizar_formulario_Click(object sender, EventArgs e)
        {
            CargarDispositivos();
        }


        #endregion

        private void btn_ajustes_Click_1(object sender, EventArgs e)
        {
            frmAjustes frmAjustes = new frmAjustes();
            frmAjustes.ShowDialog();
        }

        private void dtgv_dispositivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                    if (dtgv_dispositivos.Columns[e.ColumnIndex].Name == "btnVerContraseña")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña_claro;
                    }
                    if (dtgv_dispositivos.Columns[e.ColumnIndex].Name == "btnVerPatron")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña_claro;
                    }
                }
                else if (tema == "Oscuro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                    if (dtgv_dispositivos.Columns[e.ColumnIndex].Name == "btnVerContraseña")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña;
                    }
                    if (dtgv_dispositivos.Columns[e.ColumnIndex].Name == "btnVerPatron")
                    {
                        e.Value = Properties.Resources.icono_dtgv_contraseña;
                    }
                }
            }
        }
    }
}
