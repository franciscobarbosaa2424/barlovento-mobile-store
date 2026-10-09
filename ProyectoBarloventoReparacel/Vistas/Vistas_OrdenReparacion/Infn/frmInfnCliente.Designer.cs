namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.InformacionPropietario
{
    partial class frmInfnCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfnCliente));
            this.panel_arriba = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.cntb_cerrar_formulario = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dc_panel_arriba = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel_central = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel_dtgv_propietario = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgv_propietario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_historial_ordenes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_modificar = new Guna.UI2.WinForms.Guna2Button();
            this.panel_dtgv_dispositivo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollbar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dtgv_dispositivo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_dispositivo = new System.Windows.Forms.Label();
            this.lb_propietario = new System.Windows.Forms.Label();
            this.Información = new System.Windows.Forms.ToolTip(this.components);
            this.panel_arriba.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.panel_dtgv_propietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_propietario)).BeginInit();
            this.panel_dtgv_dispositivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dispositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_arriba
            // 
            this.panel_arriba.Controls.Add(this.lb_titulo);
            this.panel_arriba.Controls.Add(this.cntb_cerrar_formulario);
            this.panel_arriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_arriba.Location = new System.Drawing.Point(0, 0);
            this.panel_arriba.Name = "panel_arriba";
            this.panel_arriba.Size = new System.Drawing.Size(693, 35);
            this.panel_arriba.TabIndex = 10;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_titulo.Location = new System.Drawing.Point(3, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(153, 15);
            this.lb_titulo.TabIndex = 120;
            this.lb_titulo.Text = "Información propietario";
            // 
            // cntb_cerrar_formulario
            // 
            this.cntb_cerrar_formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cntb_cerrar_formulario.FillColor = System.Drawing.Color.Black;
            this.cntb_cerrar_formulario.IconColor = System.Drawing.Color.White;
            this.cntb_cerrar_formulario.Location = new System.Drawing.Point(636, 6);
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
            // panel_central
            // 
            this.panel_central.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_central.BackColor = System.Drawing.Color.Transparent;
            this.panel_central.Controls.Add(this.panel_dtgv_propietario);
            this.panel_central.Controls.Add(this.btn_eliminar);
            this.panel_central.Controls.Add(this.btn_historial_ordenes);
            this.panel_central.Controls.Add(this.btn_modificar);
            this.panel_central.Controls.Add(this.panel_dtgv_dispositivo);
            this.panel_central.Controls.Add(this.lb_dispositivo);
            this.panel_central.Controls.Add(this.lb_propietario);
            this.panel_central.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel_central.Location = new System.Drawing.Point(16, 41);
            this.panel_central.Name = "panel_central";
            this.panel_central.ShadowColor = System.Drawing.Color.Black;
            this.panel_central.ShadowShift = 3;
            this.panel_central.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_central.Size = new System.Drawing.Size(665, 552);
            this.panel_central.TabIndex = 49;
            // 
            // panel_dtgv_propietario
            // 
            this.panel_dtgv_propietario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_dtgv_propietario.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv_propietario.Controls.Add(this.dtgv_propietario);
            this.panel_dtgv_propietario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv_propietario.Location = new System.Drawing.Point(18, 38);
            this.panel_dtgv_propietario.Name = "panel_dtgv_propietario";
            this.panel_dtgv_propietario.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv_propietario.ShadowShift = 3;
            this.panel_dtgv_propietario.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv_propietario.Size = new System.Drawing.Size(636, 77);
            this.panel_dtgv_propietario.TabIndex = 199;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dtgv_propietario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_propietario.RowTemplate.DividerHeight = 3;
            this.dtgv_propietario.RowTemplate.Height = 50;
            this.dtgv_propietario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_propietario.Size = new System.Drawing.Size(624, 67);
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
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.BorderRadius = 5;
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_eliminar;
            this.btn_eliminar.Location = new System.Drawing.Point(500, 494);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(46, 44);
            this.btn_eliminar.TabIndex = 198;
            this.Información.SetToolTip(this.btn_eliminar, "Eliminar propietario (F1)");
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_historial_ordenes
            // 
            this.btn_historial_ordenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_historial_ordenes.BorderRadius = 5;
            this.btn_historial_ordenes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_historial_ordenes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_historial_ordenes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_historial_ordenes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_historial_ordenes.FillColor = System.Drawing.Color.Transparent;
            this.btn_historial_ordenes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historial_ordenes.ForeColor = System.Drawing.Color.White;
            this.btn_historial_ordenes.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_dtgv_orden;
            this.btn_historial_ordenes.Location = new System.Drawing.Point(552, 494);
            this.btn_historial_ordenes.Name = "btn_historial_ordenes";
            this.btn_historial_ordenes.Size = new System.Drawing.Size(46, 44);
            this.btn_historial_ordenes.TabIndex = 197;
            this.Información.SetToolTip(this.btn_historial_ordenes, "Historial de ordenes (F2)");
            this.btn_historial_ordenes.Click += new System.EventHandler(this.btn_historial_ordenes_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.BorderRadius = 5;
            this.btn_modificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_modificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_modificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_modificar.FillColor = System.Drawing.Color.Transparent;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Image = global::ProyectoBarloventoReparacel.Properties.Resources.icono_modificar;
            this.btn_modificar.Location = new System.Drawing.Point(604, 494);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(46, 44);
            this.btn_modificar.TabIndex = 196;
            this.Información.SetToolTip(this.btn_modificar, "Modificar propietario (F3)");
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // panel_dtgv_dispositivo
            // 
            this.panel_dtgv_dispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dtgv_dispositivo.BackColor = System.Drawing.Color.Transparent;
            this.panel_dtgv_dispositivo.Controls.Add(this.scrollbar);
            this.panel_dtgv_dispositivo.Controls.Add(this.dtgv_dispositivo);
            this.panel_dtgv_dispositivo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.panel_dtgv_dispositivo.Location = new System.Drawing.Point(18, 152);
            this.panel_dtgv_dispositivo.Name = "panel_dtgv_dispositivo";
            this.panel_dtgv_dispositivo.ShadowColor = System.Drawing.Color.Black;
            this.panel_dtgv_dispositivo.ShadowShift = 3;
            this.panel_dtgv_dispositivo.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panel_dtgv_dispositivo.Size = new System.Drawing.Size(632, 336);
            this.panel_dtgv_dispositivo.TabIndex = 195;
            // 
            // scrollbar
            // 
            this.scrollbar.AutoRoundedCorners = true;
            this.scrollbar.BindingContainer = this.dtgv_dispositivo;
            this.scrollbar.BorderRadius = 8;
            this.scrollbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.scrollbar.InUpdate = false;
            this.scrollbar.LargeChange = 10;
            this.scrollbar.Location = new System.Drawing.Point(606, 5);
            this.scrollbar.Minimum = 1;
            this.scrollbar.MinimumSize = new System.Drawing.Size(10, 0);
            this.scrollbar.Name = "scrollbar";
            this.scrollbar.ScrollbarSize = 18;
            this.scrollbar.Size = new System.Drawing.Size(18, 326);
            this.scrollbar.TabIndex = 200;
            this.scrollbar.ThumbColor = System.Drawing.Color.DimGray;
            this.scrollbar.ThumbSize = 5F;
            this.scrollbar.Value = 1;
            // 
            // dtgv_dispositivo
            // 
            this.dtgv_dispositivo.AllowUserToAddRows = false;
            this.dtgv_dispositivo.AllowUserToResizeColumns = false;
            this.dtgv_dispositivo.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_dispositivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_dispositivo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_dispositivo.ColumnHeadersHeight = 25;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_dispositivo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_dispositivo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivo.Location = new System.Drawing.Point(4, 5);
            this.dtgv_dispositivo.Name = "dtgv_dispositivo";
            this.dtgv_dispositivo.ReadOnly = true;
            this.dtgv_dispositivo.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Purple;
            this.dtgv_dispositivo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_dispositivo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgv_dispositivo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivo.RowTemplate.DividerHeight = 3;
            this.dtgv_dispositivo.RowTemplate.Height = 50;
            this.dtgv_dispositivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgv_dispositivo.Size = new System.Drawing.Size(620, 326);
            this.dtgv_dispositivo.TabIndex = 0;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_dispositivo.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_dispositivo.ThemeStyle.HeaderStyle.Height = 25;
            this.dtgv_dispositivo.ThemeStyle.ReadOnly = true;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.Height = 50;
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dtgv_dispositivo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_dispositivo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dispositivo_CellClick);
            this.dtgv_dispositivo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_dispositivo_CellFormatting);
            // 
            // lb_dispositivo
            // 
            this.lb_dispositivo.AutoSize = true;
            this.lb_dispositivo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dispositivo.ForeColor = System.Drawing.Color.DimGray;
            this.lb_dispositivo.Location = new System.Drawing.Point(17, 124);
            this.lb_dispositivo.Name = "lb_dispositivo";
            this.lb_dispositivo.Size = new System.Drawing.Size(286, 25);
            this.lb_dispositivo.TabIndex = 194;
            this.lb_dispositivo.Text = "Dispositivos del propietario";
            // 
            // lb_propietario
            // 
            this.lb_propietario.AutoSize = true;
            this.lb_propietario.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_propietario.ForeColor = System.Drawing.Color.DimGray;
            this.lb_propietario.Location = new System.Drawing.Point(13, 10);
            this.lb_propietario.Name = "lb_propietario";
            this.lb_propietario.Size = new System.Drawing.Size(126, 25);
            this.lb_propietario.TabIndex = 192;
            this.lb_propietario.Text = "Propietario";
            // 
            // frmInfnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(693, 605);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel_arriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInfnCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información propietario";
            this.Load += new System.EventHandler(this.frmInfnCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmInfnCliente_KeyUp);
            this.panel_arriba.ResumeLayout(false);
            this.panel_arriba.PerformLayout();
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel_dtgv_propietario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_propietario)).EndInit();
            this.panel_dtgv_dispositivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dispositivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_arriba;
        private System.Windows.Forms.Label lb_titulo;
        private Guna.UI2.WinForms.Guna2ControlBox cntb_cerrar_formulario;
        private Guna.UI2.WinForms.Guna2DragControl dc_panel_arriba;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_central;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv_dispositivo;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_dispositivo;
        private System.Windows.Forms.Label lb_dispositivo;
        private System.Windows.Forms.Label lb_propietario;
        private Guna.UI2.WinForms.Guna2Button btn_historial_ordenes;
        private Guna.UI2.WinForms.Guna2Button btn_modificar;
        private System.Windows.Forms.ToolTip Información;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar;
        private Guna.UI2.WinForms.Guna2ShadowPanel panel_dtgv_propietario;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv_propietario;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollbar;
    }
}