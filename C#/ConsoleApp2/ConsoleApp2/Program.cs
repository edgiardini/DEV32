using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objetivo: Solicitar e capturar nome e sobrenome
            //e exibir na frase
            //Seu nome completo é: nome sobrenome
            //1. declarar as variáveis
            string nome, sobrenome;

            //2. solicitar o nome
            Console.WriteLine("Nome: ");
            //3. receber na variável nome o valor
            nome = Console.ReadLine();

            //4. solicitar o sobrenome
            Console.WriteLine("Sobrenome: ");
            //5. receber na variável sobrenome o valor
            sobrenome = Console.ReadLine();

            //6. exibir os valores das variáveis
            Console.WriteLine("Seu nome completo é: "+nome+ " "+ sobrenome);


            Console.ReadKey();
        }
    }
}
