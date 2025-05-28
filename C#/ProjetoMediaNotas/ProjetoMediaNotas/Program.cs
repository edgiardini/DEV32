using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMediaNotas
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, media;
            string aluno;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Aluno: ");
                aluno = Console.ReadLine();

                Console.WriteLine("Nota 1: ");
                nota1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Nota 2: ");
                nota2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Nota 3: ");
                nota3 = Convert.ToDecimal(Console.ReadLine());
                media = (nota1 + nota2 + nota3) / 3;

                if (media >= 7)
                {
                    Console.WriteLine("Média: " + media + " Aluno Aprovado!");
                }
                else if (media < 7 && media >= 5)
                {
                    Console.WriteLine("Média: " + media + " Aluno em Recuperação!");
                }
                else if (media < 5)
                {
                    Console.WriteLine("Média: " + media + " Aluno Reprovado!");
                }

                Console.ReadKey();

            }




        }
    }
}
