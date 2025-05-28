using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCountdown
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.WriteLine("Informe um número para contagem regressiva: ");
            numero=Convert.ToInt32(Console.ReadLine());


            //Qdo a estrutura tiver um decremento, a condição deverá analisar
            //sendo > ou >= a algum valor.
            for (int i = numero; i >=0; i--)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
        }
    }
}
