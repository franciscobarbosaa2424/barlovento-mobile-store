namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.SeleccionarPOrden
{
    partial class frmSeleccionarDispositivoOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionarDispositivoOrden));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.btn_seleccionar_dispositivo = new Guna.UI2.WinForms.Guna2Button();
            this.tb_buscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_seleccionar = new Guna.UI2.WinForms.Guna2Button();
            this.panel_dtgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollbar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dtgv_dispositivos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel_arriba.SuspendLayout();
            this.panel_dtgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dispositivos)).BeginInit();
            this.panel_central.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(759, 35);
            this.panel_arriba.TabIndex = 8;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(145, 15);
            this.lb_titulo.TabIndex = 121;
            this.lb_titulo.Text = "Seleccionar dispositivo";
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(702, 6);
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
            // btn_seleccionar_dispositivo
            // 
            this.btn_seleccionar_dispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_seleccionar_dispositivo.BorderRadius = 5;
            this.btn_seleccionar_dispositivo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar_dispositivo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar_dispositivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_seleccionar_dispositivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_seleccionar_dispositivo.FillColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar_dispositivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_dispositivo.ForeColor = System.Drawing.Color.White;
            this.btn_seleccionar_dispositivo.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_seleccionar;
            this.btn_seleccionar_dispositivo.Location = new System.Drawing.Point(670, 419);
            this.btn_seleccionar_dispositivo.Name = "btn_seleccionar_dispositivo";
            this.btn_seleccionar_dispositivo.Size = new System.Drawing.Size(46, 44);
            this.btn_seleccionar_dispositivo.TabIndex = 2;
            this.Información.SetToolTip(this.btn_seleccionar_dispositivo, "Seleccionar dispositivo (F1)");
            this.btn_seleccionar_dispositivo.Click += new System.EventHandler(this.btn_seleccionar_dispositivo_Click);
            this.btn_seleccionar_dispositivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_seleccionar_dispositivo_KeyPress);
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
            this.tb_buscar.IconLeftSize = new System.Drawing.Size(16, 16);
            this.tb_buscar.Location = new System.Drawing.Point(20, 19);
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
            this.tb_buscar.TabIndex = 1;
            this.tb_buscar.TextChanged += new System.EventHandler(this.tb_buscar_TextChanged);
            this.tb_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_buscar_KeyPress);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BorderRadius = 5;
            this.btn_seleccionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_seleccionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_seleccionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_seleccionar.FillColor = System.Drawing.Color.Transparent;
            this.btn_seleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar.ForeColor = System.Drawing.Color.White;
            this.btn_seleccionar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_seleccionar;
            this.btn_seleccionar.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_seleccionar.Location = new System.Drawing.Point(645, 502);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(40, 40);
            this.btn_seleccionar.TabIndex = 137;
            // 
            // panel_dtgv
            // 
            this.panel_dtgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv.Controls.Add(this.scrollbar);
            this.panel_dtgv.Controls.Add(this.dtgv_dispositivos);
            this.panel_dtgv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv.Location = new System.Drawing.Point(20, 52);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv.ShadowShift = 3;
            this.panel_dtgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv.Size = new System.Drawing.Size(696, 363);
            this.panel_dtgv.TabIndex = 138;
            // 
            // scrollbar
            // 
            this.scrollbar.AutoRoundedCorners = true;
            this.scrollbar.BindingContainer = this.dtgv_dispositivos;
            this.scrollbar.BorderRadius = 8;
            this.scrollbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.scrollbar.InUpdate = false;
            this.scrollbar.LargeChange = 10;
            this.scrollbar.Location = new System.Drawing.Point(671, 8);
            this.scrollbar.Minimum = 1;
            this.scrollbar.MinimumSize = new System.Drawing.Size(10, 0);
            this.scrollbar.Name = "scrollbar";
            this.scrollbar.ScrollbarSize = 18;
            this.scrollbar.Size = new System.Drawing.Size(18, 347);
            this.scrollbar.TabIndex = 2;
            this.scrollbar.ThumbColor = System.Drawing.Color.DimGray;
            this.scrollbar.ThumbSize = 5F;
            this.scrollbar.Value = 1;
            // 
            // dtgv_dispositivos
            // 
            this.dtgv_dispositivos.AllowUserToAddRows = false;
            this.dtgv_dispositivos.AllowUserToResizeColumns = false;
            this.dtgv_dispositivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_dispositivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_dispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_dispositivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dispositivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_dispositivos.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_dispositivos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_dispositivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivos.Location = new System.Drawing.Point(4, 8);
            this.dtgv_dispositivos.Name = "dtgv_dispositivos";
            this.dtgv_dispositivos.ReadOnly = true;
            this.dtgv_dispositivos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Purple;
            this.dtgv_dispositivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_dispositivos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_dispositivos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.dtgv_dispositivos.RowTemplate.DividerHeight = 3;
            this.dtgv_dispositivos.RowTemplate.Height = 50;
            this.dtgv_dispositivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_dispositivos.Size = new System.Drawing.Size(685, 347);
            this.dtgv_dispositivos.TabIndex = 0;
            this.dtgv_dispositivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_dispositivos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_dispositivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_dispositivos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_dispositivos.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgv_dispositivos.ThemeStyle.ReadOnly = true;
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.Height = 50;
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_dispositivos_CellFormatting);
            // 
            // panel_central
            // 
            this.panel_central.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.btn_seleccionar_dispositivo);
            this.panel_central.Controls.Add(this.panel_dtgv);
            this.panel_central.Controls.Add(this.btn_seleccionar);
            this.panel_central.Controls.Add(this.tb_buscar);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(735, 472);
            this.panel_central.TabIndex = 136;
            // 
            // frmSeleccionarDispositivoOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(759, 525);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeleccionarDispositivoOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar dispositivo";
            this.Load += new System.EventHandler(this.frmSeleccionarDispositivoOrden_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSeleccionarDispositivoOrden_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_dtgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dispositivos)).EndInit();
            this.panel_central.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.ToolTip Información;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2Button btn_seleccionar_dispositivo;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollbar;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_dispositivos;
        private Guna.UI2.WinForms.Guna2Button btn_seleccionar;
        private Guna.UI2.WinForms.Guna2TextBox tb_buscar;
    }
}