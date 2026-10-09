namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Modificar
{
    partial class frmModificarOrdenReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarOrdenReparacion));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cb_estado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_5 = new System.Windows.Forms.Label();
            this.panel_dtgv_propietario = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgv_propietario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_2 = new System.Windows.Forms.Label();
            this.panel_dtgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgv_dispositivo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_agregar_imagen = new Guna.UI2.WinForms.Guna2Button();
            this.btn_modificar = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tb_falla = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_4 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.panel_arriba.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.panel_dtgv_propietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_propietario)).BeginInit();
            this.panel_dtgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dispositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Controls.Add(this.cntb_minimizar_formulario);
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(599, 35);
            this.panel_arriba.TabIndex = 37;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(190, 15);
            this.lb_titulo.TabIndex = 153;
            this.lb_titulo.Text = "Modificar órden de reparación";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(491, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 1;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(542, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            // 
            // panel_central
            // 
            this.panel_central.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.cb_estado);
            this.panel_central.Controls.Add(this.lb_5);
            this.panel_central.Controls.Add(this.panel_dtgv_propietario);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.panel_dtgv);
            this.panel_central.Controls.Add(this.btn_agregar_imagen);
            this.panel_central.Controls.Add(this.btn_modificar);
            this.panel_central.Controls.Add(this.flowLayoutPanel1);
            this.panel_central.Controls.Add(this.tb_falla);
            this.panel_central.Controls.Add(this.lb_4);
            this.panel_central.Controls.Add(this.lb_3);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(575, 560);
            this.panel_central.TabIndex = 130;
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.Transparent;
            this.cb_estado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cb_estado.BorderRadius = 5;
            this.cb_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.cb_estado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_estado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_estado.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cb_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_estado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_estado.ItemHeight = 30;
            this.cb_estado.Items.AddRange(new object[] {
            "Terminado",
            "Cancelado",
            "Pendiente",
            "En proceso"});
            this.cb_estado.Location = new System.Drawing.Point(392, 436);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(169, 36);
            this.cb_estado.TabIndex = 2;
            this.cb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_estado_KeyPress);
            // 
            // lb_5
            // 
            this.lb_5.AutoSize = true;
            this.lb_5.BackColor = System.Drawing.Color.Transparent;
            this.lb_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_5.ForeColor = System.Drawing.Color.DimGray;
            this.lb_5.Location = new System.Drawing.Point(384, 412);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(59, 21);
            this.lb_5.TabIndex = 191;
            this.lb_5.Text = "Estado:";
            // 
            // panel_dtgv_propietario
            // 
            this.panel_dtgv_propietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv_propietario.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv_propietario.Controls.Add(this.dtgv_propietario);
            this.panel_dtgv_propietario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv_propietario.Location = new System.Drawing.Point(11, 150);
            this.panel_dtgv_propietario.Name = "panel_dtgv_propietario";
            this.panel_dtgv_propietario.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv_propietario.ShadowShift = 3;
            this.panel_dtgv_propietario.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv_propietario.Size = new System.Drawing.Size(550, 80);
            this.panel_dtgv_propietario.TabIndex = 185;
            // 
            // dtgv_propietario
            // 
            this.dtgv_propietario.AllowUserToAddRows = false;
            this.dtgv_propietario.AllowUserToResizeColumns = false;
            this.dtgv_propietario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_propietario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_propietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_propietario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_propietario.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_propietario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_propietario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_propietario.Location = new System.Drawing.Point(4, 5);
            this.dtgv_propietario.Name = "dtgv_propietario";
            this.dtgv_propietario.ReadOnly = true;
            this.dtgv_propietario.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            this.dtgv_propietario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_propietario.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_propietario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_propietario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_propietario.RowTemplate.DividerHeight = 3;
            this.dtgv_propietario.RowTemplate.Height = 50;
            this.dtgv_propietario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_propietario.Size = new System.Drawing.Size(538, 70);
            this.dtgv_propietario.TabIndex = 1;
            this.dtgv_propietario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_propietario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_propietario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_propietario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_propietario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_propietario.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_propietario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_propietario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_propietario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_propietario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_propietario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_propietario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_propietario.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgv_propietario.ThemeStyle.ReadOnly = true;
            this.dtgv_propietario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_propietario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_propietario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_propietario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_propietario.ThemeStyle.RowsStyle.Height = 50;
            this.dtgv_propietario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_propietario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_2.Location = new System.Drawing.Point(10, 122);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(126, 25);
            this.lb_2.TabIndex = 184;
            this.lb_2.Text = "Propietario";
            // 
            // panel_dtgv
            // 
            this.panel_dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv.Controls.Add(this.dtgv_dispositivo);
            this.panel_dtgv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv.Location = new System.Drawing.Point(11, 35);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv.ShadowShift = 3;
            this.panel_dtgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv.Size = new System.Drawing.Size(550, 80);
            this.panel_dtgv.TabIndex = 183;
            // 
            // dtgv_dispositivo
            // 
            this.dtgv_dispositivo.AllowUserToAddRows = false;
            this.dtgv_dispositivo.AllowUserToResizeColumns = false;
            this.dtgv_dispositivo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_dispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_dispositivo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_dispositivo.ColumnHeadersHeight = 25;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_dispositivo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_dispositivo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivo.Location = new System.Drawing.Point(4, 5);
            this.dtgv_dispositivo.Name = "dtgv_dispositivo";
            this.dtgv_dispositivo.ReadOnly = true;
            this.dtgv_dispositivo.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Purple;
            this.dtgv_dispositivo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_dispositivo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_dispositivo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivo.RowTemplate.DividerHeight = 3;
            this.dtgv_dispositivo.RowTemplate.Height = 50;
            this.dtgv_dispositivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_dispositivo.Size = new System.Drawing.Size(538, 70);
            this.dtgv_dispositivo.TabIndex = 0;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgv_dispositivo.ThemeStyle.ReadOnly = true;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.Height = 50;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // btn_agregar_imagen
            // 
            this.btn_agregar_imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar_imagen.BorderRadius = 5;
            this.btn_agregar_imagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar_imagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar_imagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar_imagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar_imagen.FillColor = System.Drawing.Color.Transparent;
            this.btn_agregar_imagen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_imagen.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_imagen.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_agregar_imagen;
            this.btn_agregar_imagen.Location = new System.Drawing.Point(463, 510);
            this.btn_agregar_imagen.Name = "btn_agregar_imagen";
            this.btn_agregar_imagen.Size = new System.Drawing.Size(46, 44);
            this.btn_agregar_imagen.TabIndex = 3;
            this.Información.SetToolTip(this.btn_agregar_imagen, "Agregar imagenes (F1)");
            this.btn_agregar_imagen.Click += new System.EventHandler(this.btn_agregar_imagen_Click);
            this.btn_agregar_imagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_agregar_imagen_KeyPress);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.BorderRadius = 5;
            this.btn_modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modificar.FillColor = System.Drawing.Color.Transparent;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_modificar;
            this.btn_modificar.Location = new System.Drawing.Point(515, 510);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(46, 44);
            this.btn_modificar.TabIndex = 4;
            this.Información.SetToolTip(this.btn_modificar, "Modificar orden (F2)");
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            this.btn_modificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_modificar_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 425);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 100);
            this.flowLayoutPanel1.TabIndex = 175;
            // 
            // tb_falla
            // 
            this.tb_falla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_falla.BorderRadius = 3;
            this.tb_falla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_falla.DefaultText = "";
            this.tb_falla.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_falla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_falla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_falla.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_falla.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_falla.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_falla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_falla.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_falla.Location = new System.Drawing.Point(11, 294);
            this.tb_falla.Multiline = true;
            this.tb_falla.Name = "tb_falla";
            this.tb_falla.PasswordChar = '\0';
            this.tb_falla.PlaceholderText = "";
            this.tb_falla.SelectedText = "";
            this.tb_falla.Size = new System.Drawing.Size(550, 102);
            this.tb_falla.TabIndex = 1;
            this.tb_falla.TextChanged += new System.EventHandler(this.tb_falla_TextChanged);
            this.tb_falla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_falla_KeyPress);
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.BackColor = System.Drawing.Color.Transparent;
            this.lb_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.ForeColor = System.Drawing.Color.DimGray;
            this.lb_4.Location = new System.Drawing.Point(7, 270);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(148, 21);
            this.lb_4.TabIndex = 136;
            this.lb_4.Text = "Falla del dispositivo:";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.ForeColor = System.Drawing.Color.DimGray;
            this.lb_3.Location = new System.Drawing.Point(10, 7);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(122, 25);
            this.lb_3.TabIndex = 153;
            this.lb_3.Text = "Dispositivo";
            // 
            // dc_panel_arriba
            // 
            this.dc_panel_arriba.DockIndicatorColor = System.Drawing.Color.Black;
            this.dc_panel_arriba.DockIndicatorTransparencyValue = 0D;
            this.dc_panel_arriba.DragEndTransparencyValue = 0.1D;
            this.dc_panel_arriba.DragStartTransparencyValue = 0.1D;
            this.dc_panel_arriba.TargetControl = this.panel_arriba;
            this.dc_panel_arriba.TransparentWhileDrag = false;
            // 
            // frmModificarOrdenReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(599, 613);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarOrdenReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar orden";
            this.Load += new System.EventHandler(this.frmModificarOrdenReparacion_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmModificarOrdenReparacion_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel_dtgv_propietario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_propietario)).EndInit();
            this.panel_dtgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dispositivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv_propietario;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_propietario;
        private System.Windows.Forms.Label lb_2;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_dispositivo;
        private Guna.UI2.WinForms.Guna2Button btn_agregar_imagen;
        private Guna.UI2.WinForms.Guna2Button btn_modificar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox tb_falla;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_5;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2ComboBox cb_estado;
        private System.Windows.Forms.ToolTip Información;
    }
}