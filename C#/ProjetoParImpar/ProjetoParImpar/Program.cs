using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoParImpar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objetivo: verificar se é par ou ímpar

            int numero;

            Console.WriteLine("Este número é par ou ímpar? ");

            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("ESTE NÚMERO É PAR!");
            }
            else
            {
                Console.WriteLine("ESTE NÚMERO É ÍMPAR!");
            }

            Console.ReadKey();

        }
    }
}
