using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWhile1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com comando while
            //contagem regressiva

            int num;
            Console.WriteLine("Insira um Nº: ");
            num=Convert.ToInt32(Console.ReadLine());

            //atalho while -> while tab tab
            while (num > 0) 
            {
                Console.WriteLine(num);
                num--; //vai decrementar a contagem
            }
            Console.ReadKey();
        }
    }
}
