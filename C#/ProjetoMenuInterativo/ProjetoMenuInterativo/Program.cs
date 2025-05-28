using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMenuInterativo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("ESCOLHA UMA OPÇÃO ABAIXO: ");
                Console.WriteLine("1- Converter texto de letras minúsculas para maiúsculas: ");
                Console.WriteLine("2- Verificar par ou ímpar: ");
                Console.WriteLine("3- Calcular o quadrado do número: ");
                Console.WriteLine("4- Calcular a média de 3 valores financeiros: ");
                Console.WriteLine("5- Sair do sistema: ");
                opcao = int.Parse(Console.ReadLine());
                string texto;

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite um texto em letras minúsculas: ");
                        texto = Console.ReadLine();
                        Console.WriteLine("Texto em maiúsculo: " + texto.ToUpper());
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Digite um número inteiro: ");
                        int numero = int.Parse(Console.ReadLine());
                        if (numero % 2 == 0)
                        {
                            Console.WriteLine("O número é par!");
                        }
                        else
                        {
                            Console.WriteLine("O número é ímpar!");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Digite um número inteiro: ");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("O quadrado do número é: " + (numero * numero));
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Digite o primeiro valor: ");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo valor: ");
                        decimal valor2 = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro valor: ");
                        decimal valor3 = decimal.Parse(Console.ReadLine());
                        decimal media = (valor1 + valor2 + valor3) / 3;
                        Console.WriteLine("A média dos 3 valores é: " + media);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente!");
                        Console.WriteLine();
                        break;
                }
            } while (opcao != 5);
            Console.ReadKey();        
        }

    }
}