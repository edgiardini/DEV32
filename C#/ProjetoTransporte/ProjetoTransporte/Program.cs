using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransporte
{
    public class Program
    {
        static void Main(string[] args)
        {
            string destino, tamanho;
            decimal valorfrete, valortamanho, total;

            Console.WriteLine("Informe o destino: ");
            Console.WriteLine("AM: R$ 4500,00");
            Console.WriteLine("RO: R$ 4800,00");
            Console.WriteLine("RS: R$ 3600,00");
            Console.WriteLine("RJ: R$ 3500,00");
            Console.WriteLine("Demais UF: R$ 3000,00");
            destino = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe o tamanho: ");
            Console.WriteLine("P: R$ 1800,00");
            Console.WriteLine("M: R$ 2200,00");
            Console.WriteLine("G: R$ 3000,00");
            tamanho = Console.ReadLine().ToUpper();


            switch (destino)
            {
                case "AM":
                    valorfrete = 4500;
                    break;
                case "RO":
                    valorfrete = 4800;
                    break;
                case "RS":
                    valorfrete = 3600;
                    break;
                case "RJ":
                    valorfrete = 3500;
                    break;
                default:
                    valorfrete = 3000;
                    break;                                 

            }

            if (tamanho=="P")
            {
                valortamanho = 1800; 
                total = valorfrete + valortamanho;
                Console.WriteLine("O valor total é: " + total);
               
            }
            else if (tamanho == "M")
            {

                valortamanho = 2200;
                total = valorfrete + valortamanho;
                Console.WriteLine("O valor é: " + total);
            }
           
            else if(tamanho == "G") 
            {
                
                valortamanho = 3000;
                total = valorfrete + valortamanho;
                Console.WriteLine("O valor total é: " + total);
            }


            Console.ReadKey();        

            
                

            


        }
    }
}
