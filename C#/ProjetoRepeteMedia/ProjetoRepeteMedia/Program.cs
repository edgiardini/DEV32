using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRepeteMedia
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int quantidadeNotas = 5;
            double[] notas = new double[quantidadeNotas];
            double soma = 0;

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}: ");
                notas [i] = double.Parse( Console.ReadLine() );
                soma += notas[i];
            }

            double media = soma / quantidadeNotas;

            Console.WriteLine($"Média: {media}");

            if (media >= 6)
            {
                Console.WriteLine("Aprovado!");
            }

            else
            {
                Console.WriteLine("Reprovado!");

                
            }
        Console.ReadKey();
        }
    }
}
