using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClassificacaodeNotas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.WriteLine("Informe sua Nota: ");
            Console.WriteLine("0 a 4 - Ruim");
            Console.WriteLine("5 a 6 - Regular");
            Console.WriteLine("7 a 8 - Bom");
            Console.WriteLine("9 a 10 - Ótimo");
            nota = Convert.ToInt32(Console.ReadLine());

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Ruim");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Ruim");
                    break;
                case 4:
                    Console.WriteLine("Ruim");
                    break;
                case 5:
                    Console.WriteLine("Regular");
                    break;
                case 6:
                    Console.WriteLine("Regular");
                    break;
                case 7:
                    Console.WriteLine("Bom");
                    break;
                case 8:
                    Console.WriteLine("Bom");
                    break;
                case 9:
                    Console.WriteLine("Ótimo");
                    break;
                case 10:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Coloque uma nota válida!");
                    break;

                    Console.ReadKey();
            }



        }

    }
}

