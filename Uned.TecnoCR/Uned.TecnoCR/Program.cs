using System;
using Uned.TecnoCR.LogicaNegocio.Entidades;

namespace Uned.TecnoCR
{
    class Program
    {
        static void Main(string[] args)
        {
            var solicitud1 = new SolicitudTasaCero(120, 12);
            var solicitud2 = new SolicitudDeAltasDenominaciones(1000000, 20);
            ImprimaCondicionesDeLaSolicitud(solicitud1);
            Console.WriteLine();
            ImprimaCondicionesDeLaSolicitud(solicitud2);
            Console.ReadLine();
        }
        static void ImprimaCondicionesDeLaSolicitud(SolicitudDeCredito laSolicitud)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"La solicitud es de tipo [{laSolicitud.LaDescripcion}]");
            Console.WriteLine($"El monto solicitado es de [{laSolicitud.ElMontoSolicitadoEnColones}] colones");
            Console.WriteLine($"La tasa de interés es de [{laSolicitud.LaTasaDeInteres}]. ");
            Console.WriteLine($"El plazo es de [{laSolicitud.ElPlazoEnMeses}] meses. ");
            Console.WriteLine($"La mensualidad a pagar es: [{laSolicitud.CalculeLaMensualidad()}] colones");
        }
    }
}
