using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1_e_2_
{
    internal class Desafio_1_e_2
    {


        public void somar(int num1, int num2)
        {

            Console.WriteLine($" ==== resultado  de {num1} + {num2} =  {num1 + num2} ====");
        }

        public void subtrair(int num1, int num2)
        {

            Console.WriteLine($" ==== O resultado  de {num1} - {num2} =  {num1 - num2} ====");
        }

        public void multi(int num1, int num2)
        {


            Console.WriteLine($" ==== O resultado  de {num1} * {num2} =  {num1 * num2} ====");

        }

        public void divi(double num1, double num2)
        {

            if (num2 != 0)
            {
                Console.WriteLine($" ==== O resultado  de {num1} / {num2} =  {num1 / num2} ====");
            }
            else
            {

                Console.WriteLine("Nao pode ser divido por zero, tente de novo");

            }

        }



    }
}
