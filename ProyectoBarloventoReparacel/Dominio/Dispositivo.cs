using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarloventoReparacel.Dominio
{
    internal class Dispositivo
    {
        private int _idDispositivo;
        private string _tipoDispositivo;
        private string _marcaDispositivo;
        private string _modeloDispositivo;
        private int _numeroDeSerieDospositivo;
        private DateTime _fechaFabricacionDispositivo;
        private string _observacionDispositivo;

        public int Id
        {
            get { return _idDispositivo; }
            set { _idDispositivo = value; }
        }

        public string Tipo
        {
            get { return _tipoDispositivo; }
            set { _tipoDispositivo = value; }
        }

        public string Marca
        {
            get { return _marcaDispositivo; }
            set { _marcaDispositivo = value; }
        }

        public string Modelo
        {
            get { return _modeloDispositivo; }
            set { _modeloDispositivo = value; }
        }

        public int NumeroDeSerie
        {
            get { return _numeroDeSerieDospositivo; }
            set { _numeroDeSerieDospositivo = value; }
        }

        //public string FechaFabricacion
        // {
        //get { return _fechaFabricacionDispositivo; }
        //set { _modeloDispositivo = value; }
        //}

        public string Observacion
        {
            get { return _observacionDispositivo; }
            set { _observacionDispositivo = value; }
        }

        public override string ToString()
        {
            return this.Id + " " + this.Tipo + " " + this.Marca + " " + this.NumeroDeSerie + " " + this.Observacion;
        }

        public Dispositivo(int pId, string pTipo, string pMarca, string pModelo, int pNumeroDeSerie, string pObservacion)
        {
            this.Id = pId;
            this.Tipo = pTipo;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.NumeroDeSerie = pNumeroDeSerie;
            this.Observacion = pObservacion;

        }
    }
}
