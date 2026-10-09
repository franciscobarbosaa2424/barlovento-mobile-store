namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseña
{
    partial class frmContAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContAdmin));
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btn_aceptar = new Guna.UI2.WinForms.Guna2Button();
            this.lb_contraseña_admin = new System.Windows.Forms.Label();
            this.tb_contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_central.SuspendLayout();
            this.panel_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.btn_aceptar);
            this.panel_central.Controls.Add(this.lb_contraseña_admin);
            this.panel_central.Controls.Add(this.tb_contraseña);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(282, 174);
            this.panel_central.TabIndex = 48;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.btn_aceptar.BorderRadius = 10;
            this.btn_aceptar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_aceptar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_aceptar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_aceptar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_aceptar.FillColor = System.Drawing.Color.Transparent;
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_aceptar.ForeColor = System.Drawing.Color.Gray;
            this.btn_aceptar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_aceptar.Location = new System.Drawing.Point(178, 125);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(90, 37);
            this.btn_aceptar.TabIndex = 60;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lb_contraseña_admin
            // 
            this.lb_contraseña_admin.AutoSize = true;
            this.lb_contraseña_admin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña_admin.ForeColor = System.Drawing.Color.DimGray;
            this.lb_contraseña_admin.Location = new System.Drawing.Point(20, 52);
            this.lb_contraseña_admin.Name = "lb_contraseña_admin";
            this.lb_contraseña_admin.Size = new System.Drawing.Size(228, 19);
            this.lb_contraseña_admin.TabIndex = 59;
            this.lb_contraseña_admin.Text = "Contraseña de Administrador";
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_contraseña.BorderRadius = 5;
            this.tb_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_contraseña.DefaultText = "";
            this.tb_contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_contraseña.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_contraseña.Location = new System.Drawing.Point(28, 74);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '●';
            this.tb_contraseña.PlaceholderText = "";
            this.tb_contraseña.SelectedText = "";
            this.tb_contraseña.Size = new System.Drawing.Size(220, 27);
            this.tb_contraseña.TabIndex = 58;
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(306, 35);
            this.panel_arriba.TabIndex = 157;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(249, 6);
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
            // frmContAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(306, 227);
            this.Controls.Add(this.panel_arriba);
            this.Controls.Add(this.panel_central);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmContAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Contraseña";
            this.Load += new System.EventHandler(this.frmContAdmin_Load);
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel_arriba.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2Button btn_aceptar;
        private System.Windows.Forms.Label lb_contraseña_admin;
        private Guna.UI2.WinForms.Guna2TextBox tb_contraseña;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
    }
}