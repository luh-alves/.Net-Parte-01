using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalavraBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            for (int contL = 0; contL < 10; contL++)
            {
                for(int contC = 0; contC < 10; contC++)
                {
                    Console.Write("*");
                    if (contC >= contL)
                    {
                        break;

                    }
                 
                }
                Console.WriteLine();
            }

            for (int contL = 0; contL < 10; contL++)
            {
                for (int contC = 0; contC <= contL; contC++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
