using DesafioPOO.Models;
Nokia nk = new Nokia("996589875", "Startack", "00654", 32);

nk.InstalarAplicativo("Telegram");
nk.Ligar();
nk.ReceberLigacao();
System.Console.WriteLine($"O cel é: {nk.Numero}, do modelo: {nk.Modelo}," +
 $" com o Imei: {nk.IMEI}, e com: {nk.Memoria} de memoria ");



Iphone iph = new Iphone("81174589", "Iphone 11", "00123", 64);
iph.InstalarAplicativo("Binance");
iph.Ligar();
iph.ReceberLigacao();
System.Console.WriteLine($"O cel é: {iph.Numero}, do modelo: {iph.Modelo}," +
 $" com o imei: {iph.IMEI}, e com: {iph.Memoria} de memoria ");







