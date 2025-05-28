using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoValorVenda
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valorVenda;

            Console.WriteLine("Informe o valor da venda: ");
            valorVenda = Convert.ToInt32(Console.ReadLine());

            if (valorVenda >= 1500) 
            {
                valorVenda += 400;
            }
            else
            {
                valorVenda += 150;
            }

            Console.WriteLine("O valor final da venda é: " + valorVenda);
            Console.ReadKey();
        }
    }
}
