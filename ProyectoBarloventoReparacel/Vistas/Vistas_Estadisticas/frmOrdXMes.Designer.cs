namespace ProyectoBarloventoReparacel.Vistas.Vistas_Estadisticas
{
    partial class frmOrdXMes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdXMes));
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.grafica_ordenes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_central.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica_ordenes)).BeginInit();
            this.panel_arriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.grafica_ordenes);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_central.Location = new System.Drawing.Point(12, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(776, 397);
            this.panel_central.TabIndex = 46;
            // 
            // grafica_ordenes
            // 
            this.grafica_ordenes.BackColor = System.Drawing.Color.Transparent;
            this.grafica_ordenes.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.grafica_ordenes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica_ordenes.Legends.Add(legend1);
            this.grafica_ordenes.Location = new System.Drawing.Point(-12, 0);
            this.grafica_ordenes.Name = "grafica_ordenes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafica_ordenes.Series.Add(series1);
            this.grafica_ordenes.Size = new System.Drawing.Size(785, 394);
            this.grafica_ordenes.TabIndex = 0;
            this.grafica_ordenes.Text = "chart1";
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(800, 35);
            this.panel_arriba.TabIndex = 47;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(109, 15);
            this.lb_titulo.TabIndex = 121;
            this.lb_titulo.Text = "Órdenes por Mes";
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(743, 6);
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
            // frmOrdXMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_arriba);
            this.Controls.Add(this.panel_central);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrdXMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órdenes por Mes";
            this.Load += new System.EventHandler(this.frmOrdXMes_Load);
            this.panel_central.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafica_ordenes)).EndInit();
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica_ordenes;
        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
    }
}