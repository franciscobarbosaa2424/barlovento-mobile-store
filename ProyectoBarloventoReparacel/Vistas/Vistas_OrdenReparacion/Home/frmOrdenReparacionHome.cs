using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Properties;
using ProyectoBarloventoReparacel.Vistas.Vistas_Estadisticas;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.FacturarOrden;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Filtros;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Infn;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Informacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Modificar;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.WhatsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home
{
    public partial class frmOrdenReparacionHome : Form
    {
        private string tema;
        private string tipo_lista = "Todos";
        public frmOrdenReparacionHome()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            dtgv_ordenes.RowTemplate.Height = 40;
            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            #region Columnas datagrid
            DataGridViewImageColumn columnaOrdenesDeReparacion = new DataGridViewImageColumn
            {
                Name = "btnEstado",
                HeaderText = " ",
                Width = 10,
              
            };

            DataGridViewImageColumn masInformacion = new DataGridViewImageColumn
            {
                Name = "btnMasInformacion",
                HeaderText = " ",
                Width = 10,
                Image = Properties.Resources.icono_dtgv_informacion,
            };

            dtgv_ordenes.CellFormatting += new DataGridViewCellFormattingEventHandler(dtgv_ordenes_CellFormatting);

            dtgv_ordenes.Columns.Add(columnaOrdenesDeReparacion);
            dtgv_ordenes.Columns.Add(masInformacion);

            #endregion

            this.KeyPreview = true;
        }

  
        #region Metodos Auxiliares
        // Buscar una orden por Empresa, Persona o Dispositivo
        private void BuscarOrden(string pDato)
        {
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo
            WHERE (CL.RAZON_SOCIAL LIKE '%" + pDato.ToString() + "%'"
            + " OR DC.MARCA LIKE '%" + pDato.ToString() + "%'"
            + " OR CL.NOMBRE_COMPLETO LIKE '%" + pDato.ToString() + "%'"
            + " OR DC.MODELO LIKE '%" + pDato.ToString() + "%');";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        // Eliminar una orden de la base de datos
        private void EliminarOrden()
        {
            if (dtgv_ordenes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_ordenes.SelectedRows[0];
                int idOrden = Convert.ToInt32(filaSeleccionada.Cells["IdOrden"].Value);

                var resultado = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar esta orden de reparación? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    Conexion conexion = new Conexion();

                    if (OrdenTieneImagen(idOrden))
                    {
                        string consulta_imagen_orden = $"DELETE FROM Imagenes WHERE OrdenDeReparacionID = {idOrden}";
                        conexion.Selección(consulta_imagen_orden);
                    }

                    string consulta = $"DELETE FROM ORDEN_DE_REPARACION WHERE idOrden = {idOrden}";
                    conexion.Selección(consulta);

                    MessageBox.Show("La orden de reparación ha sido eliminada exitosamente.",
                        "Eliminación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    RecargarListaActual();
                }
            }
            else
            {
                MessageBox.Show(
                    "Por favor, selecciona una orden de reparación para eliminar.",
                    "Eliminar Orden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Identificar si una orden de reparación tiene imagenes para luego eliminarlas
        private bool OrdenTieneImagen(int idOrden)
        {
            int cantidad_imagenes = 0;
            string consulta_imagenes_orden = @"
                SELECT COUNT(*)
                FROM Imagenes
                WHERE OrdenDeReparacionID  =" + idOrden + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta_imagenes_orden);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                cantidad_imagenes = Convert.ToInt32(row[0]);
            }

            if (cantidad_imagenes > 0)
            {
                return true;
            }
            return false;
        }

        // Llamar al formulario para agregar una orden de reparación
        private void AgregarOrden()
        {
            frmAgregarOrdenReparacion frmAgregarOrdenReparacion = new frmAgregarOrdenReparacion();
            frmAgregarOrdenReparacion.Show();
        }

        // Llamar al formulario para modificar una orden de reparación
        public void ModificarOrden()
        {
            if (dtgv_ordenes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_ordenes.SelectedRows[0];
                int idOrden = Convert.ToInt32(filaSeleccionada.Cells["idOrden"].Value);
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells["ClienteId"].Value);
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["IdDispositivo"].Value);
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                string falla = Convert.ToString(filaSeleccionada.Cells["Falla"].Value);
                string estado = Convert.ToString(filaSeleccionada.Cells["Estado"].Value);


                frmModificarOrdenReparacion frmModificarOrdenReparacion = new frmModificarOrdenReparacion();
                frmModificarOrdenReparacion.CargarDatosDtgv(idOrden, idDispositivo, idCliente, tipo_cliente, falla, estado);
                frmModificarOrdenReparacion.Show();
            }
            else
            {
                MessageBox.Show(
                    "Por favor, selecciona una orden de reparación para modificar.",
                    "Modificar Orden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Imprimir la orden de reparación en formato PDF
        public void ImprimirOrden()
        {
            if (dtgv_ordenes.SelectedRows.Count > 0)
            {

                // Obtén el valor de la columna Estado
                DataGridViewRow filaSeleccionada = dtgv_ordenes.SelectedRows[0];
                string estado = Convert.ToString(filaSeleccionada.Cells["Estado"].Value);

                if (estado == "Terminado" || estado == "Cancelado")
                {
                    int idOrden = Convert.ToInt32(filaSeleccionada.Cells["IdOrden"].Value);
                    string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                    // Consulta para obtener los datos de la orden de reparación
                    string consulta = @"
                    SELECT 
                    ODR.idOrden AS IdOrden,
                    ODR.fechaIngreso AS FechaIngreso,
                    ODR.fechaEgreso AS FechaEgreso,
                    CL.NOMBRE_COMPLETO AS Cliente,
                    CL.CONTACTO_1 AS Contacto,
                    CL.DEPARTAMENTO + ', ' + CL.LOCALIDAD AS Direccion,
                    CL.RAZON_SOCIAL AS Empresa,
                    DC.MARCA AS Marca,
                    DC.TIPO_DISPOSITIVO AS TipoDispositivo,
                    DC.MODELO AS Modelo,
                    ODR.falla AS Falla,
                    ODR.estado AS Estado
                    FROM 
                    ORDEN_DE_REPARACION ODR
                    INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
                    INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo 
                    WHERE idOrden = " + idOrden + ";";

                    // Ejecutar la consulta y obtener los resultados
                    Conexion conexion = new Conexion();
                    DataSet ds = conexion.Selección(consulta);
                    DataTable dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        // Obtener la primera fila de datos
                        DataRow fila = dt.Rows[0];

                        // Configurar el SaveFileDialog para guardar el archivo PDF
                        SaveFileDialog dialogoGuardar = new SaveFileDialog();
                        dialogoGuardar.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy-HH-mm"));

                        if (dialogoGuardar.ShowDialog() == DialogResult.OK)
                        {
                            // Crear un archivo nuevo para el PDF
                            using (FileStream flujoArchivo = new FileStream(dialogoGuardar.FileName, FileMode.Create))
                            {
                                // Crear un nuevo documento PDF con tamaño A4 y márgenes
                                Document documentoPDF = new Document(PageSize.A4, 25, 25, 25, 25);
                                PdfWriter escritor = PdfWriter.GetInstance(documentoPDF, flujoArchivo);
                                documentoPDF.Open();

                                // Agregar una imagen (banner) al documento
                                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources.imagen_logo, System.Drawing.Imaging.ImageFormat.Png);
                                imagen.ScaleToFit(60, 60); // Escalar la imagen al tamaño adecuado
                                imagen.Alignment = iTextSharp.text.Image.UNDERLYING; // Posicionar detrás del texto
                                imagen.SetAbsolutePosition(documentoPDF.LeftMargin, documentoPDF.Top - 60); // Posición exacta
                                documentoPDF.Add(imagen); // Agregar la imagen al documento

                                // Construir el contenido HTML para el PDF usando una plantilla
                                string contenidoHTML = Properties.Resources.Plantilla.ToString();
                                contenidoHTML = contenidoHTML.Replace("@FECHAINGRESO", fila["FechaIngreso"].ToString());
                                contenidoHTML = contenidoHTML.Replace("@ORDEN", fila["IdOrden"].ToString());
                                if(tipo_cliente == "PERSONA")
                                {
                                    contenidoHTML = contenidoHTML.Replace("@NOMBRE", fila["Cliente"].ToString());
                                }
                                else
                                {
                                    contenidoHTML = contenidoHTML.Replace("@NOMBRE", fila["Empresa"].ToString());
                                }
                                contenidoHTML = contenidoHTML.Replace("@DIRECCION", fila["Direccion"].ToString());
                                contenidoHTML = contenidoHTML.Replace("@TELEFONO", fila["Contacto"].ToString());
                                contenidoHTML = contenidoHTML.Replace("@TIPOEQUIPO", fila["TipoDispositivo"].ToString());
                                contenidoHTML = contenidoHTML.Replace("@MODELO", fila["Modelo"].ToString());
                                contenidoHTML = contenidoHTML.Replace("@MARCA", fila["Marca"].ToString());
                                contenidoHTML = contenidoHTML.Replace("@FALLA", fila["Falla"].ToString());

                                // Convertir el contenido HTML en formato PDF
                                using (StringReader lectorHTML = new StringReader(contenidoHTML))
                                {
                                    XMLWorkerHelper.GetInstance().ParseXHtml(escritor, documentoPDF, lectorHTML);
                                }

                                // Cerrar el documento PDF y el flujo de archivo
                                documentoPDF.Close();
                                flujoArchivo.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Solo se pueden imprimir órdenes con estado 'Terminado' o 'Cancelado'.",
                    "Aviso de impresión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }

        // Llamar al formular para facturar una orden de reparación
        public void FacturarOrden()
        {
            if (dtgv_ordenes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_ordenes.SelectedRows[0];
                int id = Convert.ToInt32(filaSeleccionada.Cells["IdOrden"].Value);
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells["ClienteId"].Value);
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["IdDispositivo"].Value);
                string falla = Convert.ToString(filaSeleccionada.Cells["Falla"].Value);
                string estado = Convert.ToString(filaSeleccionada.Cells["Estado"].Value);
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                frmFacturarOrden frmFacturarOrden = new frmFacturarOrden();

                frmFacturarOrden.CargarDatosDtgv(idDispositivo, idCliente, tipo_cliente, id, estado, falla);
                frmFacturarOrden.Show();
            }
        }

        // LLamar al formulario para filtrar las órdenes de reparación
        public void FiltrosOrdenes()
        {
            frmFiltrosOrden frmFiltrosOrden = new frmFiltrosOrden();
            frmFiltrosOrden.ShowDialog();
        }

        // Filtrar las ordenes por fecha de ingreso
        public void FiltrarPorFechaIngreso(string pFechaDesde, string pFechaHasta)
        {
            tipo_lista = "Todos";
            dtgv_ordenes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo 
            WHERE FechaIngreso BETWEEN '" + pFechaDesde + "' AND '" + pFechaHasta + "';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        // Filtrar las ordenes por fecha de egreso
        public void FiltrarPorFechaEgreso(string pFechaDesde, string pFechaHasta)
        {
            tipo_lista = "Todos";
            dtgv_ordenes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo 
            WHERE FechaEgreso BETWEEN '" + pFechaDesde + "' AND '" + pFechaHasta + "';";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        // Filtrar las ordenes por estando En Proceso
        public void CargarOrdenesEnProceso()
        {
            tipo_lista = "En proceso";
            dtgv_ordenes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.total AS Total,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE estado = 'En proceso';";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;


            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";

            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 1;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";

            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 3;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 4;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 5;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;

            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Filtrar las ordenes por estando Terminado
        public void CargarOrdenesTerminadas()
        {
            tipo_lista = "Terminados";
            dtgv_ordenes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            ODR.total AS Total,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE estado = 'Terminado';";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";

            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 1;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";

            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 3;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 4;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 5;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;

            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Filtrar las ordenes por estando Pendiente
        public void CargarOrdenesPendientes()
        {
            tipo_lista = "Pendientes";
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            ODR.total AS Total,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE estado = 'Pendiente';";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            // Ajustar los encabezados de las columnas
            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";

            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 1;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";

            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 3;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 4;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 5;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 8;


            dtgv_ordenes.Columns["Total"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;

            dtgv_ordenes.RowTemplate.Height = 40;
            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Filtrar las ordenes por estando Cancelado
        public void CargarOrdenesCanceladas()
        {
            tipo_lista = "Cancelados";
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            CL.NOMBRE_COMPLETO AS Cliente,
            ODR.total AS Total,
            CL.ID AS ClienteId,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE estado = 'Cancelado';";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            // Ajustar los encabezados de las columnas
            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";

            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 1;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";

            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 3;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 4;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 5;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;

            dtgv_ordenes.RowTemplate.Height = 40;
            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Recargar la lista de ordenes actual
        private void RecargarListaActual()
        {
            if (tipo_lista == "Todos")
            {
                CargarOrdenes();
            }
            else if (tipo_lista == "Terminados")
            {
                CargarOrdenesTerminadas();
            }
            else if (tipo_lista == "Pendientes")
            {
                CargarOrdenesPendientes();
            }
            else if (tipo_lista == "En proceso")
            {
                CargarOrdenesEnProceso();
            }
            else if (tipo_lista == "Cancelados")
            {
                CargarOrdenesCanceladas();
            }
        }

        // Mostrar una orden especifica
        public void CargarOrden(int pIdOrden)
        {
            dtgv_ordenes.RowTemplate.Height = 40;
            tipo_lista = "Todos";
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE IdOrden = " + pIdOrden + ";";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        // Mostrar todas las ordenes 
        public void CargarOrdenes()
        {
            dtgv_ordenes.RowTemplate.Height = 40;
            tipo_lista = "Todos";
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo;";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        // Filtrar las ordenes por total ($)
        public void FiltrarPorTotal(int pTotalDesde, int pTotalHasta)
        {
            tipo_lista = "Todos";
            dtgv_ordenes.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL.NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo 
            WHERE Total BETWEEN " + pTotalDesde + " AND " + pTotalHasta + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        public void HistorialPropietarioDtgv(int pIdCliente, string pTipoCliente)
        {
            if (pTipoCliente == "PERSONA")
            {

                HistorialCliente(pIdCliente);
            }
            else if (pTipoCliente == "EMPRESA")
            {
                HistorialCliente(pIdCliente);
            }
        }

        public void MostrarDispositivosDtgv(int pIdDispositivo)
        {
            HistorialDispositivo(pIdDispositivo);
        }

        public void HistorialDispositivo(int pIdDispositivo)
        {
            tipo_lista = "Todos";
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            ODR.total AS Total,
            CL. NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE ODR.idDispositivo  = " + pIdDispositivo + ";";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        public void HistorialCliente(int pIdCliente)
        {
            tipo_lista = "Todos";
            string consulta = @"
            SELECT 
            ODR.idOrden AS IdOrden,
            ODR.fechaIngreso AS FechaIngreso,
            ODR.fechaEgreso AS FechaEgreso,
            CL. NOMBRE_COMPLETO AS Cliente,
            CL.ID AS ClienteId,
            CL.TIPO_CLIENTE AS TipoCliente,
            DC.MARCA + ' ' + DC.MODELO AS Dispositivo,
            CL.RAZON_SOCIAL AS RazonSocial,
            ODR.idDispositivo AS IdDispositivo,
            ODR.falla AS Falla,
            ODR.total AS Total,
            ODR.estado AS Estado
            FROM 
            ORDEN_DE_REPARACION ODR
            INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
            INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo WHERE CL.ID  = " + pIdCliente + ";";


            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_ordenes.DataSource = dt;

            dtgv_ordenes.Columns["IdOrden"].HeaderText = "Nro. Órden";
            dtgv_ordenes.Columns["IdOrden"].DisplayIndex = 0;

            dtgv_ordenes.Columns["TipoCliente"].DisplayIndex = 1;
            dtgv_ordenes.Columns["TipoCliente"].Visible = false;

            dtgv_ordenes.Columns["FechaIngreso"].HeaderText = "Fecha Ingreso";
            dtgv_ordenes.Columns["FechaIngreso"].DisplayIndex = 2;

            dtgv_ordenes.Columns["FechaEgreso"].HeaderText = "Fecha Egreso";
            dtgv_ordenes.Columns["FechaEgreso"].DisplayIndex = 3;

            dtgv_ordenes.Columns["ClienteId"].HeaderText = "Id Cliente";
            dtgv_ordenes.Columns["ClienteId"].Visible = false;
            dtgv_ordenes.Columns["ClienteId"].DisplayIndex = 4;

            dtgv_ordenes.Columns["IdDispositivo"].HeaderText = "Id Dispositivo";
            dtgv_ordenes.Columns["IdDispositivo"].Visible = false;
            dtgv_ordenes.Columns["IdDispositivo"].DisplayIndex = 5;

            dtgv_ordenes.Columns["RazonSocial"].HeaderText = "Empresa";
            dtgv_ordenes.Columns["RazonSocial"].DisplayIndex = 6;

            dtgv_ordenes.Columns["Cliente"].HeaderText = "Persona";
            dtgv_ordenes.Columns["Cliente"].DisplayIndex = 7;

            dtgv_ordenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dtgv_ordenes.Columns["Dispositivo"].DisplayIndex = 8;

            dtgv_ordenes.Columns["Falla"].HeaderText = "Falla";
            dtgv_ordenes.Columns["Falla"].DisplayIndex = 9;

            dtgv_ordenes.Columns["Total"].DisplayIndex = 10;
            dtgv_ordenes.Columns["Total"].HeaderText = "Total ($)";

            dtgv_ordenes.Columns["Estado"].DisplayIndex = 11;
            dtgv_ordenes.Columns["Estado"].Width = 86;

            dtgv_ordenes.Columns["btnEstado"].DisplayIndex = 12;
            dtgv_ordenes.Columns["btnEstado"].Width = 17;
            dtgv_ordenes.Columns["btnMasInformacion"].Width = 50;
        }

        #endregion

        #region Eventos y validaciones TextBox
        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            // Buscar una orden dado un dato (Empresa, Persona o Dispositivo)
            string dato = "%" + tb_buscar.Text + "%";
            BuscarOrden(dato);

            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 100;

            // Verificamos si el texto ingresado supera el limite
            if (tb_buscar.Text.Length > maximo_caracteres)
            {
                tb_buscar.Text = tb_buscar.Text.Substring(0, maximo_caracteres);
                tb_buscar.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void frmOrdenReparacionHome_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    EliminarOrden();
                    e.Handled = true;
                    break;

                case Keys.F2:
                    AgregarOrden();
                    e.Handled = true;
                    break;

                case Keys.F3:
                    ModificarOrden();
                    e.Handled = true;
                    break;

                case Keys.F4:
                    ImprimirOrden();
                    e.Handled = true;
                    break;

                case Keys.F5:
                    FacturarOrden();
                    e.Handled = true;
                    break;

                case Keys.F6:
                    //FacturarOrden();
                    e.Handled = true;
                    break;

                case Keys.F7:
                    FiltrosOrdenes();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        private void dtgv_ordenes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna es la columna del estado
            if (dtgv_ordenes.Columns[e.ColumnIndex].Name == "btnEstado")
            {
                // Obtén el valor de la columna Estado
                string estado = dtgv_ordenes.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

                // Cambia la imagen dependiendo del estado
                if (estado == "Pendiente")
                {
                    e.Value = Properties.Resources.icono_estado_pendiente;
                }
                else if (estado == "Terminado")
                {
                    e.Value = Properties.Resources.icono_estado_terminado;
                }
                else if (estado == "Cancelado")
                {
                    e.Value = Properties.Resources.icono_estado_cancelado;
                }
                else
                {
                    e.Value = Properties.Resources.icono_estado_en_proceso;
                }
            }
        }

        private void dtgv_ordenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la columna es la del botón (btnInformacion)
            if (dtgv_ordenes.Columns[e.ColumnIndex].Name == "btnMasInformacion" && e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dtgv_ordenes.SelectedRows[0];
                int idOrden = Convert.ToInt32(filaSeleccionada.Cells["idOrden"].Value);
                int idCliente = Convert.ToInt32(filaSeleccionada.Cells["ClienteId"].Value);
                int idDispositivo = Convert.ToInt32(filaSeleccionada.Cells["IdDispositivo"].Value);
                string tipo_cliente = Convert.ToString(filaSeleccionada.Cells["TipoCliente"].Value);
                frmInfnOrden frmInfnOrden = new frmInfnOrden();
                frmInfnOrden.CargarFechasOrden(idOrden);
                frmInfnOrden.CargarDatosFacturacion(idOrden);
                frmInfnOrden.CargarFalla(idOrden);
                frmInfnOrden.MostrarDatosDtgv(idCliente, tipo_cliente, idDispositivo);
                frmInfnOrden.Show();
            }
        }

        #endregion

        #region Botones
        private void cntb_maximizar_formulario_Click(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void cntb_cerrar_formulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_whatsapp_Click(object sender, EventArgs e)
        {
            frmMensajeWhatsApp frmMensajeWhatsApp = new frmMensajeWhatsApp();
            frmMensajeWhatsApp.ShowDialog();
        }

        // Eliminar una orden de reparación
        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            EliminarOrden();
        }

        // Agregar una orden de reparación
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarOrden();
        }

        // Modificar una orden de reparación
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ModificarOrden();
        }

        // Imprimir una orden de reparación en formato pdf
        private void btn_pdf_Click(object sender, EventArgs e)
        {
            ImprimirOrden();
        }

        // Ordenar las órdenes de reparación de forma ascendente o descendente
        private void btn_orden_asc_desc_Click(object sender, EventArgs e)
        {
            if (btn_orden_asc_desc.Checked)
            {
                DataTable dt = (DataTable)dtgv_ordenes.DataSource;
                dt.DefaultView.Sort = "IdOrden DESC";
                dtgv_ordenes.DataSource = dt;
            }
            else
            {
                DataTable dt = (DataTable)dtgv_ordenes.DataSource;
                dt.DefaultView.Sort = "IdOrden ASC";
                dtgv_ordenes.DataSource = dt;
            }
        }

        // Facturar una orden de reparación
        private void btn_facturar_Click(object sender, EventArgs e)
        {
            FacturarOrden();
        }

        // Ordenar las ordenes mediante diferentes filtros
        private void btn_filtros_orden_Click(object sender, EventArgs e)
        {
            FiltrosOrdenes();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
            this.Close();
        }

        private void btn_dispositivos_Click(object sender, EventArgs e)
        {
            frmDispositivosHome frmDispositivosHome = new frmDispositivosHome();
            frmDispositivosHome.Show();
            this.Close();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            frmClientesHome frmClientes = new frmClientesHome();
            frmClientes.Show();
            this.Close();
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            frmMovimientosHome frmMovimientosHome = new frmMovimientosHome();
            frmMovimientosHome.Show();
            this.Close();
        }

        private void btn_ordenes_Click(object sender, EventArgs e)
        {
            frmOrdenReparacionHome frmOrdenReparacionHome = new frmOrdenReparacionHome();
            frmOrdenReparacionHome.Show();
            this.Close();
        }

   

        #endregion

        private void frmOrdenReparacionHome_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
            dtgv_ordenes.RowTemplate.Height = 40;
            dtgv_ordenes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgv_ordenes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
        public void CargarTemaClaro()
        {
            tema = "Claro";
            this.tb_buscar.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_buscar.ForeColor = Color.White;
            this.tb_buscar.FocusedState.ForeColor = Color.White;
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_buscar.PlaceholderForeColor = Color.White;


            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_opciones.FillColor = Color.FromArgb(128, 141, 124);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_opciones_menu.FillColor = Color.FromArgb(95, 111, 101);

            this.dtgv_ordenes.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_ordenes.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_ordenes.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_ordenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_ordenes.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_ordenes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.btn_inicio.Image = Resources.icono_inicio_menu_claro;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu_claro;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu_claro;
            this.btn_clientes.Image = Resources.icono_clientes_menu_claro;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu_claro;
            this.btn_movimientos.Image = Resources.icono_movimientos_claro;
        
            this.btn_modificar.Image = Resources.icono_modificar_claro;
            this.btn_pdf.Image = Resources.icono_pdf_claro;
            this.btn_whatsapp.Image = Resources.icono_whatsapp_claro;
            this.btn_generar_movimiento.Image = Resources.icono_facturar_claro;

            this.btn_inicio.ForeColor = Color.White;
            this.btn_ajustes.ForeColor = Color.White;
            this.btn_clientes.ForeColor = Color.White;
            this.btn_ordenes.ForeColor = Color.White;
            this.btn_dispositivos.ForeColor = Color.White;
           
            this.btn_movimientos.ForeColor = Color.White;
            
            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_maximizar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.lb_titulo.ForeColor = Color.White;
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_orden_asc_desc.Image = Resources.icono_orden_asc_desc_claro;
            this.btn_filtros_orden.ForeColor = Color.White;
            this.btn_filtros_orden.Image = Resources.icono_filtros_claro;
            this.btn_eliminar.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_agregar.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_whatsapp.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_pdf.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_modificar.FillColor = Color.FromArgb(128, 141, 124);
            this.btn_generar_movimiento.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.FillColor = Color.FromArgb(128, 141, 124);
            this.scrollbar.ThumbColor = Color.White;
            this.btn_eliminar.Image = Resources.icono_eliminar_claro;
            this.btn_agregar.Image = Resources.icono_agregar_claro;
        }

        public void CargarTemaOscuro()
        {
            tema = "Oscuro";
            this.tb_buscar.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.BorderColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.ForeColor = Color.FromArgb(125, 137, 149);
            this.tb_buscar.FocusedState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_buscar.PlaceholderForeColor = Color.Gray;

            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_opciones.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_orden_asc_desc.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_eliminar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_agregar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_pdf.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_whatsapp.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_modificar.FillColor = Color.FromArgb(35, 36, 40);
            this.btn_generar_movimiento.FillColor = Color.FromArgb(35, 36, 40);
            this.BackColor = Color.Black;

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;
            this.cntb_maximizar_formulario.FillColor = Color.Black;
            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);

            this.panel_opciones_menu_inicio.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_opciones_menu.FillColor = Color.FromArgb(18, 18, 18);

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

            this.lb_titulo.ForeColor = Color.DimGray;
            this.btn_inicio.Image = Resources.icono_inicio_menu;
            this.btn_ajustes.Image = Resources.icono_ajustes_menu;
            this.btn_dispositivos.Image = Resources.icono_dispositivos_menu;
            this.btn_clientes.Image = Resources.icono_clientes_menu;
            this.btn_ordenes.Image = Resources.icono_ordenes_menu;
            this.btn_movimientos.Image = Resources.icono_movimientos;
           
           
            this.btn_modificar.Image = Resources.icono_modificar;
            this.btn_pdf.Image = Resources.icono_pdf;
            this.btn_whatsapp.Image = Resources.icono_whatsapp;
            this.btn_generar_movimiento.Image = Resources.icono_facturar;
            this.btn_inicio.ForeColor = Color.Gray;
            this.btn_ajustes.ForeColor = Color.Gray;
            this.btn_clientes.ForeColor = Color.Gray;
            this.btn_ordenes.ForeColor = Color.Gray;
            this.btn_dispositivos.ForeColor = Color.Gray;
         
            this.btn_movimientos.ForeColor = Color.Gray;
            this.btn_orden_asc_desc.Image = Resources.icono_orden_asc_desc;
            this.btn_filtros_orden.ForeColor = Color.DimGray;
            this.btn_filtros_orden.Image = Resources.icono_filtros;
            this.scrollbar.FillColor = Color.FromArgb(35, 36, 40);
            this.scrollbar.ThumbColor = Color.DimGray;
            this.btn_eliminar.Image = Resources.icono_eliminar;
            this.btn_agregar.Image = Resources.icono_agregar;
        }


        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            frmAjustes frmAjustes = new frmAjustes();
            frmAjustes.ShowDialog();
        }

        private void dtgv_ordenes_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tema == "Claro")
                {
                    
                    if (dtgv_ordenes.Columns[e.ColumnIndex].Name == "btnMasInformacion")
                    {
                        e.Value = Properties.Resources.icono_dtgv_informacion_claro;
                    }
                    e.CellStyle.BackColor = Color.FromArgb(95, 111, 101); // Color de fondo
                    e.CellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139); // Color de selección
                    e.CellStyle.ForeColor = Color.White; // Color del texto
                }
                else if (tema == "Oscuro")
                {
                    if (dtgv_ordenes.Columns[e.ColumnIndex].Name == "btnMasInformacion")
                    {
                        e.Value = Properties.Resources.icono_dtgv_informacion;
                    }
                    e.CellStyle.BackColor = Color.FromArgb(18, 18, 18); // Color de fondo oscuro
                    e.CellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56); // Color de selección en modo oscuro
                    e.CellStyle.ForeColor = Color.Gray; // Color del texto en modo oscuro
                }
            }
        }
    }
}
