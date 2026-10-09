namespace ProyectoBarloventoReparacel.Vistas.Vistas_Clientes
{
    partial class frmSeleccionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarCliente));
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_persona = new Guna.UI2.WinForms.Guna2Button();
            this.panel_dtgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollbar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dtgv_clientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_empresa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_seleccionar = new Guna.UI2.WinForms.Guna2Button();
            this.tb_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.panel_central.SuspendLayout();
            this.panel_dtgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).BeginInit();
            this.panel_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_central
            // 
            this.panel_central.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.btn_persona);
            this.panel_central.Controls.Add(this.panel_dtgv);
            this.panel_central.Controls.Add(this.btn_empresa);
            this.panel_central.Controls.Add(this.btn_seleccionar);
            this.panel_central.Controls.Add(this.tb_buscar);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(604, 495);
            this.panel_central.TabIndex = 132;
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
            this.btn_persona.Location = new System.Drawing.Point(486, 19);
            this.btn_persona.Name = "btn_persona";
            this.btn_persona.Size = new System.Drawing.Size(92, 25);
            this.btn_persona.TabIndex = 50;
            this.btn_persona.Text = "Persona";
            this.btn_persona.Click += new System.EventHandler(this.btn_persona_Click);
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
            this.panel_dtgv.Location = new System.Drawing.Point(14, 50);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv.ShadowShift = 3;
            this.panel_dtgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv.Size = new System.Drawing.Size(571, 379);
            this.panel_dtgv.TabIndex = 142;
            // 
            // scrollbar
            // 
            this.scrollbar.AutoRoundedCorners = true;
            this.scrollbar.BindingContainer = this.dtgv_clientes;
            this.scrollbar.BorderRadius = 8;
            this.scrollbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.scrollbar.InUpdate = false;
            this.scrollbar.LargeChange = 10;
            this.scrollbar.Location = new System.Drawing.Point(546, 8);
            this.scrollbar.Minimum = 1;
            this.scrollbar.MinimumSize = new System.Drawing.Size(10, 0);
            this.scrollbar.Name = "scrollbar";
            this.scrollbar.ScrollbarSize = 18;
            this.scrollbar.Size = new System.Drawing.Size(18, 363);
            this.scrollbar.TabIndex = 2;
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
            this.dtgv_clientes.Location = new System.Drawing.Point(4, 8);
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
            this.dtgv_clientes.Size = new System.Drawing.Size(560, 363);
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
            this.btn_empresa.Location = new System.Drawing.Point(388, 19);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(92, 25);
            this.btn_empresa.TabIndex = 49;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.Click += new System.EventHandler(this.btn_empresa_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_seleccionar.BorderRadius = 5;
            this.btn_seleccionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_seleccionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_seleccionar.FillColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ForeColor = System.Drawing.Color.White;
            this.btn_seleccionar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_seleccionar;
            this.btn_seleccionar.Location = new System.Drawing.Point(542, 435);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(46, 44);
            this.btn_seleccionar.TabIndex = 141;
            this.Información.SetToolTip(this.btn_seleccionar, "Seleccionar cliente (F1)");
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            this.btn_seleccionar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_seleccionar_KeyPress);
            // 
            // tb_buscar
            // 
            this.tb_buscar.BackColor = System.Drawing.Color.Transparent;
            this.tb_buscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_buscar.BorderRadius = 4;
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
            this.tb_buscar.IconLeftSize = new System.Drawing.Size(16, 16);
            this.tb_buscar.Location = new System.Drawing.Point(14, 17);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.PasswordChar = '\0';
            this.tb_buscar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tb_buscar.PlaceholderText = "Buscar...";
            this.tb_buscar.SelectedText = "";
            this.tb_buscar.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.tb_buscar.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.tb_buscar.ShadowDecoration.Enabled = true;
            this.tb_buscar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tb_buscar.Size = new System.Drawing.Size(246, 27);
            this.tb_buscar.TabIndex = 135;
            this.tb_buscar.TextChanged += new System.EventHandler(this.tb_buscar_TextChanged_1);
            this.tb_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_buscar_KeyPress);
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Controls.Add(this.cntb_minimizar_formulario);
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(628, 35);
            this.panel_arriba.TabIndex = 133;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(120, 15);
            this.lb_titulo.TabIndex = 155;
            this.lb_titulo.Text = "Seleccionar cliente";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(520, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 1;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(571, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
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
            // frmSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(628, 548);
            this.Controls.Add(this.panel_arriba);
            this.Controls.Add(this.panel_central);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeleccionarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar cliente";
            this.Load += new System.EventHandler(this.frmSeleccionarCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSeleccionarCliente_KeyUp);
            this.panel_central.ResumeLayout(false);
            this.panel_dtgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_clientes)).EndInit();
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2TextBox tb_buscar;
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2Button btn_seleccionar;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollbar;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_clientes;
        private Guna.UI2.WinForms.Guna2Button btn_persona;
        private Guna.UI2.WinForms.Guna2Button btn_empresa;
        private System.Windows.Forms.ToolTip Información;
    }
}