using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInformacoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade, telefone;
            int anoNascimento;
            for (int contador = 0; contador < 4; contador++) 
            {
                Console.WriteLine("Informe seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Informe sua cidade: ");
                cidade = Console.ReadLine();
                Console.WriteLine("Informe seu telefone: ");
                telefone = Console.ReadLine();
                Console.WriteLine("Informe seu ano de nascimento: ");
                anoNascimento=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Cidade: " + cidade);
                Console.WriteLine("Telefone: " + telefone);
                Console.WriteLine("Ano de nascimento: " + anoNascimento);
            }
            Console.ReadKey();
        }
    }
}
