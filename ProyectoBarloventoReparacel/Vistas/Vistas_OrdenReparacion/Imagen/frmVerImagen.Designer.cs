namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Imagen
{
    partial class frmVerImagen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerImagen));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_minimizar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pb_imagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_inicio = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel_arriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.panel_inicio.SuspendLayout();
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
            this.panel_arriba.Size = new System.Drawing.Size(373, 35);
            this.panel_arriba.TabIndex = 39;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(75, 15);
            this.lb_titulo.TabIndex = 153;
            this.lb_titulo.Text = "Ver imagen";
            // 
            // cntb_minimizar_formulario
            // 
            this.cntb_minimizar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_minimizar_formulario.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cntb_minimizar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_minimizar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_minimizar_formulario.Location = new System.Drawing.Point(265, 6);
            this.cntb_minimizar_formulario.Name = "cntb_minimizar_formulario";
            this.cntb_minimizar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_minimizar_formulario.TabIndex = 1;
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(316, 6);
            this.cntb_cerrar_formulario.Name = "cntb_cerrar_formulario";
            this.cntb_cerrar_formulario.Size = new System.Drawing.Size(45, 29);
            this.cntb_cerrar_formulario.TabIndex = 0;
            // 
            // pb_imagen
            // 
            this.pb_imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_imagen.ImageRotate = 0F;
            this.pb_imagen.Location = new System.Drawing.Point(0, 0);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(349, 327);
            this.pb_imagen.TabIndex = 40;
            this.pb_imagen.TabStop = false;
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
            // panel_inicio
            // 
            this.panel_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_inicio.BackColor = System.Drawing.Color.Transparent;
            this.panel_inicio.Controls.Add(this.pb_imagen);
            this.panel_inicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_inicio.Location = new System.Drawing.Point(12, 41);
            this.panel_inicio.Name = "panel_inicio";
            this.panel_inicio.ShadowColor = System.Drawing.Color.Black;
            this.panel_inicio.ShadowShift = 3;
            this.panel_inicio.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_inicio.Size = new System.Drawing.Size(349, 327);
            this.panel_inicio.TabIndex = 48;
            // 
            // frmVerImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 380);
            this.Controls.Add(this.panel_inicio);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVerImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver imagen";
            this.Load += new System.EventHandler(this.frmVerImagen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmVerImagen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmVerImagen_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmVerImagen_MouseUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.panel_inicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_minimizar_formulario;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2PictureBox pb_imagen;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_inicio;
    }
}