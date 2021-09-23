using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100

            int cont;

            for (cont = 1; cont <= 100; cont++)
            {
                if (cont % 3 == 0)
                {
                    Console.WriteLine(cont + " É um numero multiplo de 3");

                }

            }

            Console.ReadLine(); 
        }
    }
}
