using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa_exercicio_cotacao_moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, euro, ouro, invest;

            Console.WriteLine("Informe a cotação do Dolar: ");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a cotação do Euro: ");
            euro = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a cotação do Ouro: ");
            ouro = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o seu investimento em reais: ");
            invest = double.Parse(Console.ReadLine());

            dolar = invest / dolar;
            euro = invest / euro;
            ouro = invest / ouro;

            Console.WriteLine("\n\nValor em dolar: US$" + Math.Round(dolar, 2)
                + "\n\nValor em euro: US$" + Math.Round(euro, 2)
                + "\n\nValor em ouro: US$" + Math.Round(ouro, 2) + "!");

            Console.ReadKey();
        }
    }
}
