using ProyectoBarloventoReparacel.Dominio.Dominio_Entidades;
using ProyectoBarloventoReparacel.Persistencia.Persistencia_Controladoras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio.Dominio_Controladoras
{
    internal class Movimientos_Controladora
    {
        private Persistencia_Movimientos_Controladora _pMovimientos_Controladora;


        public Movimientos_Controladora()
        {
            this._pMovimientos_Controladora = new Persistencia_Movimientos_Controladora();

        }

        public bool AltaMovimiento(Movimientos pMovimiento)
        {
            return _pMovimientos_Controladora.PAltaMovimiento(pMovimiento);
        }

        public bool BajaMovimiento(int pId)
        {
            return _pMovimientos_Controladora.PBajaMovimiento(pId);
        }
    }
}
