using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalario
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome, profissao;
            decimal salario, comissao = 500, total, salariofinal;

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Profissão: ");
            profissao = Console.ReadLine();

            Console.WriteLine("Salário: ");
            salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Comissão = R$ 500,00");
            
            
            total = salario + comissao;
            Console.WriteLine("Salário + Comissao = Total: " + total);

            if (total>=5000)
            {
                salariofinal = total-((total *5) / 100);
                Console.WriteLine("Salário final: " +salariofinal);
            
            }

            else
            {
                salariofinal = total-((total *2) / 100);
                Console.WriteLine("Salário final: " +salariofinal);

            }

            Console.ReadKey();



            

        }
    }
}
