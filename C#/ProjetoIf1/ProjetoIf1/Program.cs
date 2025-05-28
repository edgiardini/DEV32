using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIf1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com if else

            //Usuário vai informar nome, idade e telefone
            //os sistema vai verificar a idade e liberar
            //a passagem se idade for maior ou igual a 18

            //1. Declarar as variáveis
            string nome, telefone;
            int idade;

            //2. Solicitar e capturar os valores
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Telefone:");
            telefone = Console.ReadLine();

            Console.WriteLine("Idade: ");
            idade=Convert.ToInt32(Console.ReadLine());

            //3. Validar a idade (se idade>=18...)
            //atalho if+tab
            if (idade>=18)
            {
                //se for verdadeiro cai aqui
                Console.WriteLine("Entrada liberada!");
            }
            else
            {
                //se for falso cai aqui
                Console.WriteLine("Entrada com os pais!");
            }
            
            Console.ReadKey();
        }
    }
}
