namespace ProyectoBarloventoReparacel.Vistas
{
    partial class frmClientesHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesHome));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_maximizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel_opciones_menu_inicio = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_inicio = new Guna.UI2.WinForms.Guna2Button();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_buscar_fecha = new Guna.UI2.WinForms.Guna2Button();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.dtp_fecha_hasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_orden_asc_desc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_persona = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_fecha_desde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_empresa = new Guna.UI2.WinForms.Guna2Button();
            this.panel_dtgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollbar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dtgv_clientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_opciones = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_modificar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.tb_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelAgregar = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_agregar_empresa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar_persona = new Guna.UI2.WinForms.Guna2Button();
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.panel_opciones_menu = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_movimientos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ordenes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dispositivos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajustes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clientes = new Guna.UI2.WinForms.Guna2Button();
            this.panel_arriba.SuspendLayout();
            this.panel_opciones_menu_inicio.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.panel_dtgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).BeginInit();
            this.panel_opciones.SuspendLayout();
            this.panelAgregar.SuspendLayout();
            this.panel_opciones_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
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
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Controls.Add(this.cntb_minimizar_formulario);
            this.panel_arriba.Controls.Add(this.cntb_maximizar_formulario);
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(1280, 35);
            this.panel_arriba.TabIndex = 4;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(55, 15);
            this.lb_titulo.TabIndex = 121;
            this.lb_titulo.Text = "Clientes";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(1121, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 2;
            // 
            // cntb_maximizar_formulario
            // 
            this.cntb_maximizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_maximizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.cntb_maximizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_maximizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_maximizar_formulario.Location = new System.Drawing.Point(1172, 6);
            this.cntb_maximizar_formulario.Name = "cntb_maximizar_formulario";
            this.cntb_maximizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_maximizar_formulario.TabIndex = 1;
            this.cntb_maximizar_formulario.Click += new System.EventHandler(this.cntb_maximizar_formulario_Click);
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(1223, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            this.cntb_cerrar_formulario.Click += new System.EventHandler(this.cntb_cerrar_formulario_Click);
            // 
            // panel_opciones_menu_inicio
            // 
            this.panel_opciones_menu_inicio.BackColor = System.Drawing.Color.Transparent;
            this.panel_opciones_menu_inicio.Controls.Add(this.btn_inicio);
            this.panel_opciones_menu_inicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_opciones_menu_inicio.Location = new System.Drawing.Point(12, 41);
            this.panel_opciones_menu_inicio.Name = "panel_opciones_menu_inicio";
            this.panel_opciones_menu_inicio.Radius = 5;
            this.panel_opciones_menu_inicio.ShadowColor = System.Drawing.Color.Black;
            this.panel_opciones_menu_inicio.ShadowShift = 3;
            this.panel_opciones_menu_inicio.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_opciones_menu_inicio.Size = new System.Drawing.Size(140, 60);
            this.panel_opciones_menu_inicio.TabIndex = 45;
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_inicio.BorderRadius = 10;
            this.btn_inicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inicio.FillColor = System.Drawing.Color.Transparent;
            this.btn_inicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.ForeColor = System.Drawing.Color.Gray;
            this.btn_inicio.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_inicio_menu;
            this.btn_inicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inicio.Location = new System.Drawing.Point(6, 12);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(128, 37);
            this.btn_inicio.TabIndex = 10;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panel_central
            // 
            this.panel_central.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.btn_buscar_fecha);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.lb_1);
            this.panel_central.Controls.Add(this.dtp_fecha_hasta);
            this.panel_central.Controls.Add(this.btn_orden_asc_desc);
            this.panel_central.Controls.Add(this.btn_persona);
            this.panel_central.Controls.Add(this.dtp_fecha_desde);
            this.panel_central.Controls.Add(this.btn_empresa);
            this.panel_central.Controls.Add(this.panel_dtgv);
            this.panel_central.Controls.Add(this.panel_opciones);
            this.panel_central.Controls.Add(this.tb_buscar);
            this.panel_central.Controls.Add(this.panelAgregar);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(167, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.Radius = 5;
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(1101, 628);
            this.panel_central.TabIndex = 47;
            // 
            // btn_buscar_fecha
            // 
            this.btn_buscar_fecha.BorderRadius = 5;
            this.btn_buscar_fecha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_fecha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_fecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar_fecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar_fecha.FillColor = System.Drawing.Color.Transparent;
            this.btn_buscar_fecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_fecha.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_fecha.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_buscar;
            this.btn_buscar_fecha.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_buscar_fecha.Location = new System.Drawing.Point(721, 11);
            this.btn_buscar_fecha.Name = "btn_buscar_fecha";
            this.btn_buscar_fecha.Size = new System.Drawing.Size(30, 30);
            this.btn_buscar_fecha.TabIndex = 115;
            this.Información.SetToolTip(this.btn_buscar_fecha, "Buscar");
            this.btn_buscar_fecha.Click += new System.EventHandler(this.btn_buscar_fecha_Click);
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.Gray;
            this.lb_2.Location = new System.Drawing.Point(520, 18);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(74, 15);
            this.lb_2.TabIndex = 145;
            this.lb_2.Text = "Fecha hasta:";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.Gray;
            this.lb_1.Location = new System.Drawing.Point(315, 18);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(78, 15);
            this.lb_1.TabIndex = 143;
            this.lb_1.Text = "Fecha desde:";
            // 
            // dtp_fecha_hasta
            // 
            this.dtp_fecha_hasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_hasta.BorderRadius = 2;
            this.dtp_fecha_hasta.Checked = true;
            this.dtp_fecha_hasta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_hasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_hasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha_hasta.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_hasta.Location = new System.Drawing.Point(596, 8);
            this.dtp_fecha_hasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_hasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_hasta.Name = "dtp_fecha_hasta";
            this.dtp_fecha_hasta.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha_hasta.TabIndex = 50;
            this.dtp_fecha_hasta.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            // 
            // btn_orden_asc_desc
            // 
            this.btn_orden_asc_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_orden_asc_desc.BorderRadius = 5;
            this.btn_orden_asc_desc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_orden_asc_desc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_orden_asc_desc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_orden_asc_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orden_asc_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_orden_asc_desc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_orden_asc_desc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orden_asc_desc.ForeColor = System.Drawing.Color.White;
            this.btn_orden_asc_desc.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_orden_asc_desc;
            this.btn_orden_asc_desc.Location = new System.Drawing.Point(1042, 202);
            this.btn_orden_asc_desc.Name = "btn_orden_asc_desc";
            this.btn_orden_asc_desc.Size = new System.Drawing.Size(46, 44);
            this.btn_orden_asc_desc.TabIndex = 117;
            this.Información.SetToolTip(this.btn_orden_asc_desc, "Ordenar");
            this.btn_orden_asc_desc.Click += new System.EventHandler(this.btn_orden_asc_desc_Click);
            // 
            // btn_persona
            // 
            this.btn_persona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_persona.BorderRadius = 2;
            this.btn_persona.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_persona.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_persona.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_persona.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_persona.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_persona.FillColor = System.Drawing.Color.Transparent;
            this.btn_persona.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_persona.ForeColor = System.Drawing.Color.Gray;
            this.btn_persona.Location = new System.Drawing.Point(936, 18);
            this.btn_persona.Name = "btn_persona";
            this.btn_persona.Size = new System.Drawing.Size(92, 25);
            this.btn_persona.TabIndex = 119;
            this.btn_persona.Text = "Persona";
            this.btn_persona.Click += new System.EventHandler(this.btn_persona_Click);
            // 
            // dtp_fecha_desde
            // 
            this.dtp_fecha_desde.BorderRadius = 2;
            this.dtp_fecha_desde.Checked = true;
            this.dtp_fecha_desde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_desde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha_desde.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_desde.Location = new System.Drawing.Point(399, 7);
            this.dtp_fecha_desde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_desde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_desde.Name = "dtp_fecha_desde";
            this.dtp_fecha_desde.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha_desde.TabIndex = 49;
            this.dtp_fecha_desde.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            // 
            // btn_empresa
            // 
            this.btn_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_empresa.BorderRadius = 2;
            this.btn_empresa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_empresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_empresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_empresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_empresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_empresa.FillColor = System.Drawing.Color.Transparent;
            this.btn_empresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_empresa.ForeColor = System.Drawing.Color.Gray;
            this.btn_empresa.Location = new System.Drawing.Point(838, 18);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(92, 25);
            this.btn_empresa.TabIndex = 118;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // panel_dtgv
            // 
            this.panel_dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv.Controls.Add(this.scrollbar);
            this.panel_dtgv.Controls.Add(this.dtgv_clientes);
            this.panel_dtgv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv.Location = new System.Drawing.Point(14, 49);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv.ShadowShift = 3;
            this.panel_dtgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv.Size = new System.Drawing.Size(1020, 564);
            this.panel_dtgv.TabIndex = 53;
            // 
            // scrollbar
            // 
            this.scrollbar.AutoRoundedCorners = true;
            this.scrollbar.BindingContainer = this.dtgv_clientes;
            this.scrollbar.BorderRadius = 8;
            this.scrollbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.scrollbar.InUpdate = false;
            this.scrollbar.LargeChange = 10;
            this.scrollbar.Location = new System.Drawing.Point(996, 11);
            this.scrollbar.Minimum = 1;
            this.scrollbar.MinimumSize = new System.Drawing.Size(10, 0);
            this.scrollbar.Name = "scrollbar";
            this.scrollbar.ScrollbarSize = 18;
            this.scrollbar.Size = new System.Drawing.Size(18, 545);
            this.scrollbar.TabIndex = 4;
            this.scrollbar.ThumbColor = System.Drawing.Color.DimGray;
            this.scrollbar.ThumbSize = 5F;
            this.scrollbar.Value = 1;
            // 
            // dtgv_clientes
            // 
            this.dtgv_clientes.AllowUserToAddRows = false;
            this.dtgv_clientes.AllowUserToResizeColumns = false;
            this.dtgv_clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_clientes.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_clientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_clientes.Location = new System.Drawing.Point(3, 11);
            this.dtgv_clientes.Name = "dtgv_clientes";
            this.dtgv_clientes.ReadOnly = true;
            this.dtgv_clientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            this.dtgv_clientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_clientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_clientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_clientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.dtgv_clientes.RowTemplate.DividerHeight = 3;
            this.dtgv_clientes.RowTemplate.Height = 50;
            this.dtgv_clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_clientes.Size = new System.Drawing.Size(1011, 545);
            this.dtgv_clientes.TabIndex = 0;
            this.dtgv_clientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_clientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_clientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_clientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_clientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_clientes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_clientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_clientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_clientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_clientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_clientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_clientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_clientes.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgv_clientes.ThemeStyle.ReadOnly = true;
            this.dtgv_clientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_clientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_clientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_clientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_clientes.ThemeStyle.RowsStyle.Height = 50;
            this.dtgv_clientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_clientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_clientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_clientes_CellFormatting);
            // 
            // panel_opciones
            // 
            this.panel_opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_opciones.BackColor = System.Drawing.Color.Transparent;
            this.panel_opciones.Controls.Add(this.btn_modificar);
            this.panel_opciones.Controls.Add(this.btn_agregar);
            this.panel_opciones.Controls.Add(this.btn_eliminar);
            this.panel_opciones.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_opciones.Location = new System.Drawing.Point(1040, 49);
            this.panel_opciones.Name = "panel_opciones";
            this.panel_opciones.Radius = 5;
            this.panel_opciones.ShadowColor = System.Drawing.Color.Black;
            this.panel_opciones.ShadowShift = 3;
            this.panel_opciones.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_opciones.Size = new System.Drawing.Size(52, 147);
            this.panel_opciones.TabIndex = 108;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.BorderRadius = 5;
            this.btn_modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_modificar.Image")));
            this.btn_modificar.Location = new System.Drawing.Point(2, 100);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(46, 44);
            this.btn_modificar.TabIndex = 114;
            this.Información.SetToolTip(this.btn_modificar, "Modificar cliente (F3)");
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.BorderRadius = 5;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_agregar;
            this.btn_agregar.Location = new System.Drawing.Point(2, 51);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(46, 44);
            this.btn_agregar.TabIndex = 113;
            this.Información.SetToolTip(this.btn_agregar, "Agregar cliente (F2)");
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.BorderRadius = 5;
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_eliminar;
            this.btn_eliminar.Location = new System.Drawing.Point(2, 1);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(46, 44);
            this.btn_eliminar.TabIndex = 112;
            this.Información.SetToolTip(this.btn_eliminar, "Eliminar cliente (F1)\r\n");
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // tb_buscar
            // 
            this.tb_buscar.BackColor = System.Drawing.Color.Transparent;
            this.tb_buscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_buscar.BorderRadius = 5;
            this.tb_buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_buscar.DefaultText = "";
            this.tb_buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_buscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_buscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_buscar.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_buscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_buscar.IconLeft = global::ProyectoBarloventoReparacel.Properties.Resources.icono_buscar;
            this.tb_buscar.IconLeftSize = new System.Drawing.Size(16, 16);
            this.tb_buscar.Location = new System.Drawing.Point(14, 16);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.PasswordChar = '\0';
            this.tb_buscar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_buscar.PlaceholderText = "Buscar...";
            this.tb_buscar.SelectedText = "";
            this.tb_buscar.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.tb_buscar.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_buscar.ShadowDecoration.Enabled = true;
            this.tb_buscar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_buscar.Size = new System.Drawing.Size(272, 27);
            this.tb_buscar.TabIndex = 105;
            this.tb_buscar.TextChanged += new System.EventHandler(this.tb_buscar_TextChanged_1);
            // 
            // panelAgregar
            // 
            this.panelAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelAgregar.Controls.Add(this.btn_agregar_empresa);
            this.panelAgregar.Controls.Add(this.btn_agregar_persona);
            this.panelAgregar.Location = new System.Drawing.Point(752, 443);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.ShadowDecoration.Depth = 10;
            this.panelAgregar.ShadowDecoration.Enabled = true;
            this.panelAgregar.Size = new System.Drawing.Size(123, 102);
            this.panelAgregar.TabIndex = 32;
            // 
            // btn_agregar_empresa
            // 
            this.btn_agregar_empresa.BorderRadius = 5;
            this.btn_agregar_empresa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar_empresa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar_empresa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar_empresa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar_empresa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_agregar_empresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_empresa.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_empresa.Location = new System.Drawing.Point(10, 55);
            this.btn_agregar_empresa.Name = "btn_agregar_empresa";
            this.btn_agregar_empresa.Size = new System.Drawing.Size(104, 38);
            this.btn_agregar_empresa.TabIndex = 18;
            this.btn_agregar_empresa.Text = "Empresa";
            // 
            // btn_agregar_persona
            // 
            this.btn_agregar_persona.BorderRadius = 5;
            this.btn_agregar_persona.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar_persona.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar_persona.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar_persona.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar_persona.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_agregar_persona.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_persona.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_persona.Location = new System.Drawing.Point(10, 11);
            this.btn_agregar_persona.Name = "btn_agregar_persona";
            this.btn_agregar_persona.Size = new System.Drawing.Size(104, 38);
            this.btn_agregar_persona.TabIndex = 17;
            this.btn_agregar_persona.Text = "Persona";
            // 
            // panel_opciones_menu
            // 
            this.panel_opciones_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_opciones_menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_opciones_menu.Controls.Add(this.btn_movimientos);
            this.panel_opciones_menu.Controls.Add(this.btn_ordenes);
            this.panel_opciones_menu.Controls.Add(this.btn_dispositivos);
            this.panel_opciones_menu.Controls.Add(this.btn_ajustes);
            this.panel_opciones_menu.Controls.Add(this.btn_clientes);
            this.panel_opciones_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_opciones_menu.Location = new System.Drawing.Point(12, 107);
            this.panel_opciones_menu.Name = "panel_opciones_menu";
            this.panel_opciones_menu.Radius = 5;
            this.panel_opciones_menu.ShadowColor = System.Drawing.Color.Black;
            this.panel_opciones_menu.ShadowShift = 3;
            this.panel_opciones_menu.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_opciones_menu.Size = new System.Drawing.Size(140, 562);
            this.panel_opciones_menu.TabIndex = 120;
            // 
            // btn_movimientos
            // 
            this.btn_movimientos.BorderRadius = 10;
            this.btn_movimientos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_movimientos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_movimientos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_movimientos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_movimientos.FillColor = System.Drawing.Color.Transparent;
            this.btn_movimientos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movimientos.ForeColor = System.Drawing.Color.Gray;
            this.btn_movimientos.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_movimientos;
            this.btn_movimientos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_movimientos.Location = new System.Drawing.Point(6, 135);
            this.btn_movimientos.Name = "btn_movimientos";
            this.btn_movimientos.Size = new System.Drawing.Size(128, 37);
            this.btn_movimientos.TabIndex = 47;
            this.btn_movimientos.Text = "Movimientos";
            this.btn_movimientos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_movimientos.Click += new System.EventHandler(this.btn_movimientos_Click);
            // 
            // btn_ordenes
            // 
            this.btn_ordenes.BorderRadius = 10;
            this.btn_ordenes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ordenes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ordenes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ordenes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ordenes.FillColor = System.Drawing.Color.Transparent;
            this.btn_ordenes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordenes.ForeColor = System.Drawing.Color.Gray;
            this.btn_ordenes.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_ordenes_menu;
            this.btn_ordenes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ordenes.Location = new System.Drawing.Point(6, 96);
            this.btn_ordenes.Name = "btn_ordenes";
            this.btn_ordenes.Size = new System.Drawing.Size(128, 37);
            this.btn_ordenes.TabIndex = 6;
            this.btn_ordenes.Text = "Ordenes";
            this.btn_ordenes.Click += new System.EventHandler(this.btn_ordenes_Click_1);
            // 
            // btn_dispositivos
            // 
            this.btn_dispositivos.BorderRadius = 10;
            this.btn_dispositivos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dispositivos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dispositivos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dispositivos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dispositivos.FillColor = System.Drawing.Color.Transparent;
            this.btn_dispositivos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_dispositivos.ForeColor = System.Drawing.Color.Gray;
            this.btn_dispositivos.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_dispositivos_menu;
            this.btn_dispositivos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_dispositivos.Location = new System.Drawing.Point(6, 9);
            this.btn_dispositivos.Name = "btn_dispositivos";
            this.btn_dispositivos.Size = new System.Drawing.Size(128, 37);
            this.btn_dispositivos.TabIndex = 3;
            this.btn_dispositivos.Text = "Dispositivos";
            this.btn_dispositivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_dispositivos.Click += new System.EventHandler(this.btn_dispositivos_Click_1);
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ajustes.BorderRadius = 10;
            this.btn_ajustes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_ajustes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajustes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajustes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajustes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajustes.FillColor = System.Drawing.Color.Transparent;
            this.btn_ajustes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ajustes.ForeColor = System.Drawing.Color.Gray;
            this.btn_ajustes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajustes.Image")));
            this.btn_ajustes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ajustes.Location = new System.Drawing.Point(6, 510);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(128, 37);
            this.btn_ajustes.TabIndex = 9;
            this.btn_ajustes.Text = "Ajustes";
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click_1);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BorderRadius = 10;
            this.btn_clientes.Checked = true;
            this.btn_clientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clientes.FillColor = System.Drawing.Color.Transparent;
            this.btn_clientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientes.ForeColor = System.Drawing.Color.Gray;
            this.btn_clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_clientes.Image")));
            this.btn_clientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_clientes.Location = new System.Drawing.Point(6, 53);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(128, 37);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click_1);
            // 
            // frmClientesHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1280, 686);
            this.Controls.Add(this.panel_opciones_menu);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_opciones_menu_inicio);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientesHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmClientesHome_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_opciones_menu_inicio.ResumeLayout(false);
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel_dtgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).EndInit();
            this.panel_opciones.ResumeLayout(false);
            this.panelAgregar.ResumeLayout(false);
            this.panel_opciones_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_maximizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_opciones_menu_inicio;
        private Guna.UI2.WinForms.Guna2Button btn_inicio;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2Panel panelAgregar;
        private Guna.UI2.WinForms.Guna2Button btn_agregar_empresa;
        private Guna.UI2.WinForms.Guna2Button btn_agregar_persona;
        private Guna.UI2.WinForms.Guna2TextBox tb_buscar;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_clientes;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_opciones;
        private Guna.UI2.WinForms.Guna2Button btn_modificar;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar;
        private Guna.UI2.WinForms.Guna2Button btn_orden_asc_desc;
        private System.Windows.Forms.ToolTip Información;
        private Guna.UI2.WinForms.Guna2Button btn_persona;
        private Guna.UI2.WinForms.Guna2Button btn_empresa;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_opciones_menu;
        private Guna.UI2.WinForms.Guna2Button btn_movimientos;
        private Guna.UI2.WinForms.Guna2Button btn_ordenes;
        private Guna.UI2.WinForms.Guna2Button btn_dispositivos;
        private Guna.UI2.WinForms.Guna2Button btn_ajustes;
        private Guna.UI2.WinForms.Guna2Button btn_clientes;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha_hasta;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha_desde;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private Guna.UI2.WinForms.Guna2Button btn_buscar_fecha;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollbar;
    }
}