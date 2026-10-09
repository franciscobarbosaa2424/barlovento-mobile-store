using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Properties;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Filtros;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home
{
    public partial class frmMovimientosHome : Form
    {
        private string tema;
        public frmMovimientosHome()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
        }

        private void frmMovimientosHome_Load(object sender, EventArgs e)
        {
            CargarMovimientos();

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

            this.dtgv_movimientos.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_movimientos.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_movimientos.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_movimientos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_movimientos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_movimientos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_movimientos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_movimientos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

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
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_maximizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.lb_titulo.ForeColor = Color.White;
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_orden_asc_desc.Image = Resources.icono_orden_asc_desc_claro;
            this.btn_filtros_orden.ForeColor = Color.White;
            this.btn_filtros_orden.Image = Resources.icono_filtros_claro;
            this.btn_eliminar.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_agregar.FillColor = Color.FromArgb(128, 141, 124);

            this.btn_eliminar.Image = Resources.icono_eliminar_claro;
            this.btn_agregar.Image = Resources.icono_agregar_claro;
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_opciones.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_eliminar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_agregar.FillColor = Color.FromArgb(35, 36, 40);
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_opciones_menu.FillColor = Color.FromArgb(18, 18, 18);

            this.dtgv_movimientos.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_movimientos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_movimientos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_movimientos.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_movimientos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;



            foreach (DataGridViewRow row in dtgv_movimientos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_movimientos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);

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
            this.btn_filtros_orden.ForeColor = Color.DimGray;
            this.btn_filtros_orden.Image = Resources.icono_filtros;
            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
            this.cntb_maximizar_formulario.FillColor = Color.Black;
            this.btn_eliminar.Image = Resources.icono_eliminar;
            this.btn_agregar.Image = Resources.icono_agregar;
        }

        #region Metodos auxiliares
        public void CargarMovimientos()
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS;";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void AgregarMovimiento()
        {
            frmAgregarMovimiento frmAgregarMovimiento = new frmAgregarMovimiento();
            frmAgregarMovimiento.Show();
        }

        public void EliminarMovimiento()
        {
            if (dtgv_movimientos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_movimientos.SelectedRows[0];
                int idMovimiento = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este movimiento? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {

                    Conexion conexion = new Conexion();

                    string consulta = $"DELETE FROM Movimientos WHERE idMovimiento = {idMovimiento}";
                    conexion.Selección(consulta);

                    MessageBox.Show("El movimiento ha sido eliminado exitosamente.",
                            "Eliminación exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    CargarMovimientos();
                }
            }
        }

        public void FiltrosMovimientos()
        {
            frmFiltrosMov frmFiltrosMov = new frmFiltrosMov();
            frmFiltrosMov.ShowDialog();
        }

        public void CargarAperturas()
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE tipoDeMovimiento = 'Apertura';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarCierres()
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE tipoDeMovimiento = 'Cierre';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarEntradas()
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE tipoDeMovimiento = 'Entrada';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarSalidas()
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE tipoDeMovimiento = 'Salida';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarMovimientos(int idMovimiento)
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE idMovimiento = " + idMovimiento+ ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarMovimientosPorOrden(int idOrden)
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
             FROM MOVIMIENTOS WHERE idOrden = " + idOrden + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarPorMonto(int montoDesde, int montoHasta)
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE Monto BETWEEN " + montoDesde + " AND "+  montoHasta + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }

        public void CargarPorFecha(string pFechaDesde, string pFechaHasta)
        {
            dtgv_movimientos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            idMovimiento AS Id,
            tipoDeMovimiento  AS Movimiento,
            monto AS Monto,
            fecha AS Fecha,
            idOrden AS IdOrden
            FROM MOVIMIENTOS WHERE Fecha BETWEEN '" + pFechaDesde + "' AND '" + pFechaHasta + "';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_movimientos.DataSource = dt;

            dtgv_movimientos.Columns["Id"].HeaderText = "Nro de Movimiento";
            dtgv_movimientos.Columns["Id"].DisplayIndex = 0;

            dtgv_movimientos.Columns["Movimiento"].HeaderText = "Movimiento";
            dtgv_movimientos.Columns["Movimiento"].DisplayIndex = 1;

            dtgv_movimientos.Columns["Monto"].HeaderText = "Monto ($)";
            dtgv_movimientos.Columns["Monto"].DisplayIndex = 2;

            dtgv_movimientos.Columns["Fecha"].HeaderText = "Fecha";
            dtgv_movimientos.Columns["Fecha"].DisplayIndex = 3;

            dtgv_movimientos.Columns["IdOrden"].HeaderText = "Nro. de Orden";
            dtgv_movimientos.Columns["IdOrden"].DisplayIndex = 4;
        }
        #endregion

        #region Botones
        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            AgregarMovimiento();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EliminarMovimiento();
        }

        private void btn_orden_asc_desc_Click(object sender, EventArgs e)
        {
            if (btn_orden_asc_desc.Checked)
            {
                DataTable dt = (DataTable)dtgv_movimientos.DataSource;
                dt.DefaultView.Sort = "Id DESC";
                dtgv_movimientos.DataSource = dt;
            }
            else
            {
                DataTable dt = (DataTable)dtgv_movimientos.DataSource;
                dt.DefaultView.Sort = "Id ASC";
                dtgv_movimientos.DataSource = dt;
            }
        }

        private void btn_filtros_orden_Click(object sender, EventArgs e)
        {
            FiltrosMovimientos();
        }

        private void cntb_cerrar_formulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cntb_maximizar_formulario_Click(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        #endregion

        #region Eventos y validacions TextBox
        private void frmMovimientosHome_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    EliminarMovimiento();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    AgregarMovimiento();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }





        #endregion

        private void btn_dispositivos_Click(object sender, EventArgs e)
        {
            frmDispositivosHome frmDispositivosHome = new frmDispositivosHome();
            frmDispositivosHome.Show();
            this.Close();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            frmClientesHome frmClientesHome = new frmClientesHome();
            frmClientesHome.Show();
            this.Close();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            frmMovimientosHome frmMovimientosHome = new frmMovimientosHome();
            frmMovimientosHome.Show();
            this.Close();
        }

        private void btn_ordenes_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            frmAjustes frmAjustes = new frmAjustes();
            frmAjustes.ShowDialog();
        }

        private void dtgv_movimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
