namespace Uned.TecnoCR.LogicaNegocio.Entidades
{
    public class SolicitudTasaCero
        : SolicitudDeCredito
    {
        public SolicitudTasaCero(double elMontoSolicitadoEnColones, int elPlazoEnMeses)
            : base(elMontoSolicitadoEnColones, elPlazoEnMeses)
        {
            LaTasaDeInteres = 0;
            LaDescripcion = "Tasa 0";
        }
        public override double CalculeLaMensualidad()
        {
            return ElMontoSolicitadoEnColones / ElPlazoEnMeses;
        }
    }
}
