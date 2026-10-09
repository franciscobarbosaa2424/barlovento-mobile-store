using ProyectoBarloventoReparacel.Controladoras_Persistencia;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras
{
    internal class Dispositivo_Controladora
    {
        private Persistencia_Dispositivo_Controladora _pDispositivo_Controladora;


        public Dispositivo_Controladora()
        {
            this._pDispositivo_Controladora = new Persistencia_Dispositivo_Controladora();

        }

        //Alta Dispositivo
        public bool AltaDispositivo(Dispositivo pDispositivo)
        {
            return _pDispositivo_Controladora.PAltaDispositivo(pDispositivo);
        }

        public bool BajaDispositivo(int pId)
        {
            return _pDispositivo_Controladora.PBajaDispositivo(pId);
        }

        public bool ModificarDispositivo(Dispositivo pDispositivo)
        {
            return _pDispositivo_Controladora.PModificarDispositivo(pDispositivo);
        }

    }
}
