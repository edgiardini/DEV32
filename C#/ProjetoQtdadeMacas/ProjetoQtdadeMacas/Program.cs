using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQtdadeMacas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtdadeMacas;

            Console.WriteLine("Informe a quantidade de maçãs: ");
            qtdadeMacas = Convert.ToInt32(Console.ReadLine());

            if (qtdadeMacas >= 500)
            {
                Console.WriteLine("Lote a ser enviado por transportadora especial!");
            }
            else if (qtdadeMacas >= 200)
            {
                Console.WriteLine("Lote a ser entregue na fabrica de tortas");
            }
            else
            {
                Console.WriteLine("Lote a ser entregue no mercado do bairro");
            }
            Console.ReadKey();
        }

    }
}
