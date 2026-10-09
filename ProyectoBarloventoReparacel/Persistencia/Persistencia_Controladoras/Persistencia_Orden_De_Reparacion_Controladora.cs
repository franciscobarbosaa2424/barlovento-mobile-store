using ProyectoBarloventoReparacel.Dominio;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras
{
    internal class Persistencia_Orden_De_Reparacion_Controladora
    {
        //Alta para un dispositivo

        public bool PAltaOrdenDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            return new Persistencia_Orden_De_Reparacion().AltaOrdenDeReparacion(pOrdenDeReparacion);
        }

        //Baja para un dispositivo
        public bool PBajaOrdenDeReparacion(int pId)
        {
            return new Persistencia_Orden_De_Reparacion().BajaOrdenDeReparacion(pId);
        }

        public bool PModificarOrdenDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            return new Persistencia_Orden_De_Reparacion().ModificarOrdenDeReparacion(pOrdenDeReparacion);
        }

        public bool PGenerarMovimientoDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            return new Persistencia_Orden_De_Reparacion().GenerarMovimientoDeReparacion(pOrdenDeReparacion);
        }

    }
}
