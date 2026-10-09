using ProyectoBarloventoReparacel.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades
{
    internal class Persistencia_Dispositivo
    {
        private Conexion _conexion = new Conexion();

       
        //Sentencia SQL para el alta de dispositivos
        public bool AltaDispositivo(Dispositivo pDispositivo)
        {
            string sqlDispositivo = "INSERT INTO DISPOSITIVO_CLIENTE (" +
                "ClienteId, " +
                "TIPO_DISPOSITIVO, " +
                "MARCA, " +
                "MODELO, " +
                "NUMERO_DE_SERIE, " +
                "CONTRASEÑA, " +
                "PATRON, " +
                "OBSERVACION) VALUES ('" +
                pDispositivo.IdCliente + "', '" +
                pDispositivo.Tipo + "', '" +
                pDispositivo.Marca + "', '" +
                pDispositivo.Modelo + "', '" +
                pDispositivo.NumeroDeSerie + "', '" +
                pDispositivo.Contraseña + "', '" +
                pDispositivo.Patron + "', '" +
                pDispositivo.Observacion + "')";


            return this._conexion.Consulta(sqlDispositivo);
        }

        public bool BajaDispositivo(int pId)
        {
            string sql = "DELETE FROM DISPOSITIVO_CLIENTE WHERE id=" + pId.ToString();
            return this._conexion.Consulta(sql);
        }

        public bool ModificarDispositivo(Dispositivo pDispositivo)
        {
            string sql = "UPDATE DISPOSITIVO_CLIENTE SET " +
                "TIPO_DISPOSITIVO = '" + pDispositivo.Tipo + "', " +
                "MARCA = '" + pDispositivo.Marca + "', " +
                "MODELO = '" + pDispositivo.Modelo + "', " +
                "NUMERO_DE_SERIE = '" + pDispositivo.NumeroDeSerie + "', " +
                "PATRON = '" + pDispositivo.Patron + "', " +
                "CONTRASEÑA = '" + pDispositivo.Contraseña + "', " +
                "OBSERVACION = '" + pDispositivo.Observacion + "' " +
                "WHERE idDispositivo = " + pDispositivo.IdDispositivo;
            return this._conexion.Consulta(sql);
        }

    }
}
