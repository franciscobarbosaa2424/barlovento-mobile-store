using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Filtros
{
    public partial class frmFiltrosMov : Form
    {
        public frmFiltrosMov()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            dtp_fecha_desde.Value = DateTime.Now;
            dtp_fecha_hasta.Value = DateTime.Now;
        }

        #region Metodos axuliares
        public void OrdenarPorApertura()
        {
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarAperturas();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarAperturas();
            }
        }

        public void OrdenarPorCierre()
        {
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarCierres();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarCierres();
            }
        }

        public void OrdenarPorEntrada()
        {
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarEntradas();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarEntradas();
            }
        }

        public void OrdenarPorSalida()
        {
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarSalidas();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarSalidas();
            }
        }

        public void MostrarTodosLosMovimientos()
        {
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarMovimientos();
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarMovimientos();
            }
        }

        public void OrdenarPorNroDeOrden()
        {
            int.TryParse(this.tb_numero_de_orden.Text, out int IdOrden);
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarMovimientosPorOrden(IdOrden);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarMovimientosPorOrden(IdOrden);
            }
        }

        public void OrdenarPorNroDeMovimiento()
        {
            int.TryParse(this.tb_nro_movimiento.Text, out int idMovimiento);
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarMovimientos(idMovimiento);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarMovimientos(idMovimiento);
            }
        }

        public void OrdenarPorMonto()
        {
            int.TryParse(this.tb_monto_desde.Text, out int montoDesde);
            int.TryParse(this.tb_monto_hasta.Text, out int montoHasta);
            // Verifica si el formulario ya está abierto
            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarPorMonto(montoDesde, montoHasta);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarPorMonto(montoDesde, montoHasta);
            }
        }

        public void OrdenarPorFecha()
        {
            DateTime fechaDesde = dtp_fecha_desde.Value;
            DateTime fechaHasta = dtp_fecha_hasta.Value;

            string fechaDesdeStr = fechaDesde.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaHastaStr = fechaHasta.ToString("yyyy-MM-dd HH:mm:ss");

            frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

            if (frmMovimientosHome != null)
            {
                // Si el formulario ya está abierto, utiliza la instancia existente
                frmMovimientosHome.CargarPorFecha(fechaDesdeStr, fechaHastaStr);
            }
            else
            {
                // Si el formulario no está abierto, crea una nueva instancia
                frmMovimientosHome = new frmMovimientosHome();
                frmMovimientosHome.Show();
                frmMovimientosHome.CargarPorFecha(fechaDesdeStr, fechaHastaStr);
            }
        }

        #endregion

        #region Botones
        private void btn_apertura_Click(object sender, EventArgs e)
        {
            OrdenarPorApertura();
        }

        private void btn_Cierre_Click(object sender, EventArgs e)
        {
            OrdenarPorCierre();
        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            OrdenarPorEntrada();
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            OrdenarPorSalida();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            MostrarTodosLosMovimientos();
        }

        private void btn_buscar_movimiento_Click(object sender, EventArgs e)
        {
            OrdenarPorNroDeMovimiento();
        }

        private void btn_buscar_orden_Click(object sender, EventArgs e)
        {
            OrdenarPorNroDeOrden();
        }

        private void btn_buscar_monto_Click(object sender, EventArgs e)
        {
            OrdenarPorMonto();
        }

        private void btn_buscar_fecha_Click(object sender, EventArgs e)
        {
            OrdenarPorFecha();
        }

        #endregion

        #region Eventos y validaciones TextBox
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

        private void tb_nro_movimiento_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_nro_movimiento.Text.Length > maximo_caracteres)
            {
                tb_nro_movimiento.Text = tb_nro_movimiento.Text.Substring(0, maximo_caracteres);
                tb_nro_movimiento.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_monto_desde_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_monto_desde.Text.Length > maximo_caracteres)
            {
                tb_monto_desde.Text = tb_monto_desde.Text.Substring(0, maximo_caracteres);
                tb_monto_desde.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_monto_hasta_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_monto_hasta.Text.Length > maximo_caracteres)
            {
                tb_monto_hasta.Text = tb_monto_hasta.Text.Substring(0, maximo_caracteres);
                tb_monto_hasta.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_numero_de_orden_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }

        private void tb_nro_movimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }

        private void tb_monto_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }

        private void tb_monto_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Establecer no poder ingresar caracteres que no sean numeros 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar el evento 
                e.Handled = true;
            }
        }


        #endregion
        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_apertura.ForeColor = Color.White;
            this.btn_Cierre.ForeColor = Color.White;
            this.btn_entrada.ForeColor = Color.White;
            this.btn_salida.ForeColor = Color.White;
            this.btn_todos.ForeColor = Color.White;
            this.btn_buscar_orden.ForeColor = Color.White;
            this.btn_buscar_movimiento.ForeColor = Color.White;
            this.btn_buscar_monto.ForeColor = Color.White;
            this.btn_buscar_fecha.ForeColor = Color.White;

            this.btn_apertura.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_Cierre.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_entrada.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_salida.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_todos.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_orden.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_movimiento.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_monto.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_buscar_fecha.FillColor = Color.FromArgb(128, 141, 124);

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

            this.tb_numero_de_orden.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_nro_movimiento.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_monto_desde.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_monto_hasta.FillColor = Color.FromArgb(128, 141, 124);

            this.tb_numero_de_orden.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_nro_movimiento.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_monto_desde.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_monto_hasta.BorderColor = Color.FromArgb(95, 111, 101);

            this.tb_numero_de_orden.ForeColor = Color.White;
            this.tb_nro_movimiento.ForeColor = Color.White;
            this.tb_monto_desde.ForeColor = Color.White;
            this.tb_monto_hasta.ForeColor = Color.White;

            this.dtp_fecha_desde.ForeColor = Color.White;
            this.dtp_fecha_hasta.ForeColor = Color.White;

            this.dtp_fecha_desde.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_fecha_hasta.FillColor = Color.FromArgb(95, 111, 101);
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.cntb_cerrar_formulario.FillColor = Color.Black;

            this.btn_apertura.ForeColor = Color.DimGray;
            this.btn_Cierre.ForeColor = Color.DimGray;
            this.btn_entrada.ForeColor = Color.DimGray;
            this.btn_salida.ForeColor = Color.DimGray;
            this.btn_todos.ForeColor = Color.DimGray;
            this.btn_buscar_orden.ForeColor = Color.DimGray;
            this.btn_buscar_movimiento.ForeColor = Color.DimGray;
            this.btn_buscar_monto.ForeColor = Color.DimGray;
            this.btn_buscar_fecha.ForeColor = Color.DimGray;

            this.btn_apertura.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_Cierre.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_entrada.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_salida.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_todos.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_orden.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_movimiento.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_monto.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_buscar_fecha.FillColor = Color.FromArgb(35, 36, 40);

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

            this.tb_numero_de_orden.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_nro_movimiento.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_monto_desde.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_monto_hasta.FillColor = Color.FromArgb(35, 36, 40);

            this.tb_numero_de_orden.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_nro_movimiento.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_monto_desde.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_monto_hasta.BorderColor = Color.FromArgb(18, 18, 18);

            this.tb_numero_de_orden.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_nro_movimiento.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_monto_desde.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_monto_hasta.ForeColor = Color.FromArgb(125, 137, 149);

            this.dtp_fecha_desde.ForeColor = Color.Gray;
            this.dtp_fecha_hasta.ForeColor = Color.Gray;

            this.dtp_fecha_desde.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_fecha_hasta.FillColor = Color.FromArgb(18, 18, 18);
        }



        private void frmFiltrosMov_Load(object sender, EventArgs e)
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
