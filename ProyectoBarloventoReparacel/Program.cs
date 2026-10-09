using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using ProyectoBarloventoReparacel.Vistas;
using ProyectoBarloventoReparacel.Vistas.Vistas_AMBCliente.Alta;
using ProyectoBarloventoReparacel.Vistas.Vistas_Clientes;
using ProyectoBarloventoReparacel.Vistas.Vistas_Clientes.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Modificar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.Patron;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.SeleccionarPOrden;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseña;
using ProyectoBarloventoReparacel.Vistas.Vistas_Dispositivos.VerContraseñaPatron;
using ProyectoBarloventoReparacel.Vistas.Vistas_Estadisticas;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Agregar;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Filtros;
using ProyectoBarloventoReparacel.Vistas.Vistas_Movimientos.Home;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.FacturarOrden;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Filtros;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Home;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Infn;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Informacion;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.InformacionPropietario;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.Modificar;
using ProyectoBarloventoReparacel.Vistas.Vistas_OrdenReparacion.WhatsApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBarloventoReparacel
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmIniciarSesión());

        }
    }
}
