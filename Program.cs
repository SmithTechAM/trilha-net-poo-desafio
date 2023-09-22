using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone iPhone");
Smartphone apple = new Iphone("1234","14 pro max","DJ6NGJ1",256);
apple.Ligar();
apple.InstalarAplicativo("Instagram");

Console.WriteLine("SmartPhone Nokia");
Smartphone nokinha = new Nokia("5678","S87G","FGU6A4",64);
nokinha.ReceberLigacao();
nokinha.InstalarAplicativo("Whatsapp");
