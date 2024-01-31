using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Desafio_4 bissexto = new Desafio_4();

            Console.WriteLine("Digite um ano no formato (ex: 2022) para verificar se e bissexto:");
            string entrada = Console.ReadLine();

            int ano;

            if (int.TryParse(entrada, out ano))
            {
                if (bissexto.AnoBissexto(ano))
                {
                    Console.WriteLine($"{ano} e um ano bissexto.");
                }
                else
                {
                    Console.WriteLine($"{ano} não e um ano bissexto.");
                }
            }
            else
            {
                Console.WriteLine("Entrada invalida!! Certifique-se de digitar um ano valido no formato YYYY.");
            }

            



        }
    }
}
