using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public long? Rut { get; set; } // Solo para empresa
        public string RazonSocial { get; set; } // Solo para empresa
        public long Contacto1 { get; set; }
        public long? Contacto2 { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public string Correo { get; set; }
        public string TipoCliente { get; set; } // 'PERSONA' o 'EMPRESA'
        public string Nombre { get; set; } // Solo para cliente persona
        public int? Documento { get; set; } // Solo para cliente persona

        public Cliente(
         string pNombre,
         int? pDocumento,
         long pContacto1,
         long? pContacto2,
         string pDepartamento,
         string pLocalidad,
         string pCorreo,
         string pTipoCliente)
        {
        Nombre= pNombre;
        Documento = pDocumento;
        Contacto1 = pContacto1;
        Contacto2 = pContacto2;
        Departamento = pDepartamento;
        Localidad = pLocalidad;
        Correo = pCorreo;
        TipoCliente = pTipoCliente;
        }

        public Cliente(
        string pRazon_social,
        long? pRut,
        long pContacto1,
        long? pContacto2,
        string pDepartamento,
        string pLocalidad,
        string pCorreo)
        {
            RazonSocial = pRazon_social;
            Rut = pRut;
            Contacto1 = pContacto1;
            Contacto2 = pContacto2;
            Departamento = pDepartamento;
            Localidad = pLocalidad;
            Correo = pCorreo;
        }

        public Cliente(int idCliente,
            string nombre,
            int? documento,
            long contacto1,
            long? contacto2,
            string departamento,
            string localidad,
            string correo)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Documento = documento;
            Contacto1 = contacto1;
            Contacto2 = contacto2;
            Departamento = departamento;
            Localidad = localidad;
            Correo = correo;
        }

        public Cliente(int idCliente,
            long? rut,
            string razonSocial,
            long contacto1,
            long? contacto2,
            string departamento,
            string localidad,
            string correo
            )
        {
            IdCliente = idCliente;
            Rut = rut;
            RazonSocial = razonSocial;
            Contacto1 = contacto1;
            Contacto2 = contacto2;
            Departamento = departamento;
            Localidad = localidad;
            Correo = correo;
        }
    }
}
