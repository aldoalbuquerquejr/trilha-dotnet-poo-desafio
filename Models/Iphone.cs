namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string NomeApp { get; set; }
        public Iphone()
        {

        }
        
        public Iphone(string numero, string modelo, string imei, int memoria, string nomeApp) : base(numero, modelo, imei, memoria)
        {
            NomeApp = nomeApp;
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando Iphone...");
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no dispositivo Iphone..");
        }

        public override void Desigar()
        {
            Console.WriteLine("Desligando Iphone...");
        }
    }
}