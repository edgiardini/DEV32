using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSimulaCaixa
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
            int[] quantidadeCedulas = new int[cedulas.Length];

            Console.WriteLine("Digite o valor para saque: ");
            int valorSaque = int.Parse(Console.ReadLine());

            int valorRestante = valorSaque;
            int i = 0;

            while (valorRestante > 0 && i < cedulas.Length)
            {
                if (valorRestante >= cedulas[i])
                {
                    quantidadeCedulas[i] = valorRestante / cedulas[i];
                    valorRestante %= cedulas[i];
                }
                i++;
            }

            if (valorRestante == 0)
            {
                Console.WriteLine($"Saque de R$ {valorSaque} realizado com sucesso!");
                Console.WriteLine("Cédulas fornecidas:");
                for (int j = 0; j < cedulas.Length; j++)
                {
                    if (quantidadeCedulas[j] > 0)
                    {
                        Console.WriteLine($"{quantidadeCedulas[j]} cédula(s) de R$ {cedulas[j]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque com as cédulas disponíveis!");
            }

            Console.ReadKey();
        }
    }
}
