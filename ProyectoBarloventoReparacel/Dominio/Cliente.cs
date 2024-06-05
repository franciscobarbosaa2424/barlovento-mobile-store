using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio
{
    internal class Cliente
    {
        private int _idCliente;
        private string _nombreCliente;
        private int _telefonoCliente;
        private string _direccionCliente;
        private string _localidadCliente;
        private string _estadoCliente;
        private string _correoCliente;
        private string _observacionCliente;


        public int Id
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string Nombre
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        public int Telefono
        {
            get { return _telefonoCliente; }
            set { _telefonoCliente = value; }
        }

        public string Direccion
        {
            get { return _direccionCliente; }
            set { _direccionCliente = value; }
        }

        public string Localidad
        {
            get { return _localidadCliente; }
            set { _localidadCliente = value; }
        }

        public string Estado
        {
            get { return _estadoCliente; }
            set { _estadoCliente = value; }
        }

        public string Correo
        {
            get { return _correoCliente; }
            set { _correoCliente = value; }
        }

        public string Observacion
        {
            get { return _observacionCliente; }
            set { _observacionCliente = value; }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Nombre + " " + this.Direccion + " " + this.Localidad + " " + this.Estado + " " + this.Correo + " " + this.Observacion;
        }

        public Cliente(int pId, string pNombre, int pTelefono, string pDireccion, string pLocalidad, string pEstado, string pCorreo, string pObservacion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
            this.Localidad = pLocalidad;
            this.Estado = pEstado;
            this.Correo = pCorreo;
            this.Observacion = pObservacion;

        }
    }
}
