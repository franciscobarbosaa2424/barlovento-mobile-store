               using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion;
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

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.SeleccionarPOrden
{
    public partial class frmSeleccionarDispositivoOrden : Form
    {
        private string tema;
        private string tipoCliente;
        public frmSeleccionarDispositivoOrden()
        {
            InitializeComponent();
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            #region Metodos Enter KeyPress
            this.btn_seleccionar.KeyPress += new KeyPressEventHandler(btn_seleccionar_dispositivo_KeyPress);
            this.tb_buscar.KeyPress += new KeyPressEventHandler(tb_buscar_KeyPress);
            #endregion

            this.KeyPreview = true;
        }

        private void frmSeleccionarDispositivoOrden_Load(object sender, EventArgs e)
        {
            CargarDispositivos();

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
            tema = "Claro";
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);

            this.lb_titulo.ForeColor = Color.White;

            this.btn_seleccionar_dispositivo.Image = Properties.Resources.icono_seleccionar_claro;

            this.tb_buscar.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_buscar.ForeColor = Color.White;
            this.tb_buscar.FocusedState.ForeColor = Color.White;
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.PlaceholderForeColor = Color.White;

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.dtgv_dispositivos.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivos.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivos.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_dispositivos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
            this.dtgv_dispositivos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.BackColor = Color.Black;
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;
            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);

            this.lb_titulo.ForeColor = Color.DimGray;

            this.btn_seleccionar.Image = Properties.Resources.icono_seleccionar;

            this.tb_buscar.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.PlaceholderForeColor = Color.Gray;

            this.cntb_cerrar_formulario.FillColor = Color.Black;
         

            this.dtgv_dispositivos.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivos.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_dispositivos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_dispositivos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
        }




        #region Eventos y validaciones TextBox
        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            string dato = "%" + tb_buscar.Text + "%";
            BuscarDispositivo(dato);

            // Establecer un maximo de caracteres (100) 
            int maxCaracteres = 100;

            // Verificamos si el texto ingresado supera el limite 
            if (tb_buscar.Text.Length > maxCaracteres)
            {
                tb_buscar.Text = tb_buscar.Text.Substring(0, maxCaracteres);
                tb_buscar.Select(maxCaracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void frmSeleccionarDispositivoOrden_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    SeleccionarDispositivo();
                    e.Handled = true;
                    break;

                default:
                    break;
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

        private void btn_seleccionar_dispositivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        #region Metodos auxiliares
        public void SeleccionarDispositivo()
        {
            if (dtgv_dispositivos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_dispositivos.SelectedRows[0];
                frmAgregarOrdenReparacion frmAgregarOrdenReparacion = new frmAgregarOrdenReparacion();
                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells["ClienteId"].Value);
                string tipo_cliente_seleccionado = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                frmAgregarOrdenReparacion.MostrarDatosDtgv(id, idCliente, tipo_cliente_seleccionado);


                this.Close();
                frmAgregarOrdenReparacion.Show();
            }
        }

        private void BuscarDispositivo(string pDato)
        {
            dtgv_dispositivos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            dc.idDispositivo AS Id,
            dc.clienteId AS ClienteId,
            dc.TIPO_DISPOSITIVO AS TipoDispositivo,
            dc.MARCA AS Marca,
            dc.MODELO AS Modelo,
            dc.NUMERO_DE_SERIE AS NumeroDeSerie,
            dc.OBSERVACION AS Observacion,
            c.NOMBRE_COMPLETO AS Nombre,
            c.DOCUMENTO AS Documento,
            c.RUT as Rut,
            c.CORREO as Correo,
            c.LOCALIDAD AS Localidad,
            c.DEPARTAMENTO AS Departamento,
            c.CONTACTO_1 AS Contacto1,
            c.CONTACTO_2 AS Contacto2,
            c.TIPO_CLIENTE AS TipoCliente,
            c.RAZON_SOCIAL AS RazonSocial
            FROM 
            DISPOSITIVO_CLIENTE dc
            JOIN 
            CLIENTE c ON dc.clienteId = c.ID WHERE"
            + " MARCA LIKE '" + pDato.ToString()
            + "' OR NUMERO_DE_SERIE LIKE '" + pDato.ToString()
            + "' OR RUT LIKE '" + pDato.ToString()
            + "' OR DOCUMENTO LIKE '" + pDato.ToString()
            + "' OR MODELO LIKE '" + pDato.ToString() + "';";
            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_dispositivos.DataSource = dt;

            dtgv_dispositivos.Columns["Id"].Visible = false;
            dtgv_dispositivos.Columns["Observacion"].Visible = false;
            dtgv_dispositivos.Columns["Nombre"].Visible = false;
            dtgv_dispositivos.Columns["RazonSocial"].Visible = false;
            dtgv_dispositivos.Columns["Correo"].Visible = false;
            dtgv_dispositivos.Columns["Localidad"].Visible = false;
            dtgv_dispositivos.Columns["Departamento"].Visible = false;
            dtgv_dispositivos.Columns["Contacto1"].Visible = false;
            dtgv_dispositivos.Columns["Contacto2"].Visible = false;
            dtgv_dispositivos.Columns["ClienteId"].Visible = false;
            dtgv_dispositivos.Columns["TipoCliente"].Visible = false;

            dtgv_dispositivos.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivos.Columns["Documento"].HeaderText = "Cédula dueño";
            dtgv_dispositivos.Columns["Rut"].HeaderText = "Rut dueño";
            dtgv_dispositivos.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivos.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivos.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
        }
        private void CargarDispositivos()
        {
            dtgv_dispositivos.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            dc.idDispositivo AS Id,
            dc.clienteId AS ClienteId,
            dc.TIPO_DISPOSITIVO AS TipoDispositivo,
            dc.MARCA AS Marca,
            dc.MODELO AS Modelo,
            dc.NUMERO_DE_SERIE AS NumeroDeSerie,
            dc.OBSERVACION AS Observacion,
            c.NOMBRE_COMPLETO AS Nombre,
            c.DOCUMENTO AS Documento,
            c.RUT as Rut,
            c.CORREO as Correo,
            c.LOCALIDAD AS Localidad,
            c.DEPARTAMENTO AS Departamento,
            c.CONTACTO_1 AS Contacto1,
            c.CONTACTO_2 AS Contacto2,
            c.TIPO_CLIENTE AS TipoCliente,
            c.RAZON_SOCIAL AS RazonSocial
            FROM 
            DISPOSITIVO_CLIENTE dc
            JOIN 
            CLIENTE c ON dc.clienteId = c.ID;";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_dispositivos.DataSource = dt;


            dtgv_dispositivos.Columns["Id"].Visible = false;
            dtgv_dispositivos.Columns["Observacion"].Visible = false;
            dtgv_dispositivos.Columns["Nombre"].Visible = false;
            dtgv_dispositivos.Columns["RazonSocial"].Visible = false;
            dtgv_dispositivos.Columns["Correo"].Visible = false;
            dtgv_dispositivos.Columns["Localidad"].Visible = false;
            dtgv_dispositivos.Columns["Departamento"].Visible = false;
            dtgv_dispositivos.Columns["Contacto1"].Visible = false;
            dtgv_dispositivos.Columns["Contacto2"].Visible = false;
            dtgv_dispositivos.Columns["ClienteId"].Visible = false;
            dtgv_dispositivos.Columns["TipoCliente"].Visible = false;

            dtgv_dispositivos.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivos.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivos.Columns["Documento"].HeaderText = "Cédula dueño";
            dtgv_dispositivos.Columns["Rut"].HeaderText = "Rut dueño";
            dtgv_dispositivos.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivos.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
        }
        #endregion

        #region Botones
        private void btn_seleccionar_dispositivo_Click(object sender, EventArgs e)
        {
            SeleccionarDispositivo();
        }


        #endregion

        private void dtgv_dispositivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

