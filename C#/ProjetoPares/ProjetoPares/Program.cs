using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPares
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exibir todos os números pares de 1 a 20
            //dica: usar ao invés de i++ -> i+=2

            
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine($"Números pares: {i}");
            }
            Console.ReadKey();
        }
    }
}
