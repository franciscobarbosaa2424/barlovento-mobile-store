using Guna.UI2.WinForms;
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

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Filtros
{
    public partial class frmFiltrosOrden : Form
    {
        public frmFiltrosOrden()
        {
            InitializeComponent();
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            #region Metodos Enter KeyPress
            this.btn_terminados.KeyPress += new KeyPressEventHandler(btn_terminados_KeyPress);
            this.btn_en_proceso.KeyPress += new KeyPressEventHandler(btn_en_proceso_KeyPress);
            this.btn_pendientes.KeyPress += new KeyPressEventHandler(btn_pendientes_KeyPress);
            this.btn_cancelados.KeyPress += new KeyPressEventHandler(btn_cancelados_KeyPress);
            this.tb_numero_de_orden.KeyPress += new KeyPressEventHandler(tb_numero_de_orden_KeyPress);
            this.btn_buscar_orden.KeyPress += new KeyPressEventHandler(btn_buscar_orden_KeyPress);
            this.dtp_fecha_egreso_desde.KeyPress += new KeyPressEventHandler(dtp_fecha_egreso_desde_KeyPress);
            this.dtp_fecha_egreso_hasta.KeyPress += new KeyPressEventHandler(dtp_fecha_egreso_hasta_KeyPress);
            this.dtp_fecha_ingreso_hasta.KeyPress += new KeyPressEventHandler(dtp_fecha_ingreso_hasta_KeyPress);
            this.dtp_fecha_ingreso_desde.KeyPress += new KeyPressEventHandler(dtp_fecha_ingreso_desde_KeyPress);
            this.btn_buscar_fecha_egreso.KeyPress += new KeyPressEventHandler(btn_buscar_fecha_egreso_KeyPress);
            this.btn_buscar_fecha_ingreso.KeyPress += new KeyPressEventHandler(btn_buscar_fecha_ingreso_KeyPress);
            this.tb_total_desde.KeyPress += new KeyPressEventHandler(tb_total_desde_KeyPress);
            this.tb_total_hasta.KeyPress += new KeyPressEventHandler(tb_total_hasta_KeyPress);
            this.btn_buscar_total.KeyPress += new KeyPressEventHandler(btn_buscar_total_KeyPress);
            #endregion
        }

        #region Metodos auxiliares
        // Buscar por periodos de fecha de ingreso
        public void BuscarPorFechaIngreso()
        {
            DateTime fechaDesde = dtp_fecha_ingreso_desde.Value;
            DateTime fechaHasta = dtp_fecha_ingreso_hasta.Value;

            string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd HH:mm:ss");

            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.FiltrarPorFechaIngreso(fechaDesdeStr, fechaHastaStr);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.FiltrarPorFechaIngreso(fechaDesdeStr, fechaHastaStr);
            }
        }

        // Buscar por periodos de fecha de ingreso
        public void BuscarPorFechaEgreso()
        {
            DateTime fechaDesde = dtp_fecha_egreso_desde.Value;
            DateTime fechaHasta = dtp_fecha_egreso_hasta.Value;

            string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd HH:mm:ss");

            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.FiltrarPorFechaEgreso(fechaDesdeStr, fechaHastaStr);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.FiltrarPorFechaEgreso(fechaDesdeStr, fechaHastaStr);
            }
        }

        // Mostrar solo las ordenes Terminadas
        public void OrdenarPorOrdenesTerminadas()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.CargarOrdenesTerminadas();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.CargarOrdenesTerminadas();
            }
        }

        // Mostrar solo las ordenes Canceladas
        public void OrdenarPorOrdenesCanceladas()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.CargarOrdenesCanceladas();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.CargarOrdenesCanceladas();
            }
        }

        // Mostrar solo las ordenes En Proceso
        public void OrdenarPorOrdenesEnProceso()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.CargarOrdenesEnProceso();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.CargarOrdenesEnProceso();
            }
        }

        // Mostrar solo las ordenes Pendientes
        public void OrdenarPorOrdenesPendientes()
        {
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.CargarOrdenesPendientes();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.CargarOrdenesPendientes();
            }
        }

        // Mostrar una orden especifica
        public void OrdenarPorNumeroDeOrden()
        {
            int.TryParse(this.tb_numero_de_orden.Text, out int IdOrden);
            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.CargarOrden(IdOrden);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.CargarOrden(IdOrden);
            }
        }

        // Buscar por totales ($)
        public void BuscarPorTotal()
        {
            int.TryParse(this.tb_total_desde.Text, out int totalDesde);
            int.TryParse(this.tb_total_hasta.Text, out int totalHasta);


            // Verifica si el formulario ya está abierto
            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

            if (frmOrdenReparacionHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmOrdenReparacionHome.FiltrarPorTotal(totalDesde, totalHasta);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmOrdenReparacionHome = new frmOrdenReparacionHome();
                frmOrdenReparacionHome.Show();
                frmOrdenReparacionHome.FiltrarPorTotal(totalDesde, totalHasta);
            }
        }

        #endregion

        #region Botones
        // Buscar por fecha de ingreso
        private void btn_buscar_fecha_ingreso_Click_1(object sender, EventArgs e)
        {
            BuscarPorFechaIngreso();
        }

        // Buscar por fecha de egreso
        private void btn_buscar_fecha_egreso_Click_1(object sender, EventArgs e)
        {
            BuscarPorFechaEgreso();
        }

        // Mostrar Todas las ordenes
        private void btn_todos_Click_1(object sender, EventArgs e)
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

        // Buscar por total ($)
        private void btn_buscar_total_Click(object sender, EventArgs e)
        {
            BuscarPorTotal();
        }

        // Buscar por Nro. de Orden
        private void btn_buscar_orden_Click(object sender, EventArgs e)
        {
            OrdenarPorNumeroDeOrden();
        }

        // Filtrar por ordenes Terminadas
        private void btn_terminados_Click(object sender, EventArgs e)
        {
            OrdenarPorOrdenesTerminadas();
        }

        // Filtrar por ordenes Pendientes
        private void btn_pendientes_Click(object sender, EventArgs e)
        {
            OrdenarPorOrdenesPendientes();
        }

        // Filtrar por ordenes En Proceso
        private void btn_en_proceso_Click(object sender, EventArgs e)
        {
            OrdenarPorOrdenesEnProceso();
        }

        // Filtrar por ordenes Canceladas
        private void btn_cancelados_Click(object sender, EventArgs e)
        {
            OrdenarPorOrdenesCanceladas();
        }
        #endregion

        #region
        private void tb_numero_de_orden_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_numero_de_orden.Text.Length > maximo_caracteres)
            {
                tb_numero_de_orden.Text = tb_numero_de_orden.Text.Substring(0, maximo_caracteres);
                tb_numero_de_orden.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_total_desde_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_total_desde.Text.Length > maximo_caracteres)
            {
                tb_total_desde.Text = tb_total_desde.Text.Substring(0, maximo_caracteres);
                tb_total_desde.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_total_hasta_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_total_hasta.Text.Length > maximo_caracteres)
            {
                tb_total_hasta.Text = tb_total_hasta.Text.Substring(0, maximo_caracteres);
                tb_total_hasta.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void tb_numero_de_orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }

            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }

        private void tb_total_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }

            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }

        private void btn_terminados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_pendientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_en_proceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_cancelados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_todos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtp_fecha_ingreso_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtp_fecha_ingreso_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_buscar_fecha_ingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtp_fecha_egreso_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dtp_fecha_egreso_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_buscar_fecha_egreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_buscar_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_total_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }

            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }

        private void btn_buscar_orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_terminados.ForeColor = Color.White;
            this.btn_pendientes.ForeColor = Color.White;
            this.btn_cancelados.ForeColor = Color.White;
            this.btn_en_proceso.ForeColor = Color.White;
            this.btn_todos.ForeColor = Color.White;
            this.btn_buscar_orden.ForeColor = Color.White;
            this.btn_buscar_fecha_egreso.ForeColor = Color.White;
            this.btn_buscar_fecha_ingreso.ForeColor = Color.White;
            this.btn_buscar_total.ForeColor = Color.White;

            this.btn_terminados.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_pendientes.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_cancelados.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_en_proceso.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_todos.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_orden.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_fecha_egreso.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_fecha_ingreso.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_total.FillColor = Color.FromArgb(128, 141, 124);

            this.lb_titulo.ForeColor = Color.White;
            this.lb_1.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_3.ForeColor = Color.White;
            this.lb_4.ForeColor = Color.White;
            this.lb_5.ForeColor = Color.White;
            this.lb_6.ForeColor = Color.White;
            this.lb_7.ForeColor = Color.White;
            this.lb_8.ForeColor = Color.White;
            this.lb_9.ForeColor = Color.White;
            this.lb_10.ForeColor = Color.White;
            this.lb_11.ForeColor = Color.White;

            this.tb_numero_de_orden.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_total_desde.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_total_hasta.FillColor = Color.FromArgb(128, 141, 124);

            this.tb_numero_de_orden.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_total_desde.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_total_hasta.BorderColor = Color.FromArgb(95, 111, 101);
         
            this.tb_numero_de_orden.ForeColor = Color.White;
            this.tb_total_desde.ForeColor = Color.White;
            this.tb_total_hasta.ForeColor = Color.White;
     

            this.dtp_fecha_ingreso_desde.ForeColor = Color.White;
            this.dtp_fecha_ingreso_hasta.ForeColor = Color.White;
            this.dtp_fecha_egreso_hasta.ForeColor = Color.White;
            this.dtp_fecha_egreso_desde.ForeColor = Color.White;

            this.dtp_fecha_ingreso_desde.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_fecha_ingreso_hasta.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_fecha_egreso_hasta.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_fecha_egreso_desde.FillColor = Color.FromArgb(95, 111, 101);
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.cntb_cerrar_formulario.FillColor = Color.Black;

            this.btn_terminados.ForeColor = Color.DimGray;
            this.btn_pendientes.ForeColor = Color.DimGray;
            this.btn_cancelados.ForeColor = Color.DimGray;
            this.btn_en_proceso.ForeColor = Color.DimGray;
            this.btn_todos.ForeColor = Color.DimGray;
            this.btn_buscar_orden.ForeColor = Color.DimGray;
            this.btn_buscar_fecha_egreso.ForeColor = Color.DimGray;
            this.btn_buscar_fecha_ingreso.ForeColor = Color.DimGray;
            this.btn_buscar_total.ForeColor = Color.DimGray;

            this.btn_terminados.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_pendientes.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_cancelados.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_en_proceso.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_todos.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_orden.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_fecha_egreso.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_fecha_ingreso.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_total.FillColor = Color.FromArgb(35, 36, 40);

            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_1.ForeColor = Color.Gray;
            this.lb_2.ForeColor = Color.Gray;
            this.lb_3.ForeColor = Color.Gray;
            this.lb_4.ForeColor = Color.Gray;
            this.lb_5.ForeColor = Color.Gray;
            this.lb_6.ForeColor = Color.Gray;
            this.lb_7.ForeColor = Color.Gray;
            this.lb_8.ForeColor = Color.Gray;
            this.lb_9.ForeColor = Color.Gray;
            this.lb_10.ForeColor = Color.Gray;
            this.lb_11.ForeColor = Color.Gray;

            this.tb_numero_de_orden.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_total_desde.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_total_hasta.FillColor = Color.FromArgb(35, 36, 40);
       

            this.tb_numero_de_orden.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_total_desde.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_total_hasta.BorderColor = Color.FromArgb(18, 18, 18);
        

            this.tb_numero_de_orden.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_total_desde.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_total_hasta.ForeColor = Color.FromArgb(125, 137, 149);

            this.dtp_fecha_ingreso_desde.ForeColor = Color.Gray;
            this.dtp_fecha_ingreso_hasta.ForeColor = Color.Gray;
            this.dtp_fecha_egreso_hasta.ForeColor = Color.Gray;
            this.dtp_fecha_egreso_desde.ForeColor = Color.Gray;

            this.dtp_fecha_ingreso_desde.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_fecha_ingreso_hasta.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_fecha_egreso_hasta.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_fecha_egreso_desde.FillColor = Color.FromArgb(18, 18, 18);
        }


        private void frmFiltrosOrden_Load(object sender, EventArgs e)
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
    }
}
