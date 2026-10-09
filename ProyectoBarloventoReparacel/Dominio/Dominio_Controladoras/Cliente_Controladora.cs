using ProyectoBarloventoReparacel.Controladoras_Persistencia;
using ProyectoBarloventoReparacel.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Controladoras
{
    internal class Cliente_Controladora
    {
   
        private Persistencia_Cliente_Controladora _pCliente_Controladora;

        public Cliente_Controladora()
        {
            this._pCliente_Controladora = new Persistencia_Cliente_Controladora();

        }

        public bool AltaClientePersona(Cliente pClientePersona)
        {
            return _pCliente_Controladora.PAltaClientePersona(pClientePersona);
        }

        public bool AltaClienteEmpresa(Cliente pClienteEmpresa)
        {
            return _pCliente_Controladora.PAltaClienteEmpresa(pClienteEmpresa);
        }

        public bool BajaClientePersona(int pCedula)
        {
            return _pCliente_Controladora.PBajaClientePersona(pCedula);
        }

        public bool BajaClienteEmpresa(int pRut)
        {
            return _pCliente_Controladora.PBajaClienteEmpresa(pRut);
        }

        public bool ModificarClientePersona(Cliente pClientePersona)
        {
            return _pCliente_Controladora.PModificarClientePersona(pClientePersona);
        }

        public bool ModificarClienteEmpresa(Cliente pClienteEmpresa)
        {
            return _pCliente_Controladora.PModificarClienteEmpresa(pClienteEmpresa);
        }

    }
}
