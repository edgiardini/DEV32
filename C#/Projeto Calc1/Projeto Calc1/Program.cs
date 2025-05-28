using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calc1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com variáveis do tipo int
            //Cadastro simples e cálculo da idade
            //1. Declarar variáveis
            string nome, cidade, uf, telefone;
            int anonascimento, idade, anoatual;

            //2. Solicitar os dados e capturar os valores
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("UF: ");
            uf = Console.ReadLine();

            Console.WriteLine("Telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Ano de Nascimento: ");
            anonascimento =Convert.ToInt32(Console.ReadLine());
            //anonascimento=int.Parse(Console.ReadLine());

            Console.WriteLine("Ano Atual: ");
            anoatual =Convert.ToInt32(Console.ReadLine());

            idade = anoatual - anonascimento;
            Console.WriteLine(nome + " tem "+idade+" anos!");

            Console.ReadKey();
            


        }
    }
}
