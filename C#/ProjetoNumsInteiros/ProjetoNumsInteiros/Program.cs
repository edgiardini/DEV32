using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNumsInteiros
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Digite 1 número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("Número Positivo!");
                }
                else if (numero == 0)
                {
                    Console.WriteLine("Número Neutro!");
                }

                else if (numero < 0)
                        {
                    Console.WriteLine("Número Negativo!");
                }
            }
            Console.ReadKey();


        }


    }
}

