using DesafioPOO.Models;

//Precisei mudar para NET 8.0 para rodar no meu Visual Studio


// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    { 
        Console.Clear();


        Console.WriteLine($"Teste Nokia: \n");
        Smartphone nokia = new Nokia("123456789", "Nokia", "Modelo X", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
        nokia.FazerLigacao();
        nokia.ReceberLigacao();
        nokia.DesligarAparelho();
        Console.WriteLine();


        Console.WriteLine($"Teste Iphone: \n");
        Smartphone iphone = new Iphone("987654321", "Apple", "iPhone 13", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");
        iphone.FazerLigacao();
        iphone.ReceberLigacao();
        iphone.DesligarAparelho();
    }
}