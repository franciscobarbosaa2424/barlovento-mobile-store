using ProyectoBarloventoReparacel.Dominio.Dominio_Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades
{
    internal class Persistencia_Movimientos
    {
        private Conexion _conexion = new Conexion();


        //Sentencia SQL para el alta de dispositivos
        public bool AltaMovimiento(Movimientos pMovimiento)
        {
            string sqlMovimiento = "INSERT INTO MOVIMIENTOS (tipoDeMovimiento, monto, fecha, idOrden) VALUES (@tipoDeMovimiento, @monto, @fecha, @idOrden)";
            SqlParameter[] parametros = {
            new SqlParameter("@tipoDeMovimiento", SqlDbType.VarChar) { Value = pMovimiento.TipoDeMovimiento },
            new SqlParameter("@monto", SqlDbType.Decimal) { Value = pMovimiento.Monto },
            new SqlParameter("@fecha", SqlDbType.DateTime) { Value = pMovimiento.Fecha },
            new SqlParameter("@idOrden", SqlDbType.Int) { Value = pMovimiento.IdOrden ?? (object)DBNull.Value }
};
            return this._conexion.EjecutarConsulta(sqlMovimiento, parametros);
        }

        public bool BajaMovimiento(int pId)
        {
            string sql = "DELETE FROM MOVIMIENTOS WHERE id=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool VerificarAperturaEnFecha(DateTime fecha)
        {
            string sqlCheck = "SELECT COUNT(*) FROM MOVIMIENTOS " +
                              "WHERE tipoDeMovimiento = 'Apertura' " +
                              "AND CONVERT(date, fecha) = @fecha";

            // Crear parámetro SQL para la fecha
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@fecha", SqlDbType.Date) { Value = fecha.Date }
            };

            int count = Convert.ToInt32(this._conexion.EjecutarConsultaEscalar(sqlCheck, parametros));
            return count > 0;
        }

        public bool VerificarCierreEnFecha(DateTime fecha)
        {
            string sqlCheck = "SELECT COUNT(*) FROM MOVIMIENTOS " +
                              "WHERE tipoDeMovimiento = 'Cierre' " +
                              "AND CONVERT(date, fecha) = @fecha";

            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@fecha", SqlDbType.Date) { Value = fecha.Date   }
            };

            int count = Convert.ToInt32(this._conexion.EjecutarConsultaEscalar(sqlCheck, parametros));
            return count > 0;
        }

    }
}
