using System;
using Uned.TecnoCR.LogicaNegocio.Entidades;

namespace Uned.TecnoCR
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoy = DateTime.Now;
            var solicitud1 = new SolicitudTasaCero()
            {
                ElMontoSolicitadoEnColones = 50000,
                ElPlazoEnMeses = 12,
                LaFechaDeSolicitud = hoy
            };
            var solicitud2 = new SolicitudDeAltasDenominaciones()
            {
                ElMontoSolicitadoEnColones = 1000000,
                ElPlazoEnMeses = 20,
                LaFechaDeSolicitud = hoy
            };
            ImprimaCondicionesDeLaSolicitud(solicitud1);
            Console.WriteLine("------------------------------------------------------");
            ImprimaCondicionesDeLaSolicitud(solicitud2);
            Console.ReadLine();
        }
        static void ImprimaCondicionesDeLaSolicitud(SolicitudDeCredito laSolicitud)
        {            
            Console.WriteLine($"Tipo: [{laSolicitud.LaDescripcion}]");
            Console.WriteLine($"Solicitada el: [{laSolicitud.LaFechaDeSolicitud.ToString("dd/MM/yyyy")}]");
            Console.WriteLine($"El monto es de: [{laSolicitud.ElMontoSolicitadoEnColones}] colones");
            Console.WriteLine($"La tasa de interés es de: [{laSolicitud.LaTasaDeInteres}]. ");
            Console.WriteLine($"El plazo es de: [{laSolicitud.ElPlazoEnMeses}] meses. ");
            Console.WriteLine($"La mensualidad a pagar es: [{laSolicitud.CalculeLaMensualidad()}] colones");
        }
    }
}
