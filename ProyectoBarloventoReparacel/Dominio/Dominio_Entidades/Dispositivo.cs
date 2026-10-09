using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio
{
    internal class Dispositivo
    {
        public int IdDispositivo { get; set; }
        public string Observacion { get; set; }
        public string Tipo { get; set; }
        public string NumeroDeSerie { get; set; }
        public string Contraseña { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patron { get; set; }
        public int IdCliente { get; set; }


        public Dispositivo(int idCliente, string observacion, string tipo, string numeroDeSerie, string contraseña, string marca, string modelo, string patron)
        {
            IdCliente = idCliente;
            Observacion = observacion;
            Tipo = tipo;
            NumeroDeSerie = numeroDeSerie;
            Contraseña = contraseña;
            Marca = marca;
            Modelo = modelo;
            Patron = patron;
        }

        public Dispositivo(int id, string numeroDeSerie, string observacion, string tipo,  string contraseña, string marca, string modelo, string patron, int idCliente)
        {
            IdDispositivo = id;
            NumeroDeSerie = numeroDeSerie;
            Observacion = observacion;
            Tipo = tipo;
            Contraseña = contraseña;
            Marca = marca;
            Modelo = modelo;
            Patron = patron;
            IdCliente = idCliente;
        }
    }
}
