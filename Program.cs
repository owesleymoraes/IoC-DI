
using IOC_DI_Guitarra;
using IOC_DI_Guitarra.bancoPedais;

var guitarrista = new Guitarra(new Chorus());

Console.WriteLine(guitarrista.Tocar());