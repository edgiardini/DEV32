using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDesconto
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal val, total;
            string tipoCli;

            Console.WriteLine("Informe o valor da compra: ");
            val = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe uma das opções abaixo:\n" +
                "C: Cliente comum" +
                "\nV: Cliente VIP \nF: Funcionário");
            tipoCli = Console.ReadLine();
            tipoCli=tipoCli.ToLower();
            
            switch (tipoCli)
            {
                case "c":
                    total = val;
                    Console.WriteLine("Total da compra: " +
                        total.ToString("C"));
                    break;

                case "v":
                    if (val>=500)
                    {
                        total = val - ((val * 10) / 100);
                        Console.Write("Total com 10% desc: " +
                            total.ToString("C"));
                    }
                    else
                    {
                        total = val;
                        Console.Write("Não há descontos!\n" +
                            "Total da compra:" + total.ToString("C"));
                    }
                    break;

                case "f":
                    if (val>=500)
                    {
                        total = val - ((val * 20) / 100);
                        Console.Write("Total com 20% desc: " +
                            total.ToString("C"));
                    }
                    else
                    {
                        total = val;
                        Console.Write("Não há descontos!\n" +
                            "Total da compra: " + total.ToString("C"));
                    }
                    break;
                default:
                    Console.WriteLine("Essa õpção não consta!");
                    break;

            }
            Console.ReadKey();


        }
    }
}
