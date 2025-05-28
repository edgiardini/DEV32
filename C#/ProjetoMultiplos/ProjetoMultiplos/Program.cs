using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMultiplos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exibir os múltiplos de um número até um limite
            //i+=numero
            int numero, limite;
            Console.WriteLine("Digite um número: ");
            numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um limite: ");
            limite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Múltiplos de {numero} até {limite}: ");
            for (int i = numero; i <= limite; i+=numero)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
