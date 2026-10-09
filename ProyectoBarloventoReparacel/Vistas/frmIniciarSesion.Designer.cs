namespace ProyectoBarloventoReparacel
{
    partial class frmIniciarSesión
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesión));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_1 = new System.Windows.Forms.Label();
            this.tb_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_inicio = new Guna.UI2.WinForms.Guna2Button();
            this.imagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(369, 35);
            this.panel_arriba.TabIndex = 5;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(312, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.ForeColor = System.Drawing.Color.DimGray;
            this.lb_2.Location = new System.Drawing.Point(62, 259);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(93, 19);
            this.lb_2.TabIndex = 56;
            this.lb_2.Text = "Contraseña";
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.ForeColor = System.Drawing.Color.DimGray;
            this.lb_1.Location = new System.Drawing.Point(62, 199);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(67, 19);
            this.lb_1.TabIndex = 55;
            this.lb_1.Text = "Usuario";
            // 
            // tb_usuario
            // 
            this.tb_usuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tb_usuario.BorderRadius = 5;
            this.tb_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_usuario.DefaultText = "";
            this.tb_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_usuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.tb_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_usuario.Location = new System.Drawing.Point(66, 221);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.PasswordChar = '\0';
            this.tb_usuario.PlaceholderText = "";
            this.tb_usuario.SelectedText = "";
            this.tb_usuario.Size = new System.Drawing.Size(220, 27);
            this.tb_usuario.TabIndex = 53;
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
            this.tb_contraseña.Location = new System.Drawing.Point(66, 281);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '●';
            this.tb_contraseña.PlaceholderText = "";
            this.tb_contraseña.SelectedText = "";
            this.tb_contraseña.Size = new System.Drawing.Size(220, 27);
            this.tb_contraseña.TabIndex = 54;
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
            this.btn_inicio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_inicio.Location = new System.Drawing.Point(66, 364);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(220, 37);
            this.btn_inicio.TabIndex = 57;
            this.btn_inicio.Text = "Iniciar sesión";
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // imagen
            // 
            this.imagen.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_ola;
            this.imagen.ImageRotate = 0F;
            this.imagen.Location = new System.Drawing.Point(-10, 281);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(379, 268);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 58;
            this.imagen.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::ProyectoBarloventoReparacel.Properties.Resources.imagen_logo;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(60, 38);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(256, 173);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 59;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmIniciarSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(369, 542);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_contraseña);
            this.Controls.Add(this.panel_arriba);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIniciarSesión";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.frmIniciarSesión_Load);
            this.panel_arriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_1;
        private Guna.UI2.WinForms.Guna2TextBox tb_usuario;
        private Guna.UI2.WinForms.Guna2TextBox tb_contraseña;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2Button btn_inicio;
        private Guna.UI2.WinForms.Guna2PictureBox imagen;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}

