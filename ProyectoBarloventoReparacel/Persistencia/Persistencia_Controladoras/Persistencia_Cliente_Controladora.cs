using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia;
using ProyectoBarloventoReparacel.Controladoras_Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoBarloventoReparacel.Controladoras_Persistencia
{
    internal class Persistencia_Cliente_Controladora
    {

        public bool PAltaClientePersona(Cliente pClientePersona)
        {
            return new Persistencia_Cliente().AltaClientePersona(pClientePersona);
        }

        public bool PAltaClienteEmpresa(Cliente pClienteEmpresa)
        {
            return new Persistencia_Cliente().AltaClienteEmpresa(pClienteEmpresa);
        }

        public bool PBajaClientePersona(int pCedula)
        {
            return new Persistencia_Cliente().BajaClientePersona(pCedula);
        }

        public bool PBajaClienteEmpresa(int pRut)
        {
            return new Persistencia_Cliente().BajaClienteEmpresa(pRut);
        }

        public bool PModificarClientePersona(Cliente pClientePersona)
        {
            return new Persistencia_Cliente().ModificarClientePersona(pClientePersona);
        }

        public bool PModificarClienteEmpresa(Cliente pClienteEmpresa)
        {
            return new Persistencia_Cliente().ModificarClienteEmpresa(pClienteEmpresa);
        }

    }
}
