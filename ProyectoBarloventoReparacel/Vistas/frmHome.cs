using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Properties;
using ProyectoBarloventoReparacel.Vistas.Vistas_Estadisticas;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoBarloventoReparacel.Vistas
{
    public partial class frmHome : Form
    {
        private string tema;
        public frmHome()
        {
            InitializeComponent();
            // Configurar el formato personalizado para mostrar solo el año
            dtp_año.Format = DateTimePickerFormat.Custom;
            dtp_año_2.Format = DateTimePickerFormat.Custom;
            dtp_año_3.Format = DateTimePickerFormat.Custom;
            dtp_año_4.Format = DateTimePickerFormat.Custom;

            dtp_año.CustomFormat = "yyyy";
            dtp_año_2.CustomFormat = "yyyy";
            dtp_año_3.CustomFormat = "yyyy";
            dtp_año_4.CustomFormat = "yyyy";

            // Deshabilitar la selección de días y meses
            dtp_año.ShowUpDown = true; // Esto desactiva el calendario desplegable
            dtp_año_2.ShowUpDown = true; // Esto desactiva el calendario desplegable
            dtp_año_3.ShowUpDown = true; // Esto desactiva el calendario desplegable
            dtp_año_4.ShowUpDown = true; // Esto desactiva el calendario desplegable

            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };

            DataGridViewImageColumn columnaOrdenesDeReparacion = new DataGridViewImageColumn
            {
                Name = "btnEstado",
                HeaderText = " ",
                Width = 10,
                Image = Properties.Resources.icono_estado_terminado

            };
            dtgv_ordenes.Columns.Add(columnaOrdenesDeReparacion);

        }

        #region Metodos auxiliares
        #endregion

      

        private void cargarGrafica()
        {
            Conexion conexion = new Conexion();
            grafica_todo.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Ejemplo de un color oscuro


            // Consulta para obtener el total de clientes
            string consultaClientes = "SELECT COUNT(*) FROM CLIENTE";
            DataSet ds = (DataSet)conexion.Selección(consultaClientes);
            int totalClientes = 0;

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                totalClientes = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }

            // Consulta para obtener el total de dispositivos
            string consultaDispositivos = "SELECT COUNT(*) FROM DISPOSITIVO_CLIENTE";
            DataSet ds2 = (DataSet)conexion.Selección(consultaDispositivos);
            int totalDispositivos = 0;

            if (ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
            {
                totalDispositivos = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
            }

            // Consulta para obtener el total de dispositivos
            string consultaOrdenes = "SELECT COUNT(*) FROM ORDEN_DE_REPARACION";
            DataSet ds3 = (DataSet)conexion.Selección(consultaOrdenes);
            int totalOrdenes = 0;

            if (ds3.Tables.Count > 0 && ds3.Tables[0].Rows.Count > 0)
            {
                totalOrdenes = Convert.ToInt32(ds3.Tables[0].Rows[0][0]);
            }

            // Configurar el gráfico
            grafica_todo.Series[0].Points.Clear(); // Limpiar puntos anteriores
            grafica_todo.Series[0].Font = new Font("Segoe UI", 10, FontStyle.Regular);
            grafica_todo.Series[0].LabelForeColor = Color.White;
           
            // Crear y agregar puntos al gráfico
            grafica_todo.Series[0].Points.AddXY("Clientes", totalClientes);
            grafica_todo.Series[0].Points.AddXY("Dispositivos", totalDispositivos);
            grafica_todo.Series[0].Points.AddXY("Ordenes", totalOrdenes);
            grafica_todo.Legends[0].BackColor = Color.Transparent;
            grafica_todo.Legends[0].ForeColor = Color.DimGray;
            grafica_todo.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);


            // Configurar etiquetas de datos
            grafica_todo.Series[0].IsValueShownAsLabel = true;
        }

        private void cargarGraficaClientes()
        {
            Conexion conexion = new Conexion();
            grafica_clientes.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Ejemplo de un color oscuro

            // Consulta para obtener el total de clientes
            string consultaEmpresas = "SELECT COUNT(*) FROM CLIENTE WHERE TIPO_CLIENTE = 'EMPRESA'";
            DataSet ds = (DataSet)conexion.Selección(consultaEmpresas);
            int totalEmpresas = 0;

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                totalEmpresas = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }

            string consultaPersonas = "SELECT COUNT(*) FROM CLIENTE WHERE TIPO_CLIENTE = 'PERSONA'";
            DataSet ds2 = (DataSet)conexion.Selección(consultaPersonas);
            int totalPersonas = 0;

            if (ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
            {
                totalPersonas = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
            }

            grafica_clientes.Series[0].Points.Clear(); // Limpiar puntos anteriores

            // Crear y agregar puntos al gráfico
            grafica_clientes.Series[0].Points.AddXY("Empresas", totalEmpresas);
            grafica_clientes.Series[0].Points.AddXY("Personas", totalPersonas);
            grafica_clientes.Legends[0].BackColor = Color.Transparent;
            grafica_clientes.Legends[0].ForeColor = Color.DimGray;
            grafica_clientes.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);
            // Configurar etiquetas de datos
            grafica_clientes.Series[0].IsValueShownAsLabel = true;
            grafica_clientes.Series[0].LabelForeColor = Color.White;

        }

        private void cargarGraficaOrdenesPorEstadoHoy()
        {
            Conexion conexion = new Conexion();
            graficaEstadoHoy.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40); // Color de fondo oscuro

            // Consulta SQL para obtener el total de órdenes por estado para hoy
            string consultaEstadoHoy = @"
        SELECT estado, COUNT(*) AS TotalOrdenes
        FROM ORDEN_DE_REPARACION
        WHERE CAST(fechaIngreso AS DATE) = CAST(GETDATE() AS DATE)
        GROUP BY estado";

            DataSet dsEstadoHoy = (DataSet)conexion.Selección(consultaEstadoHoy);

            // Limpiar puntos anteriores en la gráfica
            graficaEstadoHoy.Series[0].Points.Clear();

            if (dsEstadoHoy.Tables.Count > 0 && dsEstadoHoy.Tables[0].Rows.Count > 0)
            {
                // Crear y agregar puntos a la gráfica
                foreach (DataRow row in dsEstadoHoy.Tables[0].Rows)
                {
                    string estado = row["estado"].ToString();
                    int totalOrdenes = Convert.ToInt32(row["TotalOrdenes"]);
                    graficaEstadoHoy.Series[0].Points.AddXY(estado, totalOrdenes);
                }
            }
            else
            {
                // Si no hay órdenes para hoy, mostrar un mensaje en la gráfica
                graficaEstadoHoy.Series[0].Points.AddXY("Sin órdenes", 0);
            }

            // Configurar leyenda y etiquetas
            graficaEstadoHoy.Legends[0].BackColor = Color.Transparent;
            graficaEstadoHoy.Legends[0].ForeColor = Color.DimGray;
            graficaEstadoHoy.Legends[0].Font = new Font("Segoe UI", 8, FontStyle.Bold);
            graficaEstadoHoy.Series[0].IsValueShownAsLabel = true; // Mostrar valores en las barras
        }




        public void CargarOrdenes()
        {
            dtgv_ordenes.RowTemplate.Height = 40;
            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            string consulta = @"
    SELECT 
        ODR.idOrden AS IdOrden,
        ODR.fechaIngreso AS FechaIngreso,
        ODR.fechaEgreso AS FechaEgreso,
        ODR.estado AS Estado,
        DATEDIFF(HOUR, ODR.fechaIngreso, ODR.fechaEgreso) AS HorasTotales
    FROM 
        ORDEN_DE_REPARACION ODR
    WHERE 
        ODR.estado = 'Terminado';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];

            // Agregar columna para horas laborales en el DataTable
            dt.Columns.Add("HorasLaborales", typeof(string));

            // Calcular horas laborales para cada fila
            foreach (DataRow row in dt.Rows)
            {
                DateTime fechaIngreso;
                DateTime fechaEgreso;

                // Verificar si las fechas son DBNull antes de convertir
                if (row["FechaIngreso"] != DBNull.Value)
                {
                    fechaIngreso = Convert.ToDateTime(row["FechaIngreso"]);
                }
                else
                {
                    // Maneja el caso cuando fechaIngreso es nulo
                    fechaIngreso = DateTime.MinValue; // O maneja como prefieras
                }

                if (row["FechaEgreso"] != DBNull.Value)
                {
                    fechaEgreso = Convert.ToDateTime(row["FechaEgreso"]);
                }
                else
                {
                    // Maneja el caso cuando fechaEgreso es nulo
                    fechaEgreso = DateTime.MinValue; // O maneja como prefieras
                }

                // Solo calcular horas laborales si ambas fechas son válidas
                if (fechaIngreso != DateTime.MinValue && fechaEgreso != DateTime.MinValue)
                {
                    int horasLaborales = CalcularHorasLaborales(fechaIngreso, fechaEgreso);
                    row["HorasLaborales"] = horasLaborales.ToString() + " hrs";
                }
                else
                {
                    row["HorasLaborales"] = "N/A"; // O un valor predeterminado
                }
            }

            dtgv_ordenes.DataSource = dt;

            // Configurar columnas
            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Orden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 1;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["HorasTotales"].HeaderText = "Horas Totales";
            dtgv_ordenes.Columns["HorasTotales"].DisplayIndex = 3;

            dtgv_ordenes.Columns["HorasLaborales"].HeaderText = "Horas Laborales";
            dtgv_ordenes.Columns["HorasLaborales"].DisplayIndex = 4;

            dtgv_ordenes.Columns["Estado"].HeaderText = "Estado";
            dtgv_ordenes.Columns["Estado"].DisplayIndex = 5;
            dtgv_ordenes.Columns["Estado"].Width = 86;
            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 6;
            dtgv_ordenes.Columns["btnEstado"].Width = 30;
        }

        public int CalcularHorasLaborales(DateTime fechaIngreso, DateTime fechaEgreso)
        {
            // Definir los horarios laborales
            TimeSpan inicioLunesViernes = new TimeSpan(8, 30, 0); // 8:30 AM
            TimeSpan finLunesViernes = new TimeSpan(18, 0, 0); // 6:00 PM
            TimeSpan inicioSabado = new TimeSpan(9, 0, 0); // 9:00 AM
            TimeSpan finSabado = new TimeSpan(13, 0, 0); // 1:00 PM

            int totalHorasLaborales = 0;

            // Iterar sobre cada día entre la fecha de ingreso y la fecha de egreso
            for (DateTime diaActual = fechaIngreso.Date; diaActual <= fechaEgreso.Date; diaActual = diaActual.AddDays(1))
            {
                if (diaActual.DayOfWeek == DayOfWeek.Saturday)
                {
                    // Horario laboral del sábado
                    totalHorasLaborales += CalcularHorasDia(fechaIngreso, fechaEgreso, diaActual, inicioSabado, finSabado);
                }
                else if (diaActual.DayOfWeek >= DayOfWeek.Monday && diaActual.DayOfWeek <= DayOfWeek.Friday)
                {
                    // Horario laboral de lunes a viernes
                    totalHorasLaborales += CalcularHorasDia(fechaIngreso, fechaEgreso, diaActual, inicioLunesViernes, finLunesViernes);
                }
            }

            return totalHorasLaborales;
        }

        private int CalcularHorasDia(DateTime fechaIngreso, DateTime fechaEgreso, DateTime diaActual, TimeSpan inicioJornada, TimeSpan finJornada)
        {
            DateTime inicioDia = diaActual.Date + inicioJornada;
            DateTime finDia = diaActual.Date + finJornada;

            // Si el día está fuera del rango de la orden, ajustamos los tiempos
            if (diaActual == fechaIngreso.Date)
            {
                inicioDia = fechaIngreso > inicioDia ? fechaIngreso : inicioDia;
            }
            if (diaActual == fechaEgreso.Date)
            {
                finDia = fechaEgreso < finDia ? fechaEgreso : finDia;
            }

            // Si el inicio del día es mayor que el fin, no se cuentan horas de ese día
            if (inicioDia >= finDia)
            {
                return 0;
            }

            return (int)(finDia - inicioDia).TotalHours;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            cargarTiempoPromedio();
            cargarTiempoPromedioLaboral();
            cargarGrafica();
            CargarOrdenes();
            cargarGraficaClientes();
            this.dtgv_ordenes.CellFormatting += new DataGridViewCellFormattingEventHandler(dtgv_ordenes_CellFormatting);

            cargarGraficaOrdenesPorEstadoHoy();
            //cargarGraficaOrdenes6Meses();

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
        private void cargarTiempoPromedioLaboral()
        {
            Conexion conexion = new Conexion();

            // Consulta SQL para obtener las fechas de ingreso y egreso de cada orden completada
            string consultaDuracion = @"
        SELECT fechaIngreso, fechaEgreso 
        FROM ORDEN_DE_REPARACION 
        WHERE fechaEgreso IS NOT NULL";

            DataSet dsDuracion = (DataSet)conexion.Selección(consultaDuracion);

            if (dsDuracion.Tables.Count > 0 && dsDuracion.Tables[0].Rows.Count > 0)
            {
                double totalMinutosLaborales = 0;
                int totalOrdenesCompletadas = dsDuracion.Tables[0].Rows.Count;

                // Recorrer cada orden y calcular el tiempo laboral
                foreach (DataRow row in dsDuracion.Tables[0].Rows)
                {
                    DateTime fechaIngreso = Convert.ToDateTime(row["fechaIngreso"]);
                    DateTime fechaEgreso = Convert.ToDateTime(row["fechaEgreso"]);

                    // Calcular minutos laborales entre las dos fechas
                    totalMinutosLaborales += CalcularMinutosLaborales(fechaIngreso, fechaEgreso);
                }

                // Calcular el promedio de minutos laborales
                double promedioMinutosLaborales = totalMinutosLaborales / totalOrdenesCompletadas;

                // Convertir el promedio en días y horas
                int promedioDias = (int)(promedioMinutosLaborales / 570); // 570 minutos laborales por día (9.5 horas)
                int promedioHoras = (int)((promedioMinutosLaborales % 570) / 60); // Restantes horas laborales

                // Mostrar el tiempo promedio en el Label
                lb_tiempo_laboral.Text = $"Promedio (laboral): {promedioDias}días {promedioHoras}hrs";
                ;
            }
            else
            {
                // Si no hay órdenes completadas, mostrar un mensaje por defecto
                lb_tiempo_laboral.Text = "No hay órdenes completadas aún.";
            }
        }


        // Método para calcular los minutos laborales entre dos fechas
        private double CalcularMinutosLaborales(DateTime fechaInicio, DateTime fechaFin)
        {
            double minutosLaborales = 0;

            // Iterar por cada día entre las dos fechas
            for (DateTime fechaActual = fechaInicio.Date; fechaActual <= fechaFin.Date; fechaActual = fechaActual.AddDays(1))
            {
                // Si es domingo, continuar
                if (fechaActual.DayOfWeek == DayOfWeek.Sunday) continue;

                DateTime inicioJornada, finJornada;

                // Definir horario según el día de la semana
                if (fechaActual.DayOfWeek == DayOfWeek.Saturday)
                {
                    inicioJornada = fechaActual.AddHours(9);    // Sábado 9:00
                    finJornada = fechaActual.AddHours(13);      // Sábado 13:00
                }
                else
                {
                    inicioJornada = fechaActual.AddHours(8.5);  // Lunes a Viernes 8:30
                    finJornada = fechaActual.AddHours(18);      // Lunes a Viernes 18:00
                }

                // Calcular el tiempo laborable para ese día
                DateTime inicioDia = (fechaActual == fechaInicio.Date) ? fechaInicio : inicioJornada;
                DateTime finDia = (fechaActual == fechaFin.Date) ? fechaFin : finJornada;

                // Solo contar el tiempo dentro del horario laboral
                if (inicioDia < inicioJornada) inicioDia = inicioJornada;
                if (finDia > finJornada) finDia = finJornada;

                if (inicioDia < finDia)
                {
                    minutosLaborales += (finDia - inicioDia).TotalMinutes;
                }
            }

            return minutosLaborales;
        }

        public void CargarTemaClaro()
        {
            this.dtgv_ordenes.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_ordenes.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_ordenes.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tema = "Claro";
            foreach (DataGridViewRow row in dtgv_ordenes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_ordenes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_clientes.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_estados.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_resumen_general.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_ordenes_hoy.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_promedio.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_promedio_laboral.FillColor = Color.FromArgb(128, 141, 124);

            this.lblTiempoPromedio.ForeColor = Color.White;
            this.lb_tiempo_laboral.ForeColor = Color.White;

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_opciones_menu.FillColor = Color.FromArgb(95, 111, 101);

            this.lb_barlovento.ForeColor = Color.White;
            this.lb_resumen_general.ForeColor = Color.White;
            this.lb_clientes.ForeColor = Color.White;
         
            this.lb_ordenes_hoy.ForeColor = Color.White;


            this.separator_clientes.FillColor = Color.White;
        
            this.separator_resumen_general.FillColor = Color.White;
            this.separator_ordenes_hoy.FillColor = Color.White;

            this.grafica_clientes.BackColor = Color.FromArgb(128, 141, 124);
            this.grafica_todo.BackColor = Color.FromArgb(128, 141, 124);
            this.graficaEstadoHoy.BackColor = Color.FromArgb(128, 141, 124);

            this.grafica_todo.Legends[0].ForeColor = Color.White;
            this.grafica_clientes.Legends[0].ForeColor = Color.White;
            this.graficaEstadoHoy.Legends[0].ForeColor = Color.White;

            this.grafica_todo.ChartAreas[0].BackColor = Color.FromArgb(128, 141, 124);
            this.grafica_clientes.ChartAreas[0].BackColor = Color.FromArgb(128, 141, 124);
            this.graficaEstadoHoy.ChartAreas[0].BackColor = Color.FromArgb(128, 141, 124);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.IconColor = Color.White;

            this.btn_inicio.Image = Resources.icono_inicio_menu_claro;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu_claro;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu_claro;
            this.btn_clientes.Image = Resources.icono_clientes_menu_claro;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu_claro;
            this.btn_movimientos.Image = Resources.icono_movimientos_claro;
            this.btn_ordenes_por_mes.Image = Resources.icono_estadisticas_claro;
            this.btn_ordenes_por_mes_terminadas.Image = Resources.icono_estadisticas_claro;
            this.btn_ordenes_por_mes_canceladas.Image = Resources.icono_estadisticas_claro;
            this.btn_movimientos_por_mes.Image = Resources.icono_estadisticas_claro;

            this.dtp_año.ForeColor = Color.White;
            this.dtp_año_2.ForeColor = Color.White;
            this.dtp_año_3.ForeColor = Color.White;
            this.dtp_año_4.ForeColor = Color.White;

            this.dtp_año.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_año_2.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_año_3.FillColor = Color.FromArgb(95, 111, 101);
            this.dtp_año_4.FillColor = Color.FromArgb(95, 111, 101);


            this.btn_inicio.ForeColor = Color.White;
            this.btn_ajustes.ForeColor = Color.White;
            this.btn_clientes.ForeColor = Color.White;
            this.btn_ordenes.ForeColor = Color.White;
            this.btn_dispositivos.ForeColor = Color.White;
            this.btn_ordenes_por_mes.ForeColor = Color.White;
            this.btn_ordenes_por_mes_terminadas.ForeColor = Color.White;
            this.btn_ordenes_por_mes_canceladas.ForeColor = Color.White;
            this.btn_movimientos_por_mes.ForeColor = Color.White;
            this.btn_movimientos.ForeColor = Color.White;
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
            this.btn_estado_cancelado.ForeColor = Color.White;
            this.btn_estado_en_proceso.ForeColor = Color.White;
            this.btn_estado_pendiente.ForeColor = Color.White;
            this.btn_estado_terminado.ForeColor = Color.White;
        }

        public void CargarTemaOscuro()
        {
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;
            this.BackColor = Color.Black;
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_clientes.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_estados.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_resumen_general.FillColor = Color.FromArgb(35, 36, 40);
           
            this.panel_ordenes_hoy.FillColor = Color.FromArgb(35, 36, 40);


            this.dtp_año.ForeColor = Color.Gray;
            this.dtp_año_2.ForeColor = Color.Gray;
            this.dtp_año_3.ForeColor = Color.Gray;
            this.dtp_año_4.ForeColor = Color.Gray;

            this.dtp_año.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_año_2.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_año_3.FillColor = Color.FromArgb(18, 18, 18);
            this.dtp_año_4.FillColor = Color.FromArgb(18, 18, 18);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_opciones_menu.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_promedio.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_promedio_laboral.FillColor = Color.FromArgb(35, 36, 40);

            this.lb_barlovento.ForeColor = Color.DimGray;
            this.lb_resumen_general.ForeColor = Color.DimGray;
            this.lb_clientes.ForeColor = Color.DimGray;
            this.lblTiempoPromedio.ForeColor = Color.DimGray;
            this.lb_tiempo_laboral.ForeColor = Color.DimGray;

            this.lb_ordenes_hoy.ForeColor = Color.DimGray;




            this.dtgv_ordenes.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_ordenes.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;




            foreach (DataGridViewRow row in dtgv_ordenes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_ordenes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);


            this.separator_clientes.FillColor = Color.DimGray;
        
            this.separator_resumen_general.FillColor = Color.DimGray;
            this.separator_ordenes_hoy.FillColor = Color.DimGray;

            this.grafica_clientes.BackColor = Color.FromArgb(35, 36, 40);
            this.grafica_todo.BackColor = Color.FromArgb(35, 36, 40);
            this.graficaEstadoHoy.BackColor = Color.FromArgb(35, 36, 40);

            this.grafica_todo.Legends[0].ForeColor = Color.DimGray;
            this.grafica_clientes.Legends[0].ForeColor = Color.DimGray;
            this.graficaEstadoHoy.Legends[0].ForeColor = Color.DimGray;

            this.grafica_todo.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40);
            this.grafica_clientes.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40);
            this.graficaEstadoHoy.ChartAreas[0].BackColor = Color.FromArgb(35, 36, 40);

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_cerrar_formulario.IconColor = Color.White;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.IconColor = Color.White;
            tema = "Oscuro";
            this.btn_inicio.Image = Resources.icono_inicio_menu;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu;
            this.btn_clientes.Image = Resources.icono_clientes_menu;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu;
            this.btn_movimientos.Image = Resources.icono_movimientos;
            this.btn_ordenes_por_mes.Image = Resources.icono_estadisticas;
            this.btn_ordenes_por_mes_terminadas.Image = Resources.icono_estadisticas;
            this.btn_ordenes_por_mes_canceladas.Image = Resources.icono_estadisticas;
            this.btn_movimientos_por_mes.Image = Resources.icono_estadisticas;

            this.btn_inicio.ForeColor = Color.Gray;
            this.btn_ajustes.ForeColor = Color.Gray;
            this.btn_clientes.ForeColor = Color.Gray;
            this.btn_ordenes.ForeColor = Color.Gray;
            this.btn_dispositivos.ForeColor = Color.Gray;
            this.btn_ordenes_por_mes.ForeColor = Color.Gray;
            this.btn_ordenes_por_mes_terminadas.ForeColor = Color.Gray;
            this.btn_ordenes_por_mes_canceladas.ForeColor = Color.Gray;
            this.btn_movimientos_por_mes.ForeColor = Color.Gray;
            this.btn_movimientos.ForeColor = Color.Gray;

            this.btn_estado_cancelado.ForeColor = Color.Gray;
            this.btn_estado_en_proceso.ForeColor = Color.Gray;
            this.btn_estado_pendiente.ForeColor = Color.Gray;
            this.btn_estado_terminado.ForeColor = Color.Gray;
        }

        private void cargarTiempoPromedio()
        {
            Conexion conexion = new Conexion();

            // Consulta SQL para obtener la duración en minutos de cada orden completada
            string consultaDuracion = @"
        SELECT DATEDIFF(minute, fechaIngreso, fechaEgreso) AS DuracionEnMinutos 
        FROM ORDEN_DE_REPARACION 
        WHERE fechaEgreso IS NOT NULL";

            DataSet dsDuracion = (DataSet)conexion.Selección(consultaDuracion);

            if (dsDuracion.Tables.Count > 0 && dsDuracion.Tables[0].Rows.Count > 0)
            {
                int sumaDuracionEnMinutos = 0;
                int totalOrdenesCompletadas = dsDuracion.Tables[0].Rows.Count;

                // Sumar todas las duraciones en minutos
                foreach (DataRow row in dsDuracion.Tables[0].Rows)
                {
                    sumaDuracionEnMinutos += Convert.ToInt32(row["DuracionEnMinutos"]);
                }

                // Calcular el promedio de minutos
                double promedioDuracionEnMinutos = (double)sumaDuracionEnMinutos / totalOrdenesCompletadas;

                // Convertir el promedio en días y horas
                int promedioDias = (int)(promedioDuracionEnMinutos / 1440); // 1440 minutos en un día
                int promedioHoras = (int)((promedioDuracionEnMinutos % 1440) / 60); // Restantes horas

                // Mostrar el tiempo promedio en el Label
                lblTiempoPromedio.Text = $"Promedio: {promedioDias} días {promedioHoras} hrs.";
            }
            else
            {
                // Si no hay órdenes completadas, mostrar un mensaje por defecto
                lblTiempoPromedio.Text = "No hay órdenes completadas aún.";
            }
        }

        #region Botones
        private void btn_dispositivos_Click(object sender, EventArgs e)
        {
            frmDispositivosHome frmDispositivosHome = new frmDispositivosHome();
            frmDispositivosHome.Show();
            this.Close();
        }

        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            frmClientesHome frmClientesHome = new frmClientesHome();
            frmClientesHome.Show();
            this.Close();
        }

        private void btn_ordenes_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            frmMovimientosHome frmMovimientosHome = new frmMovimientosHome();
            frmMovimientosHome.Show();
            this.Close();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void cntb_cerrar_formulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void btn_ajustes_Click_1(object sender, EventArgs e)
        {
            frmAjustes frmAjustes = new frmAjustes();
            frmAjustes.ShowDialog();
        }

      

        private void btn_ordenes_por_mes_Click_1(object sender, EventArgs e)
        {
            frmOrdXMes frmOrdXMes = new frmOrdXMes();
            // Verificar si el texto ingresado es un año válido
            int año;
            if (int.TryParse(dtp_año.Text, out año))
            {
                // Verificar si el año es mayor o igual a 2000
                if (año >= 2000)
                {
                    // Llamar al método cargarGraficaOrdenes12Meses con el año ingresado
                    frmOrdXMes.cargarGraficaOrdenes12Meses(año);
                    frmOrdXMes.ShowDialog();
                }
                else
                {
                    // Mostrar un mensaje si el año es menor a 2000
                    MessageBox.Show("Por favor ingrese un año mayor o igual a 2000.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un año válido.");
            }
        }

     

    

        private void btn_ordenes_por_mes_terminadas_Click(object sender, EventArgs e)
        {
            frmOrdXMes frmOrdXMes = new frmOrdXMes();
            // Verificar si el texto ingresado es un año válido
            int año;
            if (int.TryParse(dtp_año_3.Text, out año))
            {
                // Verificar si el año es mayor o igual a 2000
                if (año >= 2000)
                {
                    // Llamar al método cargarGraficaOrdenes12Meses con el año ingresado
                    frmOrdXMes.CargarGraficaOrdenesTerminadas12Meses(año);
                    frmOrdXMes.ShowDialog();
                }
                else
                {
                    // Mostrar un mensaje si el año es menor a 2000
                    MessageBox.Show("Por favor ingrese un año mayor o igual a 2000.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un año válido.");
            }
        }

        private void ordenes_por_mes_canceladas_Click(object sender, EventArgs e)
        {
            frmOrdXMes frmOrdXMes = new frmOrdXMes();
            // Verificar si el texto ingresado es un año válido
            int año;
            if (int.TryParse(dtp_año_4.Text, out año))
            {
                // Verificar si el año es mayor o igual a 2000
                if (año >= 2000)
                {
                    // Llamar al método cargarGraficaOrdenes12Meses con el año ingresado
                    frmOrdXMes.CargarGraficaOrdenesCanceladas12Meses(año);
                    frmOrdXMes.ShowDialog();
                }
                else
                {
                    // Mostrar un mensaje si el año es menor a 2000
                    MessageBox.Show("Por favor ingrese un año mayor o igual a 2000.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un año válido.");
            }
        }

        private void movimientos_por_mes_Click(object sender, EventArgs e)
        {
            frmMovXMes frmMovXMes = new frmMovXMes();
            // Verificar si el texto ingresado es un año válido
            int año;
            if (int.TryParse(dtp_año_2.Text, out año))
            {
                // Verificar si el año es mayor o igual a 2000
                if (año >= 2000)
                {
                    // Llamar al método cargarGraficaOrdenes12Meses con el año ingresado
                    frmMovXMes.cargarGraficaMovimientosPorMes(año);
                    frmMovXMes.ShowDialog();
                }
                else
                {
                    // Mostrar un mensaje si el año es menor a 2000
                    MessageBox.Show("Por favor ingrese un año mayor o igual a 2000.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un año válido.");
            }
        }

        private void btn_estado_terminado_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.CargarOrdenesTerminadas();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_estado_cancelado_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.CargarOrdenesCanceladas();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_estado_pendiente_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.CargarOrdenesPendientes();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void btn_estado_en_proceso_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.CargarOrdenesEnProceso();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

        private void dtgv_ordenes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                }
                else if (tema == "Oscuro")
                {
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }
    }
}
