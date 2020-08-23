namespace Uned.TecnoCR.LogicaNegocio.Entidades
{
    public class SolicitudDeAltasDenominaciones
    : SolicitudDeCredito
    {
        public SolicitudDeAltasDenominaciones(double elMontoSolicitadoEnColones, int elPlazoEnMeses)
            : base(elMontoSolicitadoEnColones, elPlazoEnMeses)
        {
            LaDescripcion = "Altas denominaciones";
            LaTasaDeInteres = 0.1;
        }
        public override double CalculeLaMensualidad()
        {
            return (ElMontoSolicitadoEnColones * (1 + LaTasaDeInteres)) / ElPlazoEnMeses;
        }
    }
}
