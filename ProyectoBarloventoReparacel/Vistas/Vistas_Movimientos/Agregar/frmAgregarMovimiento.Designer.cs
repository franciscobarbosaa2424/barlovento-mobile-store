namespace ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Agregar
{
    partial class frmAgregarMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarMovimiento));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_fecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tb_monto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.cb_tipo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.panel_arriba.SuspendLayout();
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
            this.panel_arriba.Size = new System.Drawing.Size(433, 35);
            this.panel_arriba.TabIndex = 51;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(7, 11);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(130, 15);
            this.lb_titulo.TabIndex = 154;
            this.lb_titulo.Text = "Agregar Movimiento";
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(376, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            this.cntb_cerrar_formulario.TabStop = false;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.label1);
            this.panel_central.Controls.Add(this.dtp_fecha);
            this.panel_central.Controls.Add(this.tb_monto);
            this.panel_central.Controls.Add(this.lb_2);
            this.panel_central.Controls.Add(this.cb_tipo);
            this.panel_central.Controls.Add(this.lb_1);
            this.panel_central.Controls.Add(this.btn_agregar);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(10, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(411, 165);
            this.panel_central.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 207;
            this.label1.Text = "Fecha Movimiento:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha.BorderRadius = 2;
            this.dtp_fecha.Checked = true;
            this.dtp_fecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_fecha.ForeColor = System.Drawing.Color.Gray;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(18, 107);
            this.dtp_fecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_fecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(115, 36);
            this.dtp_fecha.TabIndex = 206;
            this.dtp_fecha.Value = new System.DateTime(2024, 9, 10, 22, 35, 45, 872);
            // 
            // tb_monto
            // 
            this.tb_monto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_monto.BorderRadius = 5;
            this.tb_monto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_monto.DefaultText = "";
            this.tb_monto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_monto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_monto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_monto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_monto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_monto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_monto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_monto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_monto.Location = new System.Drawing.Point(210, 39);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.PasswordChar = '\0';
            this.tb_monto.PlaceholderText = "";
            this.tb_monto.SelectedText = "";
            this.tb_monto.Size = new System.Drawing.Size(158, 27);
            this.tb_monto.TabIndex = 205;
            this.tb_monto.TextChanged += new System.EventHandler(this.tb_monto_TextChanged);
            this.tb_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_monto_KeyPress);
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.Color.Transparent;
            this.lb_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_2.Location = new System.Drawing.Point(206, 15);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(59, 21);
            this.lb_2.TabIndex = 71;
            this.lb_2.Text = "Monto:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.BackColor = System.Drawing.Color.Transparent;
            this.cb_tipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cb_tipo.BorderRadius = 5;
            this.cb_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.cb_tipo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_tipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_tipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb_tipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_tipo.ItemHeight = 30;
            this.cb_tipo.Items.AddRange(new object[] {
            "Apertura",
            "Cierre",
            "Entrada",
            "Salida"});
            this.cb_tipo.Location = new System.Drawing.Point(17, 39);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(169, 36);
            this.cb_tipo.TabIndex = 5;
            this.cb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_tipo_KeyPress);
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.Color.Transparent;
            this.lb_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.DimGray;
            this.lb_1.Location = new System.Drawing.Point(13, 15);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(152, 21);
            this.lb_1.TabIndex = 70;
            this.lb_1.Text = "Tipo de Movimiento:";
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
            this.btn_agregar.Location = new System.Drawing.Point(360, 115);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(40, 40);
            this.btn_agregar.TabIndex = 8;
            this.Información.SetToolTip(this.btn_agregar, "Agregar movimiento (F1)");
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
            // frmAgregarMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(433, 218);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar movimiento";
            this.Load += new System.EventHandler(this.frmAgregarMovimiento_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmAgregarMovimiento_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private System.Windows.Forms.Label lb_2;
        private Guna.UI2.WinForms.Guna2ComboBox cb_tipo;
        private System.Windows.Forms.Label lb_1;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
        private System.Windows.Forms.ToolTip Información;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2TextBox tb_monto;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_fecha;
    }
}