using IOC_DI_Guitarra.service;

namespace IOC_DI_Guitarra.bancoPedais
{
    public class Drive : IPedaleira
    {
        public string Efeito()
        {
            return "Trishhhhhhh Grouuu!";
        }
    }
}