namespace ProyectoBarloventoReparacel.Vistas
{
    partial class frmAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjustes));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_tema_claro = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tema_oscuro = new Guna.UI2.WinForms.Guna2Button();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.separator_ruta_python = new Guna.UI2.WinForms.Guna2Separator();
            this.lb_ruta_python = new System.Windows.Forms.Label();
            this.separator_agregar_marca_modelo = new Guna.UI2.WinForms.Guna2Separator();
            this.lb_agregar_marca_modelo = new System.Windows.Forms.Label();
            this.separator_temas = new Guna.UI2.WinForms.Guna2Separator();
            this.tb_marca = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_temas = new System.Windows.Forms.Label();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.tb_modelo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.tb_ruta_python = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ruta_python = new Guna.UI2.WinForms.Guna2Button();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.panel_arriba.Size = new System.Drawing.Size(553, 35);
            this.panel_arriba.TabIndex = 39;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(51, 15);
            this.lb_titulo.TabIndex = 121;
            this.lb_titulo.Text = "Ajustes";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(445, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 1;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(496, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            // 
            // panel_central
            // 
            this.panel_central.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.btn_tema_claro);
            this.panel_central.Controls.Add(this.btn_tema_oscuro);
            this.panel_central.Controls.Add(this.btn_agregar);
            this.panel_central.Controls.Add(this.separator_ruta_python);
            this.panel_central.Controls.Add(this.lb_ruta_python);
            this.panel_central.Controls.Add(this.separator_agregar_marca_modelo);
            this.panel_central.Controls.Add(this.lb_agregar_marca_modelo);
            this.panel_central.Controls.Add(this.separator_temas);
            this.panel_central.Controls.Add(this.tb_marca);
            this.panel_central.Controls.Add(this.lb_temas);
            this.panel_central.Controls.Add(this.lb_modelo);
            this.panel_central.Controls.Add(this.lb_marca);
            this.panel_central.Controls.Add(this.tb_modelo);
            this.panel_central.Controls.Add(this.btn_guardar);
            this.panel_central.Controls.Add(this.tb_ruta_python);
            this.panel_central.Controls.Add(this.btn_ruta_python);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(529, 500);
            this.panel_central.TabIndex = 132;
            // 
            // btn_tema_claro
            // 
            this.btn_tema_claro.BorderRadius = 10;
            this.btn_tema_claro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tema_claro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tema_claro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tema_claro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tema_claro.FillColor = System.Drawing.Color.Transparent;
            this.btn_tema_claro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_tema_claro.ForeColor = System.Drawing.Color.Gray;
            this.btn_tema_claro.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_tema_claro;
            this.btn_tema_claro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_tema_claro.Location = new System.Drawing.Point(143, 263);
            this.btn_tema_claro.Name = "btn_tema_claro";
            this.btn_tema_claro.Size = new System.Drawing.Size(111, 37);
            this.btn_tema_claro.TabIndex = 225;
            this.btn_tema_claro.Text = "Claro";
            this.btn_tema_claro.Click += new System.EventHandler(this.btn_tema_claro_Click);
            // 
            // btn_tema_oscuro
            // 
            this.btn_tema_oscuro.BorderRadius = 10;
            this.btn_tema_oscuro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tema_oscuro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tema_oscuro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tema_oscuro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tema_oscuro.FillColor = System.Drawing.Color.Transparent;
            this.btn_tema_oscuro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_tema_oscuro.ForeColor = System.Drawing.Color.Gray;
            this.btn_tema_oscuro.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_tema_oscuro;
            this.btn_tema_oscuro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_tema_oscuro.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_tema_oscuro.Location = new System.Drawing.Point(26, 263);
            this.btn_tema_oscuro.Name = "btn_tema_oscuro";
            this.btn_tema_oscuro.Size = new System.Drawing.Size(111, 37);
            this.btn_tema_oscuro.TabIndex = 224;
            this.btn_tema_oscuro.Text = "Oscuro";
            this.btn_tema_oscuro.Click += new System.EventHandler(this.btn_tema_oscuro_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BorderRadius = 5;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.Transparent;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_agregar;
            this.btn_agregar.Location = new System.Drawing.Point(402, 176);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(40, 40);
            this.btn_agregar.TabIndex = 133;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // separator_ruta_python
            // 
            this.separator_ruta_python.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.separator_ruta_python.BackColor = System.Drawing.Color.Transparent;
            this.separator_ruta_python.FillColor = System.Drawing.Color.DimGray;
            this.separator_ruta_python.Location = new System.Drawing.Point(26, 45);
            this.separator_ruta_python.Name = "separator_ruta_python";
            this.separator_ruta_python.Size = new System.Drawing.Size(192, 13);
            this.separator_ruta_python.TabIndex = 221;
            // 
            // lb_ruta_python
            // 
            this.lb_ruta_python.AutoSize = true;
            this.lb_ruta_python.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ruta_python.ForeColor = System.Drawing.Color.Gray;
            this.lb_ruta_python.Location = new System.Drawing.Point(23, 29);
            this.lb_ruta_python.Name = "lb_ruta_python";
            this.lb_ruta_python.Size = new System.Drawing.Size(92, 15);
            this.lb_ruta_python.TabIndex = 222;
            this.lb_ruta_python.Text = "Ruta de Python";
            // 
            // separator_agregar_marca_modelo
            // 
            this.separator_agregar_marca_modelo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.separator_agregar_marca_modelo.BackColor = System.Drawing.Color.Transparent;
            this.separator_agregar_marca_modelo.FillColor = System.Drawing.Color.DimGray;
            this.separator_agregar_marca_modelo.Location = new System.Drawing.Point(26, 138);
            this.separator_agregar_marca_modelo.Name = "separator_agregar_marca_modelo";
            this.separator_agregar_marca_modelo.Size = new System.Drawing.Size(192, 16);
            this.separator_agregar_marca_modelo.TabIndex = 219;
            // 
            // lb_agregar_marca_modelo
            // 
            this.lb_agregar_marca_modelo.AutoSize = true;
            this.lb_agregar_marca_modelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_agregar_marca_modelo.ForeColor = System.Drawing.Color.Gray;
            this.lb_agregar_marca_modelo.Location = new System.Drawing.Point(23, 123);
            this.lb_agregar_marca_modelo.Name = "lb_agregar_marca_modelo";
            this.lb_agregar_marca_modelo.Size = new System.Drawing.Size(173, 15);
            this.lb_agregar_marca_modelo.TabIndex = 220;
            this.lb_agregar_marca_modelo.Text = "Agregar nueva Marca/Modelo";
            // 
            // separator_temas
            // 
            this.separator_temas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.separator_temas.BackColor = System.Drawing.Color.Transparent;
            this.separator_temas.FillColor = System.Drawing.Color.DimGray;
            this.separator_temas.Location = new System.Drawing.Point(26, 247);
            this.separator_temas.Name = "separator_temas";
            this.separator_temas.Size = new System.Drawing.Size(192, 10);
            this.separator_temas.TabIndex = 217;
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
            this.tb_marca.Location = new System.Drawing.Point(26, 181);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.PasswordChar = '\0';
            this.tb_marca.PlaceholderText = "";
            this.tb_marca.SelectedText = "";
            this.tb_marca.Size = new System.Drawing.Size(169, 27);
            this.tb_marca.TabIndex = 214;
            this.tb_marca.TextChanged += new System.EventHandler(this.tb_marca_TextChanged);
            // 
            // lb_temas
            // 
            this.lb_temas.AutoSize = true;
            this.lb_temas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temas.ForeColor = System.Drawing.Color.Gray;
            this.lb_temas.Location = new System.Drawing.Point(23, 235);
            this.lb_temas.Name = "lb_temas";
            this.lb_temas.Size = new System.Drawing.Size(45, 15);
            this.lb_temas.TabIndex = 218;
            this.lb_temas.Text = "Temas ";
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.BackColor = System.Drawing.Color.Transparent;
            this.lb_modelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modelo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_modelo.Location = new System.Drawing.Point(222, 157);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(66, 21);
            this.lb_modelo.TabIndex = 213;
            this.lb_modelo.Text = "Modelo:";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.BackColor = System.Drawing.Color.Transparent;
            this.lb_marca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_marca.ForeColor = System.Drawing.Color.DimGray;
            this.lb_marca.Location = new System.Drawing.Point(22, 157);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(56, 21);
            this.lb_marca.TabIndex = 212;
            this.lb_marca.Text = "Marca:";
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
            this.tb_modelo.Location = new System.Drawing.Point(226, 181);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.PasswordChar = '\0';
            this.tb_modelo.PlaceholderText = "";
            this.tb_modelo.SelectedText = "";
            this.tb_modelo.Size = new System.Drawing.Size(169, 27);
            this.tb_modelo.TabIndex = 211;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardar.BorderRadius = 5;
            this.btn_guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar.FillColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_guardar;
            this.btn_guardar.Location = new System.Drawing.Point(470, 445);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(46, 44);
            this.btn_guardar.TabIndex = 150;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // tb_ruta_python
            // 
            this.tb_ruta_python.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_ruta_python.BorderRadius = 5;
            this.tb_ruta_python.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ruta_python.DefaultText = "";
            this.tb_ruta_python.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_ruta_python.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_ruta_python.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ruta_python.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_ruta_python.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_ruta_python.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ruta_python.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_ruta_python.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ruta_python.Location = new System.Drawing.Point(26, 67);
            this.tb_ruta_python.Name = "tb_ruta_python";
            this.tb_ruta_python.PasswordChar = '\0';
            this.tb_ruta_python.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_ruta_python.PlaceholderText = "";
            this.tb_ruta_python.SelectedText = "";
            this.tb_ruta_python.Size = new System.Drawing.Size(391, 32);
            this.tb_ruta_python.TabIndex = 143;
            // 
            // btn_ruta_python
            // 
            this.btn_ruta_python.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ruta_python.BorderRadius = 5;
            this.btn_ruta_python.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ruta_python.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ruta_python.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ruta_python.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ruta_python.FillColor = System.Drawing.Color.Transparent;
            this.btn_ruta_python.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ruta_python.ForeColor = System.Drawing.Color.White;
            this.btn_ruta_python.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_python;
            this.btn_ruta_python.Location = new System.Drawing.Point(423, 57);
            this.btn_ruta_python.Name = "btn_ruta_python";
            this.btn_ruta_python.Size = new System.Drawing.Size(46, 44);
            this.btn_ruta_python.TabIndex = 142;
            this.btn_ruta_python.Click += new System.EventHandler(this.btn_ruta_python_Click);
            // 
            // dc_panel_arriba
            // 
            this.dc_panel_arriba.DockIndicatorColor = System.Drawing.Color.Black;
            this.dc_panel_arriba.DockIndicatorTransparencyValue = 0D;
            this.dc_panel_arriba.DragStartTransparencyValue = 0.1D;
            this.dc_panel_arriba.TargetControl = this.panel_arriba;
            this.dc_panel_arriba.TransparentWhileDrag = false;
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(553, 553);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.frmAjustes_Load);
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
        private Guna.UI2.WinForms.Guna2Button btn_ruta_python;
        private Guna.UI2.WinForms.Guna2TextBox tb_ruta_python;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2TextBox tb_marca;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.Label lb_marca;
        private Guna.UI2.WinForms.Guna2TextBox tb_modelo;
        private Guna.UI2.WinForms.Guna2Separator separator_ruta_python;
        private System.Windows.Forms.Label lb_ruta_python;
        private Guna.UI2.WinForms.Guna2Separator separator_agregar_marca_modelo;
        private System.Windows.Forms.Label lb_agregar_marca_modelo;
        private Guna.UI2.WinForms.Guna2Separator separator_temas;
        private System.Windows.Forms.Label lb_temas;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private Guna.UI2.WinForms.Guna2Button btn_tema_claro;
        private Guna.UI2.WinForms.Guna2Button btn_tema_oscuro;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
    }
}