namespace ABSTRAINDO_CELULAR.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

    // TODO: Sobrescrever o método "InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp, string modelo, string imei, int memoria)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Iphone / Modelo: '{modelo}' / IMEI: '{imei}' / Memória: '{memoria}' ");
        }
    }
}