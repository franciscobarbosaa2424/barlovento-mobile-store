using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseñaPatron
{
    public partial class frmVerPatron : Form
    {
        private int selectionOrder = 1;
        private List<Guna2CustomRadioButton> selectedRadioButtons = new List<Guna2CustomRadioButton>();
        private List<int> orden = new List<int>();
        private string orden_ingreso;
        public frmVerPatron()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            #region Evento CheckedChanged
            rb_1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_3.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_4.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_5.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_6.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_7.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_8.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rb_9.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            this.Paint += new PaintEventHandler(panel_central_Paint);
            #endregion
        }


        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.gb_1.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_1.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_1.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_2.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_2.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_2.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_3.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_3.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_3.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_4.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_4.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_4.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_5.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_5.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_5.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_6.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_6.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_6.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_7.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_7.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_7.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_8.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_8.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_8.BorderColor = Color.FromArgb(95, 111, 101);

            this.gb_9.FillColor = Color.FromArgb(95, 111, 101);
            this.gb_9.CustomBorderColor = Color.FromArgb(95, 111, 101);
            this.gb_9.BorderColor = Color.FromArgb(95, 111, 101);

            this.rb_1.UncheckedState.BorderColor = Color.White;
            this.rb_2.UncheckedState.BorderColor = Color.White;
            this.rb_3.UncheckedState.BorderColor = Color.White;
            this.rb_4.UncheckedState.BorderColor = Color.White;
            this.rb_5.UncheckedState.BorderColor = Color.White;
            this.rb_6.UncheckedState.BorderColor = Color.White;
            this.rb_7.UncheckedState.BorderColor = Color.White;
            this.rb_8.UncheckedState.BorderColor = Color.White;
            this.rb_9.UncheckedState.BorderColor = Color.White;

            this.rb_1.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_2.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_3.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_4.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_5.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_6.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_7.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_8.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);
            this.rb_9.CheckedState.InnerColor = Color.FromArgb(95, 111, 101);

            this.rb_1.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_2.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_3.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_4.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_5.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_6.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_7.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_8.CheckedState.FillColor = Color.FromArgb(64, 83, 76);
            this.rb_9.CheckedState.FillColor = Color.FromArgb(64, 83, 76);

        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;

            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.cntb_cerrar_formulario.FillColor = Color.Black;

            this.gb_1.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_1.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_1.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_2.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_2.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_2.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_3.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_3.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_3.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_4.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_4.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_4.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_5.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_5.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_5.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_6.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_6.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_6.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_7.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_7.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_7.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_8.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_8.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_8.BorderColor = Color.FromArgb(18, 18, 18);

            this.gb_9.FillColor = Color.FromArgb(18, 18, 18);
            this.gb_9.CustomBorderColor = Color.FromArgb(18, 18, 18);
            this.gb_9.BorderColor = Color.FromArgb(18, 18, 18);

            this.rb_1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_2.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_3.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_4.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_5.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_6.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_7.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_8.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            this.rb_9.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);

            this.rb_1.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_2.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_3.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_4.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_5.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_6.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_7.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_8.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);
            this.rb_9.CheckedState.InnerColor = Color.FromArgb(18, 18, 18);

            this.rb_1.CheckedState.FillColor = Color.Black;
            this.rb_2.CheckedState.FillColor = Color.Black;
            this.rb_3.CheckedState.FillColor = Color.Black;
            this.rb_4.CheckedState.FillColor = Color.Black;
            this.rb_5.CheckedState.FillColor = Color.Black;
            this.rb_6.CheckedState.FillColor = Color.Black;
            this.rb_7.CheckedState.FillColor = Color.Black; 
            this.rb_8.CheckedState.FillColor = Color.Black;
            this.rb_9.CheckedState.FillColor = Color.Black;
        }

        #region Metodos auxiliares
        public void DibujarPatronDesdeString(string patron)
        {
            // Limpia la lista de botones seleccionados y reinicia el patrón actual
            foreach (var rb in selectedRadioButtons)
            {
                rb.Checked = false;
            }
            selectedRadioButtons.Clear();
            orden.Clear();

            // Divide el string en posiciones
            string[] posiciones = patron.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Itera sobre las posiciones para marcar los RadioButtons correspondientes
            foreach (string pos in posiciones)
            {
                int posicion;
                if (int.TryParse(pos, out posicion))
                {
                    Guna2CustomRadioButton rb = GetRadioButtonFromPosition(posicion);
                    if (rb != null)
                    {
                        rb.Checked = true;
                    }
                }
            }

            // Fuerza el repintado del formulario para dibujar las líneas
            this.Invalidate();
        }

        // Método para obtener el RadioButton correspondiente a una posición
        private Guna2CustomRadioButton GetRadioButtonFromPosition(int posicion)
        {
            switch (posicion)
            {
                case 1: return rb_1;
                case 2: return rb_2;
                case 3: return rb_3;
                case 4: return rb_4;
                case 5: return rb_5;
                case 6: return rb_6;
                case 7: return rb_7;
                case 8: return rb_8;
                case 9: return rb_9;
                default: return null;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CustomRadioButton rb = sender as Guna2CustomRadioButton;
            if (rb == null) return;

            Label lb = FindLabelForRadioButton(rb);
            HandleRadioButtonChange(rb, lb);

            if (rb.Checked)
            {
                if (!selectedRadioButtons.Contains(rb))
                {
                    selectedRadioButtons.Add(rb);
                }
            }
            else
            {
                selectedRadioButtons.Remove(rb);
            }

            // Solicita redibujar el formulario
            this.Invalidate();
        }

        private Label FindLabelForRadioButton(Guna2CustomRadioButton rb)
        {
            if (rb == rb_1) return lb_1;
            if (rb == rb_2) return lb_2;
            if (rb == rb_3) return lb_3;
            if (rb == rb_4) return lb_4;
            if (rb == rb_5) return lb_5;
            if (rb == rb_6) return lb_6;
            if (rb == rb_7) return lb_7;
            if (rb == rb_8) return lb_8;
            if (rb == rb_9) return lb_9;
            return null;
        }

        private int GetPositionFromRadioButton(Guna2CustomRadioButton rb)
        {
            // Asigna cada RadioButton a un número específico
            if (rb == rb_1) return 1;
            if (rb == rb_2) return 2;
            if (rb == rb_3) return 3;
            if (rb == rb_4) return 4;
            if (rb == rb_5) return 5;
            if (rb == rb_6) return 6;
            if (rb == rb_7) return 7;
            if (rb == rb_8) return 8;
            if (rb == rb_9) return 9;
            return 0; // Default o en caso de error
        }

        private void panel_central_Paint(object sender, PaintEventArgs e)
        {
            if (selectedRadioButtons.Count < 2) return;

            using (Pen pen = new Pen(Color.Red, 2))
            {
                for (int i = 0; i < selectedRadioButtons.Count - 1; i++)
                {
                    Point start = selectedRadioButtons[i].Parent.Location;
                    Point end = selectedRadioButtons[i + 1].Parent.Location;
                    // Ajusta las coordenadas para dibujar desde el centro de los RadioButtons
                    start.Offset(selectedRadioButtons[i].Width / 2, selectedRadioButtons[i].Height / 2);
                    end.Offset(selectedRadioButtons[i + 1].Width / 2, selectedRadioButtons[i + 1].Height / 2);
                    e.Graphics.DrawLine(pen, start, end);
                }
            }
        }

        private void HandleRadioButtonChange(Guna2CustomRadioButton rb, Label lb)
        {
            // Determinar el número de posición del RadioButton basado en su nombre
            int position = GetPositionFromRadioButton(rb);

            if (rb.Checked)
            {
                lb.Text = position.ToString();
                if (!orden.Contains(position)) // Asegúrate de no agregar duplicados
                {
                    orden.Add(position);
                }
            }
            else
            {
                lb.Text = string.Empty;
                lb.Visible = false;
                orden.Remove(position); // Eliminar el orden correspondiente
            }
        }

        #endregion

        private void frmVerPatron_Load(object sender, EventArgs e)
        {
            // Aplicar el tema guardado
            if (Properties.Settings.Default.TemaOscuro)
            {
                CargarTemaOscuro();
            }
            else
            {
                CargarTemaClaro();
            }
        }
    }
}
