using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSwitch3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //trabalhar com switch case e tratar a variável
            //string antes de acionar o switch

            Console.WriteLine("Informe M ou F");
            string sexo = Console.ReadLine();

            //tratar a variável para maiusculo
            string msexo = sexo.ToUpper(); //ToLower()

            switch (msexo)
            {
                case "M":
                    Console.WriteLine("Maiusculo");
                    break;
                case "F":
                    Console.WriteLine("Feminino");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
            Console.ReadKey();

        }
    }
}
