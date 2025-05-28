using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadoraSimples
{
    public class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, total;



            Console.WriteLine("Informe Valor 1: ");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe Valor 2: ");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a Operação Matemática: ");
            Console.WriteLine("1 Soma / 2 Subtração / 3 Multiplicação / 4 Divisão");
            total = Convert.ToInt32(Console.ReadLine());


            switch (total)
            {
                case 1:
                    Console.WriteLine(val1 + val2);
                    break;
                case 2:
                    Console.WriteLine(val1 - val2);
                    break;
                case 3:
                    Console.WriteLine(val1 * val2);
                    break;
                case 4:
                    Console.WriteLine(val1 / val2);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            Console.ReadKey();


        }

    }
}

