using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversõesEOutrosTiposNumericos04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            //int é um tipo de variavel que suporta valores ate 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //o long é uma variavel de 64 bits
            long idade;
            idade = 130000000000000;
            Console.WriteLine(idade);

            //o short é um tipo de variavel de 16 bits
            short quantidadeProduto;
            quantidadeProduto = 15000;
            Console.WriteLine(quantidadeProduto);

            float altura;
            altura = 1.80f;
            Console.WriteLine(altura);

            //float pontoFlutuante = 3.14f;   

            double salario2 = 1270.50;
            int valor = (int)salario2;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);



            Console.ReadLine();
        }
    }
}
