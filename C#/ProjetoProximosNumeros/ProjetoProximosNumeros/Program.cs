using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProximosNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objetivo: solicitar um Nº inteiro e exibir os próximos 7 números do nº informado
            Console.WriteLine("Informe um número: ");
            int numero=Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"Os próximos 7 números são : " + $"{i + numero}");
            }
            Console.ReadKey();
        }
    }
}
