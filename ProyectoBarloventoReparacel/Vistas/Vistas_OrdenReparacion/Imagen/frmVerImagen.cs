using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Imagen
{
    public partial class frmVerImagen : Form
    {
        private bool isResizing = false;
        private Point lastCursorPosition;
        private const int borderSize = 10; // Tamaño del borde de redimensionamiento
        public frmVerImagen(byte[] imagen)
        {
            InitializeComponent();
            MostrarImagen(imagen);
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            this.MouseDown += new MouseEventHandler(frmVerImagen_MouseDown);
            this.MouseMove += new MouseEventHandler(frmVerImagen_MouseMove);
            this.MouseUp += new MouseEventHandler(frmVerImagen_MouseUp);
          
        }





        #region Metodos auxiliares
        private void MostrarImagen(byte[] imagen)
        {
            // Convertir el byte[] en una imagen y asignarla al PictureBox
            using (MemoryStream ms = new MemoryStream(imagen))
            {
                pb_imagen.Image = Image.FromStream(ms);
            }


            // Ajustar el modo de tamaño del PictureBox para que se adapte al tamaño actual
            pb_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void frmVerImagen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isResizing = false;
            }
        }

        private void frmVerImagen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.X >= this.Width - borderSize && e.Y >= this.Height - borderSize)
                {
                    isResizing = true;
                    lastCursorPosition = e.Location;
                }
            }
        }

        private void frmVerImagen_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int newWidth = this.Width + (e.X - lastCursorPosition.X);
                int newHeight = this.Height + (e.Y - lastCursorPosition.Y);

                this.Size = new Size(newWidth, newHeight);

                lastCursorPosition = e.Location;
            }
            else
            {
                // Cambiar el cursor cuando está cerca del borde del formulario
                if (e.X >= this.Width - borderSize && e.Y >= this.Height - borderSize)
                {
                    this.Cursor = Cursors.SizeNWSE;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        public void CargarTemaClaro()
        {
            this.BackColor = Color.FromArgb(64, 83, 76);
            this.lb_titulo.ForeColor = Color.White;
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
        }

        public void CargarTemaOscuro()
        {
            this.BackColor = Color.Black;
            this.lb_titulo.ForeColor = Color.DimGray;
            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
        }


        private void frmVerImagen_Load(object sender, EventArgs e)
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
    #endregion
}

