using System;

namespace Uned.TecnoCR.LogicaNegocio.Entidades
{
    public abstract class SolicitudDeCredito
    {
        public double ElMontoSolicitadoEnColones { get; set; }
        public int ElPlazoEnMeses { get; set; }
        public string LaDescripcion { get; protected set; }
        public double LaTasaDeInteres { get; protected set; }
        public DateTime LaFechaDeSolicitud { get; set; }        
        public abstract double CalculeLaMensualidad();
    }
}
