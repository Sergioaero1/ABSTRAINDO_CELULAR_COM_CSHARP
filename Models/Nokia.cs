
using System.Reflection;

namespace ABSTRAINDO_CELULAR.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

    // TODO: Sobrescrever o método "InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp, string modelo, string imei, int memoria)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia Modelo: '{modelo}', IMEI: '{imei}', Memória: '{memoria}'");
        }
    }
}