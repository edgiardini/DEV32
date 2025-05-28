using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDiadaSemana
{
    public class Program
    {
        static void Main(string[] args)
        {
            int dia;

            Console.WriteLine("Escolha o dia da semana: 1-Domingo 2-Segunda 3-Terça 4-Quarta 5-Quinta 6-Sexta 7-Sábado");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;

                    Console.ReadKey();
            }
        }
    }
}
