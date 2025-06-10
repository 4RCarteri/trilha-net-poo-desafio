using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto do tipo Nokia
        Smartphone nokia = new Nokia("123456789", "Modelo Nokia", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um objeto do tipo Iphone
        Smartphone iphone = new Iphone("987654321", "Modelo iPhone", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
