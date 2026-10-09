using ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras
{
    internal class Orden_De_Reparacion_Controladora
    {
        private Persistencia_Orden_De_Reparacion_Controladora _pOrdenDeReparacion_Controladora;


        public Orden_De_Reparacion_Controladora()
        {
            this._pOrdenDeReparacion_Controladora = new Persistencia_Orden_De_Reparacion_Controladora();

        }

        //Alta Orden De Reparacion
        public bool AltaOrdenDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            return _pOrdenDeReparacion_Controladora.PAltaOrdenDeReparacion(pOrdenDeReparacion);
        }

        public bool BajaOrdenDeReparacion(int pId)
        {
            return _pOrdenDeReparacion_Controladora.PBajaOrdenDeReparacion(pId);
        }

        public bool ModificarOrdenDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            return _pOrdenDeReparacion_Controladora.PModificarOrdenDeReparacion(pOrdenDeReparacion);
        }
        public bool GenerarMovimientoDeReparacion(OrdenDeReparacion pOrdenDeReparacion)
        {
            return _pOrdenDeReparacion_Controladora.PGenerarMovimientoDeReparacion(pOrdenDeReparacion);
        }


    }
}
