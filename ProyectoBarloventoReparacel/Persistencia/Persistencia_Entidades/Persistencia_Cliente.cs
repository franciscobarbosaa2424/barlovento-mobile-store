using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBarloventoReparacel.Dominio;

namespace ProyectoBarloventoReparacel.Persistencia
{
    internal class Persistencia_Cliente
    {
        private Conexion _conexion = new Conexion();

        public bool AltaClientePersona(Cliente pClientePersona)
        {
            // Si CONTACTO_2 es null o 0, insertar NULL en lugar de un número
            string contacto2 = pClientePersona.Contacto2 == 0 ? "NULL" : pClientePersona.Contacto2.ToString();

            // Sentencia SQL para el alta de clientes de tipo Persona
            string consulta_cliente_persona = "INSERT INTO CLIENTE (" +
                "TIPO_CLIENTE, " +
                "LOCALIDAD, " +
                "DEPARTAMENTO, " +
                "CONTACTO_1, " +
                "CONTACTO_2, " +
                "CORREO, " +
                "FECHA_AUD, " +
                "HORA_AUD, " +
                "NOMBRE_COMPLETO, " +
                "DOCUMENTO) VALUES ('PERSONA', '" +
                pClientePersona.Localidad + "', '" +
                pClientePersona.Departamento + "', '" +
                pClientePersona.Contacto1 + "', " +
                contacto2 + ", '" +  // Aquí se inserta NULL si no se provee un valor para CONTACTO_2
                pClientePersona.Correo + "', " +
                "GETDATE(), FORMAT(GETDATE(), 'HH:mm'), '" +
                pClientePersona.Nombre + "', '" +
                pClientePersona.Documento + "');";

            return this._conexion.Consulta(consulta_cliente_persona);
        }


        public bool AltaClienteEmpresa(Cliente pClienteEmpresa)
        {
            /* Sentencia SQL para el alta de clientes de tipo Empresa */
            string consulta_cliente_empresa = "INSERT INTO CLIENTE (" +
                "TIPO_CLIENTE, " +
                "LOCALIDAD, " +
                "DEPARTAMENTO, " +
                "CONTACTO_1, " +
                "CONTACTO_2, " +
                "CORREO, " +
                "FECHA_AUD, " +
                "HORA_AUD, " +
                "RUT, " +
                "RAZON_SOCIAL) VALUES ('EMPRESA', '" +
                 pClienteEmpresa.Localidad + "', '" +
                 pClienteEmpresa.Departamento + "', '" +
                 pClienteEmpresa.Contacto1 + "', '" +
                 pClienteEmpresa.Contacto2 + "', '" +
                 pClienteEmpresa.Correo + "', " +
                 "GETDATE(), FORMAT(GETDATE(), 'HH:mm'), " +
                 pClienteEmpresa.Rut + ", '" +
                 pClienteEmpresa.RazonSocial + "');";

            return this._conexion.Consulta(consulta_cliente_empresa);
        }

        public bool BajaClientePersona(int pCedula)
        {
            string consulta = "DELETE FROM CLIENTE WHERE CEDULA=" + pCedula.ToString();
            return this._conexion.Consulta(consulta);
        }

        public bool BajaClienteEmpresa(long pRut)
        {
            string consulta = "DELETE FROM CLIENTE WHERE RUT=" + pRut.ToString();
            return this._conexion.Consulta(consulta);
        }

        public bool ModificarClientePersona(Cliente pClientePersona)
        {
            string consulta = "UPDATE CLIENTE SET "
                + "LOCALIDAD='" + pClientePersona.Localidad + "',"
                + "DEPARTAMENTO='" + pClientePersona.Departamento + "', "
                + "CONTACTO_1='" + pClientePersona.Contacto1 + "', "
                + "CONTACTO_2='" + pClientePersona.Contacto2 + "', "
                + "CORREO='" + pClientePersona.Correo + "',"
                + "NOMBRE_COMPLETO='" + pClientePersona.Nombre + "', "
                + "DOCUMENTO='" + pClientePersona.Documento.ToString() + "' "
                 + "WHERE ID=" + pClientePersona.IdCliente.ToString();
            return this._conexion.Consulta(consulta);
        }

        public bool ModificarClienteEmpresa(Cliente pClienteEmpresa)
        {
            string consulta = "UPDATE CLIENTE SET "
                + "LOCALIDAD='" + pClienteEmpresa.Localidad + "',"
                + "DEPARTAMENTO='" + pClienteEmpresa.Departamento + "', "
                + "CONTACTO_1='" + pClienteEmpresa.Contacto1 + "', "
                + "CONTACTO_2='" + pClienteEmpresa.Contacto2 + "', "
                + "CORREO='" + pClienteEmpresa.Correo + "',"
                + "RAZON_SOCIAL='" + pClienteEmpresa.RazonSocial + "' "
                 + "WHERE ID=" + pClienteEmpresa.IdCliente.ToString();
            return this._conexion.Consulta(consulta);
        }
    }
}
