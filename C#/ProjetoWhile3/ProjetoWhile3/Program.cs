using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWhile3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //trabalhando com do while
            //calculadora com opção de sair

            int op;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1- Soma: ");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação: ");
                Console.WriteLine("4- Divisão: ");
                Console.WriteLine("5- Sair do sistema ");
                Console.WriteLine("Opção: ");
                op = Convert.ToInt32(Console.ReadLine());

                //verificando op entre 1 e 4
                if (op >= 1 && op <= 4)
                {
                    Console.WriteLine("Informe o 1º valor: ");
                    int val1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o 2º valor: ");
                    int val2 = Convert.ToInt32(Console.ReadLine());

                    int resultado = 0;

                    switch (op) //analisando as opções
                    {
                        case 1:
                            resultado = val1 + val2;
                            break;
                        case 2:
                            resultado = val1 - val2;
                            break;
                        case 3:
                            resultado = val1 * val2;
                            break;
                        case 4:
                            if (val2 != 0)
                            {
                                resultado = val1 / val2;

                            }
                            else
                            {
                                Console.WriteLine
                                    ("Erro divisão por zero!");
                            }
                            break;
                    }
                    if (op != 4 || val2 != 0)
                    {
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                }
                else if (op != 5)
                {
                    Console.WriteLine("Opção inválida! Tente Novamente!");
                }
            }

            while (op != 5); //sair
            {
                Console.WriteLine("Saindo... ");
                Console.ReadKey();
            }
        }
    }
}
