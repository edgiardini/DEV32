using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMenuOpcoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menu;

            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine("1- Tenha um bom dia");
            Console.WriteLine("2- Data Atual");
            Console.WriteLine("3- Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Tenha um bom dia");
                    break;
                case 2:
                    Console.WriteLine("10/03/2025");
                    break;
                case 3:
                    Console.WriteLine("Sair");
                    break;

            }


            Console.ReadKey();



        }
    }

}