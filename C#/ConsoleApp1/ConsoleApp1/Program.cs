using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //comentario para 1 linha
            /*
             * comentario para mais de 1 linha
             */

            //solicitar e receber nome, cidade, uf e telefone do usuário


            //1. declarar variáveis string
            string nome, cidade, uf, telefone;
            //2. solicitar o nome
            //exibir um texto
            Console.WriteLine("Informe seu nome: ");
            //atribuir o texto à variável nome
            nome= Console.ReadLine();

            //atalho console.writeline (cw+tab)
            Console.WriteLine("Informe sua cidade: ");
            cidade= Console.ReadLine();

            Console.WriteLine("Informe a UF: ");
            uf= Console.ReadLine();

            Console.WriteLine("Informe o telefone: ");
            telefone= Console.ReadLine();


            //exibindo os dados das variáveis
            Console.WriteLine("Seu nome é: "+nome);
            Console.WriteLine("Vc mora na cidade: "+cidade);
            Console.WriteLine("UF: "+uf);
            Console.WriteLine("Seu contato: "+telefone);

            //parar a tela após exibição
            Console.WriteLine("Pressione qq tecla para sair!");
            Console.ReadKey();

        }
    }
}
