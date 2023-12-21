
using IOC_DI_Guitarra.service;

namespace IOC_DI_Guitarra.bancoPedais
{
    public class Chorus : IPedaleira
    {
        public string Efeito()
        {
            return "Trilinnnn Trin Trin clin Trin!";
        }
    }
}