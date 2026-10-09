using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseñaPatron;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseña
{
    public partial class frmContAdmin : Form
    {
        private int id_dispositivo;
        private string patron;
        private string contraseña;
        private string parametro;
        public frmContAdmin()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
        }

        public void CargarContraseña(int pIdDispositivo)
        {
            id_dispositivo = pIdDispositivo;
            parametro = "contraseña";
        }

        public void CargarPatron(string pPatron)
        {
            patron = pPatron;
            parametro = "patron";
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (parametro == "contraseña")
            {
                if (tb_contraseña.Text == "Barlovento.2024")
                {
                    int contador = 0;
                    string consulta_dispositivo = @"
                    SELECT COUNT(contraseña)
                    FROM  DISPOSITIVO_CLIENTE
                    WHERE idDispositivo  =" + id_dispositivo + ";";

                    Conexion conexion = new Conexion();
                    DataSet ds = conexion.Selección(consulta_dispositivo);
                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        contador = Convert.ToInt32(row[0]);
                    }

                    if (contador > 0)
                    {
                        string consulta_dispositivo_contraseña = @"
                    SELECT contraseña
                    FROM  DISPOSITIVO_CLIENTE
                    WHERE idDispositivo  =" + id_dispositivo + ";";

                        DataSet ds2 = conexion.Selección(consulta_dispositivo_contraseña);
                        DataTable dt2 = ds2.Tables[0];

                        if (dt2.Rows.Count > 0)
                        {
                            DataRow row = dt2.Rows[0];
                            contraseña = Convert.ToString(row[0]);
                        }

                        MessageBox.Show("La contraseña del dispositivo es " + contraseña + ".",
                        "Contraseña del Dispositivo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else if(parametro == "patron")
            {
                if (tb_contraseña.Text == "Barlovento.2024")
                {
                    frmVerPatron frmVerPatron = new frmVerPatron();
                    frmVerPatron.DibujarPatronDesdeString(patron);
                    frmVerPatron.ShowDialog();
                    this.Close();
                }
            }
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.lb_contraseña_admin.ForeColor = Color.DimGray;

            this.cntb_cerrar_formulario.FillColor = Color.Black;

            this.tb_contraseña.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_contraseña.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_contraseña.ForeColor = Color.FromArgb(125, 137, 149);
        }

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.lb_contraseña_admin.ForeColor = Color.White;

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_aceptar.ForeColor = Color.White;

            this.tb_contraseña.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_contraseña.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_contraseña.ForeColor = Color.White;

        }


        private void frmContAdmin_Load(object sender, EventArgs e)
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
