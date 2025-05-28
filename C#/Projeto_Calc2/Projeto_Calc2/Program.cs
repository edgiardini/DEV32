using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calc2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, soma, subtrai, multiplica, dividir;

            Console.WriteLine("Valor 1: ");
            val1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor 2: ");
            val2 =Convert.ToInt32(Console.ReadLine());

            soma = val1 + val2;
            Console.WriteLine("A soma de "+val1 + "+" +val2+" = "+soma);

            subtrai = val1 - val2;
            Console.WriteLine("A subtração de " + val1 + "-" + val2 + " = " +subtrai);

            multiplica = val1 * val2;
            Console.WriteLine("A multiplicação de " + val1 + "*" + val2 + " = " +multiplica);


            dividir = val1 / val2;
            Console.WriteLine("A divisão de " + val1 + "/" + val2 + " = " +dividir);

            Console.ReadKey();

            

        }
    }
}
