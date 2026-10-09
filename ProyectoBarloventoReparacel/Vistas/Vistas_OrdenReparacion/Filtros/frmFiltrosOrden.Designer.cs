namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Filtros
{
    partial class frmFiltrosOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltrosOrden));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tb_total_hasta = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_total_desde = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_buscar_total = new Guna.UI2.WinForms.Guna2Button();
            this.lb_11 = new System.Windows.Forms.Label();
            this.lb_10 = new System.Windows.Forms.Label();
            this.lb_9 = new System.Windows.Forms.Label();
            this.dtp_fecha_egreso_hasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_buscar_fecha_egreso = new Guna.UI2.WinForms.Guna2Button();
            this.lb_8 = new System.Windows.Forms.Label();
            this.lb_7 = new System.Windows.Forms.Label();
            this.dtp_fecha_egreso_desde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_6 = new System.Windows.Forms.Label();
            this.dtp_fecha_ingreso_hasta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_buscar_fecha_ingreso = new Guna.UI2.WinForms.Guna2Button();
            this.lb_5 = new System.Windows.Forms.Label();
            this.lb_4 = new System.Windows.Forms.Label();
            this.dtp_fecha_ingreso_desde = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_3 = new System.Windows.Forms.Label();
            this.btn_buscar_orden = new Guna.UI2.WinForms.Guna2Button();
            this.tb_numero_de_orden = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.btn_todos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancelados = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pendientes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_en_proceso = new Guna.UI2.WinForms.Guna2Button();
            this.btn_terminados = new Guna.UI2.WinForms.Guna2Button();
            this.lb_1 = new System.Windows.Forms.Label();
            this.panel_arriba.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(393, 35);
            this.panel_arriba.TabIndex = 131;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(336, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(127, 15);
            this.lb_titulo.TabIndex = 152;
            this.lb_titulo.Text = "Filtros de busqueda";
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
            // panel_central
            // 
            this.panel_central.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.tb_total_hasta);
            this.panel_central.Controls.Add(this.tb_total_desde);
            this.panel_central.Controls.Add(this.btn_buscar_total);
            this.panel_central.Controls.Add(this.lb_11);
            this.panel_central.Controls.Add(this.lb_10);
            this.panel_central.Controls.Add(this.lb_9);
            this.panel_central.Controls.Add(this.dtp_fecha_egreso_hasta);
            this.panel_central.Controls.Add(this.btn_buscar_fecha_egreso);
            this.panel_central.Controls.Add(this.lb_8);
            this.panel_central.Controls.Add(this.lb_7);
            this.panel_central.Controls.Add(this.dtp_fecha_egreso_desde);
            this.panel_central.Controls.Add(this.lb_6);
            this.panel_central.Controls.Add(this.dtp_fecha_ingreso_hasta);
            this.panel_central.Controls.Add(this.btn_buscar_fecha_ingreso);
            this.panel_central.Controls.Add(this.lb_5);
            this.panel_central.Controls.Add(this.lb_4);
            this.panel_central.Controls.Add(this.dtp_fecha_ingreso_desde);
            this.panel_central.Controls.Add(this.lb_3);
            this.panel_central.Controls.Add(this.btn_buscar_orden);
            this.panel_central.Controls.Add(this.tb_numero_de_orden);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.btn_todos);
            this.panel_central.Controls.Add(this.btn_cancelados);
            this.panel_central.Controls.Add(this.btn_pendientes);
            this.panel_central.Controls.Add(this.btn_en_proceso);
            this.panel_central.Controls.Add(this.btn_terminados);
            this.panel_central.Controls.Add(this.lb_1);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(369, 405);
            this.panel_central.TabIndex = 132;
            // 
            // tb_total_hasta
            // 
            this.tb_total_hasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_total_hasta.BorderRadius = 5;
            this.tb_total_hasta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_total_hasta.DefaultText = "";
            this.tb_total_hasta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_total_hasta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_total_hasta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_total_hasta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_total_hasta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_total_hasta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_total_hasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_total_hasta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_total_hasta.Location = new System.Drawing.Point(148, 356);
            this.tb_total_hasta.Name = "tb_total_hasta";
            this.tb_total_hasta.PasswordChar = '\0';
            this.tb_total_hasta.PlaceholderText = "";
            this.tb_total_hasta.SelectedText = "";
            this.tb_total_hasta.Size = new System.Drawing.Size(115, 27);
            this.tb_total_hasta.TabIndex = 15;
            this.tb_total_hasta.TextChanged += new System.EventHandler(this.tb_total_hasta_TextChanged);
            this.tb_total_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_total_hasta_KeyPress);
            // 
            // tb_total_desde
            // 
            this.tb_total_desde.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_total_desde.BorderRadius = 5;
            this.tb_total_desde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_total_desde.DefaultText = "";
            this.tb_total_desde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_total_desde.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_total_desde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_total_desde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_total_desde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_total_desde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_total_desde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_total_desde.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_total_desde.Location = new System.Drawing.Point(25, 356);
            this.tb_total_desde.Name = "tb_total_desde";
            this.tb_total_desde.PasswordChar = '\0';
            this.tb_total_desde.PlaceholderText = "";
            this.tb_total_desde.SelectedText = "";
            this.tb_total_desde.Size = new System.Drawing.Size(115, 27);
            this.tb_total_desde.TabIndex = 14;
            this.tb_total_desde.TextChanged += new System.EventHandler(this.tb_total_desde_TextChanged);
            this.tb_total_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_total_desde_KeyPress);
            // 
            // btn_buscar_total
            // 
            this.btn_buscar_total.BorderRadius = 5;
            this.btn_buscar_total.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_total.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar_total.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_buscar_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_total.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscar_total.Location = new System.Drawing.Point(269, 356);
            this.btn_buscar_total.Name = "btn_buscar_total";
            this.btn_buscar_total.Size = new System.Drawing.Size(79, 25);
            this.btn_buscar_total.TabIndex = 16;
            this.btn_buscar_total.Text = "Buscar";
            this.btn_buscar_total.Click += new System.EventHandler(this.btn_buscar_total_Click);
            this.btn_buscar_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_buscar_total_KeyPress);
            // 
            // lb_11
            // 
            this.lb_11.AutoSize = true;
            this.lb_11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_11.ForeColor = System.Drawing.Color.Gray;
            this.lb_11.Location = new System.Drawing.Point(145, 338);
            this.lb_11.Name = "lb_11";
            this.lb_11.Size = new System.Drawing.Size(41, 15);
            this.lb_11.TabIndex = 156;
            this.lb_11.Text = "Hasta:";
            // 
            // lb_10
            // 
            this.lb_10.AutoSize = true;
            this.lb_10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_10.ForeColor = System.Drawing.Color.Gray;
            this.lb_10.Location = new System.Drawing.Point(22, 338);
            this.lb_10.Name = "lb_10";
            this.lb_10.Size = new System.Drawing.Size(45, 15);
            this.lb_10.TabIndex = 155;
            this.lb_10.Text = "Desde:";
            // 
            // lb_9
            // 
            this.lb_9.AutoSize = true;
            this.lb_9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_9.ForeColor = System.Drawing.Color.Gray;
            this.lb_9.Location = new System.Drawing.Point(5, 324);
            this.lb_9.Name = "lb_9";
            this.lb_9.Size = new System.Drawing.Size(52, 15);
            this.lb_9.TabIndex = 153;
            this.lb_9.Text = "Total ($)";
            // 
            // dtp_fecha_egreso_hasta
            // 
            this.dtp_fecha_egreso_hasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_egreso_hasta.BorderRadius = 2;
            this.dtp_fecha_egreso_hasta.Checked = true;
            this.dtp_fecha_egreso_hasta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_egreso_hasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_egreso_hasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha_egreso_hasta.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha_egreso_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_egreso_hasta.Location = new System.Drawing.Point(148, 271);
            this.dtp_fecha_egreso_hasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_egreso_hasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_egreso_hasta.Name = "dtp_fecha_egreso_hasta";
            this.dtp_fecha_egreso_hasta.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha_egreso_hasta.TabIndex = 12;
            this.dtp_fecha_egreso_hasta.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            this.dtp_fecha_egreso_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_fecha_egreso_hasta_KeyPress);
            // 
            // btn_buscar_fecha_egreso
            // 
            this.btn_buscar_fecha_egreso.BorderRadius = 5;
            this.btn_buscar_fecha_egreso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_fecha_egreso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_fecha_egreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar_fecha_egreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar_fecha_egreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_buscar_fecha_egreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_fecha_egreso.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscar_fecha_egreso.Location = new System.Drawing.Point(269, 277);
            this.btn_buscar_fecha_egreso.Name = "btn_buscar_fecha_egreso";
            this.btn_buscar_fecha_egreso.Size = new System.Drawing.Size(79, 25);
            this.btn_buscar_fecha_egreso.TabIndex = 13;
            this.btn_buscar_fecha_egreso.Text = "Buscar";
            this.btn_buscar_fecha_egreso.Click += new System.EventHandler(this.btn_buscar_fecha_egreso_Click_1);
            this.btn_buscar_fecha_egreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_buscar_fecha_egreso_KeyPress);
            // 
            // lb_8
            // 
            this.lb_8.AutoSize = true;
            this.lb_8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_8.ForeColor = System.Drawing.Color.Gray;
            this.lb_8.Location = new System.Drawing.Point(145, 253);
            this.lb_8.Name = "lb_8";
            this.lb_8.Size = new System.Drawing.Size(74, 15);
            this.lb_8.TabIndex = 150;
            this.lb_8.Text = "Fecha hasta:";
            // 
            // lb_7
            // 
            this.lb_7.AutoSize = true;
            this.lb_7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_7.ForeColor = System.Drawing.Color.Gray;
            this.lb_7.Location = new System.Drawing.Point(22, 253);
            this.lb_7.Name = "lb_7";
            this.lb_7.Size = new System.Drawing.Size(78, 15);
            this.lb_7.TabIndex = 149;
            this.lb_7.Text = "Fecha desde:";
            // 
            // dtp_fecha_egreso_desde
            // 
            this.dtp_fecha_egreso_desde.BorderRadius = 2;
            this.dtp_fecha_egreso_desde.Checked = true;
            this.dtp_fecha_egreso_desde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_egreso_desde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha_egreso_desde.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha_egreso_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_egreso_desde.Location = new System.Drawing.Point(25, 271);
            this.dtp_fecha_egreso_desde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_egreso_desde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_egreso_desde.Name = "dtp_fecha_egreso_desde";
            this.dtp_fecha_egreso_desde.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha_egreso_desde.TabIndex = 11;
            this.dtp_fecha_egreso_desde.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            this.dtp_fecha_egreso_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_fecha_egreso_desde_KeyPress);
            // 
            // lb_6
            // 
            this.lb_6.AutoSize = true;
            this.lb_6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_6.ForeColor = System.Drawing.Color.Gray;
            this.lb_6.Location = new System.Drawing.Point(5, 234);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(97, 15);
            this.lb_6.TabIndex = 147;
            this.lb_6.Text = "Fecha de egreso";
            // 
            // dtp_fecha_ingreso_hasta
            // 
            this.dtp_fecha_ingreso_hasta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_ingreso_hasta.BorderRadius = 2;
            this.dtp_fecha_ingreso_hasta.Checked = true;
            this.dtp_fecha_ingreso_hasta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_ingreso_hasta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_ingreso_hasta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha_ingreso_hasta.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha_ingreso_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_ingreso_hasta.Location = new System.Drawing.Point(148, 183);
            this.dtp_fecha_ingreso_hasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_ingreso_hasta.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_ingreso_hasta.Name = "dtp_fecha_ingreso_hasta";
            this.dtp_fecha_ingreso_hasta.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha_ingreso_hasta.TabIndex = 9;
            this.dtp_fecha_ingreso_hasta.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            this.dtp_fecha_ingreso_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_fecha_ingreso_hasta_KeyPress);
            // 
            // btn_buscar_fecha_ingreso
            // 
            this.btn_buscar_fecha_ingreso.BorderRadius = 5;
            this.btn_buscar_fecha_ingreso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_fecha_ingreso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_fecha_ingreso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar_fecha_ingreso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar_fecha_ingreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_buscar_fecha_ingreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_fecha_ingreso.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscar_fecha_ingreso.Location = new System.Drawing.Point(269, 187);
            this.btn_buscar_fecha_ingreso.Name = "btn_buscar_fecha_ingreso";
            this.btn_buscar_fecha_ingreso.Size = new System.Drawing.Size(79, 25);
            this.btn_buscar_fecha_ingreso.TabIndex = 10;
            this.btn_buscar_fecha_ingreso.Text = "Buscar";
            this.btn_buscar_fecha_ingreso.Click += new System.EventHandler(this.btn_buscar_fecha_ingreso_Click_1);
            this.btn_buscar_fecha_ingreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_buscar_fecha_ingreso_KeyPress);
            // 
            // lb_5
            // 
            this.lb_5.AutoSize = true;
            this.lb_5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_5.ForeColor = System.Drawing.Color.Gray;
            this.lb_5.Location = new System.Drawing.Point(145, 165);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(74, 15);
            this.lb_5.TabIndex = 144;
            this.lb_5.Text = "Fecha hasta:";
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.ForeColor = System.Drawing.Color.Gray;
            this.lb_4.Location = new System.Drawing.Point(22, 165);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(78, 15);
            this.lb_4.TabIndex = 142;
            this.lb_4.Text = "Fecha desde:";
            // 
            // dtp_fecha_ingreso_desde
            // 
            this.dtp_fecha_ingreso_desde.BorderRadius = 2;
            this.dtp_fecha_ingreso_desde.Checked = true;
            this.dtp_fecha_ingreso_desde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha_ingreso_desde.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha_ingreso_desde.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha_ingreso_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_ingreso_desde.Location = new System.Drawing.Point(25, 183);
            this.dtp_fecha_ingreso_desde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha_ingreso_desde.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha_ingreso_desde.Name = "dtp_fecha_ingreso_desde";
            this.dtp_fecha_ingreso_desde.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha_ingreso_desde.TabIndex = 8;
            this.dtp_fecha_ingreso_desde.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            this.dtp_fecha_ingreso_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_fecha_ingreso_desde_KeyPress);
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.ForeColor = System.Drawing.Color.Gray;
            this.lb_3.Location = new System.Drawing.Point(5, 146);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(100, 15);
            this.lb_3.TabIndex = 140;
            this.lb_3.Text = "Fecha de ingreso";
            // 
            // btn_buscar_orden
            // 
            this.btn_buscar_orden.BorderRadius = 5;
            this.btn_buscar_orden.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_orden.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar_orden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buscar_orden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buscar_orden.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_buscar_orden.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_orden.ForeColor = System.Drawing.Color.DimGray;
            this.btn_buscar_orden.Location = new System.Drawing.Point(166, 112);
            this.btn_buscar_orden.Name = "btn_buscar_orden";
            this.btn_buscar_orden.Size = new System.Drawing.Size(79, 25);
            this.btn_buscar_orden.TabIndex = 7;
            this.btn_buscar_orden.Text = "Buscar";
            this.btn_buscar_orden.Click += new System.EventHandler(this.btn_buscar_orden_Click);
            this.btn_buscar_orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_buscar_orden_KeyPress);
            // 
            // tb_numero_de_orden
            // 
            this.tb_numero_de_orden.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_numero_de_orden.BorderRadius = 5;
            this.tb_numero_de_orden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_numero_de_orden.DefaultText = "";
            this.tb_numero_de_orden.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_numero_de_orden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_numero_de_orden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_numero_de_orden.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_numero_de_orden.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_numero_de_orden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_numero_de_orden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_numero_de_orden.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_numero_de_orden.Location = new System.Drawing.Point(8, 110);
            this.tb_numero_de_orden.Name = "tb_numero_de_orden";
            this.tb_numero_de_orden.PasswordChar = '\0';
            this.tb_numero_de_orden.PlaceholderText = "";
            this.tb_numero_de_orden.SelectedText = "";
            this.tb_numero_de_orden.Size = new System.Drawing.Size(152, 27);
            this.tb_numero_de_orden.TabIndex = 6;
            this.tb_numero_de_orden.TextChanged += new System.EventHandler(this.tb_numero_de_orden_TextChanged);
            this.tb_numero_de_orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numero_de_orden_KeyPress);
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.Gray;
            this.lb_2.Location = new System.Drawing.Point(5, 92);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(106, 15);
            this.lb_2.TabIndex = 57;
            this.lb_2.Text = "Numero de orden";
            // 
            // btn_todos
            // 
            this.btn_todos.BorderRadius = 5;
            this.btn_todos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_todos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_todos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_todos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_todos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_todos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_todos.ForeColor = System.Drawing.Color.DimGray;
            this.btn_todos.Location = new System.Drawing.Point(106, 57);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(79, 25);
            this.btn_todos.TabIndex = 5;
            this.btn_todos.Text = "Todos";
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click_1);
            this.btn_todos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_todos_KeyPress);
            // 
            // btn_cancelados
            // 
            this.btn_cancelados.BorderRadius = 5;
            this.btn_cancelados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_cancelados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelados.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cancelados.Location = new System.Drawing.Point(8, 57);
            this.btn_cancelados.Name = "btn_cancelados";
            this.btn_cancelados.Size = new System.Drawing.Size(92, 25);
            this.btn_cancelados.TabIndex = 4;
            this.btn_cancelados.Text = "Cancelados";
            this.btn_cancelados.Click += new System.EventHandler(this.btn_cancelados_Click);
            this.btn_cancelados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_cancelados_KeyPress);
            // 
            // btn_pendientes
            // 
            this.btn_pendientes.BorderRadius = 5;
            this.btn_pendientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_pendientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_pendientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_pendientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_pendientes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_pendientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pendientes.ForeColor = System.Drawing.Color.DimGray;
            this.btn_pendientes.Location = new System.Drawing.Point(106, 26);
            this.btn_pendientes.Name = "btn_pendientes";
            this.btn_pendientes.Size = new System.Drawing.Size(92, 25);
            this.btn_pendientes.TabIndex = 2;
            this.btn_pendientes.Text = "Pendientes";
            this.btn_pendientes.Click += new System.EventHandler(this.btn_pendientes_Click);
            this.btn_pendientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_pendientes_KeyPress);
            // 
            // btn_en_proceso
            // 
            this.btn_en_proceso.BorderRadius = 5;
            this.btn_en_proceso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_en_proceso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_en_proceso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_en_proceso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_en_proceso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_en_proceso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_en_proceso.ForeColor = System.Drawing.Color.DimGray;
            this.btn_en_proceso.Location = new System.Drawing.Point(204, 26);
            this.btn_en_proceso.Name = "btn_en_proceso";
            this.btn_en_proceso.Size = new System.Drawing.Size(92, 25);
            this.btn_en_proceso.TabIndex = 3;
            this.btn_en_proceso.Text = "En proceso";
            this.btn_en_proceso.Click += new System.EventHandler(this.btn_en_proceso_Click);
            this.btn_en_proceso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_en_proceso_KeyPress);
            // 
            // btn_terminados
            // 
            this.btn_terminados.BorderRadius = 5;
            this.btn_terminados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_terminados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_terminados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_terminados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_terminados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.btn_terminados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminados.ForeColor = System.Drawing.Color.DimGray;
            this.btn_terminados.Location = new System.Drawing.Point(8, 26);
            this.btn_terminados.Name = "btn_terminados";
            this.btn_terminados.Size = new System.Drawing.Size(92, 25);
            this.btn_terminados.TabIndex = 1;
            this.btn_terminados.Text = "Terminados";
            this.btn_terminados.Click += new System.EventHandler(this.btn_terminados_Click);
            this.btn_terminados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_terminados_KeyPress);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.Gray;
            this.lb_1.Location = new System.Drawing.Point(5, 8);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(48, 15);
            this.lb_1.TabIndex = 50;
            this.lb_1.Text = "Estados";
            // 
            // frmFiltrosOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(393, 458);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltrosOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros de busqueda";
            this.Load += new System.EventHandler(this.frmFiltrosOrden_Load);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha_egreso_hasta;
        private Guna.UI2.WinForms.Guna2Button btn_buscar_fecha_egreso;
        private System.Windows.Forms.Label lb_8;
        private System.Windows.Forms.Label lb_7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha_egreso_desde;
        private System.Windows.Forms.Label lb_6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha_ingreso_hasta;
        private Guna.UI2.WinForms.Guna2Button btn_buscar_fecha_ingreso;
        private System.Windows.Forms.Label lb_5;
        private System.Windows.Forms.Label lb_4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha_ingreso_desde;
        private System.Windows.Forms.Label lb_3;
        private Guna.UI2.WinForms.Guna2Button btn_buscar_orden;
        private Guna.UI2.WinForms.Guna2TextBox tb_numero_de_orden;
        private System.Windows.Forms.Label lb_2;
        private Guna.UI2.WinForms.Guna2Button btn_todos;
        private Guna.UI2.WinForms.Guna2Button btn_cancelados;
        private Guna.UI2.WinForms.Guna2Button btn_pendientes;
        private Guna.UI2.WinForms.Guna2Button btn_en_proceso;
        private Guna.UI2.WinForms.Guna2Button btn_terminados;
        private System.Windows.Forms.Label lb_1;
        private Guna.UI2.WinForms.Guna2TextBox tb_total_hasta;
        private Guna.UI2.WinForms.Guna2TextBox tb_total_desde;
        private Guna.UI2.WinForms.Guna2Button btn_buscar_total;
        private System.Windows.Forms.Label lb_11;
        private System.Windows.Forms.Label lb_10;
        private System.Windows.Forms.Label lb_9;
    }
}