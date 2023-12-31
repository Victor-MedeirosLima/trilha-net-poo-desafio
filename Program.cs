using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("998765", "modelo 5", "22222", 64);

nokia.Ligar();
nokia.InstalarAplicativo("Facebook");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Smartphone iphone = new Iphone("12345", "modelo 15", "5423", 256);

iphone.Ligar();
iphone.InstalarAplicativo("Tinder");
iphone.ReceberLigacao();