using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Media
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal nota1, nota2, nota3, media;

            Console.WriteLine("Nota 1: ");
            nota1=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Nota 2: ");
            nota2=Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Nota 3: ");
            nota3=Convert.ToDecimal(Console.ReadLine());        
          
            
            media= (nota1+nota2+nota3)/3;

            Console.WriteLine("A média é: " +media);

            //media>=8 aprovado
            //media estiver entre 5 e 7 recuperação
            //media abaixo de 5 reprovado

            if (media>=8)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (media>=5 && media<8) //<=7
            {
                Console.WriteLine("Recuperação!");
            }
            else 
            {
                Console.WriteLine("Reprovado!");
            }


            Console.ReadKey();
        }
    }
}
