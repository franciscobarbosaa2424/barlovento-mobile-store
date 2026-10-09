namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Modificar
{
    partial class frmModificarDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarDispositivo));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tb_marca = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_mostrar_contraseña = new Guna.UI2.WinForms.Guna2Button();
            this.btn_patron = new Guna.UI2.WinForms.Guna2Button();
            this.tb_contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_5 = new System.Windows.Forms.Label();
            this.lb_7 = new System.Windows.Forms.Label();
            this.lb_6 = new System.Windows.Forms.Label();
            this.lb_4 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.tb_tipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_modelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_numero_de_serie = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_observacion = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_dtgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgv_propietario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_modificar = new Guna.UI2.WinForms.Guna2Button();
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_arriba.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.panel_dtgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_propietario)).BeginInit();
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
            this.panel_arriba.Size = new System.Drawing.Size(612, 35);
            this.panel_arriba.TabIndex = 9;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(133, 15);
            this.lb_titulo.TabIndex = 154;
            this.lb_titulo.Text = "Modificar dispositivo";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(504, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 1;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(555, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.tb_marca);
            this.panel_central.Controls.Add(this.btn_mostrar_contraseña);
            this.panel_central.Controls.Add(this.btn_patron);
            this.panel_central.Controls.Add(this.tb_contraseña);
            this.panel_central.Controls.Add(this.lb_5);
            this.panel_central.Controls.Add(this.lb_7);
            this.panel_central.Controls.Add(this.lb_6);
            this.panel_central.Controls.Add(this.lb_4);
            this.panel_central.Controls.Add(this.lb_3);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.tb_tipo);
            this.panel_central.Controls.Add(this.tb_modelo);
            this.panel_central.Controls.Add(this.tb_numero_de_serie);
            this.panel_central.Controls.Add(this.tb_observacion);
            this.panel_central.Controls.Add(this.panel_dtgv);
            this.panel_central.Controls.Add(this.lb_1);
            this.panel_central.Controls.Add(this.btn_modificar);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(588, 505);
            this.panel_central.TabIndex = 91;
            // 
            // tb_marca
            // 
            this.tb_marca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_marca.BorderRadius = 5;
            this.tb_marca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_marca.DefaultText = "";
            this.tb_marca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_marca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_marca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_marca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_marca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_marca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_marca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_marca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_marca.Location = new System.Drawing.Point(17, 352);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.PasswordChar = '\0';
            this.tb_marca.PlaceholderText = "";
            this.tb_marca.SelectedText = "";
            this.tb_marca.Size = new System.Drawing.Size(169, 27);
            this.tb_marca.TabIndex = 6;
            this.tb_marca.TextChanged += new System.EventHandler(this.tb_marca_TextChanged);
            this.tb_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_marca_KeyPress);
            // 
            // btn_mostrar_contraseña
            // 
            this.btn_mostrar_contraseña.BorderRadius = 5;
            this.btn_mostrar_contraseña.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_mostrar_contraseña.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_mostrar_contraseña.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_mostrar_contraseña.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_mostrar_contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_mostrar_contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_mostrar_contraseña.FillColor = System.Drawing.Color.Transparent;
            this.btn_mostrar_contraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_mostrar_contraseña.ForeColor = System.Drawing.Color.White;
            this.btn_mostrar_contraseña.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_mostrar_contraseña.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_contraseña;
            this.btn_mostrar_contraseña.Location = new System.Drawing.Point(542, 283);
            this.btn_mostrar_contraseña.Name = "btn_mostrar_contraseña";
            this.btn_mostrar_contraseña.Size = new System.Drawing.Size(25, 25);
            this.btn_mostrar_contraseña.TabIndex = 209;
            this.btn_mostrar_contraseña.Click += new System.EventHandler(this.btn_mostrar_contraseña_Click);
            // 
            // btn_patron
            // 
            this.btn_patron.BorderRadius = 5;
            this.btn_patron.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btn_patron.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_patron.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_patron.DisabledState.ForeColor = System.Drawing.Color.White;
            this.btn_patron.FillColor = System.Drawing.Color.Transparent;
            this.btn_patron.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_patron.ForeColor = System.Drawing.Color.White;
            this.btn_patron.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_patron;
            this.btn_patron.Location = new System.Drawing.Point(533, 406);
            this.btn_patron.Name = "btn_patron";
            this.btn_patron.Size = new System.Drawing.Size(40, 40);
            this.btn_patron.TabIndex = 208;
            this.Información.SetToolTip(this.btn_patron, "Agregar patrón (F2)");
            this.btn_patron.Click += new System.EventHandler(this.btn_patron_Click);
            this.btn_patron.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_patron_KeyPress);
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_contraseña.BorderRadius = 5;
            this.tb_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contraseña.DefaultText = "";
            this.tb_contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contraseña.Location = new System.Drawing.Point(404, 283);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '●';
            this.tb_contraseña.PlaceholderText = "";
            this.tb_contraseña.SelectedText = "";
            this.tb_contraseña.Size = new System.Drawing.Size(132, 27);
            this.tb_contraseña.TabIndex = 5;
            this.tb_contraseña.UseSystemPasswordChar = true;
            this.tb_contraseña.TextChanged += new System.EventHandler(this.tb_contraseña_TextChanged);
            this.tb_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contraseña_KeyPress);
            // 
            // lb_5
            // 
            this.lb_5.AutoSize = true;
            this.lb_5.BackColor = System.Drawing.Color.Transparent;
            this.lb_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_5.ForeColor = System.Drawing.Color.DimGray;
            this.lb_5.Location = new System.Drawing.Point(400, 259);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(92, 21);
            this.lb_5.TabIndex = 202;
            this.lb_5.Text = "Contraseña:";
            // 
            // lb_7
            // 
            this.lb_7.AutoSize = true;
            this.lb_7.BackColor = System.Drawing.Color.Transparent;
            this.lb_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_7.ForeColor = System.Drawing.Color.DimGray;
            this.lb_7.Location = new System.Drawing.Point(213, 328);
            this.lb_7.Name = "lb_7";
            this.lb_7.Size = new System.Drawing.Size(66, 21);
            this.lb_7.TabIndex = 196;
            this.lb_7.Text = "Modelo:";
            // 
            // lb_6
            // 
            this.lb_6.AutoSize = true;
            this.lb_6.BackColor = System.Drawing.Color.Transparent;
            this.lb_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_6.ForeColor = System.Drawing.Color.DimGray;
            this.lb_6.Location = new System.Drawing.Point(13, 328);
            this.lb_6.Name = "lb_6";
            this.lb_6.Size = new System.Drawing.Size(56, 21);
            this.lb_6.TabIndex = 195;
            this.lb_6.Text = "Marca:";
            // 
            // lb_4
            // 
            this.lb_4.AutoSize = true;
            this.lb_4.BackColor = System.Drawing.Color.Transparent;
            this.lb_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.ForeColor = System.Drawing.Color.DimGray;
            this.lb_4.Location = new System.Drawing.Point(213, 259);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(129, 21);
            this.lb_4.TabIndex = 197;
            this.lb_4.Text = "Numero de serie:";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.BackColor = System.Drawing.Color.Transparent;
            this.lb_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.ForeColor = System.Drawing.Color.DimGray;
            this.lb_3.Location = new System.Drawing.Point(13, 259);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(43, 21);
            this.lb_3.TabIndex = 194;
            this.lb_3.Text = "Tipo:";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_2.Location = new System.Drawing.Point(13, 131);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(100, 21);
            this.lb_2.TabIndex = 198;
            this.lb_2.Text = "Observacion:";
            // 
            // tb_tipo
            // 
            this.tb_tipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_tipo.BorderRadius = 5;
            this.tb_tipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tipo.DefaultText = "";
            this.tb_tipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_tipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_tipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_tipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_tipo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_tipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_tipo.Location = new System.Drawing.Point(17, 283);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.PasswordChar = '\0';
            this.tb_tipo.PlaceholderText = "";
            this.tb_tipo.SelectedText = "";
            this.tb_tipo.Size = new System.Drawing.Size(169, 27);
            this.tb_tipo.TabIndex = 3;
            this.tb_tipo.TextChanged += new System.EventHandler(this.tb_tipo_TextChanged);
            this.tb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tipo_KeyPress);
            // 
            // tb_modelo
            // 
            this.tb_modelo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_modelo.BorderRadius = 5;
            this.tb_modelo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_modelo.DefaultText = "";
            this.tb_modelo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_modelo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_modelo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_modelo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_modelo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_modelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_modelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_modelo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_modelo.Location = new System.Drawing.Point(217, 352);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.PasswordChar = '\0';
            this.tb_modelo.PlaceholderText = "";
            this.tb_modelo.SelectedText = "";
            this.tb_modelo.Size = new System.Drawing.Size(169, 27);
            this.tb_modelo.TabIndex = 7;
            this.tb_modelo.TextChanged += new System.EventHandler(this.tb_modelo_TextChanged);
            this.tb_modelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_modelo_KeyPress);
            // 
            // tb_numero_de_serie
            // 
            this.tb_numero_de_serie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_numero_de_serie.BorderRadius = 5;
            this.tb_numero_de_serie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_numero_de_serie.DefaultText = "";
            this.tb_numero_de_serie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_numero_de_serie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_numero_de_serie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_numero_de_serie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_numero_de_serie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_numero_de_serie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_numero_de_serie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_numero_de_serie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_numero_de_serie.Location = new System.Drawing.Point(217, 283);
            this.tb_numero_de_serie.Name = "tb_numero_de_serie";
            this.tb_numero_de_serie.PasswordChar = '\0';
            this.tb_numero_de_serie.PlaceholderText = "";
            this.tb_numero_de_serie.SelectedText = "";
            this.tb_numero_de_serie.Size = new System.Drawing.Size(169, 27);
            this.tb_numero_de_serie.TabIndex = 4;
            this.tb_numero_de_serie.TextChanged += new System.EventHandler(this.tb_numero_de_serie_TextChanged);
            this.tb_numero_de_serie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numero_de_serie_KeyPress);
            // 
            // tb_observacion
            // 
            this.tb_observacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_observacion.BorderRadius = 3;
            this.tb_observacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_observacion.DefaultText = "";
            this.tb_observacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_observacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_observacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_observacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_observacion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_observacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_observacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_observacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_observacion.Location = new System.Drawing.Point(17, 155);
            this.tb_observacion.Multiline = true;
            this.tb_observacion.Name = "tb_observacion";
            this.tb_observacion.PasswordChar = '\0';
            this.tb_observacion.PlaceholderText = "";
            this.tb_observacion.SelectedText = "";
            this.tb_observacion.Size = new System.Drawing.Size(418, 83);
            this.tb_observacion.TabIndex = 1;
            this.tb_observacion.TextChanged += new System.EventHandler(this.tb_observacion_TextChanged);
            this.tb_observacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_observacion_KeyPress);
            // 
            // panel_dtgv
            // 
            this.panel_dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv.Controls.Add(this.dtgv_propietario);
            this.panel_dtgv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv.Location = new System.Drawing.Point(13, 37);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv.ShadowShift = 3;
            this.panel_dtgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv.Size = new System.Drawing.Size(552, 80);
            this.panel_dtgv.TabIndex = 187;
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
            this.dtgv_propietario.Size = new System.Drawing.Size(540, 70);
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
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.DimGray;
            this.lb_1.Location = new System.Drawing.Point(12, 9);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(126, 25);
            this.lb_1.TabIndex = 186;
            this.lb_1.Text = "Propietario";
            // 
            // btn_modificar
            // 
            this.btn_modificar.BorderRadius = 5;
            this.btn_modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modificar.FillColor = System.Drawing.Color.Transparent;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_modificar;
            this.btn_modificar.Location = new System.Drawing.Point(533, 452);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(40, 40);
            this.btn_modificar.TabIndex = 8;
            this.Información.SetToolTip(this.btn_modificar, "Modificar dispositivo (F1)");
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            this.btn_modificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_modificar_KeyPress);
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
            // frmModificarDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(612, 557);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar dispositivo";
            this.Load += new System.EventHandler(this.frmModificarDispositivo_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmModificarDispositivo_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel_dtgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_propietario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2TextBox tb_marca;
        private Guna.UI2.WinForms.Guna2Button btn_mostrar_contraseña;
        private Guna.UI2.WinForms.Guna2Button btn_patron;
        private Guna.UI2.WinForms.Guna2TextBox tb_contraseña;
        private System.Windows.Forms.Label lb_5;
        private System.Windows.Forms.Label lb_7;
        private System.Windows.Forms.Label lb_6;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_2;
        private Guna.UI2.WinForms.Guna2TextBox tb_tipo;
        private Guna.UI2.WinForms.Guna2TextBox tb_modelo;
        private Guna.UI2.WinForms.Guna2TextBox tb_numero_de_serie;
        private Guna.UI2.WinForms.Guna2TextBox tb_observacion;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_propietario;
        private System.Windows.Forms.Label lb_1;
        private Guna.UI2.WinForms.Guna2Button btn_modificar;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.ToolTip Información;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
    }
}