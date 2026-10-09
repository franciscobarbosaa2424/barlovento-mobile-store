using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras
{
    internal class Persistencia_Dispositivo_Controladora
    {
        //Alta para un dispositivo

        public bool PAltaDispositivo(Dispositivo pDispositivo)
        {
            return new Persistencia_Dispositivo().AltaDispositivo(pDispositivo);
        }

        //Baja para un dispositivo
        public bool PBajaDispositivo(int pId)
        {
            return new Persistencia_Dispositivo().BajaDispositivo(pId);
        }

        public bool PModificarDispositivo(Dispositivo pDispositivo)
        {
            return new Persistencia_Dispositivo().ModificarDispositivo(pDispositivo);
        }

    }
}
