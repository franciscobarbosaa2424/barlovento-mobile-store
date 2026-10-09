using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio.Dominio_Entidades
{
    internal class Movimientos
    {
        public int IdMovimiento { get; set; }
        public string TipoDeMovimiento { get; set; }
        public decimal Monto { get; set; }
        public DateTime? _fecha;
        public int? IdOrden { get; set; }

        public DateTime? Fecha
        {
            get { return _fecha; } // Devuelve el valor nullable original
            set { _fecha = value; } // Asigna el valor directamente, ya es nullable
        }

        public Movimientos(string tipoDeMovimiento, decimal monto, DateTime fecha, int idOrden)
        {
            TipoDeMovimiento = tipoDeMovimiento;
            Monto = monto;
            _fecha = fecha;
            IdOrden = idOrden;
        }

        public Movimientos(string tipoDeMovimiento, decimal monto, DateTime fecha)
        {
            TipoDeMovimiento = tipoDeMovimiento;
            Monto = monto;
            _fecha = fecha;
        }
    }
}
