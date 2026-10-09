using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Clientes
{
    public partial class frmSeleccionarCliente : Form
    {
        private string tema;
        private string tipoCliente;
        public frmSeleccionarCliente()
        {
            InitializeComponent();

            #region Metodos Enter KeyPress
            this.btn_seleccionar.KeyPress += new KeyPressEventHandler(btn_seleccionar_KeyPress);
            this.tb_buscar.KeyPress += new KeyPressEventHandler(tb_buscar_KeyPress);
            #endregion
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            this.KeyPreview = true;
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            tipoCliente = "PERSONA";
            CargarPersona();
            btn_persona.Checked = true;

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

        #region Metodos auxiliares
        public void CargarTemaClaro()
        {
            tema = "Claro";
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);

            this.lb_titulo.ForeColor = Color.White;

            this.btn_empresa.ForeColor = Color.White;
            this.btn_persona.ForeColor = Color.White;

            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar_claro;

            this.tb_buscar.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_buscar.ForeColor = Color.White;
            this.tb_buscar.FocusedState.ForeColor = Color.White;
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.PlaceholderForeColor = Color.White;

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.dtgv_clientes.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_clientes.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_clientes.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_clientes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_clientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;

        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);

            this.lb_titulo.ForeColor = Color.DimGray;

            this.btn_empresa.ForeColor = Color.Gray;
            this.btn_persona.ForeColor = Color.Gray;

            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar;

            this.tb_buscar.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.PlaceholderForeColor = Color.Gray;

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;

            this.dtgv_clientes.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_clientes.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_clientes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_clientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
        }


        private void BuscarEmpresa(string pDato)
        {
            dtgv_clientes.RowTemplate.Height = 40;
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
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'EMPRESA' AND"
            + " RUT LIKE '" + pDato.ToString()
            + "' OR RAZON_SOCIAL LIKE '" + pDato.ToString() + "';";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;

            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].Visible = false;

            dtgv_clientes.Columns["RazonSocial"].HeaderText = "Razon Social";
            dtgv_clientes.Columns["RazonSocial"].DisplayIndex = 0;

            dtgv_clientes.Columns["Rut"].HeaderText = "Rut";
            dtgv_clientes.Columns["Rut"].DisplayIndex = 1;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 2;
            dtgv_clientes.Columns["Departamento"].Visible = false;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 3;
            dtgv_clientes.Columns["Localidad"].Visible = false;

            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto ";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 4;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 5;
            dtgv_clientes.Columns["Contacto2"].Width = 120;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 6;
        }

        private void BuscarPersona(string pDato)
        {
            dtgv_clientes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            NOMBRE_COMPLETO AS Nombre,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'PERSONA' AND"
            + " NOMBRE_COMPLETO LIKE '" + pDato.ToString()
            + "' OR DOCUMENTO LIKE '" + pDato.ToString() + "';";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;
        }

        private void CargarPersona()
        {
            dtgv_clientes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            NOMBRE_COMPLETO AS Nombre,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'PERSONA';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;


            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].HeaderText = "Tipo cliente";
            dtgv_clientes.Columns["TipoCliente"].Visible = false;

            dtgv_clientes.Columns["Nombre"].HeaderText = "Nombre";
            dtgv_clientes.Columns["Nombre"].DisplayIndex = 0;

            dtgv_clientes.Columns["Documento"].HeaderText = "Documento";
            dtgv_clientes.Columns["Documento"].DisplayIndex = 3;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 4;
            dtgv_clientes.Columns["Departamento"].Visible = false;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 5;
            dtgv_clientes.Columns["Localidad"].Visible = false;

            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 6;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 7;
            dtgv_clientes.Columns["Contacto2"].Width = 120;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 8;
            dtgv_clientes.Columns["Correo"].Visible = false;
        }

        private void CargarEmpresa()
        {
            dtgv_clientes.RowTemplate.Height = 40;
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
            CORREO AS Correo
            FROM CLIENTE WHERE TIPO_CLIENTE = 'EMPRESA';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_clientes.DataSource = dt;

            dtgv_clientes.Columns["Id"].HeaderText = "Id";
            dtgv_clientes.Columns["Id"].Visible = false;

            dtgv_clientes.Columns["TipoCliente"].Visible = false;

            dtgv_clientes.Columns["RazonSocial"].HeaderText = "Razon Social";
            dtgv_clientes.Columns["RazonSocial"].DisplayIndex = 0;

            dtgv_clientes.Columns["Rut"].HeaderText = "Rut";
            dtgv_clientes.Columns["Rut"].DisplayIndex = 1;

            dtgv_clientes.Columns["Departamento"].HeaderText = "Departamento";
            dtgv_clientes.Columns["Departamento"].DisplayIndex = 2;
            dtgv_clientes.Columns["Departamento"].Visible = false;

            dtgv_clientes.Columns["Localidad"].HeaderText = "Localidad";
            dtgv_clientes.Columns["Localidad"].DisplayIndex = 3;
            dtgv_clientes.Columns["Localidad"].Visible = false;

            dtgv_clientes.Columns["Contacto1"].HeaderText = "Contacto ";
            dtgv_clientes.Columns["Contacto1"].DisplayIndex = 4;

            dtgv_clientes.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_clientes.Columns["Contacto2"].DisplayIndex = 5;
            dtgv_clientes.Columns["Contacto2"].Width = 120;

            dtgv_clientes.Columns["Correo"].HeaderText = "Correo";
            dtgv_clientes.Columns["Correo"].DisplayIndex = 6;
        }

        public void SeleccionarCliente()
        {
            if (dtgv_clientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_clientes.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);

                if (tipo_cliente == "PERSONA")
                {
                    frmAgregarDispositivo frmAgregarDispositivo = new frmAgregarDispositivo();
                    frmAgregarDispositivo.CargarDatos(id, tipo_cliente);
                    frmAgregarDispositivo.Show();
                }
                else if (tipo_cliente == "EMPRESA")
                {
                    frmAgregarDispositivo frmAgregarDispositivo = new frmAgregarDispositivo();
                    frmAgregarDispositivo.CargarDatos(id, tipo_cliente);
                    frmAgregarDispositivo.Show();
                }

                this.Close();
            }
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void tb_buscar_TextChanged_1(object sender, EventArgs e)
        {
            string dato = "%" + tb_buscar.Text + "%";
            if (tipoCliente == "EMPRESA")
            {
                BuscarEmpresa(dato);
            }
            else if (tipoCliente == "PERSONA")
            {
                BuscarPersona(dato);
            }

            // Establecer un maximo de caracteres (100) 
            int maxCaracteres = 100;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_buscar.Text.Length > maxCaracteres)
            {
                tb_buscar.Text = tb_buscar.Text.Substring(0, maxCaracteres);
                tb_buscar.Select(maxCaracteres, 0); // Colocar el cursor al final del texto 
            }

        }

        private void tb_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_seleccionar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void frmSeleccionarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    SeleccionarCliente();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region Botones
        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }

        private void btn_persona_Click(object sender, EventArgs e)
        {
            tipoCliente = "PERSONA";
            CargarPersona();
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            tipoCliente = "EMPRESA";
            CargarEmpresa();
        }


        #endregion

        private void dtgv_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                }
                else if (tema == "Oscuro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }
    }
}
