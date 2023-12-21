using IOC_DI_Guitarra.service;

namespace IOC_DI_Guitarra
{
    public class Guitarra
    {
        private IPedaleira _efeitoPedal;

        public Guitarra(IPedaleira efeitoPedal)
        {
            _efeitoPedal = efeitoPedal;
        }

        public string Tocar()
        {
            return _efeitoPedal.Efeito();
        }

    }
}