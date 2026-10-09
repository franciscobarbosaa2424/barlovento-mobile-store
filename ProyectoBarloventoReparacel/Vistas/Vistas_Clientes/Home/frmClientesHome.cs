using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_AMBCliente.Alta;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos;
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
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Properties;
using ProyectoBarloventoReparacel.Vistas.Vistas_Clientes.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;

namespace ProyectoBarloventoReparacel.Vistas
{
    public partial class frmClientesHome : Form
    {
        private string tema;
        string tipo_cliente;
        private int cantidad_dispositivos;
        public frmClientesHome()
        {
            InitializeComponent();
            tipo_cliente = "PERSONA";
            this.KeyPreview = true;

            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };

            dtp_fecha_desde.Value = DateTime.Now;
            dtp_fecha_hasta.Value = DateTime.Now;
      
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarPersonas();
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
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_opciones.FillColor = Color.FromArgb(128, 141, 124);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_opciones_menu.FillColor = Color.FromArgb(95, 111, 101);

            this.dtgv_clientes.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_clientes.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_clientes.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_clientes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_clientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.tb_buscar.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_buscar.ForeColor = Color.White;
            this.tb_buscar.FocusedState.ForeColor = Color.White;
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.PlaceholderForeColor = Color.White;

            this.btn_inicio.Image = Resources.icono_inicio_menu_claro;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu_claro;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu_claro;
            this.btn_clientes.Image = Resources.icono_clientes_menu_claro;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu_claro;
            this.btn_movimientos.Image = Resources.icono_movimientos_claro;
        
            this.btn_modificar.Image = Resources.icono_modificar_claro;

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
            this.btn_persona.ForeColor = Color.White;
            this.btn_empresa.ForeColor = Color.White;
            this.lb_1.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.btn_eliminar.Image = Resources.icono_eliminar_claro;
            this.btn_agregar.Image = Resources.icono_agregar_claro;


            this.dtp_fecha_desde.ForeColor = Color.White;
            this.dtp_fecha_hasta.ForeColor = Color.White;

            this.dtp_fecha_desde.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_fecha_hasta.FillColor = Color.FromArgb(95, 111, 101);
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_opciones.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_eliminar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_agregar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_modificar.FillColor = Color.FromArgb(35, 36, 40);
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_opciones_menu.FillColor = Color.FromArgb(18, 18, 18);

            this.dtgv_clientes.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_clientes.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            this.btn_persona.ForeColor = Color.Gray;
            this.btn_empresa.ForeColor = Color.Gray;
            this.lb_1.ForeColor = Color.Gray;
            this.lb_2.ForeColor = Color.Gray;
            this.tb_buscar.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.PlaceholderForeColor = Color.Gray;

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
            this.cntb_maximizar_formulario.FillColor = Color.Black;
            foreach (DataGridViewRow row in dtgv_clientes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_clientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
            this.dtp_fecha_desde.ForeColor = Color.Gray;
            this.dtp_fecha_hasta.ForeColor = Color.Gray;

            this.dtp_fecha_desde.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_fecha_hasta.FillColor = Color.FromArgb(18, 18, 18);
            this.lb_titulo.ForeColor = Color.DimGray;
            this.btn_inicio.Image = Resources.icono_inicio_menu;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu;
            this.btn_clientes.Image = Resources.icono_clientes_menu;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu;
            this.btn_movimientos.Image = Resources.icono_movimientos;
         
            this.btn_modificar.Image = Resources.icono_modificar;

            this.btn_inicio.ForeColor = Color.Gray;
            this.btn_ajustes.ForeColor = Color.Gray;
            this.btn_clientes.ForeColor = Color.Gray;
            this.btn_ordenes.ForeColor = Color.Gray;
            this.btn_dispositivos.ForeColor = Color.Gray;
            
            this.btn_movimientos.ForeColor = Color.Gray;
            this.btn_orden_asc_desc.Image = Resources.icono_orden_asc_desc;
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;

            this.btn_eliminar.Image = Resources.icono_eliminar;
            this.btn_agregar.Image = Resources.icono_agregar;
        }

        #region Botones
        private void btn_persona_Click(object sender, EventArgs e)
        {
            CargarPersonas();
            tipo_cliente = "PERSONA";
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            CargarEmpresas();
            tipo_cliente = "EMPRESA";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            EliminarCliente();
        }

        private void btn_orden_asc_desc_Click(object sender, EventArgs e)
        {
            if (btn_orden_asc_desc.Checked)
            {
                DataTable dt = (DataTable)dtgv_clientes.DataSource;
                dt.DefaultView.Sort = "Id DESC";
                dtgv_clientes.DataSource = dt;
            }
            else
            {
                DataTable dt = (DataTable)dtgv_clientes.DataSource;
                dt.DefaultView.Sort = "Id ASC";
                dtgv_clientes.DataSource = dt;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void cntb_maximizar_formulario_Click(object sender, EventArgs e)
        {
            if(tipo_cliente == "EMPRESA")
            {
                CargarEmpresas();
            }  
            else if(tipo_cliente == "PERSONA")
            {
                CargarPersonas();
            }
            
           
        }

        private void cntb_cerrar_formulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void btn_dispositivos_Click_1(object sender, EventArgs e)
        {
            frmDispositivosHome frmDispositivosHome = new frmDispositivosHome();
            frmDispositivosHome.Show();
            this.Close();
        }

        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            frmClientesHome frmClientesHome = new frmClientesHome();
            frmClientesHome.Show();
            this.Close();
        }

        private void btn_ordenes_Click_1(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            frmMovimientosHome frmMovimientosHome = new frmMovimientosHome();
            frmMovimientosHome.Show();
            this.Close();
        }

        #endregion

        #region Metodos auxiliares
        public void AgregarCliente()
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.Show();
        }

        public void BuscarClientePorFecha()
        {
            if(tipo_cliente == "PERSONA")
            {
                DateTime fechaDesde = dtp_fecha_desde.Value;
                DateTime fechaHasta = dtp_fecha_hasta.Value;

                string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd HH:mm:ss");
                dtgv_clientes.RowTemplate.Height = 40;
                string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            NOMBRE_COMPLETO AS Nombre,
            FECHA_AUD AS FechaRegistro,
            HORA_AUD AS HoraRegistro,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'PERSONA' AND FECHA_AUD BETWEEN '" + fechaDesdeStr + "' AND '" + fechaHastaStr + "' ;";

                Conexion conexion = new Conexion();
                DataSet ds = conexion.Selección(consulta);
                DataTable dt = ds.Tables[0];
                dtgv_clientes.DataSource = dt;


                dtgv_clientes.Columns["Id"].HeaderText = "Id";
                dtgv_clientes.Columns["Id"].Visible = false;

                dtgv_clientes.Columns["TipoCliente"].HeaderText = "Tipo cliente";
                dtgv_clientes.Columns["TipoCliente"].Visible = false;

                dtgv_clientes.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";
                dtgv_clientes.Columns["FechaRegistro"].DisplayIndex = 0;

                dtgv_clientes.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
                dtgv_clientes.Columns["HoraRegistro"].DisplayIndex = 1;

                dtgv_clientes.Columns["Nombre"].HeaderText = "Nombre";
                dtgv_clientes.Columns["Nombre"].DisplayIndex = 2;

                dtgv_clientes.Columns["Documento"].HeaderText = "Documento";
                dtgv_clientes.Columns["Documento"].DisplayIndex = 3;

                dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
                dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;

                dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
                dtgv_clientes.Columns["Localidad"].DisplayIndex = 5;

                dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto";
                dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

                dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
                dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;

                dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
                dtgv_clientes.Columns["Correo"].DisplayIndex = 8;
            }
            else if(tipo_cliente == "EMPRESA")
            {
                DateTime fechaDesde = dtp_fecha_desde.Value;
                DateTime fechaHasta = dtp_fecha_hasta.Value;

                string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd HH:mm:ss");
                dtgv_clientes.RowTemplate.Height = 40;
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
              FROM CLIENTE WHERE TIPO_CLIENTE = 'EMPRESA' AND FECHA_AUD BETWEEN '" + fechaDesdeStr + "' AND '" + fechaHastaStr + "' ;";

                Conexion conexion = new Conexion();
                DataSet ds = conexion.Selección(consulta);
                DataTable dt = ds.Tables[0];
                dtgv_clientes.DataSource = dt;

                dtgv_clientes.Columns["Id"].HeaderText = "Id";
                dtgv_clientes.Columns["Id"].Visible = false;

                dtgv_clientes.Columns["TipoCliente"].Visible = false;

                dtgv_clientes.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";
                dtgv_clientes.Columns["FechaRegistro"].DisplayIndex = 0;

                dtgv_clientes.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
                dtgv_clientes.Columns["HoraRegistro"].DisplayIndex = 1;

                dtgv_clientes.Columns["RazonSocial"].HeaderText = "Razon Social";
                dtgv_clientes.Columns["RazonSocial"].DisplayIndex = 2;

                dtgv_clientes.Columns["Rut"].HeaderText = "Rut";
                dtgv_clientes.Columns["Rut"].DisplayIndex = 3;

                dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
                dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;

                dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
                dtgv_clientes.Columns["Localidad"].DisplayIndex = 5;

                dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto ";
                dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

                dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
                dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;

                dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
                dtgv_clientes.Columns["Correo"].DisplayIndex = 8;
            }
        }

        public void CargarPersonas()
        {
            dtgv_clientes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            NOMBRE_COMPLETO AS Nombre,
            FECHA_AUD AS FechaRegistro,
            HORA_AUD AS HoraRegistro,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'PERSONA';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;

          
            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].HeaderText = "Tipo cliente";
            dtgv_clientes.Columns["TipoCliente"].Visible = false;
           
            dtgv_clientes.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";
            dtgv_clientes.Columns["FechaRegistro"].DisplayIndex = 0;

            dtgv_clientes.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
            dtgv_clientes.Columns["HoraRegistro"].DisplayIndex = 1;

            dtgv_clientes.Columns["Nombre"].HeaderText = "Nombre";
            dtgv_clientes.Columns["Nombre"].DisplayIndex = 2;
                
            dtgv_clientes.Columns["Documento"].HeaderText = "Documento";
            dtgv_clientes.Columns["Documento"].DisplayIndex = 3;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 5; 
           
            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 8;
        }

        public void CargarEmpresas()
        {
            dtgv_clientes.RowTemplate.Height = 40;
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
            FROM CLIENTE WHERE TIPO_CLIENTE = 'Empresa';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;

            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].Visible = false;

            dtgv_clientes.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";
            dtgv_clientes.Columns["FechaRegistro"].DisplayIndex = 0;

            dtgv_clientes.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
            dtgv_clientes.Columns["HoraRegistro"].DisplayIndex = 1;

            dtgv_clientes.Columns["RazonSocial"].HeaderText = "Razon Social";
            dtgv_clientes.Columns["RazonSocial"].DisplayIndex = 2;

            dtgv_clientes.Columns["Rut"].HeaderText = "Rut";
            dtgv_clientes.Columns["Rut"].DisplayIndex = 3;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 5;

            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto ";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 8;
        }

        public void ModificarCliente()
        {
            if (dtgv_clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_clientes.SelectedRows[0];
                string tipoCliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);

                frmModificarCliente frmModificarCliente = new frmModificarCliente();

                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string correo = Convert.ToString(filaSeleccionada.Cells["Correo"].Value);
                string localidad = Convert.ToString(filaSeleccionada.Cells["Localidad"].Value);
                string departamento = Convert.ToString(filaSeleccionada.Cells["Departamento"].Value);

                // Convertir Contacto1 directamente
                long contacto_1 = Convert.ToInt64(filaSeleccionada.Cells["Contacto1"].Value);

                // Verificar si Contacto2 es NULL antes de convertir
                long? contacto_2 = filaSeleccionada.Cells["Contacto2"].Value != DBNull.Value
                                  ? Convert.ToInt64(filaSeleccionada.Cells["Contacto2"].Value)
                                  : (long?)null;

                if (tipoCliente == "EMPRESA")
                {
                    long rut = Convert.ToInt64(filaSeleccionada.Cells["Rut"].Value);
                    string razonSocial = Convert.ToString(filaSeleccionada.Cells["RazonSocial"].Value);

                    // Llamar al formulario para modificar datos de empresa
                    frmModificarCliente.CargarDatosEmpresa(id, rut, razonSocial, correo, contacto_1, contacto_2, localidad, departamento);
                    frmModificarCliente.ShowDialog();
                }
                else if (tipoCliente == "PERSONA")
                {
                    string nombre = Convert.ToString(filaSeleccionada.Cells["Nombre"].Value);
                    int documento = Convert.ToInt32(filaSeleccionada.Cells["Documento"].Value);

                    // Llamar al formulario para modificar datos de persona
                    frmModificarCliente.CargarDatosPersona(id, documento, nombre, correo, contacto_1, contacto_2, localidad, departamento);
                    frmModificarCliente.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para modificar.");
            }
        }


        public void EliminarCliente()
        {
            if (dtgv_clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_clientes.SelectedRows[0];
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
                    if (ClienteTieneDispositivo(idPropietario))
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
                    if(tipo_cliente == "PERSONA")
                    {
                        CargarPersonas();
                    }
                    else if(tipo_cliente == "EMPRESA")
                    {
                        CargarEmpresas();
                    }
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

        private void BuscarEmpresa(string pDato)
        {
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
            FROM CLIENTE WHERE TIPO_CLIENTE = 'EMPRESA' AND"
            + " RUT LIKE '" + pDato.ToString()
            + "' OR RAZON_SOCIAL LIKE '" + pDato.ToString() + "';";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;

            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].Visible = false;

            dtgv_clientes.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";
            dtgv_clientes.Columns["FechaRegistro"].DisplayIndex = 0;

            dtgv_clientes.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
            dtgv_clientes.Columns["HoraRegistro"].DisplayIndex = 1;

            dtgv_clientes.Columns["RazonSocial"].HeaderText = "Razon Social";
            dtgv_clientes.Columns["RazonSocial"].DisplayIndex = 2;

            dtgv_clientes.Columns["Rut"].HeaderText = "Rut";
            dtgv_clientes.Columns["Rut"].DisplayIndex = 3;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 5;

            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto ";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 8;

        }

        private void BuscarPersona(string pDato)
        {
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            NOMBRE_COMPLETO AS Nombre,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            FECHA_AUD AS FechaRegistro,
            HORA_AUD AS HoraRegistro,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'PERSONA' AND"
            + " NOMBRE_COMPLETO LIKE '" + pDato.ToString()
            + "' OR DOCUMENTO LIKE '" + pDato.ToString() + "';";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;

            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].HeaderText = "Tipo cliente";
            dtgv_clientes.Columns["TipoCliente"].Visible = false;

            dtgv_clientes.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";
            dtgv_clientes.Columns["FechaRegistro"].DisplayIndex = 0;

            dtgv_clientes.Columns["HoraRegistro"].HeaderText = "Hora de ing.";
            dtgv_clientes.Columns["HoraRegistro"].DisplayIndex = 1;

            dtgv_clientes.Columns["Nombre"].HeaderText = "Nombre";
            dtgv_clientes.Columns["Nombre"].DisplayIndex = 2;

            dtgv_clientes.Columns["Documento"].HeaderText = "Documento";
            dtgv_clientes.Columns["Documento"].DisplayIndex = 3;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 5;

            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 8;

        }

        #endregion

        #region Eventos y validaciones TextBox
        private void tb_buscar_TextChanged_1(object sender, EventArgs e)
        {
            string dato = "%" + tb_buscar.Text + "%";
            if (tipo_cliente == "EMPRESA")
            {
                BuscarEmpresa(dato);
            }
            else if (tipo_cliente == "PERSONA")
            {
                BuscarPersona(dato);
            }

            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 100;

            // Verificamos si el texto ingresado supera el limite
            if (tb_buscar.Text.Length > maximo_caracteres)
            {
                tb_buscar.Text = tb_buscar.Text.Substring(0, maximo_caracteres);
                tb_buscar.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void frmClientesHome_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    EliminarCliente();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    AgregarCliente();
                    e.Handled = true;
                    break;

                case Keys.F3:
                    ModificarCliente();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
           
        }


        #endregion

        private void btn_buscar_fecha_Click(object sender, EventArgs e)
        {
            BuscarClientePorFecha();
        }

        private void btn_ajustes_Click_1(object sender, EventArgs e)
        {
            frmAjustes frmAjustes = new frmAjustes();
            frmAjustes.ShowDialog();
        }

        private void dtgv_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                }
                else if (tema == "Oscuro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }
    }
}
