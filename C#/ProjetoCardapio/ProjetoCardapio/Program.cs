using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCardapio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Restaurante!");
            Console.WriteLine("Escolha seu prato digitando o número correspondente: ");
            Console.WriteLine("1- Ovo frito com goiabada - R$ 20,00");
            Console.WriteLine("2- Farofa de girino - R$ 25,00");
            Console.WriteLine("3- Estrobolete de pombo obeso - R$ 30,00");
            Console.WriteLine("4- Estrogonhoque - R$ 40,00");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha) 
            {
                case 1:
                    Console.WriteLine("Você escolheu ovo frito com goiabada! Preço: R$ 20,00");
                    break;
                    case 2:
                    Console.WriteLine("Você escolheu farofa de girino! Preço: R$ 25,00");
                    break;
                    case 3:
                    Console.WriteLine("Você escolheu estrombolete de pombo obeso! Preço: R$ 30,00");
                    break;
                    case 4:
                    Console.WriteLine("Você escolheu estrogonhoque! Preço: R$ 40,00");
                    break;
                default:
                    Console.WriteLine("Escolha inválida! Tente novamente!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
