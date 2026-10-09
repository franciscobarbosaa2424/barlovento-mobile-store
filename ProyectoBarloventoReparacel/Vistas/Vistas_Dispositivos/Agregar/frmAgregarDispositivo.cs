using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBarloventoReparacel.Vistas.Vistas_Clientes;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_Clientes.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Patron;
using System.Windows.Documents;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar
{
    public partial class frmAgregarDispositivo : Form
    {
        string patron_dispositivo;
        string numero_de_serie;
        int cliente_id;
        public frmAgregarDispositivo()
        {
            InitializeComponent();
            CargarDatosAutoCompletar();
            cargarMarcas();
            this.tb_tipo.Text = "Celular";
            tb_marca.TextChanged += tb_marca_TextChanged;
            this.KeyPreview = true;

            #region Metodos Enter KeyPress
            this.btn_agregar_cliente.KeyPress += new KeyPressEventHandler(btn_agregar_cliente_KeyPress);
            this.btn_seleccionar_cliente.KeyPress += new KeyPressEventHandler(btn_seleccionar_cliente_KeyPress);
            this.tb_observacion.KeyPress += new KeyPressEventHandler(tb_observacion_KeyPress);
            this.tb_tipo.KeyPress += new KeyPressEventHandler(tb_tipo_KeyPress);
            this.tb_numero_de_serie.KeyPress += new KeyPressEventHandler(tb_numero_de_serie_KeyPress);
            this.tb_contraseña.KeyPress += new KeyPressEventHandler(tb_contraseña_KeyPress);
            this.tb_marca.KeyPress += new KeyPressEventHandler(tb_marca_KeyPress);
            this.tb_modelo.KeyPress += new KeyPressEventHandler(tb_modelo_KeyPress);
            this.btn_patron.KeyPress += new KeyPressEventHandler(btn_patron_KeyPress);
            this.btn_agregar.KeyPress += new KeyPressEventHandler(btn_modificar_KeyPress);
            #endregion
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
        }

        #region Eventos y validaciones TextBox
        private void tb_observacion_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (250) 
            int maximo_caracteres = 250;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_observacion.Text.Length > maximo_caracteres)
            {
                tb_observacion.Text = tb_observacion.Text.Substring(0, maximo_caracteres);
                tb_observacion.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_numero_de_serie_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (15) 
            int maximo_caracteres = 15;

            //  Verificamos si el texto ingresado supera el limite 
            if (tb_numero_de_serie.Text.Length > maximo_caracteres)
            {
                tb_numero_de_serie.Text = tb_numero_de_serie.Text.Substring(0, maximo_caracteres);
                tb_numero_de_serie.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_contraseña_TextChanged(object sender, EventArgs e)
        {
            if (btn_mostrar_contraseña.Checked)
            {
                tb_contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                tb_contraseña.UseSystemPasswordChar = true;
            }

            // Establecer un maximo de caracteres (255) 
            int maximo_caracteres = 255;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_contraseña.Text.Length > maximo_caracteres)
            {
                tb_contraseña.Text = tb_contraseña.Text.Substring(0, maximo_caracteres);
                tb_contraseña.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_tipo_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (70) 
            int maximo_caracteres = 70;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_tipo.Text.Length > maximo_caracteres)
            {
                tb_tipo.Text = tb_tipo.Text.Substring(0, maximo_caracteres);
                tb_tipo.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
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

        private void tb_modelo_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (70) 
            int maximo_caracteres = 70;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_modelo.Text.Length > maximo_caracteres)
            {
                tb_modelo.Text = tb_modelo.Text.Substring(0, maximo_caracteres);
                tb_modelo.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void frmAgregarDispositivo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    AgregarCliente();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    SeleccionarCliente();
                    e.Handled = true;
                    break;

                case Keys.F3:
                    AgregarPatron();
                    e.Handled = true;
                    break;

                case Keys.F4:
                    AgregarDispositivo();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        private void btn_agregar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_seleccionar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_observacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_numero_de_serie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_patron_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_modificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        #region Botones
        private void btn_mostrar_contraseña_Click(object sender, EventArgs e)
        {
            if (btn_mostrar_contraseña.Checked)
            {
                tb_contraseña.PasswordChar = '\0';
            }

            else
            {
                tb_contraseña.PasswordChar = '●';
            }
        }

        private void btn_patron_Click(object sender, EventArgs e)
        {
            AgregarPatron();
        }

        private void btn_agregar_cliente_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void btn_seleccionar_cliente_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarDispositivo();
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            AgregarDispositivo();
        }

        #endregion

        #region Metodos auxiliares
        private bool FaltaDatos()
        {
            /* Comprobamos si hay algun TextBox vacio */
            if (
                this.tb_numero_de_serie.Text == "" ||
                this.cliente_id == 0 ||
                this.tb_marca.Text == "" ||
                this.tb_modelo.Text == ""
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LimpiarDatos()
        {
            /* Limpiar los TextBox */
            this.tb_contraseña.Clear();
            this.tb_modelo.Clear();
            this.tb_numero_de_serie.Clear();
            this.tb_contraseña.Clear();
            this.tb_observacion.Clear();
        }

        public void CargarDatos(int pClienteId, string pTipoCliente)
        {
            if (pTipoCliente == "PERSONA")
            {
                CargarPersona(pClienteId);
                cliente_id = pClienteId;
            }
            else if (pTipoCliente == "EMPRESA")
            {
                CargarEmpresa(pClienteId);
                cliente_id = pClienteId;
            }
        }

        public void SeleccionarDispositivo()
        {
            frmAgregarOrdenReparacion frmAgregarOrdenReparacion = new frmAgregarOrdenReparacion();
            frmAgregarOrdenReparacion.DatosDadoNumeroDeSerie(numero_de_serie);
            frmAgregarOrdenReparacion.Show();
            this.Close();
        }

        public void SeleccionarCliente()
        {
            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();
            frmSeleccionarCliente.ShowDialog();
            this.Close();
        }

        public void AgregarDispositivo()
        {
            if (FaltaDatos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos antes de continuar.",
              "Datos Incompletos",
              MessageBoxButtons.OK,
              MessageBoxIcon.Warning);
            }
            else
            {
                int clienteId = cliente_id;
                string observacion = this.tb_observacion.Text;
                string tipo = this.tb_tipo.Text;
                string numero_de_Serie = this.tb_numero_de_serie.Text;
                string contraseña = this.tb_contraseña.Text;
                string marca = this.tb_marca.Text;
                string modelo = this.tb_modelo.Text;
                string patron = patron_dispositivo;

                if (NumeroDeSerieExiste(numero_de_Serie))
                {
                    MessageBox.Show("El numero de serie ya fue ingresado en la base de datos.", "Numero de serie Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Dispositivo_Controladora dispositivo_Controladora = new Dispositivo_Controladora();
                Dispositivo dispositivo = new Dispositivo(
                    clienteId,
                    observacion,
                    tipo,
                    numero_de_Serie,
                    contraseña,
                    marca,
                    modelo,
                    patron
                    );

                /* Mostramos un mensaje de Exito o de Error dependiendo si el dispositivo fue ingresado a la base de datos o no */
                if (dispositivo_Controladora.AltaDispositivo(dispositivo))
                {
                    this.LimpiarDatos();
                    MessageBox.Show("El dispositivo ha sido ingresado exitosamente.", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Verifica si el formulario ya está abierto
                    frmDispositivosHome frmDispositivosHome = Application.OpenForms["frmDispositivosHome"] as frmDispositivosHome;

                    if (frmDispositivosHome != null)
                    {
                        // Si el formulario ya está abierto, utiliza la instancia existente
                        frmDispositivosHome.CargarDispositivos();
                    }
                  
                    btn_seleccionar.Visible = true;
                    numero_de_serie = numero_de_Serie;
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar al dispositivo. Por favor, intente nuevamente.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private bool NumeroDeSerieExiste(string pNumeroDeSerie)
        {
            int contador = 0;
            string consulta_existe_numero_de_serie = @"
                        SELECT COUNT(*)
                        FROM DISPOSITIVO_CLIENTE
                        WHERE NUMERO_DE_SERIE  ='" + pNumeroDeSerie + "';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_existe_numero_de_serie);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                contador = Convert.ToInt32(row[0]);
            }

            if (contador > 0)
            {
                return true;
            }
            return false;
        }

        public void AgregarCliente()
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.Show();
            this.Close();
        }

        public void MostrarEmpresaDtgv(int pClienteId)
        {
            CargarEmpresa(pClienteId);
            cliente_id = pClienteId;
        }

        public void MostrarPersonaDtgv(int pClienteId)
        {
            CargarPersona(pClienteId);
            cliente_id = pClienteId;
        }

        public void CargarPatron(string pPatron)
        {
            patron_dispositivo = pPatron;
            btn_patron.Enabled = false;
        }

        private void CargarPersona(int pIdCliente)
        {
            dtgv_propietario.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            NOMBRE_COMPLETO AS NombreCompleto,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;


            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;

            dtgv_propietario.Columns["TipoCliente"].HeaderText = "Tipo cliente";
            dtgv_propietario.Columns["TipoCliente"].Visible = false;

            dtgv_propietario.Columns["NombreCompleto"].HeaderText = "Nombre";

            dtgv_propietario.Columns["Documento"].HeaderText = "Documento";

            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";

            dtgv_propietario.Columns["Departamento"].Visible = false;

            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";

            dtgv_propietario.Columns["Localidad"].Visible = false;

            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto";

            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";

            dtgv_propietario.Columns["Contacto2"].Width = 120;

            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";

            dtgv_propietario.Columns["Correo"].Visible = false;
        }

        private void CargarEmpresa(int pIdCliente)
        {
            dtgv_propietario.RowTemplate.Height = 40;
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
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;

            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;

            dtgv_propietario.Columns["TipoCliente"].Visible = false;

            dtgv_propietario.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";

            dtgv_propietario.Columns["FechaRegistro"].Visible = false;

            dtgv_propietario.Columns["HoraRegistro"].HeaderText = "Hora de ing.";

            dtgv_propietario.Columns["HoraRegistro"].Visible = false;

            dtgv_propietario.Columns["RazonSocial"].HeaderText = "Razon Social";

            dtgv_propietario.Columns["Rut"].HeaderText = "Rut";

            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";

            dtgv_propietario.Columns["Departamento"].Visible = false;

            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";

            dtgv_propietario.Columns["Localidad"].Visible = false;

            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto ";

            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_propietario.Columns["Contacto2"].Visible = false;

            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";
        }

        public void AgregarPatron()
        {
            frmPatronDispositivo frmPatronDispositivo = new frmPatronDispositivo();
            frmPatronDispositivo.ShowDialog();
        }


        #endregion

        private void frmAgregarDispositivo_Load(object sender, EventArgs e)
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

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_patron.Image = Properties.Resources.icono_patron_claro;
            this.btn_agregar.Image = Properties.Resources.icono_agregar_claro;
            this.btn_mostrar_contraseña.Image = Properties.Resources.icono_contraseña_claro;
            this.btn_agregar_cliente.Image = Properties.Resources.icono_agregar_claro;
            this.btn_seleccionar_cliente.Image = Properties.Resources.icono_seleccionar_claro;
            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar_claro;

            this.lb_titulo.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_3.ForeColor = Color.White;
            this.lb_4.ForeColor = Color.White;
            this.lb_5.ForeColor = Color.White;
            this.lb_6.ForeColor = Color.White;
            this.lb_7.ForeColor = Color.White;
            this.lb_8.ForeColor = Color.White;

            this.tb_observacion.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_observacion.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_observacion.ForeColor = Color.White;

            this.tb_numero_de_serie.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_numero_de_serie.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_numero_de_serie.ForeColor = Color.White;

            this.tb_modelo.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_modelo.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_modelo.ForeColor = Color.White;

            this.tb_marca.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_marca.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_marca.ForeColor = Color.White;

            this.tb_tipo.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_tipo.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_tipo.ForeColor = Color.White;

            this.tb_contraseña.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_contraseña.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_contraseña.ForeColor = Color.White;

            this.dtgv_propietario.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_propietario.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_propietario.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_propietario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_propietario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);


            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;

            this.btn_patron.Image = Properties.Resources.icono_patron;
            this.btn_agregar.Image = Properties.Resources.icono_agregar;
            this.btn_mostrar_contraseña.Image = Properties.Resources.icono_contraseña;
            this.btn_agregar_cliente.Image = Properties.Resources.icono_agregar;
            this.btn_seleccionar_cliente.Image = Properties.Resources.icono_seleccionar;
            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar;
            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.lb_3.ForeColor = Color.DimGray;
            this.lb_4.ForeColor = Color.DimGray;
            this.lb_5.ForeColor = Color.DimGray;
            this.lb_6.ForeColor = Color.DimGray;
            this.lb_7.ForeColor = Color.DimGray;
            this.lb_8.ForeColor = Color.DimGray;

            this.tb_observacion.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_observacion.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_observacion.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_tipo.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_tipo.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_tipo.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_numero_de_serie.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_numero_de_serie.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_numero_de_serie.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_contraseña.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_contraseña.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_contraseña.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_marca.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_marca.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_marca.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_modelo.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_modelo.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_modelo.ForeColor = Color.FromArgb(125, 137, 149);

            this.dtgv_propietario.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_propietario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_propietario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
        }
    }  
}
