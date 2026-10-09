using ProyectoBarloventoReparacel.Dominio.Dominio_Entidades;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras
{
    internal class Persistencia_Movimientos_Controladora
    {
        public bool PAltaMovimiento(Movimientos pMovimiento)
        {
            return new Persistencia_Movimientos().AltaMovimiento(pMovimiento);
        }

        public bool PBajaMovimiento(int pId)
        {
            return new Persistencia_Movimientos().BajaMovimiento(pId);
        }

        public bool VerificarAperturaEnFecha(DateTime fecha)
        {
            return new Persistencia_Movimientos().VerificarAperturaEnFecha(fecha);
        }

        public bool VerificarCierreEnFecha(DateTime fecha)
        {
            return new Persistencia_Movimientos().VerificarCierreEnFecha(fecha);
        }
    }
}
