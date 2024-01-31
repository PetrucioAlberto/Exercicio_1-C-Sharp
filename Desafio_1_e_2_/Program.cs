using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1_e_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// ###################### Desafio 1 e 2 ########################################

            Desafio_1_e_2 cal = new Desafio_1_e_2();


            do
            {
                Console.WriteLine("##################################################");
                Console.WriteLine("#          Bem-vindo à Nossa Calculadora         #");
                Console.WriteLine("##################################################");
                Console.WriteLine("# 1 - Somar                                      #");
                Console.WriteLine("# 2 - Subtrair                                   #");
                Console.WriteLine("# 3 - Multiplicar                                #");
                Console.WriteLine("# 4 - Dividir                                    #");
                Console.WriteLine("##################################################");
                Console.Write("# Digite sua opção: ");
                string escolha = Console.ReadLine();
                Console.WriteLine("==================================================");

                int num1, num2;



                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Operação escolhida é: SOMA");
                        Console.Write("Digite o primeiro número : ");
                        if (!int.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        Console.Write("Digite o segundo número da soma  : ");
                        if (!int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        cal.somar(num1, num2);
                        break;

                    case "2":
                        Console.WriteLine("Operação escolhida é SUBTRAÇÃO");
                        Console.WriteLine("Digite o primeiro número ");
                        if (!int.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        Console.Write("Digite o segundo número  : ");
                        if (!int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        cal.subtrair(num1, num2);
                        break;

                    case "3":
                        Console.WriteLine("Operação escolhida é MULTIPLICAÇÃO");
                        Console.WriteLine("Digite o primeiro numero ");
                        if (!int.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        Console.Write("Digite o segundo número   : ");
                        if (!int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        cal.multi(num1, num2);
                        break;

                    case "4":
                        Console.WriteLine("Operação escolhida é DIVISÃO");
                        Console.WriteLine("Digite o primeiro numero ");
                        if (!int.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        Console.Write("Digite o segundo número  : ");
                        if (!int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Entrada inválida ");
                            break;
                        }
                        cal.divi(num1, num2);
                        break;



                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }





                Console.Write("Deseja continuar S/N ?");



            }
            while (Console.ReadLine().ToLower() == "s");





        }
    }
}
