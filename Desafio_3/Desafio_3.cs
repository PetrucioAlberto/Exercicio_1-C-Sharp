using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    internal class Desafio_3
    {

        public double Calcular(double num1, double num2, char operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case '+': resultado = num1 + num2; break;
                case '-': resultado = num1 - num2; break;
                case '*': resultado = num1 * num2; break;
                case '/':
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Divisao por zero nao é permitida!");
                    break;
                default:
                    Console.WriteLine("Operador invalido! Tente novamente.");
                    break;
            }

            return resultado;



        }
    }
}
