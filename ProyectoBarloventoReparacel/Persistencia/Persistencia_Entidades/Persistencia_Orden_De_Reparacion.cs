using ProyectoBarloventoReparacel.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades
{
    internal class Persistencia_Orden_De_Reparacion
    {
        private Conexion _conexion = new Conexion();
        public bool AltaOrdenDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            bool resultado = true;
            int ordenDeReparacionId = 0;

            string sqlOrdenDeReparacion = "INSERT INTO Orden_De_Reparacion (" +
                "fechaIngreso, " +
                "fechaEgreso, " +
                "ClienteId, " +
                "idDispositivo, " +
                "falla, " +
                "estado) VALUES (GetDate(), NULL, @ClienteId, @IdDispositivo, @Falla, @Estado);" +
                "SELECT SCOPE_IDENTITY();"; // Esto devolverá el ID de la orden recién creada.

            SqlParameter[] parametrosOrden = new SqlParameter[]
            {
        new SqlParameter("@ClienteId", SqlDbType.Int) { Value = pOrdenDeReparacion.Cliente },
        new SqlParameter("@IdDispositivo", SqlDbType.Int) { Value = pOrdenDeReparacion.Dispositivo },
        new SqlParameter("@Falla", SqlDbType.NVarChar) { Value = pOrdenDeReparacion.Falla },
        new SqlParameter("@Estado", SqlDbType.NVarChar) { Value = pOrdenDeReparacion.Estado }
            };

            // Ejecuta la consulta para insertar la orden de reparación y obtener el ID generado
            ordenDeReparacionId = _conexion.EjecutarConsultaEscalar(sqlOrdenDeReparacion, parametrosOrden);

            if (ordenDeReparacionId <= 0)
            {
                return false; // Si no se pudo obtener el ID, algo salió mal
            }

            // Ahora inserta las imágenes relacionadas con esta orden de reparación
            string sqlImagen = "INSERT INTO Imagenes (OrdenDeReparacionID, Imagen) VALUES (@OrdenDeReparacionID, @Imagen)";

            foreach (var imagen in pOrdenDeReparacion.Imagen)
            {
                SqlParameter[] parametrosImagen = new SqlParameter[]
                {
            new SqlParameter("@OrdenDeReparacionID", SqlDbType.Int) { Value = ordenDeReparacionId },
            new SqlParameter("@Imagen", SqlDbType.VarBinary) { Value = (object)imagen ?? DBNull.Value }
                };

                if (!_conexion.EjecutarConsulta(sqlImagen, parametrosImagen))
                {
                    resultado = false;
                    break;
                }
            }

            return resultado;
        }



        public bool BajaOrdenDeReparacion(int pId)
        {
            string sql = "DELETE FROM Orden_De_Reparacion WHERE id=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool ModificarOrdenDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            bool resultado = true;

            // Actualiza los datos de la orden de reparación
            string sql = "UPDATE Orden_De_Reparacion SET " +
                         "falla = @Falla, " +
                         "estado = @Estado " +
                         "WHERE idOrden = @IdOrden";

            SqlParameter[] parametrosOrden = new SqlParameter[]
            {
        new SqlParameter("@Falla", SqlDbType.NVarChar) { Value = pOrdenDeReparacion.Falla },
        new SqlParameter("@Estado", SqlDbType.NVarChar) { Value = pOrdenDeReparacion.Estado },
        new SqlParameter("@IdOrden", SqlDbType.Int) { Value = pOrdenDeReparacion.Id }
            };

            if (!_conexion.EjecutarConsulta(sql, parametrosOrden))
            {
                return false; // Si no se pudo actualizar la orden de reparación, se retorna false
            }

            // Inserta las nuevas imágenes
            string sqlInsertarImagen = "INSERT INTO Imagenes (OrdenDeReparacionID, Imagen) VALUES (@OrdenDeReparacionID, @Imagen)";
            string sqlVerificarImagen = "SELECT COUNT(*) FROM Imagenes WHERE OrdenDeReparacionID = @OrdenDeReparacionID AND Imagen = @Imagen";

            foreach (var imagen in pOrdenDeReparacion.Imagen)
            {
                SqlParameter[] parametrosVerificar = new SqlParameter[]
                {
            new SqlParameter("@OrdenDeReparacionID", SqlDbType.Int) { Value = pOrdenDeReparacion.Id },
            new SqlParameter("@Imagen", SqlDbType.VarBinary) { Value = (object)imagen ?? DBNull.Value }
                };

                // Verifica si la imagen ya existe en la base de datos
                int conteoImagenes = Convert.ToInt32(_conexion.EjecutarConsultaEscalar(sqlVerificarImagen, parametrosVerificar));

                if (conteoImagenes == 0) // Solo inserta si la imagen no existe
                {
                    SqlParameter[] parametrosImagen = new SqlParameter[]
                    {
                new SqlParameter("@OrdenDeReparacionID", SqlDbType.Int) { Value = pOrdenDeReparacion.Id },
                new SqlParameter("@Imagen", SqlDbType.VarBinary) { Value = (object)imagen ?? DBNull.Value }
                    };

                    if (!_conexion.EjecutarConsulta(sqlInsertarImagen, parametrosImagen))
                    {
                        resultado = false; // Si hay un error al insertar alguna imagen, detenemos el proceso
                        break;
                    }
                }
            }

            return resultado;
        }


        public bool GenerarMovimientoDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            string sql = "UPDATE Orden_De_Reparacion SET " +
                  "presupuesto = @Presupuesto, " +
                  "materiales = @Materiales, " +
                  "manoDeObra = @ManoDeObra, " +
                  "total = @Total, " +
                  "fechaEgreso = @FechaEgreso, " +
                  "estado = @Estado, " +
                  "falla = @Falla " +
                  "WHERE idOrden = @IdOrden";

            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@Presupuesto", SqlDbType.Decimal)
        {
            Precision = 10,
            Scale = 2,
            Value = pOrdenDeReparacion.Presupuesto
        },
        new SqlParameter("@Materiales", SqlDbType.Decimal)
        {
            Precision = 10,
            Scale = 2,
            Value = pOrdenDeReparacion.Materiales
        },
        new SqlParameter("@ManoDeObra", SqlDbType.Decimal)
        {
            Precision = 10,
            Scale = 2,
            Value = pOrdenDeReparacion.ManoDeObra
        },
        new SqlParameter("@Total", SqlDbType.Decimal)
        {
            Precision = 10,
            Scale = 2,
            Value = pOrdenDeReparacion.Total
        },
        new SqlParameter("@FechaEgreso", SqlDbType.DateTime)
        {
            Value = (object)pOrdenDeReparacion.FechaEgreso ?? DBNull.Value
        },
        new SqlParameter("@IdOrden", SqlDbType.Int)
        {
            Value = pOrdenDeReparacion.Id
        },
        new SqlParameter("@Estado", SqlDbType.NVarChar)
        {
            Value = pOrdenDeReparacion.Estado
        },
        new SqlParameter("@Falla", SqlDbType.NVarChar)
        {
            Value = pOrdenDeReparacion.Falla
        }
            };

            return _conexion.EjecutarConsulta(sql, parametros);
        }



    }
}
