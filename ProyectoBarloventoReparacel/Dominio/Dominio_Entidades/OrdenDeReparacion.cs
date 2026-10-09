using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoBarloventoReparacel.Persistencia;

namespace ProyectoBarloventoReparacel.Dominio
{
    internal class OrdenDeReparacion
    {
        private int _idOrdenDeReparacion;
        private DateTime _fechaIngreso;
        protected int _cliente;
        protected int _dispositivo;
        private string _fallaDispositivo;
        private string _estadoDispositivo;
        private List<byte[]> _imagen;
        private DateTime? _fechaEgreso;

        public decimal Presupuesto { get; set; }
        public decimal Materiales { get; set; }
        public decimal ManoDeObra { get; set; }
        public decimal Total { get; set; }

        public int Id
        {
            get { return _idOrdenDeReparacion; }
            set { _idOrdenDeReparacion = value; }
        }

        public string FechaIngreso
        {
            get { return _fechaIngreso.ToString("dd-MM-yyyy HH:mm"); } // Cambia el formato 
            set { _fechaIngreso = DateTime.Parse(value); } // Parse string a DateTime
        }
        public DateTime? FechaEgreso
        {
            get { return _fechaEgreso; }
            set { _fechaEgreso = value; }
        }

        public int Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public int Dispositivo
        {
            get { return _dispositivo; }
            set { _dispositivo = value; }
        }

        public string Falla
        {
            get { return _fallaDispositivo; }
            set { _fallaDispositivo = value; }
        }

        public string Estado
        {
            get { return _estadoDispositivo; }
            set { _estadoDispositivo = value; }
        }
        public List<byte[]> Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        public int IdOrden { get; }

        public OrdenDeReparacion()
        {
        }

        public OrdenDeReparacion(DateTime fechaIngreso, DateTime fechaEgreso, int cliente, int dispositivo, string fallaDispositivo, string estadoDispositivo, List<byte[]> imagen)
        {
            _fechaIngreso = fechaIngreso;
            _fechaEgreso = fechaEgreso;
            _cliente = cliente;
            _dispositivo = dispositivo;
            _fallaDispositivo = fallaDispositivo;
            _estadoDispositivo = estadoDispositivo;
            _imagen = imagen;
        }

        public OrdenDeReparacion(DateTime fechaIngreso, int idCliente, int idDispositivo, string falla, string estado, List<byte[]> imagen)
        {
            this._fechaIngreso = fechaIngreso;
            this._cliente = idCliente;
            this._dispositivo = idDispositivo;
            Falla = falla;
            Estado = estado;
            Imagen = imagen;
        }

        public OrdenDeReparacion(int id, int idCliente, int idDispositivo, string falla, List<byte[]> imagen)
        {
            Id = id;
            this._cliente = idCliente;
            this._dispositivo = idDispositivo;
            Falla = falla;
            Imagen = imagen;
        }


        public OrdenDeReparacion(int id, int cliente, int dispositivo, DateTime? fechaEgreso, string pEstado, decimal precioPresupuesto, decimal precioMateriales, decimal precioManoDeObra, decimal total, string pFalla)
        {
            Id = id;
            _cliente = cliente;
            _dispositivo = dispositivo;
            _fechaEgreso = fechaEgreso;
            Presupuesto = precioPresupuesto;
            Materiales = precioMateriales;
            ManoDeObra = precioManoDeObra;
            Total = total;
            Estado = pEstado;
            Falla = pFalla;
        }

        public OrdenDeReparacion(DateTime fechaIngreso, int cliente, int dispositivo, string fallaDispositivo, string estadoDispositivo)
        {
            _fechaIngreso = fechaIngreso;
            _cliente = cliente;
            _dispositivo = dispositivo;
            _fallaDispositivo = fallaDispositivo;
            _estadoDispositivo = estadoDispositivo;
        }

        public OrdenDeReparacion(int idOrden, string falla, string estado, List<byte[]> imagen)
        {
            _idOrdenDeReparacion = idOrden;
            _fallaDispositivo = falla;
            _estadoDispositivo = estado;
            Imagen = imagen;
        }
    }
}
