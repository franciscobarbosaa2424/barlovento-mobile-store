namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.FacturarOrden
{
    partial class frmFacturarOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturarOrden));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.btn_generar_movimiento = new Guna.UI2.WinForms.Guna2Button();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tb_total = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_dispositivo_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_cliente_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_egreso = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_10 = new System.Windows.Forms.Label();
            this.tb_cotizacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.rb_usd = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_uyu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lb_6 = new System.Windows.Forms.Label();
            this.panel_dtgv_propietario = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgv_propietario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_3 = new System.Windows.Forms.Label();
            this.panel_dtgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgv_dispositivo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_2 = new System.Windows.Forms.Label();
            this.tb_precioMateriales = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_9 = new System.Windows.Forms.Label();
            this.tb_precioManoDeObra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_8 = new System.Windows.Forms.Label();
            this.tb_precioPresupuesto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_5 = new System.Windows.Forms.Label();
            this.cb_estado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_7 = new System.Windows.Forms.Label();
            this.tb_falla = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_4 = new System.Windows.Forms.Label();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.panel_arriba.TabIndex = 38;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(132, 15);
            this.lb_titulo.TabIndex = 153;
            this.lb_titulo.Text = "Generar movimiento";
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
            // btn_generar_movimiento
            // 
            this.btn_generar_movimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generar_movimiento.BorderRadius = 5;
            this.btn_generar_movimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_generar_movimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_generar_movimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_generar_movimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_generar_movimiento.FillColor = System.Drawing.Color.Transparent;
            this.btn_generar_movimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_movimiento.ForeColor = System.Drawing.Color.White;
            this.btn_generar_movimiento.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_facturar;
            this.btn_generar_movimiento.Location = new System.Drawing.Point(515, 572);
            this.btn_generar_movimiento.Name = "btn_generar_movimiento";
            this.btn_generar_movimiento.Size = new System.Drawing.Size(46, 44);
            this.btn_generar_movimiento.TabIndex = 6;
            this.Información.SetToolTip(this.btn_generar_movimiento, "Generar Movimiento (F1)");
            this.btn_generar_movimiento.Click += new System.EventHandler(this.btn_facturar_Click);
            this.btn_generar_movimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_facturar_KeyPress);
            // 
            // panel_central
            // 
            this.panel_central.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.tb_total);
            this.panel_central.Controls.Add(this.tb_dispositivo_id);
            this.panel_central.Controls.Add(this.tb_cliente_id);
            this.panel_central.Controls.Add(this.dtp_egreso);
            this.panel_central.Controls.Add(this.lb_10);
            this.panel_central.Controls.Add(this.tb_cotizacion);
            this.panel_central.Controls.Add(this.rb_usd);
            this.panel_central.Controls.Add(this.rb_uyu);
            this.panel_central.Controls.Add(this.lb_6);
            this.panel_central.Controls.Add(this.panel_dtgv_propietario);
            this.panel_central.Controls.Add(this.lb_3);
            this.panel_central.Controls.Add(this.panel_dtgv);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.tb_precioMateriales);
            this.panel_central.Controls.Add(this.lb_9);
            this.panel_central.Controls.Add(this.tb_precioManoDeObra);
            this.panel_central.Controls.Add(this.lb_8);
            this.panel_central.Controls.Add(this.tb_precioPresupuesto);
            this.panel_central.Controls.Add(this.lb_5);
            this.panel_central.Controls.Add(this.cb_estado);
            this.panel_central.Controls.Add(this.lb_7);
            this.panel_central.Controls.Add(this.btn_generar_movimiento);
            this.panel_central.Controls.Add(this.tb_falla);
            this.panel_central.Controls.Add(this.lb_4);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(575, 630);
            this.panel_central.TabIndex = 134;
            // 
            // tb_total
            // 
            this.tb_total.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_total.BorderRadius = 5;
            this.tb_total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_total.DefaultText = "";
            this.tb_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tb_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_total.Enabled = false;
            this.tb_total.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_total.Location = new System.Drawing.Point(198, 433);
            this.tb_total.Name = "tb_total";
            this.tb_total.PasswordChar = '\0';
            this.tb_total.PlaceholderText = "";
            this.tb_total.SelectedText = "";
            this.tb_total.Size = new System.Drawing.Size(169, 27);
            this.tb_total.TabIndex = 214;
            // 
            // tb_dispositivo_id
            // 
            this.tb_dispositivo_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_dispositivo_id.BorderRadius = 5;
            this.tb_dispositivo_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_dispositivo_id.DefaultText = "";
            this.tb_dispositivo_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_dispositivo_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_dispositivo_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_dispositivo_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_dispositivo_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_dispositivo_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_dispositivo_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_dispositivo_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_dispositivo_id.Location = new System.Drawing.Point(241, 261);
            this.tb_dispositivo_id.Name = "tb_dispositivo_id";
            this.tb_dispositivo_id.PasswordChar = '\0';
            this.tb_dispositivo_id.PlaceholderText = "";
            this.tb_dispositivo_id.ReadOnly = true;
            this.tb_dispositivo_id.SelectedText = "";
            this.tb_dispositivo_id.Size = new System.Drawing.Size(24, 27);
            this.tb_dispositivo_id.TabIndex = 212;
            this.tb_dispositivo_id.Visible = false;
            // 
            // tb_cliente_id
            // 
            this.tb_cliente_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_cliente_id.BorderRadius = 5;
            this.tb_cliente_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cliente_id.DefaultText = "";
            this.tb_cliente_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_cliente_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_cliente_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cliente_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cliente_id.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_cliente_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_cliente_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cliente_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_cliente_id.Location = new System.Drawing.Point(211, 261);
            this.tb_cliente_id.Name = "tb_cliente_id";
            this.tb_cliente_id.PasswordChar = '\0';
            this.tb_cliente_id.PlaceholderText = "";
            this.tb_cliente_id.ReadOnly = true;
            this.tb_cliente_id.SelectedText = "";
            this.tb_cliente_id.Size = new System.Drawing.Size(24, 27);
            this.tb_cliente_id.TabIndex = 211;
            this.tb_cliente_id.Visible = false;
            // 
            // dtp_egreso
            // 
            this.dtp_egreso.Checked = true;
            this.dtp_egreso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_egreso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_egreso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_egreso.Location = new System.Drawing.Point(198, 541);
            this.dtp_egreso.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_egreso.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_egreso.Name = "dtp_egreso";
            this.dtp_egreso.Size = new System.Drawing.Size(207, 21);
            this.dtp_egreso.TabIndex = 210;
            this.dtp_egreso.Value = new System.DateTime(2024, 9, 14, 0, 0, 0, 0);
            this.dtp_egreso.Visible = false;
            // 
            // lb_10
            // 
            this.lb_10.AutoSize = true;
            this.lb_10.BackColor = System.Drawing.Color.Transparent;
            this.lb_10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lb_10.ForeColor = System.Drawing.Color.DimGray;
            this.lb_10.Location = new System.Drawing.Point(198, 501);
            this.lb_10.Name = "lb_10";
            this.lb_10.Size = new System.Drawing.Size(75, 19);
            this.lb_10.TabIndex = 209;
            this.lb_10.Text = "Cotización:";
            this.lb_10.Visible = false;
            // 
            // tb_cotizacion
            // 
            this.tb_cotizacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_cotizacion.BorderRadius = 5;
            this.tb_cotizacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_cotizacion.DefaultText = "";
            this.tb_cotizacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_cotizacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_cotizacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cotizacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_cotizacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_cotizacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_cotizacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_cotizacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_cotizacion.Location = new System.Drawing.Point(272, 501);
            this.tb_cotizacion.Name = "tb_cotizacion";
            this.tb_cotizacion.PasswordChar = '\0';
            this.tb_cotizacion.PlaceholderText = "";
            this.tb_cotizacion.SelectedText = "";
            this.tb_cotizacion.Size = new System.Drawing.Size(71, 28);
            this.tb_cotizacion.TabIndex = 208;
            this.tb_cotizacion.Visible = false;
            this.tb_cotizacion.TextChanged += new System.EventHandler(this.tb_cotizacion_TextChanged);
            this.tb_cotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cotizacion_KeyPress);
            // 
            // rb_usd
            // 
            this.rb_usd.AutoSize = true;
            this.rb_usd.BackColor = System.Drawing.Color.Transparent;
            this.rb_usd.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rb_usd.CheckedState.BorderThickness = 0;
            this.rb_usd.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.rb_usd.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_usd.CheckedState.InnerOffset = -4;
            this.rb_usd.ForeColor = System.Drawing.Color.DimGray;
            this.rb_usd.Location = new System.Drawing.Point(272, 478);
            this.rb_usd.Name = "rb_usd";
            this.rb_usd.Size = new System.Drawing.Size(48, 17);
            this.rb_usd.TabIndex = 207;
            this.rb_usd.Text = "USD";
            this.rb_usd.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_usd.UncheckedState.BorderThickness = 2;
            this.rb_usd.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_usd.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_usd.UseVisualStyleBackColor = false;
            this.rb_usd.CheckedChanged += new System.EventHandler(this.rb_usd_CheckedChanged);
            // 
            // rb_uyu
            // 
            this.rb_uyu.AutoSize = true;
            this.rb_uyu.BackColor = System.Drawing.Color.Transparent;
            this.rb_uyu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rb_uyu.CheckedState.BorderThickness = 0;
            this.rb_uyu.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.rb_uyu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_uyu.CheckedState.InnerOffset = -4;
            this.rb_uyu.ForeColor = System.Drawing.Color.DimGray;
            this.rb_uyu.Location = new System.Drawing.Point(198, 478);
            this.rb_uyu.Name = "rb_uyu";
            this.rb_uyu.Size = new System.Drawing.Size(48, 17);
            this.rb_uyu.TabIndex = 206;
            this.rb_uyu.Text = "UYU";
            this.rb_uyu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_uyu.UncheckedState.BorderThickness = 2;
            this.rb_uyu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_uyu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_uyu.UseVisualStyleBackColor = false;
            this.rb_uyu.CheckedChanged += new System.EventHandler(this.rb_uyu_CheckedChanged);
            // 
            // lb_6
            // 
            this.lb_6.AutoSize = true;
            this.lb_6.BackColor = System.Drawing.Color.Transparent;
            this.lb_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_6.ForeColor = System.Drawing.Color.DimGray;
            this.lb_6.Location = new System.Drawing.Point(194, 409);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(45, 21);
            this.lb_6.TabIndex = 205;
            this.lb_6.Text = "Total:";
            // 
            // panel_dtgv_propietario
            // 
            this.panel_dtgv_propietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv_propietario.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv_propietario.Controls.Add(this.dtgv_propietario);
            this.panel_dtgv_propietario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv_propietario.Location = new System.Drawing.Point(11, 156);
            this.panel_dtgv_propietario.Name = "panel_dtgv_propietario";
            this.panel_dtgv_propietario.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv_propietario.ShadowShift = 3;
            this.panel_dtgv_propietario.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv_propietario.Size = new System.Drawing.Size(550, 86);
            this.panel_dtgv_propietario.TabIndex = 203;
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
            this.dtgv_propietario.Size = new System.Drawing.Size(538, 76);
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
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.ForeColor = System.Drawing.Color.DimGray;
            this.lb_3.Location = new System.Drawing.Point(10, 128);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(126, 25);
            this.lb_3.TabIndex = 202;
            this.lb_3.Text = "Propietario";
            // 
            // panel_dtgv
            // 
            this.panel_dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv.Controls.Add(this.dtgv_dispositivo);
            this.panel_dtgv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv.Location = new System.Drawing.Point(11, 41);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv.ShadowShift = 3;
            this.panel_dtgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv.Size = new System.Drawing.Size(550, 86);
            this.panel_dtgv.TabIndex = 201;
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
            this.dtgv_dispositivo.Size = new System.Drawing.Size(538, 76);
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
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_2.Location = new System.Drawing.Point(10, 13);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(122, 25);
            this.lb_2.TabIndex = 200;
            this.lb_2.Text = "Dispositivo";
            // 
            // tb_precioMateriales
            // 
            this.tb_precioMateriales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_precioMateriales.BorderRadius = 5;
            this.tb_precioMateriales.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_precioMateriales.DefaultText = "";
            this.tb_precioMateriales.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_precioMateriales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_precioMateriales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tb_precioMateriales.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_precioMateriales.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_precioMateriales.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_precioMateriales.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_precioMateriales.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_precioMateriales.Location = new System.Drawing.Point(11, 541);
            this.tb_precioMateriales.Name = "tb_precioMateriales";
            this.tb_precioMateriales.PasswordChar = '\0';
            this.tb_precioMateriales.PlaceholderText = "";
            this.tb_precioMateriales.SelectedText = "";
            this.tb_precioMateriales.Size = new System.Drawing.Size(169, 27);
            this.tb_precioMateriales.TabIndex = 4;
            this.tb_precioMateriales.TextChanged += new System.EventHandler(this.tb_precioMateriales_TextChanged);
            this.tb_precioMateriales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precioMateriales_KeyPress);
            // 
            // lb_9
            // 
            this.lb_9.AutoSize = true;
            this.lb_9.BackColor = System.Drawing.Color.Transparent;
            this.lb_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_9.ForeColor = System.Drawing.Color.DimGray;
            this.lb_9.Location = new System.Drawing.Point(7, 517);
            this.lb_9.Name = "lb_9";
            this.lb_9.Size = new System.Drawing.Size(85, 21);
            this.lb_9.TabIndex = 199;
            this.lb_9.Text = "Materiales:";
            // 
            // tb_precioManoDeObra
            // 
            this.tb_precioManoDeObra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_precioManoDeObra.BorderRadius = 5;
            this.tb_precioManoDeObra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_precioManoDeObra.DefaultText = "";
            this.tb_precioManoDeObra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_precioManoDeObra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_precioManoDeObra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tb_precioManoDeObra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_precioManoDeObra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_precioManoDeObra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_precioManoDeObra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_precioManoDeObra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_precioManoDeObra.Location = new System.Drawing.Point(11, 487);
            this.tb_precioManoDeObra.Name = "tb_precioManoDeObra";
            this.tb_precioManoDeObra.PasswordChar = '\0';
            this.tb_precioManoDeObra.PlaceholderText = "";
            this.tb_precioManoDeObra.SelectedText = "";
            this.tb_precioManoDeObra.Size = new System.Drawing.Size(169, 27);
            this.tb_precioManoDeObra.TabIndex = 3;
            this.tb_precioManoDeObra.TextChanged += new System.EventHandler(this.tb_precioManoDeObra_TextChanged);
            this.tb_precioManoDeObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precioManoDeObra_KeyPress);
            // 
            // lb_8
            // 
            this.lb_8.AutoSize = true;
            this.lb_8.BackColor = System.Drawing.Color.Transparent;
            this.lb_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_8.ForeColor = System.Drawing.Color.DimGray;
            this.lb_8.Location = new System.Drawing.Point(7, 463);
            this.lb_8.Name = "lb_8";
            this.lb_8.Size = new System.Drawing.Size(113, 21);
            this.lb_8.TabIndex = 197;
            this.lb_8.Text = "Mano de Obra:";
            // 
            // tb_precioPresupuesto
            // 
            this.tb_precioPresupuesto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_precioPresupuesto.BorderRadius = 5;
            this.tb_precioPresupuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_precioPresupuesto.DefaultText = "";
            this.tb_precioPresupuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_precioPresupuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_precioPresupuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_precioPresupuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_precioPresupuesto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_precioPresupuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_precioPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_precioPresupuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_precioPresupuesto.Location = new System.Drawing.Point(11, 433);
            this.tb_precioPresupuesto.Name = "tb_precioPresupuesto";
            this.tb_precioPresupuesto.PasswordChar = '\0';
            this.tb_precioPresupuesto.PlaceholderText = "";
            this.tb_precioPresupuesto.SelectedText = "";
            this.tb_precioPresupuesto.Size = new System.Drawing.Size(169, 27);
            this.tb_precioPresupuesto.TabIndex = 2;
            this.tb_precioPresupuesto.TextChanged += new System.EventHandler(this.tb_precioPresupuesto_TextChanged);
            this.tb_precioPresupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precioPresupuesto_KeyPress);
            // 
            // lb_5
            // 
            this.lb_5.AutoSize = true;
            this.lb_5.BackColor = System.Drawing.Color.Transparent;
            this.lb_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_5.ForeColor = System.Drawing.Color.DimGray;
            this.lb_5.Location = new System.Drawing.Point(7, 409);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(99, 21);
            this.lb_5.TabIndex = 195;
            this.lb_5.Text = "Presupuesto:";
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
            "Cancelado"});
            this.cb_estado.Location = new System.Drawing.Point(385, 433);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(169, 36);
            this.cb_estado.TabIndex = 5;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            this.cb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_estado_KeyPress);
            // 
            // lb_7
            // 
            this.lb_7.AutoSize = true;
            this.lb_7.BackColor = System.Drawing.Color.Transparent;
            this.lb_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_7.ForeColor = System.Drawing.Color.DimGray;
            this.lb_7.Location = new System.Drawing.Point(377, 409);
            this.lb_7.Name = "lb_7";
            this.lb_7.Size = new System.Drawing.Size(59, 21);
            this.lb_7.TabIndex = 191;
            this.lb_7.Text = "Estado:";
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
            // dc_panel_arriba
            // 
            this.dc_panel_arriba.DockIndicatorColor = System.Drawing.Color.Black;
            this.dc_panel_arriba.DockIndicatorTransparencyValue = 0D;
            this.dc_panel_arriba.DragEndTransparencyValue = 0.1D;
            this.dc_panel_arriba.DragStartTransparencyValue = 0.1D;
            this.dc_panel_arriba.TargetControl = this.panel_arriba;
            this.dc_panel_arriba.TransparentWhileDrag = false;
            // 
            // frmFacturarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(599, 683);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar movimiento";
            this.Load += new System.EventHandler(this.frmFacturarOrden_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFacturarOrden_KeyUp);
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
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private System.Windows.Forms.ToolTip Información;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private System.Windows.Forms.Label lb_6;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv_propietario;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_propietario;
        private System.Windows.Forms.Label lb_3;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_dispositivo;
        private System.Windows.Forms.Label lb_2;
        private Guna.UI2.WinForms.Guna2TextBox tb_precioMateriales;
        private System.Windows.Forms.Label lb_9;
        private Guna.UI2.WinForms.Guna2TextBox tb_precioManoDeObra;
        private System.Windows.Forms.Label lb_8;
        private Guna.UI2.WinForms.Guna2TextBox tb_precioPresupuesto;
        private System.Windows.Forms.Label lb_5;
        private Guna.UI2.WinForms.Guna2ComboBox cb_estado;
        private System.Windows.Forms.Label lb_7;
        private Guna.UI2.WinForms.Guna2Button btn_generar_movimiento;
        private Guna.UI2.WinForms.Guna2TextBox tb_falla;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_10;
        private Guna.UI2.WinForms.Guna2TextBox tb_cotizacion;
        private Guna.UI2.WinForms.Guna2RadioButton rb_usd;
        private Guna.UI2.WinForms.Guna2RadioButton rb_uyu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_egreso;
        private Guna.UI2.WinForms.Guna2TextBox tb_dispositivo_id;
        private Guna.UI2.WinForms.Guna2TextBox tb_cliente_id;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2TextBox tb_total;
    }
}