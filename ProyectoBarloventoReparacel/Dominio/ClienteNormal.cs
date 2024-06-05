using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio
{
    class ClienteNormal : Cliente
    {
        private int _cedulaCliente;

        public int Cedula
        {
            get { return _cedulaCliente; }
            set { _cedulaCliente = value; }
        }

        public ClienteNormal(int pId, string pNombre, int pTelefono, string pDireccion, string pLocalidad, string pEstado, string pCorreo, string pObservacion)
            : base(pId, pNombre, pTelefono, pDireccion, pLocalidad, pEstado, pCorreo, pObservacion)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
