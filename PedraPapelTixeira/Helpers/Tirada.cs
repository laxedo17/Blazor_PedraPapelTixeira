namespace PedraPapelTixeira.Helpers
{
    public class Tirada
    {
        public OpcionPPT Eleccion { get; set; }
        public OpcionPPT GanaContra { get; set; }
        public OpcionPPT PerdeContra { get; set; }
        public string Imaxe { get; set; }

        public XogoStatus XogaContra(Tirada tiradaOponente)
        {
            if (Eleccion == tiradaOponente.Eleccion)
            {
                return XogoStatus.Empate;
            }

            if (PerdeContra == tiradaOponente.Eleccion)
            {
                return XogoStatus.Derrota;
            }

            return XogoStatus.Victoria;
        }
    }
}