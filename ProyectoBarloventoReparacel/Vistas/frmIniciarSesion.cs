using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel
{
    public partial class frmIniciarSesión : Form
    {
        public frmIniciarSesión()
        {
            InitializeComponent();

            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
        }

        private void frmIniciarSesión_Load(object sender, EventArgs e)
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

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;

            usuario = tb_usuario.Text;
            contraseña = tb_contraseña.Text;

            if (contraseña == "Barlovento.2024" && usuario == "Admin")
            {
                frmHome frmHome = new frmHome();
                frmHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"La contraseña o el usuario es incorrecto", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(95, 111, 101);
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(95, 111, 101);
            this.lb_1.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.imagen.Image = Properties.Resources.icono_ola_claro;
            this.btn_inicio.ForeColor = Color.White;

            this.tb_contraseña.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_contraseña.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_contraseña.ForeColor = Color.White;
            this.tb_contraseña.FocusedState.ForeColor = Color.White;
            this.tb_contraseña.FocusedState.FillColor = Color.FromArgb(128, 141, 124);

            this.tb_usuario.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_usuario.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_usuario.ForeColor = Color.White;
            this.tb_usuario.FocusedState.ForeColor = Color.White;
            this.tb_usuario.FocusedState.FillColor = Color.FromArgb(128, 141, 124);
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.FromArgb(18,18,18);
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(18, 18, 18);
            this.lb_1.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.imagen.Image = Properties.Resources.icono_ola;
            this.btn_inicio.ForeColor = Color.Gray;

            this.tb_contraseña.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_contraseña.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_contraseña.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_contraseña.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_contraseña.FocusedState.FillColor = Color.FromArgb(35, 36, 40);


            this.tb_usuario.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_usuario.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_usuario.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_usuario.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_usuario.FocusedState.FillColor = Color.FromArgb(35, 36, 40);

        }
    }
}
