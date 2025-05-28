using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSwitch2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int cor;

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe a cor de sua camiseta: 1-Azul 2-Preta 3-Branca 4-Vermelha");
            cor = Convert.ToInt32(Console.ReadLine());

            switch (cor)
            {
                case 1:
                    Console.WriteLine("Você escolheu a camiseta AZUL");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a camiseta PRETA");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a camiseta BRANCA");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a camiseta VERMELHA");
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções acima");
                    break;
            }
            Console.ReadKey();
        }
    }
}
