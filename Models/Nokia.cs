namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public string NomeApp { get; set; }
        public Nokia()
        {

        }

        public Nokia(string numero, string modelo, string imei, int memoria, string nomeApp) : base(numero, modelo, imei, memoria)
        {
            NomeApp = nomeApp;
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando Nokia...");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no dispositivo Nokia..");
        }

        public override void Desigar()
        {
            Console.WriteLine("Desligando Nokia...");
        }
    }
}