using Guna.UI2.WinForms;
using Org.BouncyCastle.Security;
using ProyectoBarloventoReparacel.Dominio.Dominio_Entidades;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Agregar
{
    public partial class frmAgregarMovimiento : Form
    {
        public frmAgregarMovimiento()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            this.KeyPreview = true;
            dtp_fecha.Value = DateTime.Now;
            #region Metodos Enter KeyPress
            this.tb_monto.KeyPress += new KeyPressEventHandler(tb_monto_KeyPress);
            this.cb_tipo.KeyPress += new KeyPressEventHandler(cb_tipo_KeyPress);
            this.btn_agregar.KeyPress += new KeyPressEventHandler(btn_agregar_KeyPress);
            #endregion

        }

        #region Metodos auxiliares
        private bool FaltanDatos()
        {
            /* Comprobamos si hay algun TextBox vacio */
            if (
                this.tb_monto.Text == "" ||
                this.cb_tipo.Text == "" 
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AgregarMovimiento()
        {
            if (FaltanDatos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos antes de continuar.",
                "Datos Incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                decimal.TryParse(this.tb_monto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal monto);
                string tipo = cb_tipo.Text;
                DateTime fecha = dtp_fecha.Value;

                Persistencia_Movimientos_Controladora persistencia_Movimientos_Controladora = new Persistencia_Movimientos_Controladora();

                // Verificar condiciones de apertura y cierre para la fecha seleccionada
                bool aperturaRealizada = persistencia_Movimientos_Controladora.VerificarAperturaEnFecha(fecha);
                bool cierreRealizado = persistencia_Movimientos_Controladora.VerificarCierreEnFecha(fecha);

                // Validar la entrada según el tipo de movimiento
                if (tipo == "Apertura")
                {
                    if (aperturaRealizada)
                    {
                        MessageBox.Show("Ya se ha ingresado una apertura para esta fecha.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (tipo == "Cierre")
                {
                    if (cierreRealizado)
                    {
                        MessageBox.Show("Ya se ha ingresado un cierre para esta fecha.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!aperturaRealizada)
                    {
                        MessageBox.Show("No se puede realizar un cierre sin una apertura previa en esta fecha.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (tipo == "Entrada" || tipo == "Salida")
                {
                    if (!aperturaRealizada)
                    {
                        MessageBox.Show("No se puede realizar una entrada o salida sin una apertura previa en esta fecha.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if(cierreRealizado)
                    {
                        MessageBox.Show("No se puede realizar una entrada o salida si se realizo un cierre en esta fecha.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Crear instancia de movimientos y realizar la inserción
                Movimientos movimientos = new Movimientos(tipo, monto, fecha);
                persistencia_Movimientos_Controladora.PAltaMovimiento(movimientos);
                MessageBox.Show("El movimiento ha sido ingresado exitosamente.", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMovimientosHome frmMovimientosHome = Application.OpenForms["frmMovimientosHome"] as frmMovimientosHome;

                if (frmMovimientosHome != null)
                {
                    // Si el formulario ya está abierto, utiliza la instancia existente
                    frmMovimientosHome.CargarMovimientos();
                }
            }
        }

        #endregion

        #region Botones
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarMovimiento();
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void tb_monto_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_monto.Text.Length > maximo_caracteres)
            {
                tb_monto.Text = tb_monto.Text.Substring(0, maximo_caracteres);
                tb_monto.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_monto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cb_tipo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAgregarMovimiento_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    AgregarMovimiento();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }


        #endregion

        private void frmAgregarMovimiento_Load(object sender, EventArgs e)
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

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.lb_1.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;

            this.cntb_cerrar_formulario.FillColor = Color.Black;

            this.lb_titulo.ForeColor = Color.DimGray;

            this.tb_monto.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_monto.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_monto.ForeColor = Color.FromArgb(125, 137, 149);

            this.cb_tipo.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_tipo.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_tipo.ForeColor = Color.FromArgb(125, 137, 149);

            this.dtp_fecha.ForeColor = Color.Gray;

            this.dtp_fecha.FillColor = Color.FromArgb(18, 18, 18);
            this.btn_agregar.Image = Properties.Resources.icono_agregar;
        }

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.lb_1.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.dtp_fecha.ForeColor = Color.White;
            this.dtp_fecha.FillColor = Color.FromArgb(95, 111, 101);

            this.lb_titulo.ForeColor = Color.White;

            this.tb_monto.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_monto.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_monto.ForeColor = Color.White;

            this.cb_tipo.BorderColor = Color.FromArgb(95, 111, 101);
            this.cb_tipo.FillColor = Color.FromArgb(128, 141, 124);
            this.cb_tipo.ForeColor = Color.White;

            this.btn_agregar.Image = Properties.Resources.icono_agregar_claro;

        }
    }
}
