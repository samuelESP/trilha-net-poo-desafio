using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: \n");
Smartphone nokia = new Nokia("123", " Nokia C20", "111111111111111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
nokia.ExibirDados();



Console.WriteLine("Iphone: \n");
Smartphone iphone = new Iphone("456", "16", "", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitch");
iphone.ExibirDados();

