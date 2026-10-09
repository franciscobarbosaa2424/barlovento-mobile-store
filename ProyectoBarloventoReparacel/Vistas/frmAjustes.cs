using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.WhatsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace ProyectoBarloventoReparacel.Vistas
{
    public partial class frmAjustes : Form
    {
        private string ruta_python;
        Conexion conexion = new Conexion();
        public frmAjustes()
        {
            InitializeComponent();
            CargarDatosAutoCompletar();
            cargarMarcas();
            // Cargar la ruta guardada si existe
            ruta_python = Properties.Settings.Default.RutaPython;

            if (!string.IsNullOrEmpty(ruta_python))
            {
                tb_ruta_python.Text = ruta_python;
            }
        }
        private void CargarDatosAutoCompletar()
        {
            // Crear una instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Diccionario para almacenar consultas SQL y sus respectivos TextBoxes
            var camposAutocompletar = new Dictionary<string, Guna2TextBox>
            {
                    { "SELECT MODELO FROM DISPOSITIVO_DEFAULT", tb_modelo }
             };

            // Iterar sobre el diccionario y cargar los datos de autocompletado para cada TextBox
            foreach (var campo in camposAutocompletar)
            {
                // Obtener el conjunto de datos (DataSet) utilizando la clase Conexion
                DataSet ds = conexion.Selección(campo.Key);

                // Crear una colección para almacenar los datos de autocompletado
                AutoCompleteStringCollection datosAutoCompletar = new AutoCompleteStringCollection();

                try
                {
                    // Llenar la colección de autocompletado con los datos del DataSet
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        // Asumimos que la columna a utilizar es la primera del resultado
                        datosAutoCompletar.Add(fila[0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error en caso de que ocurra una excepción
                    MessageBox.Show("Error: " + ex.Message);
                }

                // Asignar la colección de datos de autocompletado al TextBox
                campo.Value.AutoCompleteCustomSource = datosAutoCompletar;
                campo.Value.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                campo.Value.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void cargarMarcas()
        {
            string sql = "SELECT DISTINCT MARCA FROM DISPOSITIVO_DEFAULT";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(sql);

            AutoCompleteStringCollection datosAutoCompletar = new AutoCompleteStringCollection();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                datosAutoCompletar.Add(row["MARCA"].ToString());
            }

            tb_marca.AutoCompleteCustomSource = datosAutoCompletar;
            tb_marca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_marca.AutoCompleteSource = AutoCompleteSource.CustomSource;

            tb_marca.TextChanged += tb_marca_TextChanged;
        }

        private void cargarModelos(string pMarca)
        {
            string sql = "SELECT MODELO FROM DISPOSITIVO_DEFAULT WHERE MARCA = '" + pMarca.ToString() + "'";
            tb_modelo.Clear();
            Conexion conexion2 = new Conexion();
            DataSet ds2 = conexion2.Selección(sql);

            AutoCompleteStringCollection datosAutoCompletar = new AutoCompleteStringCollection();

            foreach (DataRow fila in ds2.Tables[0].Rows)
            {
                datosAutoCompletar.Add(fila["MODELO"].ToString());
            }

            tb_modelo.AutoCompleteCustomSource = datosAutoCompletar;
            tb_modelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb_modelo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void btn_ruta_python_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos ejecutables (*.exe)|*.exe";
                openFileDialog.Title = "Seleccionar intérprete de Python";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    tb_ruta_python.Text = openFileDialog.FileName;
                    ruta_python = tb_ruta_python.Text;
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Guarda la ruta en las propiedades de configuración
            Properties.Settings.Default.RutaPython = ruta_python;
            Properties.Settings.Default.Save();

            frmMensajeWhatsApp frmMensajeWhatsApp = new frmMensajeWhatsApp();
            frmMensajeWhatsApp.CargarRutaPython(ruta_python);

            MessageBox.Show("Los ajustes han sido guardados correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tb_marca_TextChanged(object sender, EventArgs e)
        {
            string marcaSeleccionada = tb_marca.Text;
            cargarModelos(marcaSeleccionada);

            // Establecer un maximo de caracteres (70) 
            int maximo_caracteres = 70;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_marca.Text.Length > maximo_caracteres)
            {
                tb_marca.Text = tb_marca.Text.Substring(0, maximo_caracteres);
                tb_marca.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }
        // Método para dar de alta un nuevo dispositivo en la tabla DISPOSITIVO_DEFAULT
        public bool AltaDispositivo(string marca, string modelo)
        {
            // Sentencia SQL para insertar un nuevo dispositivo
            string sqlDispositivo = "INSERT INTO DISPOSITIVO_DEFAULT (MARCA, MODELO) VALUES ('" +
                marca + "', '" + modelo + "')";

            return this.conexion.Consulta(sqlDispositivo);
        }
        // Método para verificar si un modelo ya existe en la tabla DISPOSITIVO_DEFAULT
        private bool ModeloExiste(string pModelo)
        {
            int contador = 0;
            string consulta_existe_modelo = @"
                SELECT COUNT(*)
                FROM DISPOSITIVO_DEFAULT
                WHERE MODELO = '" + pModelo + "';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_existe_modelo);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                contador = Convert.ToInt32(row[0]);
            }

            return contador > 0;
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string marca = tb_marca.Text;
            string modelo = tb_modelo.Text;

            // Verificar que los campos no estén vacíos
            if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
            {
                MessageBox.Show("Por favor, complete tanto la marca como el modelo.", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el modelo ya existe
            if (ModeloExiste(modelo))
            {
                MessageBox.Show("Este modelo ya está registrado.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar al método AltaDispositivo para insertar en la base de datos
            bool resultado = AltaDispositivo(marca, modelo);

            // Mostrar mensaje de éxito o error
            if (resultado)
            {
                MessageBox.Show("Dispositivo agregado correctamente.", "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el dispositivo.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_agregar.Image = Properties.Resources.icono_agregar_claro;
            this.btn_guardar.Image = Properties.Resources.icono_guardar_claro;
            this.btn_tema_claro.Image = Properties.Resources.icono_tema_claro_claro;
            this.btn_tema_oscuro.Image = Properties.Resources.icono_tema_oscuro_claro;
            this.btn_ruta_python.Image = Properties.Resources.icono_python_claro;

            this.btn_tema_claro.ForeColor = Color.White;
            this.btn_tema_oscuro.ForeColor = Color.White;

            this.separator_agregar_marca_modelo.FillColor = Color.White;
            this.separator_ruta_python.FillColor = Color.White;
            this.separator_temas.FillColor = Color.White;

            this.lb_agregar_marca_modelo.ForeColor = Color.White;
            this.lb_marca.ForeColor = Color.White;
            this.lb_modelo.ForeColor = Color.White;
            this.lb_ruta_python.ForeColor = Color.White;
            this.lb_temas.ForeColor = Color.White;
            this.lb_titulo.ForeColor = Color.White;

            this.tb_marca.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_modelo.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_ruta_python.FillColor = Color.FromArgb(128, 141, 124);

            this.tb_marca.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_modelo.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_ruta_python.BorderColor = Color.FromArgb(95, 111, 101);

            this.tb_marca.ForeColor = Color.White;
            this.tb_modelo.ForeColor = Color.White;
            this.tb_ruta_python.ForeColor = Color.White;
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.IconColor = Color.White;

            this.btn_agregar.Image = Properties.Resources.icono_agregar;
            this.btn_guardar.Image = Properties.Resources.icono_guardar;
            this.btn_tema_claro.Image = Properties.Resources.icono_tema_claro;
            this.btn_tema_oscuro.Image = Properties.Resources.icono_tema_oscuro;
            this.btn_ruta_python.Image = Properties.Resources.icono_python;

            this.btn_tema_claro.ForeColor = Color.Gray;
            this.btn_tema_oscuro.ForeColor = Color.Gray;

            this.separator_agregar_marca_modelo.FillColor = Color.DimGray;
            this.separator_ruta_python.FillColor = Color.DimGray;
            this.separator_temas.FillColor = Color.DimGray;

            this.lb_agregar_marca_modelo.ForeColor = Color.Gray;
            this.lb_marca.ForeColor = Color.DimGray;
            this.lb_modelo.ForeColor = Color.DimGray;
            this.lb_ruta_python.ForeColor = Color.Gray;
            this.lb_temas.ForeColor = Color.Gray;
            this.lb_titulo.ForeColor = Color.DimGray;

            this.tb_marca.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_modelo.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_ruta_python.FillColor = Color.FromArgb(35, 36, 40);

            this.tb_marca.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_modelo.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_ruta_python.BorderColor = Color.FromArgb(18, 18, 18);

            this.tb_marca.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_modelo.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_ruta_python.ForeColor = Color.FromArgb(125, 137, 149);
        }





        private void btn_tema_claro_Click(object sender, EventArgs e)
        {
            CargarTemaClaro();
            Properties.Settings.Default.TemaOscuro = false;  // Guardar que el tema es claro
            Properties.Settings.Default.Save();  // Guardar los cambios
                                                 // Recorrer todos los formularios abiertos y aplicar el tema oscuro
            foreach (Form form in Application.OpenForms)
            {
                // Verifica si el formulario tiene el método CargarTemaOscuro
                var method = form.GetType().GetMethod("CargarTemaClaro");
                if (method != null)
                {
                    method.Invoke(form, null);  // Invoca el método CargarTemaOscuro si existe
                }
            }
        }

        private void btn_tema_oscuro_Click(object sender, EventArgs e)
        {
            CargarTemaOscuro();
            Properties.Settings.Default.TemaOscuro = true;  // Guardar que el tema es oscuro
            Properties.Settings.Default.Save();  // Guardar los cambios
            foreach (Form form in Application.OpenForms)
            {
                // Verifica si el formulario tiene el método CargarTemaOscuro
                var method = form.GetType().GetMethod("CargarTemaOscuro");
                if (method != null)
                {
                    method.Invoke(form, null);  // Invoca el método CargarTemaOscuro si existe
                }
            }
        }

        private void frmAjustes_Load(object sender, EventArgs e)
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
