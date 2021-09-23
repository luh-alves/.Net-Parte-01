using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 3;
            if(idadeJoao >= 18 )
            {
                Console.WriteLine("João possui mais de 18 anos , pode entrar!!!");
                Console.WriteLine("Seja bem vindo");
            }
            else if (quantidadePessoas>=2)
            {
                Console.WriteLine("Você não tem mais de 18 , mais pode entrar , pois está acompanhado");
            }
            else
            {
                Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
