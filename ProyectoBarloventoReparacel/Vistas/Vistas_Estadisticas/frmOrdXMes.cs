using ProyectoBarloventoReparacel.Persistencia;
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
    public partial class frmOrdXMes : Form
    {
        public frmOrdXMes()
        {
            InitializeComponent();
        }

        private void frmOrdXMes_Load(object sender, EventArgs e)
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

        public void cargarGraficaOrdenes12Meses(int año)
        {
            Conexion conexion = new Conexion();
            grafica_ordenes.Series[0].Points.Clear();
            grafica_ordenes.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Color de fondo oscuro

            // Cambiar a gráfico de columnas (barras verticales)
            grafica_ordenes.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            // Consulta SQL modificada para obtener las órdenes del año seleccionado
            string consultaOrdenesPorMes = @"
    WITH UltimosMeses AS (
        SELECT TOP 12 MONTH(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Mes, YEAR(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Año
        FROM (VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11)) AS T(n)
        ORDER BY n
    )
    SELECT U.Mes, ISNULL(COUNT(O.fechaIngreso), 0) AS Cantidad
    FROM UltimosMeses U
    LEFT JOIN ORDEN_DE_REPARACION O ON U.Mes = MONTH(O.fechaIngreso) AND U.Año = YEAR(O.fechaIngreso)
    WHERE U.Año = @año
    GROUP BY U.Mes
    ORDER BY U.Mes";

            // Reemplazar el parámetro del año
            consultaOrdenesPorMes = consultaOrdenesPorMes.Replace("@año", año.ToString());


            DataSet ds = (DataSet)conexion.Selección(consultaOrdenesPorMes);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int mes = Convert.ToInt32(row["Mes"]);
                    int cantidad = Convert.ToInt32(row["Cantidad"]);

                    // Convertir el número de mes a nombre del mes (en español)
                    string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                    grafica_ordenes.Series[0].Points.AddXY(nombreMes, cantidad);
                }
            }

            // Configuración de la apariencia de la gráfica
            grafica_ordenes.Series[0].Font = new Font("Segoe UI", 8, FontStyle.Regular);
            grafica_ordenes.Series[0].LabelForeColor = Color.DimGray; // Color de las etiquetas de las barras
            grafica_ordenes.Legends[0].BackColor = Color.Transparent;
            grafica_ordenes.Legends[0].ForeColor = Color.DimGray;
            grafica_ordenes.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // Mostrar etiquetas de los valores
            grafica_ordenes.Series[0].IsValueShownAsLabel = true;

            // Configurar el intervalo de etiquetas del eje X para que se muestren todos los meses
            grafica_ordenes.ChartAreas[0].AxisX.Interval = 1;
            grafica_ordenes.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray; // Color de los meses
            grafica_ordenes.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            grafica_ordenes.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            grafica_ordenes.ChartAreas[0].AxisY.LineColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.LineColor = Color.DimGray;

            // Configurar color de las barras
            grafica_ordenes.Series[0].Color = Color.DodgerBlue;

            // Eliminar la línea negra al lado del mes
            grafica_ordenes.Series[0].BorderColor = Color.Transparent;

            // Configurar los ejes para que no muestren las marcas (tick marks)
            grafica_ordenes.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.DimGray;


            // Deshabilitar la leyenda
            grafica_ordenes.Legends[0].Enabled = false;
        }

        public void CargarGraficaOrdenesTerminadas12Meses(int año)
        {
            Conexion conexion = new Conexion();
            grafica_ordenes.Series[0].Points.Clear();
            grafica_ordenes.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Color de fondo oscuro

            // Cambiar a gráfico de columnas (barras verticales)
            grafica_ordenes.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Consulta SQL modificada para obtener las órdenes terminadas del año seleccionado
            string consultaOrdenesPorMes = @"
    WITH UltimosMeses AS (
        SELECT TOP 12 MONTH(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Mes, 
        YEAR(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Año
        FROM (VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11)) AS T(n)
        ORDER BY n
    )
    SELECT U.Mes, ISNULL(COUNT(O.fechaIngreso), 0) AS Cantidad
    FROM UltimosMeses U
    LEFT JOIN ORDEN_DE_REPARACION O ON U.Mes = MONTH(O.fechaIngreso) AND U.Año = YEAR(O.fechaIngreso)
    WHERE U.Año = @año AND O.ESTADO = 'Terminado'
    GROUP BY U.Mes
    ORDER BY U.Mes";

            // Reemplazar el parámetro del año
            consultaOrdenesPorMes = consultaOrdenesPorMes.Replace("@año", año.ToString());

            DataSet ds = (DataSet)conexion.Selección(consultaOrdenesPorMes);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int mes = Convert.ToInt32(row["Mes"]);
                    int cantidad = Convert.ToInt32(row["Cantidad"]);

                    // Convertir el número de mes a nombre del mes (en español)
                    string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                    grafica_ordenes.Series[0].Points.AddXY(nombreMes, cantidad);
                }
            }

            // Configuración de la apariencia de la gráfica
            grafica_ordenes.Series[0].Font = new Font("Segoe UI", 8, FontStyle.Regular);
            grafica_ordenes.Series[0].LabelForeColor = Color.DimGray; // Color de las etiquetas de las barras
            grafica_ordenes.Legends[0].BackColor = Color.Transparent;
            grafica_ordenes.Legends[0].ForeColor = Color.DimGray;
            grafica_ordenes.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // Mostrar etiquetas de los valores
            grafica_ordenes.Series[0].IsValueShownAsLabel = true;

            // Configurar el intervalo de etiquetas del eje X para que se muestren todos los meses
            grafica_ordenes.ChartAreas[0].AxisX.Interval = 1;
            grafica_ordenes.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray; // Color de los meses
            grafica_ordenes.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            grafica_ordenes.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            grafica_ordenes.ChartAreas[0].AxisY.LineColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.LineColor = Color.DimGray;

            // Configurar color de las barras
            grafica_ordenes.Series[0].Color = Color.DodgerBlue;

            // Eliminar la línea negra al lado del mes
            grafica_ordenes.Series[0].BorderColor = Color.Transparent;

            // Configurar los ejes para que no muestren las marcas (tick marks)
            grafica_ordenes.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.DimGray;

            // Deshabilitar la leyenda
            grafica_ordenes.Legends[0].Enabled = false;
        }
        public void CargarGraficaOrdenesCanceladas12Meses(int año)
        {
            Conexion conexion = new Conexion();
            grafica_ordenes.Series[0].Points.Clear();
            grafica_ordenes.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Color de fondo oscuro

            // Cambiar a gráfico de columnas (barras verticales)
            grafica_ordenes.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            // Consulta SQL modificada para obtener las órdenes terminadas del año seleccionado
            string consultaOrdenesPorMes = @"
    WITH UltimosMeses AS (
        SELECT TOP 12 MONTH(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Mes, 
        YEAR(DATEADD(MONTH, -n, DATEFROMPARTS(@año, 12, 1))) AS Año
        FROM (VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11)) AS T(n)
        ORDER BY n
    )
    SELECT U.Mes, ISNULL(COUNT(O.fechaIngreso), 0) AS Cantidad
    FROM UltimosMeses U
    LEFT JOIN ORDEN_DE_REPARACION O ON U.Mes = MONTH(O.fechaIngreso) AND U.Año = YEAR(O.fechaIngreso)
    WHERE U.Año = @año AND O.ESTADO = 'Cancelado'
    GROUP BY U.Mes
    ORDER BY U.Mes";

            // Reemplazar el parámetro del año
            consultaOrdenesPorMes = consultaOrdenesPorMes.Replace("@año", año.ToString());

            DataSet ds = (DataSet)conexion.Selección(consultaOrdenesPorMes);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int mes = Convert.ToInt32(row["Mes"]);
                    int cantidad = Convert.ToInt32(row["Cantidad"]);

                    // Convertir el número de mes a nombre del mes (en español)
                    string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
                    grafica_ordenes.Series[0].Points.AddXY(nombreMes, cantidad);
                }
            }

            // Configuración de la apariencia de la gráfica
            grafica_ordenes.Series[0].Font = new Font("Segoe UI", 8, FontStyle.Regular);
            grafica_ordenes.Series[0].LabelForeColor = Color.DimGray; // Color de las etiquetas de las barras
            grafica_ordenes.Legends[0].BackColor = Color.Transparent;
            grafica_ordenes.Legends[0].ForeColor = Color.DimGray;
            grafica_ordenes.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);

            // Mostrar etiquetas de los valores
            grafica_ordenes.Series[0].IsValueShownAsLabel = true;

            // Configurar el intervalo de etiquetas del eje X para que se muestren todos los meses
            grafica_ordenes.ChartAreas[0].AxisX.Interval = 1;
            grafica_ordenes.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray; // Color de los meses
            grafica_ordenes.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            grafica_ordenes.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            grafica_ordenes.ChartAreas[0].AxisY.LineColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.LineColor = Color.DimGray;

            // Configurar color de las barras
            grafica_ordenes.Series[0].Color = Color.DodgerBlue;

            // Eliminar la línea negra al lado del mes
            grafica_ordenes.Series[0].BorderColor = Color.Transparent;

            // Configurar los ejes para que no muestren las marcas (tick marks)
            grafica_ordenes.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.DimGray;
            grafica_ordenes.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.DimGray;

            // Deshabilitar la leyenda
            grafica_ordenes.Legends[0].Enabled = false;
        }


        public void CargarTemaClaro()
        {
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.grafica_ordenes.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.grafica_ordenes.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            this.grafica_ordenes.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.White;
            this.grafica_ordenes.ChartAreas[0].AxisY.MinorTickMark.LineColor = Color.White;
            this.grafica_ordenes.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.White;
            this.grafica_ordenes.ChartAreas[0].AxisX.MinorTickMark.LineColor = Color.White;

            this.grafica_ordenes.Series[0].LabelForeColor = Color.White;
            this.grafica_ordenes.ChartAreas[0].BackColor = Color.FromArgb(95, 111, 101);

            this.grafica_ordenes.ChartAreas[0].AxisY.LineColor = Color.White;
            this.grafica_ordenes.ChartAreas[0].AxisX.LineColor = Color.White;

            this.grafica_ordenes.Legends[0].ForeColor = Color.White;
            this.lb_titulo.ForeColor = Color.White;

        }

        public void CargarTemaOscuro()
        {

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.BackColor = Color.Black;
            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.lb_titulo.ForeColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisY.MinorTickMark.LineColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisX.MinorTickMark.LineColor = Color.DimGray;

            this.grafica_ordenes.Series[0].LabelForeColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].BackColor = Color.FromArgb(18, 18, 18);
            this.grafica_ordenes.ChartAreas[0].AxisY.LineColor = Color.DimGray;
            this.grafica_ordenes.ChartAreas[0].AxisX.LineColor = Color.DimGray;

            this.grafica_ordenes.Legends[0].ForeColor = Color.DimGray;


        }
    }
}
