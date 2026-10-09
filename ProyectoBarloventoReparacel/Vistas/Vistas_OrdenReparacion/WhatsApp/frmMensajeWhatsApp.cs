using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.WhatsApp
{
    public partial class frmMensajeWhatsApp : Form
    {
        private string ruta_python;
        public frmMensajeWhatsApp()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            cb_pais.Text = "Uruguay (+598)";
        }

        public void setDatosTextBox(int pIdCliente)
        {
            string consulta_contacto_cliente = @"
                SELECT 
                CONTACTO_1 AS Contacto
                FROM CLIENTE
                WHERE ID=" + pIdCliente + ";";
            Conexion conexion = new Conexion();
            DataSet dataSet = conexion.Selección(consulta_contacto_cliente);
            DataTable dataTable = dataSet.Tables[0];


            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                tb_contacto.Text = Convert.ToString(row["Contacto"]);
            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            // Diccionario con los países y sus características
            Dictionary<string, string> paises = new Dictionary<string, string>
            {
                { "Argentina(+54)", "+54" },
                { "Brasil(+55)", "+55" },
                { "Paraguay(+595)", "+595" },
                { "Uruguay(+598)", "+598" },
                { "Venezuela(+58)", "+58" }
            };

            string caracteristica;
            string numero = tb_contacto.Text;

            // Validar si el país seleccionado está en el diccionario
            if (paises.TryGetValue(cb_pais.Text, out caracteristica))
            {
                numero = caracteristica + tb_contacto.Text;
            }

            string mensaje = tb_mensaje.Text;

            // Enviar el mensaje
            enviarMensaje(numero, mensaje);


        }

        public void CargarRutaPython(string pRutaPhython)
        {
            ruta_python = pRutaPhython;
        }

        private void enviarMensaje(string numeroTelefono, string mensajeTexto)
        {
            // Ruta al intérprete de Python y al script de Python
            string rutaPython = ruta_python;  // Reemplaza con la ruta a tu python.exe
            string rutaScript = @"C:\Users\PC\Downloads\ProyectoBarloventoReparacel 5.2.0\ProyectoBarloventoReparacel\ProyectoBarloventoReparacel\MensajeWhatsApp.py";

            // Número de teléfono y mensaje como argumentos
            string numero = numeroTelefono;
            string mensaje = mensajeTexto;

            // Configura el proceso para ejecutar Python
            ProcessStartInfo infoInicio = new ProcessStartInfo
            {
                FileName = rutaPython,
                Arguments = $"\"{rutaScript}\" \"{numero}\" \"{mensaje}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            try
            {
                // Ejecuta el proceso de Python
                using (Process proceso = Process.Start(infoInicio))
                {
                    // Lee cualquier error del script
                    using (System.IO.StreamReader lectorErrores = proceso.StandardError)
                    {
                        string error = lectorErrores.ReadToEnd();
                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show($"Error al ejecutar el script: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el script de Python: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_seleccionar_1_Click(object sender, EventArgs e)
        {
            tb_mensaje.Text = " Buenos dias! Nos complace informarte que tu equipo ha sido reparado exitosamente. ";
        }

        private void btn_seleccionar_2_Click(object sender, EventArgs e)
        {
            tb_mensaje.Text = " Buenos dias! Tu celular ha sido reparado y esta listo para recoger.";
        }

        private void btn_seleccionar_3_Click(object sender, EventArgs e)
        {
            tb_mensaje.Text = " Buenos dias! Te informamos que la orden de reparación de tu celular ha sido cancelada";
        }

        private void btn_mensajes_sin_leer_Click(object sender, EventArgs e)
        {
            // Ruta al intérprete de Python y al script de Python
            string rutaPython = ruta_python;
            string scriptPath = @"C:\Users\PC\Downloads\ProyectoBarloventoReparacel 5.2.0\ProyectoBarloventoReparacel\ProyectoBarloventoReparacel\MensajesSinLeer.py";

            // Configura el proceso para ejecutar Python
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = rutaPython,
                Arguments = $"\"{scriptPath}\"", // Puedes añadir más argumentos si es necesario
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            try
            {
                // Ejecuta el proceso de Python
                using (Process process = Process.Start(startInfo))
                {
                    // Lee la salida del script
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    // Espera a que el proceso termine
                    process.WaitForExit();

                    // Muestra la salida y errores
                    if (process.ExitCode == 1)
                    {
                        MessageBox.Show("No hay chats por leer.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(output))
                        {
                            MessageBox.Show($"\n{output}", "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show($"\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar el script de Python: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMensajeWhatsApp_Load(object sender, EventArgs e)
        {
            // Cargar la ruta de Python desde los settings
            ruta_python = Properties.Settings.Default.RutaPython;
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
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.panel_mensaje_1.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_mensaje_2.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_mensaje_3.FillColor = Color.FromArgb(128, 141, 124);


            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            

            this.btn_seleccionar_1.Image = Properties.Resources.icono_seleccionar_claro;
            this.btn_seleccionar_2.Image = Properties.Resources.icono_seleccionar_claro;
            this.btn_seleccionar_3.Image = Properties.Resources.icono_seleccionar_claro;
            this.btn_enviar.Image = Properties.Resources.icono_enviar_mensaje_claro;
        

            this.btn_mensajes_sin_leer.ForeColor = Color.White;
           

            this.lb_contacto.ForeColor = Color.White;
            this.lb_pais.ForeColor = Color.White;
            this.lb_titulo.ForeColor = Color.White;
            this.lb_mensaje_1.ForeColor = Color.White;
            this.lb_mensaje_2.ForeColor = Color.White;
            this.lb_mensaje_3.ForeColor = Color.White;
         

            this.tb_contacto.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_mensaje.FillColor = Color.FromArgb(128, 141, 124);
            this.cb_pais.FillColor = Color.FromArgb(128, 141, 124);

            this.tb_contacto.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_mensaje.BorderColor = Color.FromArgb(95, 111, 101);
            this.cb_pais.BorderColor = Color.FromArgb(95, 111, 101);

            this.tb_contacto.ForeColor = Color.White;
            this.tb_mensaje.ForeColor = Color.White;
            this.cb_pais.ForeColor = Color.White;
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);


            this.panel_mensaje_1.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_mensaje_2.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_mensaje_3.FillColor = Color.FromArgb(18, 18, 18);

            this.cntb_cerrar_formulario.FillColor = Color.Black;
          
          

            this.btn_seleccionar_1.Image = Properties.Resources.icono_seleccionar;
            this.btn_seleccionar_2.Image = Properties.Resources.icono_seleccionar;
            this.btn_seleccionar_3.Image = Properties.Resources.icono_seleccionar;
            this.btn_enviar.Image = Properties.Resources.icono_enviar_mensaje;

            this.btn_mensajes_sin_leer.ForeColor = Color.Gray;
           

            this.lb_contacto.ForeColor = Color.Gray;
            this.lb_pais.ForeColor = Color.DimGray;
            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_mensaje_1.ForeColor = Color.DimGray;
            this.lb_mensaje_2.ForeColor = Color.DimGray;
            this.lb_mensaje_3.ForeColor = Color.DimGray;

            this.tb_contacto.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_mensaje.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_pais.FillColor = Color.FromArgb(35, 36, 40);

            this.tb_contacto.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_mensaje.BorderColor = Color.FromArgb(18, 18, 18);
            this.cb_pais.BorderColor = Color.FromArgb(18, 18, 18);

            this.tb_contacto.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_mensaje.ForeColor = Color.FromArgb(125, 137, 149);
            this.cb_pais.ForeColor = Color.FromArgb(125, 137, 149);
        }

    }
}
