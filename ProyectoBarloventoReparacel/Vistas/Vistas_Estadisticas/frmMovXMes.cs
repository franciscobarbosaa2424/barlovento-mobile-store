using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_Estadisticas
{
    public partial class frmMovXMes : Form
    {
        public frmMovXMes()
        {
            InitializeComponent();
        }

        private void frmMovXMes_Load(object sender, EventArgs e)
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

        public void cargarGraficaMovimientosPorMes(int año)
        {
            Conexion conexion = new Conexion();
            grafica_movimientos.Series[0].Points.Clear();
            grafica_movimientos.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Color de fondo oscuro

            // Cambiar a gráfico de líneas
            grafica_movimientos.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            // Consulta SQL modificada para obtener los movimientos del año seleccionado
            string consultaMovimientosPorMes = @"
    WITH UltimosMeses AS (
        SELECT TOP 12 MONTH(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Mes, YEAR(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Año
        FROM (VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11)) AS T(n)
        ORDER BY n
    )
    SELECT U.Mes, ISNULL(SUM(M.monto), 0) AS Total
    FROM UltimosMeses U
    LEFT JOIN MOVIMIENTOS M ON U.Mes = MONTH(M.fecha) AND U.Año = YEAR(M.fecha)
    WHERE U.Año = @año
    GROUP BY U.Mes
    ORDER BY U.Mes";

            // Reemplazar el parámetro del año
            consultaMovimientosPorMes = consultaMovimientosPorMes.Replace("@año", año.ToString());

            DataSet ds = (DataSet)conexion.Selección(consultaMovimientosPorMes);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int mes = Convert.ToInt32(row["Mes"]);
                    decimal total = Convert.ToDecimal(row["Total"]);

                    // Convertir el número de mes a nombre del mes (en español)
                    string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                    grafica_movimientos.Series[0].Points.AddXY(nombreMes, total);
                }
            }

            // Configuración de la apariencia de la gráfica
            grafica_movimientos.Series[0].Font = new Font("Segoe UI", 8, FontStyle.Regular);
            grafica_movimientos.Series[0].LabelForeColor = Color.DimGray; // Color de las etiquetas de las líneas
            grafica_movimientos.Legends[0].BackColor = Color.Transparent;
            grafica_movimientos.Legends[0].ForeColor = Color.DimGray;
            grafica_movimientos.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // Mostrar etiquetas de los valores
            grafica_movimientos.Series[0].IsValueShownAsLabel = true;

            // Configurar el intervalo de etiquetas del eje X para que se muestren todos los meses
            grafica_movimientos.ChartAreas[0].AxisX.Interval = 1;
            grafica_movimientos.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray; // Color de los meses
            grafica_movimientos.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;
            grafica_movimientos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            grafica_movimientos.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            grafica_movimientos.ChartAreas[0].AxisY.LineColor = Color.DimGray;
            grafica_movimientos.ChartAreas[0].AxisX.LineColor = Color.DimGray;

            // Configurar color de la línea
            grafica_movimientos.Series[0].Color = Color.DodgerBlue;

            // Configurar los ejes para que no muestren las marcas (tick marks)
            grafica_movimientos.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.DimGray;
            grafica_movimientos.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.DimGray;

            // Deshabilitar la leyenda
            grafica_movimientos.Legends[0].Enabled = false;
        }

        public void CargarTemaClaro()
        {
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.grafica_movimientos.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.grafica_movimientos.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            this.grafica_movimientos.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.White;
            this.grafica_movimientos.ChartAreas[0].AxisY.MinorTickMark.LineColor = Color.White;
            this.grafica_movimientos.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.White;
            this.grafica_movimientos.ChartAreas[0].AxisX.MinorTickMark.LineColor = Color.White;

            this.grafica_movimientos.Series[0].LabelForeColor = Color.White;
            this.grafica_movimientos.ChartAreas[0].BackColor = Color.FromArgb(95, 111, 101);

            this.grafica_movimientos.ChartAreas[0].AxisY.LineColor = Color.White;
            this.grafica_movimientos.ChartAreas[0].AxisX.LineColor = Color.White;

            this.grafica_movimientos.Legends[0].ForeColor = Color.White;
            this.lb_titulo.ForeColor = Color.White;

        }

        public void CargarTemaOscuro()
        {

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.BackColor = Color.Black;
            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.lb_titulo.ForeColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;
           this.grafica_movimientos.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].AxisY.MinorTickMark.LineColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].AxisX.MinorTickMark.LineColor = Color.DimGray;

            this.grafica_movimientos.Series[0].LabelForeColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].BackColor = Color.FromArgb(18, 18, 18);
            this.grafica_movimientos.ChartAreas[0].AxisY.LineColor = Color.DimGray;
            this.grafica_movimientos.ChartAreas[0].AxisX.LineColor = Color.DimGray;

           this.grafica_movimientos.Legends[0].ForeColor = Color.DimGray;

           
        }
    }
}
