using ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras;
using ProyectoBarloventoReparacel.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBarloventoReparacel.Persistencia;
using TheArtOfDevHtmlRenderer.Adapters;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades;
using ProyectoBarloventoReparacel.Dominio.Dominio_Entidades;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using Guna.UI2.WinForms;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.WhatsApp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.IO;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Agregar;

namespace ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.FacturarOrden
{
    public partial class frmFacturarOrden : Form
    {
        private string tema;
        int id_orden;
        public frmFacturarOrden()
        {
            Guna2ShadowForm sombra_formulario = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.Black
            };
            InitializeComponent();
            rb_uyu.Checked = true;
            tb_cotizacion.Visible = false; // Asegúrate de que el TextBox de cotización esté oculto inicialmente
            //ActualizarCotizacion("UYU");
            //ActualizarHabilitacionTextBox();// Realizar los cálculos iniciales usando pesos uruguayos
            dtp_egreso.Value = DateTime.Now;
            tb_precioManoDeObra.Text = "0.00";
            tb_precioMateriales.Text = "0.00";
            tb_precioPresupuesto.Text = "0.00";
            this.KeyPreview = true;

            #region Metodos Enter KeyPress
            this.tb_precioManoDeObra.KeyPress += new KeyPressEventHandler(tb_precioManoDeObra_KeyPress);
            this.tb_precioMateriales.KeyPress += new KeyPressEventHandler(tb_precioMateriales_KeyPress);
            this.tb_precioPresupuesto.KeyPress += new KeyPressEventHandler(tb_precioPresupuesto_KeyPress);
            this.tb_falla.KeyPress += new KeyPressEventHandler(tb_falla_KeyPress);
            this.btn_generar_movimiento.KeyPress += new KeyPressEventHandler(btn_facturar_KeyPress);
            this.cb_estado.KeyPress += new KeyPressEventHandler(cb_estado_KeyPress);
            #endregion

        }

        #region Metodos auxiliares
        private bool FaltanDatos()
        {
            // Comprobamos si hay algun TextBox vacio
            if (
                this.cb_estado.Text == "" 
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CargarDatosDtgv(int pDispositivoId, int pIdCliente, string pTipoCliente, int pOrdenId, string pEstado, string pFalla)
        {
            if (pTipoCliente == "PERSONA")
            {
                CargarDispositivo(pDispositivoId);
                CargarPersona(pIdCliente);
            }
            else if (pTipoCliente == "EMPRESA")
            {
                CargarDispositivo(pDispositivoId);
                CargarEmpresa(pIdCliente);
            }
            tb_falla.Text = pFalla.ToString();
            tb_cliente_id.Text = pIdCliente.ToString();
            tb_dispositivo_id.Text = pDispositivoId.ToString();
            id_orden = pOrdenId;
            cb_estado.Text = pEstado;
        }

        private void CargarDispositivo(int idDispositivo)
        {
            dtgv_dispositivo.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            dc.idDispositivo AS Id,
            dc.clienteId AS ClienteId,
            dc.TIPO_DISPOSITIVO AS TipoDispositivo,
            dc.MARCA AS Marca,
            dc.MODELO AS Modelo,
            dc.NUMERO_DE_SERIE AS NumeroDeSerie,
            dc.OBSERVACION AS Observacion,
            c.NOMBRE_COMPLETO AS Nombre,
            c.DOCUMENTO AS Documento,
            c.RUT as Rut,
            c.CORREO as Correo,
            c.LOCALIDAD AS Localidad,
            c.DEPARTAMENTO AS Departamento,
            c.CONTACTO_1 AS Contacto1,
            c.CONTACTO_2 AS Contacto2,
            c.TIPO_CLIENTE AS TipoCliente,
            c.RAZON_SOCIAL AS RazonSocial
            FROM 
            DISPOSITIVO_CLIENTE dc
            JOIN 
            CLIENTE c ON dc.clienteId = c.ID WHERE dc.idDispositivo =" + idDispositivo + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_dispositivo.DataSource = dt;


            dtgv_dispositivo.Columns["Id"].Visible = false;
            dtgv_dispositivo.Columns["Observacion"].Visible = false;
            dtgv_dispositivo.Columns["Nombre"].Visible = false;
            dtgv_dispositivo.Columns["RazonSocial"].Visible = false;
            dtgv_dispositivo.Columns["Correo"].Visible = false;
            dtgv_dispositivo.Columns["Rut"].Visible = false;
            dtgv_dispositivo.Columns["Localidad"].Visible = false;
            dtgv_dispositivo.Columns["Departamento"].Visible = false;
            dtgv_dispositivo.Columns["Contacto1"].Visible = false;
            dtgv_dispositivo.Columns["Contacto2"].Visible = false;
            dtgv_dispositivo.Columns["ClienteId"].Visible = false;
            dtgv_dispositivo.Columns["Documento"].Visible = false;
            dtgv_dispositivo.Columns["TipoCliente"].Visible = false;

            dtgv_dispositivo.Columns["TipoDispositivo"].HeaderText = "Tipo";
            dtgv_dispositivo.Columns["Marca"].HeaderText = "Marca";
            dtgv_dispositivo.Columns["Modelo"].HeaderText = "Modelo";
            dtgv_dispositivo.Columns["NumeroDeSerie"].HeaderText = "Nro. de Serie";
        }

        public void CargarEmpresa(int pIdCliente)
        {
            dtgv_propietario.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            RUT AS Rut,
            RAZON_SOCIAL AS RazonSocial,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            FECHA_AUD AS FechaRegistro,
            HORA_AUD AS HoraRegistro,
            CORREO AS Correo
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;

            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;


            dtgv_propietario.Columns["TipoCliente"].Visible = false;


            dtgv_propietario.Columns["FechaRegistro"].HeaderText = "Fecha de ing.";

            dtgv_propietario.Columns["FechaRegistro"].Visible = false;

            dtgv_propietario.Columns["HoraRegistro"].HeaderText = "Hora de ing.";

            dtgv_propietario.Columns["HoraRegistro"].Visible = false;

            dtgv_propietario.Columns["RazonSocial"].HeaderText = "Razon Social";


            dtgv_propietario.Columns["Rut"].HeaderText = "Rut";


            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";

            dtgv_propietario.Columns["Departamento"].Visible = false;

            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";

            dtgv_propietario.Columns["Localidad"].Visible = false;

            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto ";


            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";
            dtgv_propietario.Columns["Contacto2"].Visible = false;


            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";
        }

        public void CargarPersona(int pIdCliente)
        {
            dtgv_propietario.RowTemplate.Height = 40;
            string consulta = @"
            SELECT 
            ID AS Id,
            TIPO_CLIENTE AS TipoCliente,
            NOMBRE_COMPLETO AS NombreCompleto,
            DOCUMENTO AS Documento,
            LOCALIDAD AS Localidad,
            DEPARTAMENTO AS Departamento,
            CONTACTO_1 AS Contacto1,
            CONTACTO_2 AS Contacto2,
            CORREO AS Correo
            FROM CLIENTE WHERE Id = " + pIdCliente + ";";

            Conexion conexion = new Conexion();
            DataSet ds = conexion.Selección(consulta);
            DataTable dt = ds.Tables[0];
            dtgv_propietario.DataSource = dt;


            dtgv_propietario.Columns["Id"].HeaderText = "Id";
            dtgv_propietario.Columns["Id"].Visible = false;


            dtgv_propietario.Columns["TipoCliente"].HeaderText = "Tipo cliente";
            dtgv_propietario.Columns["TipoCliente"].Visible = false;


            dtgv_propietario.Columns["NombreCompleto"].HeaderText = "Nombre";


            dtgv_propietario.Columns["Documento"].HeaderText = "Documento";


            dtgv_propietario.Columns["Departamento"].HeaderText = "Departamento";

            dtgv_propietario.Columns["Departamento"].Visible = false;

            dtgv_propietario.Columns["Localidad"].HeaderText = "Localidad";

            dtgv_propietario.Columns["Localidad"].Visible = false;

            dtgv_propietario.Columns["Contacto1"].HeaderText = "Contacto";


            dtgv_propietario.Columns["Contacto2"].HeaderText = "Segundo contacto";

            dtgv_propietario.Columns["Contacto2"].Width = 120;

            dtgv_propietario.Columns["Correo"].HeaderText = "Correo";

            dtgv_propietario.Columns["Correo"].Visible = false;

        }

        private void CalcularTotal()
        {
            decimal presupuesto = 0;
            decimal manoDeObra = 0;
            decimal materiales = 0;
            decimal cotizacion = 1;

            // Intenta convertir los valores de los TextBox a decimales
            decimal.TryParse(tb_precioPresupuesto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out presupuesto);
            decimal.TryParse(tb_precioManoDeObra.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out manoDeObra);
            decimal.TryParse(tb_precioMateriales.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out materiales);

            if (rb_usd.Checked && decimal.TryParse(tb_cotizacion.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal cotizacionTemp))
            {
                cotizacion = cotizacionTemp;
                materiales *= cotizacion; // Ajustar el valor de materiales según la cotización
            }

            // Calcula el total
            decimal total = presupuesto + manoDeObra + materiales;

            // Muestra el total en el TextBox total, formateado a dos decimales
            tb_total.Text = total.ToString("F2", CultureInfo.InvariantCulture); // "F2" formatea el número con dos decimales
        }

        private void ActualizarHabilitacionTextBox()
        {
            bool estadoTerminado = cb_estado.SelectedItem != null && cb_estado.SelectedItem.ToString() == "Terminado";

            tb_precioManoDeObra.Enabled = estadoTerminado;
            tb_precioMateriales.Enabled = estadoTerminado;
        }

        private void ActualizarCotizacion(string moneda)
        {
            decimal tasaCambio = 1; // Tasa de cambio predeterminada para pesos uruguayos
            decimal materiales = 0;
            decimal manoDeObra = 0;
            decimal presupuesto = 0;

            // Convertir los valores de los TextBox a decimal
            decimal.TryParse(tb_precioMateriales.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out materiales);
            decimal.TryParse(tb_precioManoDeObra.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out manoDeObra);
            decimal.TryParse(tb_precioPresupuesto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out presupuesto);

            if (moneda == "USD")
            {
                // Usa la cotización del TextBox si es válida; de lo contrario, usa una predeterminada.
                if (!decimal.TryParse(tb_cotizacion.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out tasaCambio))
                {
                    tasaCambio = 0.00M; // Tasa predeterminada si no se ingresa una cotización válida
                }
            }

            // Aplicar la tasa de cambio
            materiales *= tasaCambio;
            manoDeObra *= tasaCambio;
            presupuesto *= tasaCambio;

            // Calcular el total
            decimal total = materiales + manoDeObra + presupuesto;

            // Mostrar el total en el TextBox total, formateado a dos decimales
            tb_total.Text = total.ToString("F2", CultureInfo.InvariantCulture);
        }

        private void EnviarMensaje()
        {
            int.TryParse(this.tb_cliente_id.Text, out int idCliente);
            frmMensajeWhatsApp frmMensajeWhatsApp = new frmMensajeWhatsApp();
            frmMensajeWhatsApp.setDatosTextBox(idCliente);
            frmMensajeWhatsApp.ShowDialog();
        }

        public void ImprimirOrden(int idOrden)
        {
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
                        string tipo_cliente;
                        string consulta_tipo_cliente = @"
                        SELECT 
                        CL.TIPO_CLIENTE
                        FROM 
                        ORDEN_DE_REPARACION ODR
                        INNER JOIN CLIENTE CL ON ODR.clienteId = CL.ID
                        INNER JOIN DISPOSITIVO_CLIENTE DC ON ODR.idDispositivo = DC.idDispositivo 
                        WHERE idOrden = " + idOrden + ";";

                        DataSet ds2 = conexion.Selección(consulta_tipo_cliente);
                        DataTable dt2 = ds2.Tables[0];

                        if (dt2.Rows.Count > 0)
                        {
                            DataRow row = dt2.Rows[0];
                            tipo_cliente = Convert.ToString(row[0]);
                        


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
                        if (tipo_cliente == "PERSONA")
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
                MessageBox.Show("No se encontraron datos para la orden seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TipoCliente(int idOrden)
        {
            
        }
        public void GenerarMovimientoOrden()
        {
            if (FaltanDatos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos antes de continuar.",
                "Datos Incompletos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                // Conversión de los datos ingresados en el formulario
                int id = id_orden;
                int.TryParse(this.tb_cliente_id.Text, out int idCliente);
                int.TryParse(this.tb_dispositivo_id.Text, out int idDispositivo);
                decimal.TryParse(this.tb_precioPresupuesto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precioPresupuesto);
                decimal.TryParse(this.tb_precioMateriales.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precioMateriales);
                decimal.TryParse(this.tb_precioManoDeObra.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precioManoDeObra);
                decimal.TryParse(this.tb_total.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal total);
                string falla = tb_falla.Text;
                DateTime? fechaEgreso = DateTime.Now;
                string estado = cb_estado.SelectedItem.ToString();

                // Verificar apertura del día
                Persistencia_Movimientos movimientosPersistencia = new Persistencia_Movimientos();

                // Asegurar que la fecha no sea nula antes de verificar
                if (fechaEgreso.HasValue)
                {
                    if (!movimientosPersistencia.VerificarAperturaEnFecha(fechaEgreso.Value))
                    {
                        DialogResult resultado = MessageBox.Show(
                            "No se ha realizado la apertura del día. ¿Deseas hacer la apertura ahora?",
                            "Apertura Pendiente",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (resultado == DialogResult.Yes)
                        {
                            // Abre el formulario para agregar movimiento
                            frmAgregarMovimiento frmAgregarMovimiento = new frmAgregarMovimiento();
                            this.Close();
                            frmAgregarMovimiento.ShowDialog();
                            return;
                        }
                        else
                        {
                            // Si el usuario selecciona "No", salir del método
                            return;
                        }
                    }
                    if (movimientosPersistencia.VerificarCierreEnFecha(fechaEgreso.Value))
                    {
                        MessageBox.Show("No se puede ingresar el movimiento porque se realizo un cierre en esta fecha.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de egreso es nula o inválida.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si la fecha es inválida
                }

                // Crear la instancia de OrdenDeReparacion con los datos
                OrdenDeReparacion ordenDeReparacion = new OrdenDeReparacion(
                    id,
                    idCliente,
                    idDispositivo,
                    fechaEgreso,
                    estado,
                    precioPresupuesto,
                    precioMateriales,
                    precioManoDeObra,
                    total,
                    falla
                );

                // Intentar generar el movimiento de la orden de reparación
                Orden_De_Reparacion_Controladora orden_De_Reparacion_Controladora = new Orden_De_Reparacion_Controladora();
                if (orden_De_Reparacion_Controladora.GenerarMovimientoDeReparacion(ordenDeReparacion))
                {
                    MessageBox.Show("Movimiento generado con éxito.", "Generación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // MessageBox preguntando si desea imprimir la orden
                    DialogResult resultadoImpresion = MessageBox.Show("¿Desea imprimir la orden?", "Confirmar impresión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultadoImpresion == DialogResult.Yes)
                    {
                        // Llamar a la función ImprimirOrden si el usuario selecciona "Sí"
                        ImprimirOrden(id_orden);
                    }

                    // Insertar en MOVIMIENTOS si el estado es "Terminado" o "Cancelado"
                    if (estado == "Terminado" || estado == "Cancelado")
                    {
                        Movimientos nuevoMovimiento = new Movimientos("Entrada", total, DateTime.Now, id);

                        // Insertar el movimiento
                        if (movimientosPersistencia.AltaMovimiento(nuevoMovimiento))
                        {
                            frmOrdenReparacionHome frmOrdenReparacionHome = Application.OpenForms["frmOrdenReparacionHome"] as frmOrdenReparacionHome;

                            if (frmOrdenReparacionHome != null)
                            {
                                // Si el formulario ya está abierto, utiliza la instancia existente
                                frmOrdenReparacionHome.CargarOrdenes();
                            }

                           
                            if (estado == "Terminado" || estado == "Cancelado")
                            {
                                var resultado = MessageBox.Show(
                                  "¿Quieres enviar un mensaje a WhatsApp?.",
                                  "Confirmar envio",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Warning);

                                if (resultado == DialogResult.Yes)
                                {
                                    EnviarMensaje();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar el movimiento.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No fue posible generar el movimiento para esta orden de reparación. Por favor, intente nuevamente.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion

        #region Eventos y validaciones TextBox

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ActualizarHabilitacionTextBox();
        }

        private void rb_uyu_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_uyu.Checked)
            {
                tb_cotizacion.Visible = false; // Oculta el TextBox cuando se selecciona UYU
                ActualizarCotizacion("UYU");
            }
        }

        private void rb_usd_CheckedChanged(object sender, EventArgs e)
        {
            // Hacer visible el TextBox tb_cotizacion si el CheckBox cb_USD está marcado
            tb_cotizacion.Visible = rb_usd.Checked;
            lb_10.Visible = rb_usd.Checked;

            if (rb_usd.Checked)
            {
                tb_cotizacion.Visible = true; // Muestra el TextBox cuando se selecciona USD
                ActualizarCotizacion("USD");
            }
        }

        private void tb_precioManoDeObra_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_precioManoDeObra.Text.Length > maximo_caracteres)
            {
                tb_precioManoDeObra.Text = tb_precioManoDeObra.Text.Substring(0, maximo_caracteres);
                tb_precioManoDeObra.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_precioMateriales_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_precioMateriales.Text.Length > maximo_caracteres)
            {
                tb_precioMateriales.Text = tb_precioMateriales.Text.Substring(0, maximo_caracteres);
                tb_precioMateriales.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_precioPresupuesto_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_precioPresupuesto.Text.Length > maximo_caracteres)
            {
                tb_precioPresupuesto.Text = tb_precioPresupuesto.Text.Substring(0, maximo_caracteres);
                tb_precioPresupuesto.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }

        }

        private void tb_falla_TextChanged(object sender, EventArgs e)
        {
            /* Establecer un maximo de caracteres (255) */
            int maxCaracteres = 255;

            /* Verificamos si el texto ingresado supera el limite */
            if (tb_falla.Text.Length > maxCaracteres)
            {
                tb_falla.Text = tb_falla.Text.Substring(0, maxCaracteres);
                tb_falla.Select(maxCaracteres, 0); /*Colocar el cursor al final del texto */
            }
        }

        private void tb_cotizacion_TextChanged(object sender, EventArgs e)
        {
            // Establecer un maximo de caracteres (100)
            int maximo_caracteres = 6;

            // Verificamos si el texto ingresado supera el limite
            if (tb_cotizacion.Text.Length > maximo_caracteres)
            {
                tb_cotizacion.Text = tb_cotizacion.Text.Substring(0, maximo_caracteres);
                tb_cotizacion.Select(maximo_caracteres, 0); // Colocar el cursor al final del texto 
            }
        }

        private void tb_precioManoDeObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, el punto decimal y las teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancelar el evento para otros caracteres
            }

            // Evitar que se ingrese un signo menos
            if (e.KeyChar == '-')
            {
                e.Handled = true; // Cancelar el evento si es un signo menos
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_precioMateriales_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, el punto decimal y las teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancelar el evento para otros caracteres
            }

            // Evitar que se ingrese un signo menos
            if (e.KeyChar == '-')
            {
                e.Handled = true; // Cancelar el evento si es un signo menos
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_precioPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, el punto decimal y las teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancelar el evento para otros caracteres
            }

            // Evitar que se ingrese un signo menos
            if (e.KeyChar == '-')
            {
                e.Handled = true; // Cancelar el evento si es un signo menos
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void tb_cotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, el punto decimal y las teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancelar el evento para otros caracteres
            }

            // Evitar que se ingrese un signo menos
            if (e.KeyChar == '-')
            {
                e.Handled = true; // Cancelar el evento si es un signo menos
            }
        }

        private void frmFacturarOrden_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    GenerarMovimientoOrden();
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        private void tb_falla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btn_facturar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cb_estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        #endregion

        #region Botones
        private void btn_facturar_Click(object sender, EventArgs e)
        {
            GenerarMovimientoOrden();
        }

        public void CargarTemaClaro()
        {
            this.cb_estado.FillColor = Color.FromArgb(128, 141, 124);
            this.cb_estado.BorderColor = Color.FromArgb(95, 111, 101);
            this.cb_estado.ForeColor = Color.White;
            tema = "Claro";
            this.BackColor = Color.FromArgb(64, 83, 76);

            this.panel_central.FillColor = Color.FromArgb(95, 111, 101);
            this.panel_dtgv.FillColor = Color.FromArgb(128, 141, 124);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(128, 141, 124);

            this.cntb_cerrar_formulario.FillColor = Color.FromArgb(64, 83, 76);
            this.cntb_minimizar_formulario.FillColor = Color.FromArgb(64, 83, 76);

            this.btn_generar_movimiento.Image = Properties.Resources.icono_facturar_claro;
         
            this.lb_titulo.ForeColor = Color.White;
            this.lb_2.ForeColor = Color.White;
            this.lb_3.ForeColor = Color.White;
            this.lb_4.ForeColor = Color.White;
            this.lb_5.ForeColor = Color.White;
            this.lb_6.ForeColor = Color.White;
            this.lb_7.ForeColor = Color.White;
            this.lb_8.ForeColor = Color.White;
            this.lb_9.ForeColor = Color.White;
            this.lb_10.ForeColor = Color.White;


            this.tb_falla.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_falla.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_falla.ForeColor = Color.White;

            this.tb_precioPresupuesto.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_precioPresupuesto.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_precioPresupuesto.ForeColor = Color.White;

            this.tb_total.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_total.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_total.ForeColor = Color.White;

            this.tb_precioMateriales.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_precioMateriales.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_precioMateriales.ForeColor = Color.White;

            this.tb_precioManoDeObra.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_precioManoDeObra.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_precioManoDeObra.ForeColor = Color.White;

            this.tb_cotizacion.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_cotizacion.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_cotizacion.ForeColor = Color.White;


            this.tb_total.DisabledState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_total.DisabledState.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_total.DisabledState.ForeColor = Color.White;

            this.tb_precioMateriales.DisabledState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_precioMateriales.DisabledState.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_precioMateriales.DisabledState.ForeColor = Color.White;

            this.tb_precioManoDeObra.DisabledState.FillColor = Color.FromArgb(128, 141, 124);
            this.tb_precioManoDeObra.DisabledState.BorderColor = Color.FromArgb(95, 111, 101);
            this.tb_precioManoDeObra.DisabledState.ForeColor = Color.White;



            this.dtgv_dispositivo.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivo.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_dispositivo.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_dispositivo.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }

            this.dtgv_dispositivo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);

            this.dtgv_propietario.BackgroundColor = Color.FromArgb(95, 111, 101);
            this.dtgv_propietario.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            this.dtgv_propietario.GridColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 141, 124);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewRow row in dtgv_propietario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(95, 111, 101);
            }
            this.rb_usd.ForeColor = Color.White;
            this.rb_uyu.ForeColor = Color.White;
            this.dtgv_propietario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(144, 161, 139);
        }

        public void CargarTemaOscuro()
        {
            this.rb_usd.ForeColor = Color.DimGray;
            this.rb_uyu.ForeColor = Color.DimGray;
            tema = "Oscuro";
            this.BackColor = Color.Black;
            this.cb_estado.FillColor = Color.FromArgb(35, 36, 40);
            this.cb_estado.BorderColor = Color.FromArgb(18, 18, 18);
            this.cb_estado.ForeColor = Color.FromArgb(125, 137, 149);
            this.panel_central.FillColor = Color.FromArgb(18, 18, 18);
            this.panel_dtgv.FillColor = Color.FromArgb(35, 36, 40);
            this.panel_dtgv_propietario.FillColor = Color.FromArgb(35, 36, 40);

            this.cntb_cerrar_formulario.FillColor = Color.Black;
            this.cntb_minimizar_formulario.FillColor = Color.Black;

            this.btn_generar_movimiento.Image = Properties.Resources.icono_facturar;


            this.lb_titulo.ForeColor = Color.DimGray;
            this.lb_2.ForeColor = Color.DimGray;
            this.lb_3.ForeColor = Color.DimGray;
            this.lb_4.ForeColor = Color.DimGray;
            this.lb_5.ForeColor = Color.DimGray;
            this.lb_6.ForeColor = Color.DimGray;
            this.lb_7.ForeColor = Color.DimGray;
            this.lb_8.ForeColor = Color.DimGray;
            this.lb_9.ForeColor = Color.DimGray;
            this.lb_10.ForeColor = Color.DimGray;


            this.tb_falla.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_falla.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_falla.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_precioPresupuesto.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_precioPresupuesto.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_precioPresupuesto.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_total.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_total.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_total.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_precioMateriales.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_precioMateriales.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_precioMateriales.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_precioManoDeObra.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_precioManoDeObra.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_precioManoDeObra.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_cotizacion.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_cotizacion.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_cotizacion.ForeColor = Color.FromArgb(125, 137, 149);


            this.tb_total.DisabledState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_total.DisabledState.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_total.DisabledState.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_precioMateriales.DisabledState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_precioMateriales.DisabledState.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_precioMateriales.DisabledState.ForeColor = Color.FromArgb(125, 137, 149);

            this.tb_precioManoDeObra.DisabledState.FillColor = Color.FromArgb(35, 36, 40);
            this.tb_precioManoDeObra.DisabledState.BorderColor = Color.FromArgb(18, 18, 18);
            this.tb_precioManoDeObra.DisabledState.ForeColor = Color.FromArgb(125, 137, 149);



            this.dtgv_dispositivo.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivo.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_dispositivo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_dispositivo.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_dispositivo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);


            this.dtgv_propietario.BackgroundColor = Color.FromArgb(18, 18, 18);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.GridColor = Color.FromArgb(35, 36, 40);
            this.dtgv_propietario.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;

            foreach (DataGridViewRow row in dtgv_propietario.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
            }
            this.dtgv_propietario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(49, 51, 56);
        }


        #endregion

        private void frmFacturarOrden_Load(object sender, EventArgs e)
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
