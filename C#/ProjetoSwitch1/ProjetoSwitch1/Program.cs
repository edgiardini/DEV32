using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSwitch1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //trabalhando com switch case
            int op;
            string nome;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" Informe o sexo: 1-M ou 2-F");
            op = Convert.ToInt32(Console.ReadLine());

            //atalho switch case -> switch tab
            switch (op)
            {
                case 1:
                    Console.WriteLine("Masculino");
                    break;
                case 2:
                    Console.WriteLine("Feminino");
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções acima");
                    break;
            }
            Console.ReadKey();

        }
    }
}
