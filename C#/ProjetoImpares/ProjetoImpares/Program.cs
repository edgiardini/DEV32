using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImpares
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero, limite;

            Console.WriteLine("Digite um número: ");
            numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um limite: ");
            limite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Números ímpares de {numero} até {limite}");

            if (numero % 2 == 0)
            {
                numero++;
            }

            for (int i = numero; i <= limite; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
