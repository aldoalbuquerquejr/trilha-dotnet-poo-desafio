using DesafioPOO.Models;

//Testes com o celular 1
Iphone cellPhone1 = new Iphone();
Console.WriteLine("Coletando dados do Iphone: ");
Console.Write("Número: ");
cellPhone1.Numero = Console.ReadLine();
Console.Write("Modelo: ");
cellPhone1.Modelo = Console.ReadLine();
Console.Write("IMEI: ");
cellPhone1.IMEI = Console.ReadLine();
Console.Write("Memória: ");
cellPhone1.Memoria = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual aplicativo deseja instalar? ");
cellPhone1.NomeApp = Console.ReadLine();

Console.WriteLine("\n---------------------------\n");

cellPhone1.Ligar();
Console.WriteLine("Exibindo dados do Iphone: ");
Console.WriteLine($"Número: {cellPhone1.Numero}");
Console.WriteLine($"Modelo: {cellPhone1.Modelo}");
Console.WriteLine($"IMEI: {cellPhone1.IMEI}");
Console.WriteLine($"Memória: {cellPhone1.Memoria} GB");
cellPhone1.InstalarAplicativo(cellPhone1.NomeApp);
cellPhone1.ReceberLigacao();
cellPhone1.Desigar();

//Testes com o celular 2
Console.WriteLine("\n---------------------------\n");

Nokia cellPhone2 = new Nokia();
Console.WriteLine("Coletando dados do Nokia: ");
Console.Write("Número: ");
cellPhone2.Numero = Console.ReadLine();
Console.Write("Modelo: ");
cellPhone2.Modelo = Console.ReadLine();
Console.Write("IMEI: ");
cellPhone2.IMEI = Console.ReadLine();
Console.Write("Memória: ");
cellPhone2.Memoria = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual aplicativo deseja instalar? ");
cellPhone2.NomeApp = Console.ReadLine();

Console.WriteLine("\n---------------------------\n");

cellPhone2.Ligar();
Console.WriteLine("Exibindo dados do Nokia: ");
Console.WriteLine($"Número: {cellPhone2.Numero}");
Console.WriteLine($"Modelo: {cellPhone2.Modelo}");
Console.WriteLine($"IMEI: {cellPhone2.IMEI}");
Console.WriteLine($"Memória: {cellPhone2.Memoria} GB");
cellPhone2.InstalarAplicativo(cellPhone2.NomeApp);
cellPhone2.ReceberLigacao();
cellPhone2.Desigar();