using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double rendimentos = 1.0036;
            double valor = 1000;

            for (int contA = 1; contA <= 5; contA++)
            {
                for(int contM = 1; contM <= 12; contM++)
                {
                    valor = valor * rendimentos;
                }
                rendimentos += 0.0010;
            }
            Console.WriteLine("Ao termino terá " + valor);

            Console.ReadLine();

        }
    }
}
