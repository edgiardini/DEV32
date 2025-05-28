using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string destino, tamanho;
            decimal valorfrete, valortamanho = 0, total;

            Console.WriteLine("Informe o destino: ");
            destino = Console.ReadLine().ToUpper(); // Converter para maiúsculas para evitar erro de entrada

            Console.WriteLine("\nTabela de Fretes:");
            Console.WriteLine("AM: R$ 4500,00");
            Console.WriteLine("RO: R$ 4800,00");
            Console.WriteLine("RS: R$ 3600,00");
            Console.WriteLine("RJ: R$ 3500,00");
            Console.WriteLine("Demais UF: R$ 3000,00");

            Console.WriteLine("\nInforme o tamanho (P, M ou G): ");
            tamanho = Console.ReadLine().ToUpper(); // Converter para maiúsculas para evitar erro de entrada

            // Definir o valor do frete com base no destino
            switch (destino)
            {
                case "AM":
                    valorfrete = 4500;
                    break;
                case "RO":
                    valorfrete = 4800;
                    break;
                case "RS":
                    valorfrete = 3600;
                    break;
                case "RJ":
                    valorfrete = 3500;
                    break;
                default:
                    valorfrete = 3000;
                    break;
            }

            // Definir o valor com base no tamanho
            switch (tamanho)
            {
                case "P":
                    valortamanho = 1800;
                    break;
                case "M":
                    valortamanho = 2200;
                    break;
                case "G":
                    valortamanho = 3000;
                    break;
                default:
                    Console.WriteLine("Tamanho inválido. Por favor, escolha entre P, M ou G.");
                    return; // Encerra o programa se o tamanho for inválido
            }

            // Calcular e exibir o total
            total = valorfrete + valortamanho;
            Console.WriteLine($"\nO valor do frete é: R$ {valorfrete}");
            Console.WriteLine($"O valor do tamanho é: R$ {valortamanho}");
            Console.WriteLine($"O valor total é: R$ {total}");

            Console.ReadKey();
        }
    }
}
