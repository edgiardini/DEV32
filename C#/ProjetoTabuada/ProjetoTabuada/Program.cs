using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTabuada
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Objetivo: Solicitar um número ao usuário
            //e exibir sua tabuada de 1 a 10.

            //1. solicitar um valor inteiro
            Console.WriteLine("Informe um Nº para a tabuada: ");
            
            //2. receber o valor do usuário
            int numero=Convert.ToInt32(Console.ReadLine());

            //3. criar a estrutura de laço para a tabuada
            for (int i = 0; i <=10; i++) 
            {
                //exibir a tabuada juntando o número * i
                Console.WriteLine($"{numero} x {i}={numero*i}");
            }
            Console.ReadKey();
        }
    }
}
