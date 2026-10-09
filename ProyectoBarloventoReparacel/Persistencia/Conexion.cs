using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel.Persistencia
{
    internal class Conexion
    {
        private string _cadenaConexion = @"data source= DESKTOP-KNKJ7PV\SQLEXPRESS;" +
                                       "Initial Catalog=Barlovento;Integrated Security=SSPI";
      
        public bool Consulta(string sql)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(this._cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en Conexión.Consulta: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataSet Selección(string sql)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(this._cadenaConexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
                DataSet resultado = new DataSet();
                conexion.Open();
                adaptador.Fill(resultado);
                adaptador.Dispose();
                conexion.Close();
                return resultado;
            }
            catch (Exception e)
            {
                throw new Exception("Error en Conexión.Selección, sql = " + sql, e);
            }
        }

        public bool EjecutarConsulta(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection connection = new SqlConnection(this._cadenaConexion))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parametros != null)
                    {
                        command.Parameters.AddRange(parametros);
                    }

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        public int EjecutarConsultaEscalar(string sql, SqlParameter[] parametros)
        {
            int resultado = 0;

            using (SqlConnection conexion = new SqlConnection(_cadenaConexion))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }

                    try
                    {
                        conexion.Open();
                        resultado = Convert.ToInt32(comando.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                       
                    }
                }
            }

            return resultado;
        }

        internal DataSet Selección(SqlCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
