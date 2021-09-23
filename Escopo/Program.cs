using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            

            if (acompanhado == true)
            {
                string mensagem = "João está acompanhado";
                Console.WriteLine(mensagem);
            }
            else
            {
                string mensagem = "João não está acompanhado";
                Console.WriteLine(mensagem);
            }

            if (idadeJoao >= 18 && acompanhado == true)
            {
                ;
                Console.WriteLine("Pode entrar");
                
            }
            else
            {
                Console.WriteLine(" Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
