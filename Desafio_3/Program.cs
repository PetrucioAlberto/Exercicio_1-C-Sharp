using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //// ###################### desafio 3 #############################################



            Desafio_3 calculadora = new Desafio_3();


            while (true)
            {
                Console.WriteLine("Digite a operacao no formato (ex: 3 + 5) com espaco entre os numeros");
                string entrada = Console.ReadLine();

                string[] separar = entrada.Split(' ');
                if (separar.Length != 3)
                {
                    Console.WriteLine("Entrada invalida! Tente novamente.");
                    continue;
                }

                double num1, num2;
                if (!double.TryParse(separar[0], out num1) || !double.TryParse(separar[2], out num2))
                {
                    Console.WriteLine("Números invalidos! Tente novamente.");
                    continue;
                }

                char operador = separar[1][0];

                double resultado = calculadora.Calcular(num1, num2, operador);

                Console.WriteLine("Resultado: " + resultado);

                Console.WriteLine("Deseja realizar outra operacao? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() != "s")
                    break;
            }



        }
    }
}
