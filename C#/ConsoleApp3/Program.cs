using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Nome, Sobrenome, Origem, Destino, CPF;
            
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Sobrenome: ");
            Sobrenome = Console.ReadLine();

            Console.WriteLine("Origem: ");
            Origem = Console.ReadLine();

            Console.WriteLine("Destino: ");
            Destino = Console.ReadLine();

            Console.WriteLine("CPF:");
            CPF = Console.ReadLine();

            Console.WriteLine("\nNome: "+Nome);
            Console.WriteLine("\nSobrenome: "+Sobrenome);
            Console.WriteLine("\nOrigem: "+Origem);
            Console.WriteLine("\nDestino: "+Destino);
            Console.WriteLine("\nCPF: "+CPF);

            Console.ReadKey();

        }
    }
}
