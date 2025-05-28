using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosIdade
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                string nome, cpf, profissao;
                int anoNascimento, idade;

                Console.WriteLine("Informe o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Informe o CPF: ");
                cpf = Console.ReadLine();
                Console.WriteLine("Informe a profissão: ");
                profissao = Console.ReadLine();
                Console.WriteLine("Informe o ano de nascimento: ");
                anoNascimento=Convert.ToInt32(Console.ReadLine());
                
                idade = 2025 - anoNascimento;

                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"CPF: {cpf}");
                Console.WriteLine($"Profissão: {profissao}");
                Console.WriteLine($"Ano de Nascimento: {anoNascimento}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
