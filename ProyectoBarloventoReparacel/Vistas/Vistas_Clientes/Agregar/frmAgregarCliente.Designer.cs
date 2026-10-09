namespace ProyectoBarloventoReparacel.Vistas.Vistas_Clientes.Agregar
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lb_extranjero = new System.Windows.Forms.Label();
            this.extranjero = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_seleccionar = new Guna.UI2.WinForms.Guna2Button();
            this.tb_1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_localidad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_departamento = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_contacto_1 = new System.Windows.Forms.Label();
            this.cb_departamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_localidad = new System.Windows.Forms.Label();
            this.tb_contacto_2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.tb_contacto_1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_contacto_2 = new System.Windows.Forms.Label();
            this.tb_correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_correo = new System.Windows.Forms.Label();
            this.tb_2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_persona = new Guna.UI2.WinForms.Guna2Button();
            this.btn_empresa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.informacion = new System.Windows.Forms.ToolTip(this.components);
            this.panel_arriba.SuspendLayout();
            this.panel_central.SuspendLayout();
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
            this.panel_arriba.Size = new System.Drawing.Size(423, 35);
            this.panel_arriba.TabIndex = 7;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(7, 11);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(99, 15);
            this.lb_titulo.TabIndex = 154;
            this.lb_titulo.Text = "Agregar cliente";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(315, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 1;
            this.cntb_minimizar_formulario.TabStop = false;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(366, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            this.cntb_cerrar_formulario.TabStop = false;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.lb_extranjero);
            this.panel_central.Controls.Add(this.extranjero);
            this.panel_central.Controls.Add(this.btn_seleccionar);
            this.panel_central.Controls.Add(this.tb_1);
            this.panel_central.Controls.Add(this.cb_localidad);
            this.panel_central.Controls.Add(this.lb_departamento);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.lb_contacto_1);
            this.panel_central.Controls.Add(this.cb_departamento);
            this.panel_central.Controls.Add(this.lb_localidad);
            this.panel_central.Controls.Add(this.tb_contacto_2);
            this.panel_central.Controls.Add(this.lb_1);
            this.panel_central.Controls.Add(this.tb_contacto_1);
            this.panel_central.Controls.Add(this.lb_contacto_2);
            this.panel_central.Controls.Add(this.tb_correo);
            this.panel_central.Controls.Add(this.lb_correo);
            this.panel_central.Controls.Add(this.tb_2);
            this.panel_central.Controls.Add(this.btn_persona);
            this.panel_central.Controls.Add(this.btn_empresa);
            this.panel_central.Controls.Add(this.btn_agregar);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(399, 424);
            this.panel_central.TabIndex = 49;
            // 
            // lb_extranjero
            // 
            this.lb_extranjero.AutoSize = true;
            this.lb_extranjero.BackColor = System.Drawing.Color.Transparent;
            this.lb_extranjero.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lb_extranjero.ForeColor = System.Drawing.Color.DimGray;
            this.lb_extranjero.Location = new System.Drawing.Point(246, 15);
            this.lb_extranjero.Name = "lb_extranjero";
            this.lb_extranjero.Size = new System.Drawing.Size(103, 13);
            this.lb_extranjero.TabIndex = 207;
            this.lb_extranjero.Text = "Número Extranjero";
            // 
            // extranjero
            // 
            this.extranjero.AutoSize = true;
            this.extranjero.BackColor = System.Drawing.Color.Transparent;
            this.extranjero.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.extranjero.CheckedState.BorderRadius = 0;
            this.extranjero.CheckedState.BorderThickness = 0;
            this.extranjero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.extranjero.Location = new System.Drawing.Point(355, 15);
            this.extranjero.Name = "extranjero";
            this.extranjero.Size = new System.Drawing.Size(15, 14);
            this.extranjero.TabIndex = 206;
            this.extranjero.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.extranjero.UncheckedState.BorderRadius = 0;
            this.extranjero.UncheckedState.BorderThickness = 0;
            this.extranjero.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.extranjero.UseVisualStyleBackColor = false;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BorderRadius = 5;
            this.btn_seleccionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_seleccionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_seleccionar.FillColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_seleccionar.ForeColor = System.Drawing.Color.White;
            this.btn_seleccionar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_seleccionar;
            this.btn_seleccionar.Location = new System.Drawing.Point(298, 372);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(40, 40);
            this.btn_seleccionar.TabIndex = 205;
            this.informacion.SetToolTip(this.btn_seleccionar, "Seleccionar cliente");
            this.btn_seleccionar.Visible = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // tb_1
            // 
            this.tb_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_1.BorderRadius = 5;
            this.tb_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_1.DefaultText = "";
            this.tb_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_1.Location = new System.Drawing.Point(18, 65);
            this.tb_1.Name = "tb_1";
            this.tb_1.PasswordChar = '\0';
            this.tb_1.PlaceholderText = "";
            this.tb_1.SelectedText = "";
            this.tb_1.Size = new System.Drawing.Size(169, 27);
            this.tb_1.TabIndex = 1;
            this.tb_1.TextChanged += new System.EventHandler(this.tb_1_TextChanged);
            this.tb_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_1_KeyPress);
            // 
            // cb_localidad
            // 
            this.cb_localidad.BackColor = System.Drawing.Color.Transparent;
            this.cb_localidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cb_localidad.BorderRadius = 5;
            this.cb_localidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_localidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.cb_localidad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_localidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_localidad.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cb_localidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_localidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_localidad.ItemHeight = 30;
            this.cb_localidad.Location = new System.Drawing.Point(215, 228);
            this.cb_localidad.Name = "cb_localidad";
            this.cb_localidad.Size = new System.Drawing.Size(169, 36);
            this.cb_localidad.TabIndex = 6;
            this.cb_localidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_localidad_KeyPress);
            // 
            // lb_departamento
            // 
            this.lb_departamento.AutoSize = true;
            this.lb_departamento.BackColor = System.Drawing.Color.Transparent;
            this.lb_departamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_departamento.ForeColor = System.Drawing.Color.DimGray;
            this.lb_departamento.Location = new System.Drawing.Point(14, 203);
            this.lb_departamento.Name = "lb_departamento";
            this.lb_departamento.Size = new System.Drawing.Size(113, 21);
            this.lb_departamento.TabIndex = 73;
            this.lb_departamento.Text = "Departamento:";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_2.Location = new System.Drawing.Point(211, 41);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(71, 21);
            this.lb_2.TabIndex = 71;
            this.lb_2.Text = "Ninguno";
            // 
            // lb_contacto_1
            // 
            this.lb_contacto_1.AutoSize = true;
            this.lb_contacto_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_contacto_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contacto_1.ForeColor = System.Drawing.Color.DimGray;
            this.lb_contacto_1.Location = new System.Drawing.Point(14, 123);
            this.lb_contacto_1.Name = "lb_contacto_1";
            this.lb_contacto_1.Size = new System.Drawing.Size(75, 21);
            this.lb_contacto_1.TabIndex = 74;
            this.lb_contacto_1.Text = "Contacto:";
            // 
            // cb_departamento
            // 
            this.cb_departamento.BackColor = System.Drawing.Color.Transparent;
            this.cb_departamento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cb_departamento.BorderRadius = 5;
            this.cb_departamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_departamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.cb_departamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_departamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_departamento.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_departamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_departamento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_departamento.ItemHeight = 30;
            this.cb_departamento.Location = new System.Drawing.Point(18, 227);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(169, 36);
            this.cb_departamento.TabIndex = 5;
            this.cb_departamento.SelectedIndexChanged += new System.EventHandler(this.cb_departamento_SelectedIndexChanged);
            this.cb_departamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_departamento_KeyPress);
            // 
            // lb_localidad
            // 
            this.lb_localidad.AutoSize = true;
            this.lb_localidad.BackColor = System.Drawing.Color.Transparent;
            this.lb_localidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_localidad.ForeColor = System.Drawing.Color.DimGray;
            this.lb_localidad.Location = new System.Drawing.Point(211, 204);
            this.lb_localidad.Name = "lb_localidad";
            this.lb_localidad.Size = new System.Drawing.Size(79, 21);
            this.lb_localidad.TabIndex = 72;
            this.lb_localidad.Text = "Localidad:";
            // 
            // tb_contacto_2
            // 
            this.tb_contacto_2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_contacto_2.BorderRadius = 5;
            this.tb_contacto_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contacto_2.DefaultText = "";
            this.tb_contacto_2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_contacto_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_contacto_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contacto_2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contacto_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_contacto_2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contacto_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_contacto_2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contacto_2.Location = new System.Drawing.Point(215, 147);
            this.tb_contacto_2.Name = "tb_contacto_2";
            this.tb_contacto_2.PasswordChar = '\0';
            this.tb_contacto_2.PlaceholderText = "";
            this.tb_contacto_2.SelectedText = "";
            this.tb_contacto_2.Size = new System.Drawing.Size(169, 27);
            this.tb_contacto_2.TabIndex = 4;
            this.tb_contacto_2.TextChanged += new System.EventHandler(this.tb_contacto_2_TextChanged);
            this.tb_contacto_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contacto_2_KeyPress);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.DimGray;
            this.lb_1.Location = new System.Drawing.Point(14, 41);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(71, 21);
            this.lb_1.TabIndex = 70;
            this.lb_1.Text = "Ninguno";
            // 
            // tb_contacto_1
            // 
            this.tb_contacto_1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_contacto_1.BorderRadius = 5;
            this.tb_contacto_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contacto_1.DefaultText = "";
            this.tb_contacto_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_contacto_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_contacto_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contacto_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contacto_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_contacto_1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contacto_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_contacto_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contacto_1.Location = new System.Drawing.Point(18, 147);
            this.tb_contacto_1.Name = "tb_contacto_1";
            this.tb_contacto_1.PasswordChar = '\0';
            this.tb_contacto_1.PlaceholderText = "";
            this.tb_contacto_1.SelectedText = "";
            this.tb_contacto_1.Size = new System.Drawing.Size(169, 27);
            this.tb_contacto_1.TabIndex = 3;
            this.tb_contacto_1.TextChanged += new System.EventHandler(this.tb_contacto_1_TextChanged);
            this.tb_contacto_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contacto_1_KeyPress);
            // 
            // lb_contacto_2
            // 
            this.lb_contacto_2.AutoSize = true;
            this.lb_contacto_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_contacto_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contacto_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_contacto_2.Location = new System.Drawing.Point(211, 123);
            this.lb_contacto_2.Name = "lb_contacto_2";
            this.lb_contacto_2.Size = new System.Drawing.Size(138, 21);
            this.lb_contacto_2.TabIndex = 75;
            this.lb_contacto_2.Text = "Segundo contacto:";
            // 
            // tb_correo
            // 
            this.tb_correo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_correo.BorderRadius = 5;
            this.tb_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_correo.DefaultText = "";
            this.tb_correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_correo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_correo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_correo.Location = new System.Drawing.Point(18, 309);
            this.tb_correo.Name = "tb_correo";
            this.tb_correo.PasswordChar = '\0';
            this.tb_correo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_correo.PlaceholderText = "ejemplo@dominio.com";
            this.tb_correo.SelectedText = "";
            this.tb_correo.Size = new System.Drawing.Size(169, 27);
            this.tb_correo.TabIndex = 7;
            this.tb_correo.TextChanged += new System.EventHandler(this.tb_correo_TextChanged);
            this.tb_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_correo_KeyPress);
            // 
            // lb_correo
            // 
            this.lb_correo.AutoSize = true;
            this.lb_correo.BackColor = System.Drawing.Color.Transparent;
            this.lb_correo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_correo.Location = new System.Drawing.Point(14, 285);
            this.lb_correo.Name = "lb_correo";
            this.lb_correo.Size = new System.Drawing.Size(61, 21);
            this.lb_correo.TabIndex = 76;
            this.lb_correo.Text = "Correo:";
            // 
            // tb_2
            // 
            this.tb_2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_2.BorderRadius = 5;
            this.tb_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_2.DefaultText = "";
            this.tb_2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_2.Location = new System.Drawing.Point(215, 65);
            this.tb_2.Name = "tb_2";
            this.tb_2.PasswordChar = '\0';
            this.tb_2.PlaceholderText = "";
            this.tb_2.SelectedText = "";
            this.tb_2.Size = new System.Drawing.Size(169, 27);
            this.tb_2.TabIndex = 2;
            this.tb_2.TextChanged += new System.EventHandler(this.tb_2_TextChanged);
            this.tb_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_2_KeyPress);
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
            this.btn_persona.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_persona.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_persona.ForeColor = System.Drawing.Color.Gray;
            this.btn_persona.Location = new System.Drawing.Point(101, 3);
            this.btn_persona.Name = "btn_persona";
            this.btn_persona.Size = new System.Drawing.Size(92, 25);
            this.btn_persona.TabIndex = 48;
            this.btn_persona.Text = "Persona";
            this.informacion.SetToolTip(this.btn_persona, "Cliente de tipo Persona");
            this.btn_persona.Click += new System.EventHandler(this.btn_persona_Click);
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
            this.btn_empresa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_empresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_empresa.ForeColor = System.Drawing.Color.Gray;
            this.btn_empresa.Location = new System.Drawing.Point(3, 3);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(92, 25);
            this.btn_empresa.TabIndex = 47;
            this.btn_empresa.Text = "Empresa";
            this.informacion.SetToolTip(this.btn_empresa, "Cliente de tipo Empresa");
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BorderRadius = 5;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.Transparent;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_agregar;
            this.btn_agregar.Location = new System.Drawing.Point(344, 372);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(40, 40);
            this.btn_agregar.TabIndex = 8;
            this.informacion.SetToolTip(this.btn_agregar, "Agregar cliente (F1)");
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            this.btn_agregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_agregar_KeyPress);
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
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(423, 477);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmAgregarCliente_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2Button btn_persona;
        private Guna.UI2.WinForms.Guna2Button btn_empresa;
        private Guna.UI2.WinForms.Guna2TextBox tb_1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_localidad;
        private System.Windows.Forms.Label lb_departamento;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_contacto_1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_departamento;
        private System.Windows.Forms.Label lb_localidad;
        private Guna.UI2.WinForms.Guna2TextBox tb_contacto_2;
        private System.Windows.Forms.Label lb_1;
        private Guna.UI2.WinForms.Guna2TextBox tb_contacto_1;
        private System.Windows.Forms.Label lb_contacto_2;
        private Guna.UI2.WinForms.Guna2TextBox tb_correo;
        private System.Windows.Forms.Label lb_correo;
        private Guna.UI2.WinForms.Guna2TextBox tb_2;
        private System.Windows.Forms.ToolTip informacion;
        private Guna.UI2.WinForms.Guna2Button btn_seleccionar;
        private Guna.UI2.WinForms.Guna2CheckBox extranjero;
        private System.Windows.Forms.Label lb_extranjero;
    }
}