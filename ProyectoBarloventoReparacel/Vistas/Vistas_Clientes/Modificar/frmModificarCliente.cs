using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Controladoras;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.InformacionPropietario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_AMBCliente.Alta
{
    public partial class frmModificarCliente : Form
    {
        string tipo_cliente;
        int id_cliente;
        long rut_anterior;
        int documento_anterior;
        public frmModificarCliente()
        {
            InitializeComponent();
            CargarDepartamentos();
            this.KeyPreview = true;

            #region Metodos Enter KeyPress
            this.tb_1.KeyPress += new KeyPressEventHandler(tb_1_KeyPress);
            this.tb_2.KeyPress += new KeyPressEventHandler(tb_2_KeyPress);
            this.tb_contacto_1.KeyPress += new KeyPressEventHandler(tb_contacto_1_KeyPress);
            this.tb_contacto_2.KeyPress += new KeyPressEventHandler(tb_contacto_2_KeyPress);
            this.cb_departamento.KeyPress += new KeyPressEventHandler(cb_departamento_KeyPress);
            this.cb_localidad.KeyPress += new KeyPressEventHandler(cb_localidad_KeyPress);
            this.tb_correo.KeyPress += new KeyPressEventHandler(tb_correo_KeyPress);
            this.btn_modificar.KeyPress += new KeyPressEventHandler(btn_modificar_KeyPress);
            #endregion

            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
        }

        #region Metodos auxiliares
        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

         
            this.btn_modificar.Image = Properties.Resources.icono_modificar_claro;

      
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
            this.cb_localidad.ForeColor = Color.White;
            this.tb_correo.ForeColor = Color.White;


        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

           
            this.btn_modificar.Image = Properties.Resources.icono_modificar;


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

        private void CargarLocalidades(string departamento)
        {
            cb_localidad.Items.Clear();
            string sql = "SELECT DISTINCT LOCALIDAD FROM LOCALIDAD WHERE DEPARTAMENTO = '" + departamento + "'";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(sql);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cb_localidad.Items.Add(row["LOCALIDAD"].ToString());
            }
        }

        public void CargarDatosEmpresa(int pId,
      long pRut,
      string pRazonSocial,
      string pCorreo,
      long pContacto1,
      long? pContacto2,  // Cambiado a nullable
      string pLocalidad,
      string pDepartamento)
        {
            lb_1.Text = "Razón Social:";
            lb_2.Text = "Rut:";
            tipo_cliente = "EMPRESA";

            id_cliente = pId;
            tb_1.Text = pRazonSocial.ToString();
            tb_2.Text = pRut.ToString();
            tb_contacto_1.Text = pContacto1.ToString();
            rut_anterior = pRut;

            // Si pContacto2 tiene un valor, se muestra, de lo contrario, se deja vacío
            tb_contacto_2.Text = pContacto2.HasValue ? pContacto2.Value.ToString() : string.Empty;

            tb_correo.Text = pCorreo;

            // Cargar departamentos y seleccionar el correspondiente
            CargarDepartamentos();
            cb_departamento.SelectedItem = pDepartamento;

            // Cargar localidades y seleccionar la correspondiente
            CargarLocalidades(pDepartamento);
            cb_localidad.SelectedItem = pLocalidad;
        }


        public void CargarDatosPersona(int pId,
       int pDocumento,
       string pNombre,
       string pCorreo,
       long pContacto1,
       long? pContacto2,  // Cambiado a nullable
       string pLocalidad,
       string pDepartamento)
        {
            lb_1.Text = "Nombre:";
            lb_2.Text = "Documento:";
            tipo_cliente = "PERSONA";

            id_cliente = pId;
            tb_1.Text = pNombre.ToString();
            tb_2.Text = pDocumento.ToString();
            tb_contacto_1.Text = pContacto1.ToString();
            documento_anterior = pDocumento;

            // Si pContacto2 tiene un valor, se muestra, de lo contrario, se deja vacío
            tb_contacto_2.Text = pContacto2.HasValue ? pContacto2.Value.ToString() : string.Empty;

            tb_correo.Text = pCorreo;

            // Cargar departamentos y seleccionar el correspondiente
            CargarDepartamentos();
            cb_departamento.SelectedItem = pDepartamento;

            // Cargar localidades y seleccionar la correspondiente
            CargarLocalidades(pDepartamento);
            cb_localidad.SelectedItem = pLocalidad;
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

        public void ModificarCliente()
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
                Cliente_Controladora cliente_Controladora = new Cliente_Controladora();

                if (tipo_cliente == "PERSONA")
                {
                    int.TryParse(this.tb_2.Text, out int documento);

                    // Verificar si la documento ya existe
                    if (DocumentoExiste(documento) && documento != documento_anterior)
                    {
                        MessageBox.Show("El documento ingresado ya está registrado en el sistema.",
                             "Documento Duplicado",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        return; // Detener la modificación si ya existe
                    }

                    string localidad = this.cb_localidad.Text;
                    string departamento = this.cb_departamento.Text;
                    long.TryParse(this.tb_contacto_1.Text, out long contacto1);
                    long.TryParse(this.tb_contacto_2.Text, out long contacto2);
                    int idCliente = id_cliente;
                    string correo = this.tb_correo.Text;
                    string nombre = this.tb_1.Text;

                    Cliente cliente_persona = new Cliente(
                        idCliente,
                        nombre,
                        documento,
                        contacto1,
                        contacto2,
                        departamento,
                        localidad,
                        correo
                    );

                    if (cliente_Controladora.ModificarClientePersona(cliente_persona))
                    {
                        // Verifica si el formulario ya está abierto
                        frmClientesHome frmClientesHome = Application.OpenForms["frmClientesHome"] as frmClientesHome;

                        if (frmClientesHome != null)
                        {
                            // Si el formulario ya está abierto, utiliza la instancia existente
                            frmClientesHome.CargarPersonas();
                        }

                        ActualizarFormularios(idCliente, "persona");
                        MessageBox.Show("El cliente ha sido modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar al cliente. Por favor, intente nuevamente.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tipo_cliente == "EMPRESA")
                {
                    long.TryParse(this.tb_2.Text, out long rut);

                    // Verificar si el RUT ya existe
                    if (RutExiste(rut) && rut != rut_anterior)
                    {
                        MessageBox.Show("El RUT ingresado ya está registrado en el sistema.",
                             "RUT Duplicado",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                        return; // Detener la modificación si ya existe
                    }

                    string localidad = this.cb_localidad.Text;
                    string departamento = this.cb_departamento.Text;
                    long.TryParse(this.tb_contacto_1.Text, out long contacto1);
                    long.TryParse(this.tb_contacto_2.Text, out long contacto2);
                    int idCliente = id_cliente;
                    string correo = this.tb_correo.Text;
                    string razon_social = this.tb_1.Text;

                    Cliente cliente_empresa = new Cliente(
                        idCliente,
                        rut,
                        razon_social,
                        contacto1,
                        contacto2,
                        departamento,
                        localidad,
                        correo
                    );

                    if (cliente_Controladora.ModificarClienteEmpresa(cliente_empresa))
                    {
                        // Verifica si el formulario ya está abierto
                        frmClientesHome frmClientesHome = Application.OpenForms["frmClientesHome"] as frmClientesHome;

                        if (frmClientesHome != null)
                        {
                            // Si el formulario ya está abierto, utiliza la instancia existente
                            frmClientesHome.CargarEmpresas();
                        } 
                        ActualizarFormularios(idCliente, "empresa");
                        MessageBox.Show("El cliente ha sido modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar al cliente. Por favor, intente nuevamente.", "Error de Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ActualizarFormularios(int idCliente, string tipo)
        {
            // Verifica si el formulario de información del cliente ya está abierto
            frmInfnCliente frmInfnCliente = Application.OpenForms["frmInfnCliente"] as frmInfnCliente;

            if (frmInfnCliente != null)
            {
                if (tipo == "persona")
                {
                    frmInfnCliente.CargarPersona(idCliente);
                }
                else
                {
                    frmInfnCliente.CargarEmpresa(idCliente);
                }
            }

            // Verifica si el formulario de agregar orden ya está abierto
            frmAgregarOrdenReparacion frmAgregarOrdenReparacion = Application.OpenForms["frmAgregarOrdenReparacion"] as frmAgregarOrdenReparacion;

            if (frmAgregarOrdenReparacion != null)
            {
                if (tipo == "persona")
                {
                    frmAgregarOrdenReparacion.CargarPersona(idCliente);
                }
                else
                {
                    frmAgregarOrdenReparacion.CargarEmpresa(idCliente);
                }
            }
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
        #endregion

        #region Botones
        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void cb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_departamento.SelectedItem != null)
            {
                string departamentoSeleccionado = cb_departamento.SelectedItem.ToString();
                CargarLocalidades(departamentoSeleccionado);
            }
        }

        private void frmModificarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    ModificarCliente();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        private void tb_2_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (12 ya que es un rut) 
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

            /* Establecer un maximo de caracteres (8 ya que es una documento) */
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

        private void tb_contacto_1_TextChanged(object sender, EventArgs e)
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
                tb_correo.ForeColor = Color.FromArgb(125, 137, 149);
            }
            else
            {
                /* Si el correo no es válido, cambia el color de fondo del TextBox a rojo */
                tb_correo.ForeColor = Color.Red;
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

        private void btn_modificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }


        #endregion

        private void frmModificarCliente_Load(object sender, EventArgs e)
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
