using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("123", "Modelo 1", "00000000", 128);
Iphone i1 = new Iphone("456", "Modelo 2", "11111111", 256);

n1.Ligar();
n1.InstalarAplicativo("WhatsApp");
n1.ReceberLigacao();

i1.Ligar();
i1.InstalarAplicativo("Facebook");
i1.ReceberLigacao();