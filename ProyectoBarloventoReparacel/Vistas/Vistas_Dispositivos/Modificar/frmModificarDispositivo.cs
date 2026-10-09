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
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Patron;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Informacion;
using Guna.UI2.WinForms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Modificar
{
    public partial class frmModificarDispositivo : Form
    {
        string patron;
        string patron_dispositivo;
        string tipo_cliente;
        int id_cliente;
        int id_dispositivo;
        string numero_de_serie_anterior;
        public frmModificarDispositivo()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            this.KeyPreview = true;

            #region Metodos Enter KeyPress
            this.tb_observacion.KeyPress += new KeyPressEventHandler(tb_observacion_KeyPress);
            this.tb_tipo.KeyPress += new KeyPressEventHandler(tb_tipo_KeyPress);
            this.tb_numero_de_serie.KeyPress += new KeyPressEventHandler(tb_numero_de_serie_KeyPress);
            this.tb_contraseña.KeyPress += new KeyPressEventHandler(tb_contraseña_KeyPress);
            this.tb_marca.KeyPress += new KeyPressEventHandler(tb_marca_KeyPress);
            this.tb_modelo.KeyPress += new KeyPressEventHandler(tb_modelo_KeyPress);
            this.btn_patron.KeyPress += new KeyPressEventHandler(btn_patron_KeyPress);
            this.btn_modificar.KeyPress += new KeyPressEventHandler(btn_modificar_KeyPress);
            #endregion

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

        private void tb_marca_TextChanged(object sender, EventArgs e)
        {
            string marcaSeleccionada = tb_marca.Text;
            CargarModelos(marcaSeleccionada);

            // Establecer un maximo de caracteres (70) 
            int maximo_caracteres = 70;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_marca.Text.Length > maximo_caracteres)
            {
                tb_marca.Text = tb_marca.Text.Substring(0, maximo_caracteres);
                tb_marca.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
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

        private void frmModificarDispositivo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    ModificarDispositivo();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    CargarPatron(patron_dispositivo);
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Metodos auxiliares
        public void CargarPatron(string pPatron)
        {
            frmPatronDispositivo frmPatronDispositivo = new frmPatronDispositivo();
            frmPatronDispositivo.DibujarPatronDesdeString(patron_dispositivo);
            frmPatronDispositivo.ShowDialog();
        }

        public void CargarNuevoPatron(string pPatron) 
        {
            patron_dispositivo = pPatron;
            btn_patron.Enabled = false;
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

        private void CargarMarcas()
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

        public void CargarDispositivo(int pId,
            string pTipo,
            string pMarca,
            string pModelo,
            string pNumeroDeSerie,
            string pObservacion,
            int pIdCliente,
            string pTipoCliente,
            string pContraseña,
            string pPatron
            )
        {
            id_dispositivo = pId;
            id_cliente = pIdCliente;
            tb_tipo.Text = pTipo;
            tb_contraseña.Text = pContraseña;
            patron_dispositivo = pPatron;
            tb_observacion.Text = pObservacion;
            tb_numero_de_serie.Text = pNumeroDeSerie;
            tipo_cliente = pTipoCliente;
            numero_de_serie_anterior = pNumeroDeSerie;
            if (pTipoCliente == "PERSONA")
            {
                CargarPersona(pIdCliente);
                id_cliente = pIdCliente;
            }
            else if (pTipoCliente == "EMPRESA")
            {
                CargarEmpresa(pIdCliente);
                id_cliente = pIdCliente;
            }

            // Cargar las marcas si aún no están cargadas
            if (tb_marca.AutoCompleteCustomSource.Count == 0)
            {
                CargarMarcas();
            }

            // Asegurarse de que la marca está en la lista de autocompletar antes de seleccionarla
            if (!string.IsNullOrEmpty(pMarca) && tb_marca.AutoCompleteCustomSource.Contains(pMarca))
            {
                tb_marca.Text = pMarca;

                // Cargar modelos para la marca seleccionada
                CargarModelos(pMarca);

                // Asegurarse de que el modelo está en la lista de autocompletar antes de seleccionarlo
                if (tb_modelo.AutoCompleteCustomSource.Contains(pModelo))
                {
                    tb_modelo.Text = pModelo;
                }
                else
                {
                    tb_modelo.Text = ""; // O un valor predeterminado si no está disponible
                }
            }
            else
            {
                tb_marca.Text = ""; // Reiniciar la marca si no es válida
                tb_modelo.Text = ""; // Reiniciar el modelo si la marca no es válida
            }
        }

        private void CargarModelos(string pMarca)
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

        public void ModificarDispositivo()
        {
            int idDispositivo = id_dispositivo;
            int IdCliente = id_cliente;
            string tipo = this.tb_tipo.Text;
            string marca = this.tb_marca.Text;
            string contraseña = this.tb_contraseña.Text;
            string modelo = this.tb_modelo.Text;
            string numeroDeSerie = this.tb_numero_de_serie.Text;
            string observacion = this.tb_observacion.Text;
            string patron = patron_dispositivo;

            Dispositivo_Controladora dispositivo_Controladora = new Dispositivo_Controladora();
            Dispositivo dispositivo = new Dispositivo
                (
                idDispositivo,
                numeroDeSerie,
                observacion,
                tipo,
                contraseña,
                marca,
                modelo,
                patron,
                IdCliente
                );

            if (NumeroDeSerieExiste(numeroDeSerie) && numeroDeSerie != numero_de_serie_anterior)
            {
                MessageBox.Show("El número de serie ya está en uso por otro dispositivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dispositivo_Controladora.ModificarDispositivo(dispositivo))
            {
                frmDispositivosHome frmDispositivosHome = Application.OpenForms["frmDispositivosHome"] as frmDispositivosHome;
                frmAgregarOrdenReparacion frmAgregarOrdenReparacion = Application.OpenForms["frmAgregarOrdenReparacion"] as frmAgregarOrdenReparacion;
                frmInfnDispositivo frmInfnDispositivo = Application.OpenForms["frmInfnDispositivo"] as frmInfnDispositivo;
                if (frmAgregarOrdenReparacion != null)
                {
                    // Si el formulario ya está abierto, utiliza la instancia existente
                    frmAgregarOrdenReparacion.MostrarDatosDtgv(idDispositivo, IdCliente, tipo_cliente);
                }

                if (frmInfnDispositivo != null)
                {
                    // Si el formulario ya está abierto, utiliza la instancia existente
                    frmInfnDispositivo.MostrarDatosDtgv(IdCliente, tipo_cliente, idDispositivo);
                }

                if (frmDispositivosHome != null)
                {
                    // Si el formulario ya está abierto, utiliza la instancia existente
                    frmDispositivosHome.CargarDispositivos();
                }
                MessageBox.Show("El dispositivo ha sido modificado exitosamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error, no fue posible modificar a este dispositivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarDispositivo();
        }

        private void btn_patron_Click(object sender, EventArgs e)
        {
            CargarPatron(patron_dispositivo);
        }

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



        #endregion

        private void frmModificarDispositivo_Load(object sender, EventArgs e)
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
            this.btn_modificar.Image = Properties.Resources.icono_modificar_claro;
            this.btn_mostrar_contraseña.Image = Properties.Resources.icono_contraseña_claro;

            this.lb_titulo.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_3.ForeColor = Color.White;
            this.lb_4.ForeColor = Color.White;
            this.lb_5.ForeColor = Color.White;
            this.lb_6.ForeColor = Color.White;
            this.lb_7.ForeColor = Color.White;

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
            this.btn_modificar.Image = Properties.Resources.icono_modificar;
            this.btn_mostrar_contraseña.Image = Properties.Resources.icono_contraseña;
        
            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.lb_3.ForeColor = Color.DimGray;
            this.lb_4.ForeColor = Color.DimGray;
            this.lb_5.ForeColor = Color.DimGray;
            this.lb_6.ForeColor = Color.DimGray;
            this.lb_7.ForeColor = Color.DimGray;

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
