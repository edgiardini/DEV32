using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, op, total;

            Console.WriteLine("Valor 1: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Valor 2: ");
            val2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Escolha uma das operações: ");
            Console.WriteLine("1- Soma: ");
            Console.WriteLine("2- Subtração: ");
            Console.WriteLine("3- Multiplicação: ");
            Console.WriteLine("4- Divisão: ");

            op = Convert.ToInt32(Console.ReadLine());


            if (op == 1)
            {
                total = val1 + val2;
                Console.WriteLine("Total: " + total);
            }
            else if (op == 2)
            {
                total = val1 - val2;
                Console.WriteLine("Total: " + total);
            }
            else if (op == 3)
            {
                total = val1 * val2;
                Console.WriteLine("Total: " + total);
            }
            else if (op == 4)
            {
                if (val2 == 0)
                {
                    Console.WriteLine("Valor 2 não pode ser zero!");
                    Console.WriteLine("Tente novamente! ");

                }
                else
                {

                    total = val1 / val2;
                    Console.WriteLine("Total: " + total);
                }

                Console.ReadKey();

            }
        }
    }
}
