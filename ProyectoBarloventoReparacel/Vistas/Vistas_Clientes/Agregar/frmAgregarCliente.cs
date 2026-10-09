using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Controladoras;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Clientes.Agregar
{
    public partial class frmAgregarCliente : Form
    {
        string tipo_cliente;
        int documento_cliente;
        long rut_cliente;
        public frmAgregarCliente()
        {
            InitializeComponent();
            this.btn_persona.Checked = true;
            tipo_cliente = "PERSONA";

            lb_1.Text = "Nombre:";
            lb_2.Text = "Documento:";
            this.KeyPreview = true;


            #region Metodos Enter KeyPress
            this.tb_1.KeyPress += new KeyPressEventHandler(tb_1_KeyPress);
            this.tb_2.KeyPress += new KeyPressEventHandler(tb_2_KeyPress);
            this.tb_contacto_1.KeyPress += new KeyPressEventHandler(tb_contacto_1_KeyPress);
            this.tb_contacto_2.KeyPress += new KeyPressEventHandler(tb_contacto_2_KeyPress);
            this.cb_departamento.KeyPress += new KeyPressEventHandler(cb_departamento_KeyPress);
            this.cb_localidad.KeyPress += new KeyPressEventHandler(cb_localidad_KeyPress);
            this.tb_correo.KeyPress += new KeyPressEventHandler(tb_correo_KeyPress);        
            this.btn_agregar.KeyPress += new KeyPressEventHandler(btn_agregar_KeyPress);
            #endregion

            // Sombra para el formulario 
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };

        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();

            this.cb_departamento.Text = "Colonia";
            this.cb_localidad.Text = "Colonia Del Sacramento";

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


        #region Eventos y validaciones TextBox
        private void tb_2_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (12 ya que es un rut) */
            if (tipo_cliente == "EMPRESA")
            {
                int maxCaracteres = 12;

                /* Verificamos si el texto ingresado supera el limite */
                if (tb_2.Text.Length > maxCaracteres)
                {
                    tb_2.Text = tb_2.Text.Substring(0, maxCaracteres);
                    tb_2.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
                }
            }

            /* Establecer un maximo de caracteres (11 ya que es un documento) */
            else if (tipo_cliente == "PERSONA")
            {
                int maxCaracteres = 11;

                /* Verificamos si el texto ingresado supera el limite */
                if (tb_2.Text.Length > maxCaracteres)
                {
                    tb_2.Text = tb_2.Text.Substring(0, maxCaracteres);
                    tb_2.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
                }
            }
        }

        private void tb_contacto_1_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (9) */
            
            int maxCaracteres = extranjero.Checked ? 12 : 9;
           
            /* Verificamos si el texto ingresado supera el limite */
            if (tb_contacto_1.Text.Length > maxCaracteres)
            {
                tb_contacto_1.Text = tb_contacto_1.Text.Substring(0, maxCaracteres);
                tb_contacto_1.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
            }
        }

        private void tb_contacto_2_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (9) */
            int maxCaracteres = extranjero.Checked ? 12 : 9;

            /* Verificamos si el texto ingresado supera el limite */
            if (tb_contacto_2.Text.Length > maxCaracteres)
            {
                tb_contacto_2.Text = tb_contacto_2.Text.Substring(0, maxCaracteres);
                tb_contacto_2.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
            }
        }

        private void tb_correo_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (150) */
            int maxCaracteres = 150;

            /* Verificamos si el texto ingresado supera el limite */
            if (tb_correo.Text.Length > maxCaracteres)
            {
                tb_correo.Text = tb_correo.Text.Substring(0, maxCaracteres);
                tb_correo.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
            }

            string correo = tb_correo.Text;

            /* Verifica si el correo es válido usando el método CorreoEsValido */
            if (CorreoEsValido(correo))
            {
                /* Si el correo es válido, cambia el color de fondo del TextBox a blanco */
                // Aplicar el tema guardado
                if (Properties.Settings.Default.TemaOscuro)
                {
                    tb_correo.ForeColor = Color.FromArgb(125, 137, 149);
                }
                else
                {
                    tb_correo.ForeColor = Color.White;
                }
               
            }
            else
            {
                /* Si el correo no es válido, cambia el color de fondo del TextBox a rojo */
                tb_correo.ForeColor = Color.Red;
            }
        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (100) */
            int maxCaracteres = 100;

            /* Verificamos si el texto ingresado supera el limite */
            if (tb_1.Text.Length > maxCaracteres)
            {
                tb_1.Text = tb_1.Text.Substring(0, maxCaracteres);
                tb_1.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
            }
        }

        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_departamento.SelectedItem != null)
            {
                string departamentoSeleccionado = cb_departamento.SelectedItem.ToString();
                CargarLocalidades(departamentoSeleccionado);
            }
        }

        private void tb_contacto_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }

            /* Establecer no poder ingresar caracteres que no sean numeros */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                /* Si no es un número ni la tecla de retroceso, cancelar el evento */
                e.Handled = true;
            }
        }

        private void tb_contacto_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }

            /* Establecer no poder ingresar caracteres que no sean numeros */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                /* Si no es un número ni la tecla de retroceso, cancelar el evento */
                e.Handled = true;
            }
        }

        private void tb_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }

            /* Establecer no poder ingresar caracteres que no sean numeros */
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                /* Si no es un número ni la tecla de retroceso, cancelar el evento */
                e.Handled = true;
            }
        }

        private void tb_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cb_departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cb_localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_correo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmAgregarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    AgregarCliente();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region Metodos auxiliares
        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);
            this.lb_extranjero.ForeColor = Color.White;
            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar_claro;
            this.btn_agregar.Image = Properties.Resources.icono_agregar_claro;
            
            this.btn_empresa.FillColor = Color.FromArgb(95, 111, 101);
            this.btn_persona.FillColor = Color.FromArgb(95, 111, 101);
            this.btn_empresa.ForeColor = Color.White;
            this.btn_persona.ForeColor = Color.White;

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.lb_titulo.ForeColor = Color.White;
            this.lb_1.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_contacto_1.ForeColor = Color.White;
            this.lb_contacto_2.ForeColor = Color.White;
            this.lb_departamento.ForeColor = Color.White;
            this.lb_localidad.ForeColor = Color.White;
            this.lb_correo.ForeColor = Color.White;


            this.tb_1.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_2.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_contacto_1.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_contacto_2.FillColor = Color.FromArgb(128, 141, 124);
            this.cb_departamento.FillColor = Color.FromArgb(128, 141, 124);
            this.cb_localidad.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_correo.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_correo.ForeColor = Color.White;

            this.tb_1.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_2.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_contacto_1.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_contacto_2.BorderColor = Color.FromArgb(95, 111, 101);
            this.cb_departamento.BorderColor = Color.FromArgb(95, 111, 101);
            this.cb_localidad.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_correo.BorderColor = Color.FromArgb(95, 111, 101);


            this.tb_1.ForeColor = Color.White;
            this.tb_2.ForeColor = Color.White;
            this.tb_contacto_1.ForeColor = Color.White;
            this.tb_contacto_2.ForeColor = Color.White;
            this.cb_departamento.ForeColor = Color.White;
            this.cb_localidad.ForeColor =   Color.White;
        


        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black; 

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar;
            this.btn_agregar.Image = Properties.Resources.icono_agregar;

            this.btn_empresa.FillColor = Color.FromArgb(18, 18, 18);
            this.btn_persona.FillColor = Color.FromArgb(18, 18, 18);
            this.btn_empresa.ForeColor = Color.Gray;
            this.btn_persona.ForeColor = Color.Gray;

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;

            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_1.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.lb_contacto_1.ForeColor = Color.DimGray;
            this.lb_contacto_2.ForeColor = Color.DimGray;
            this.lb_departamento.ForeColor = Color.DimGray;
            this.lb_localidad.ForeColor = Color.DimGray;
            this.lb_correo.ForeColor = Color.DimGray;

            this.lb_extranjero.ForeColor = Color.DimGray;
            this.tb_1.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_2.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_contacto_1.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_contacto_2.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_departamento.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_localidad.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_correo.FillColor = Color.FromArgb(35, 36, 40);

            this.tb_1.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_2.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_contacto_1.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_contacto_2.BorderColor = Color.FromArgb(18, 18, 18);
            this.cb_departamento.BorderColor = Color.FromArgb(18, 18, 18);
            this.cb_localidad.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_correo.BorderColor = Color.FromArgb(18, 18, 18);


            this.tb_1.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_2.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_contacto_1.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_contacto_2.ForeColor = Color.FromArgb(125, 137, 149);
            this.cb_departamento.ForeColor = Color.FromArgb(125, 137, 149);
            this.cb_localidad.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_correo.ForeColor = Color.FromArgb(125, 137, 149);
        }



        private bool CorreoEsValido(string pCorreo)
        {
            try
            {
                /* Intenta crear una dirección de correo electrónico con el texto ingresado */
                var addr = new System.Net.Mail.MailAddress(pCorreo);

                /* Devuelve true si la dirección de correo es válida */
                return addr.Address == pCorreo;
            }
            catch
            {
                /* Si ocurre una excepción, significa que el correo no es válido */
                return false;
            }
        }

        private bool FaltaDatos()
        {
            /* Comprobamos si hay algun TextBox vacio */
            if (
                this.tb_1.Text == "" ||
                this.tb_2.Text == "" ||
                this.tb_contacto_1.Text == "" ||
                this.cb_departamento.Text == "" ||
                this.cb_localidad.Text == "" 
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
            this.tb_1.Clear();
            this.tb_2.Clear();
            this.tb_contacto_1.Clear();
            this.tb_contacto_2.Clear();
            this.tb_correo.Clear();
        }

        private void CargarDepartamentos()
        {
            string sql = "SELECT DISTINCT DEPARTAMENTO FROM Localidad";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(sql);



            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cb_departamento.Items.Add(row["DEPARTAMENTO"].ToString());
            }
            cb_departamento.SelectedIndexChanged += cb_departamento_SelectedIndexChanged;
        }

        private void CargarLocalidades(string pDepartamento)
        {
            cb_localidad.Items.Clear();
            string sql = "SELECT DISTINCT LOCALIDAD FROM LOCALIDAD WHERE DEPARTAMENTO = '" + pDepartamento + "'";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cb_localidad.Items.Add(row["LOCALIDAD"].ToString());
            }
        }

        private bool RutExiste(long pRut)
        {
            int contador = 0;
            string consulta_existe_rut = @"
                        SELECT COUNT(*)
                        FROM CLIENTE
                        WHERE RUT  =" + pRut + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_existe_rut);
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

        private bool DocumentoExiste(int pDocumento)
        {
            int contador = 0;
            string consulta_existe_documento = @"
                        SELECT COUNT(*)
                        FROM CLIENTE
                        WHERE DOCUMENTO  =" + pDocumento + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_existe_documento);
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
            if (tipo_cliente == "EMPRESA")
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
                    string razon_social = this.tb_1.Text;
                    long.TryParse(this.tb_2.Text, out long rut);

                    long.TryParse(this.tb_contacto_1.Text, out long contacto_1);
                    long.TryParse(this.tb_contacto_2.Text, out long contacto_2);

                    string departamentoCliente = this.cb_departamento.Text;
                    string localidadCliente = this.cb_localidad.Text;
                    string correoCliente = this.tb_correo.Text;

                    if (RutExiste(rut))
                    {
                        MessageBox.Show("El RUT ya fue ingresado en la base de datos.", "RUT Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Cliente_Controladora cliente_Controladora = new Cliente_Controladora();
                    Cliente cliente_empresa = new Cliente
                        (
                        razon_social,
                        rut,
                        contacto_1,
                        contacto_2,
                        departamentoCliente,
                        localidadCliente,
                        correoCliente
                        );

                    /* Mostrar un mensaje de Exito o de Error dependiendo si el cliente fue ingresado a la base de datos o no */
                    if (cliente_Controladora.AltaClienteEmpresa(cliente_empresa))
                    {
                        // Verifica si el formulario ya está abierto
                        frmClientesHome frmClientesHome = Application.OpenForms["frmClientesHome"] as frmClientesHome;

                        if (frmClientesHome != null)
                        {
                            // Si el formulario ya está abierto, utiliza la instancia existente
                            frmClientesHome.CargarEmpresas();
                        }

                        this.LimpiarDatos();
                        MessageBox.Show("El cliente ha sido ingresado exitosamente.", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_seleccionar.Visible = true;
                        rut_cliente = rut;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ingresar al cliente. Por favor, intente nuevamente.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (tipo_cliente == "PERSONA")
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
                    string nombre = this.tb_1.Text;
                    int.TryParse(this.tb_2.Text, out int documento);

                    long.TryParse(this.tb_contacto_1.Text, out long contacto_1);
                    long.TryParse(this.tb_contacto_2.Text, out long contacto_2);

                    string departamento = this.cb_departamento.Text;
                    string localidad = this.cb_localidad.Text;
                    string correo = this.tb_correo.Text;
                    string tipoCliente = "PERSONA";

                    if (DocumentoExiste(documento))
                    {
                        MessageBox.Show("El documento ya fue ingresado en la base de datos.", "Documento Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Cliente_Controladora cliente_Controladora = new Cliente_Controladora();
                    Cliente cliente_persona = new Cliente
                        (
                        nombre,
                        documento,
                        contacto_1,
                        contacto_2,
                        departamento,
                        localidad,
                        correo,
                        tipoCliente
                        );

                    /* Mostrar un mensaje de Exito o de Error dependiendo si el cliente fue ingresado a la base de datos o no */
                    if (cliente_Controladora.AltaClientePersona(cliente_persona))
                    {
                        // Verifica si el formulario ya está abierto
                        frmClientesHome frmClientesHome = Application.OpenForms["frmClientesHome"] as frmClientesHome;

                        if (frmClientesHome != null)
                        {
                            // Si el formulario ya está abierto, utiliza la instancia existente
                            frmClientesHome.CargarPersonas();
                        }


                        this.LimpiarDatos();
                        MessageBox.Show("El cliente ha sido ingresado exitosamente.", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_seleccionar.Visible = true;
                        documento_cliente = documento;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ingresar al cliente. Por favor, intente nuevamente.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void SeleccionarCliente()
        {
            if (tipo_cliente == "EMPRESA")
            {
                int id_cliente;
                string consulta_id_cliente = @"
                        SELECT ID
                        FROM CLIENTE
                        WHERE RUT  =" + rut_cliente + ";";

                Conexion conexion = new Conexion();
                DataSet ds = conexion.Selección(consulta_id_cliente);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    id_cliente = Convert.ToInt32(row[0]);

                    frmAgregarDispositivo frmAgregarDispositivo = new frmAgregarDispositivo();
                    frmAgregarDispositivo.MostrarEmpresaDtgv(id_cliente);
                    frmAgregarDispositivo.Show();
                    this.Close();
                }
            }
            else if (tipo_cliente == "PERSONA")
            {
                int id_cliente;
                string consulta_id_cliente = @"
                        SELECT ID
                        FROM CLIENTE
                        WHERE DOCUMENTO  =" + documento_cliente + ";";

                Conexion conexion = new Conexion();
                DataSet ds = conexion.Selección(consulta_id_cliente);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    id_cliente = Convert.ToInt32(row[0]);

                    frmAgregarDispositivo frmAgregarDispositivo = new frmAgregarDispositivo();
                    frmAgregarDispositivo.MostrarPersonaDtgv(id_cliente);
                    frmAgregarDispositivo.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se pudo seleccionar el cliente. Por favor, intente nuevamente.",
                    "Error de Selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarCliente();
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            if (btn_empresa.Checked)
            {
                /* Establecer el tipo de cliente como Empresa */
                tipo_cliente = "EMPRESA";

                lb_1.Text = "Razón Social:";
                lb_2.Text = "Rut:";
            }
        }

        private void btn_persona_Click(object sender, EventArgs e)
        {
            if (btn_persona.Checked)
            {
                /* Establecer el tipo de cliente como Persona */
                tipo_cliente = "PERSONA";

                lb_1.Text = "Nombre:";
                lb_2.Text = "Documento:";
            }
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }

        #endregion

      

       
    }
}
