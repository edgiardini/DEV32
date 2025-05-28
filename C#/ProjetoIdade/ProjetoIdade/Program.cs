using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIdade
{
    public class Program
    {
        static void Main(string[] args)
        {
            int idade;

            
            Console.WriteLine("INFORME A IDADE: ");

            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 13)
            {
                Console.WriteLine("CRIANÇA");
            }

            else if (idade >= 13 && idade <= 17)
            {
                Console.WriteLine("ADOLESCENTE");
            }

            else if (idade >=18 && idade <=59)
            {
                Console.WriteLine("ADULTO");
            }
            else if (idade>=60)
            {
                Console.WriteLine("IDOSO");
            }

            Console.ReadKey();

        }


                


        }
    }

