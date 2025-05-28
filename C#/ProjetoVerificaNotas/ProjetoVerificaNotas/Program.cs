using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVerificaNotas
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int numAlunos = 4;
            double[] notas = new double[numAlunos];
            double soma = 0;
            double media;

            Console.WriteLine("Digite as notas dos 4 alunos:");

            for (int i = 0; i < numAlunos; i++)
            {
                Console.Write($"Nota do aluno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                soma += notas[i];
            }

            media = soma / numAlunos;

            Console.WriteLine($"\nMédia da turma: {media:F2}");

            foreach (double nota in notas)
            {
                if (nota >= 7)
                    Console.WriteLine($"Nota {nota:F2} - Aprovado");
                else if (nota >= 5)
                    Console.WriteLine($"Nota {nota:F2} - Recuperação");
                else
                    Console.WriteLine($"Nota {nota:F2} - Reprovado");
            }
            Console.ReadKey();
        
        }

    }
}
