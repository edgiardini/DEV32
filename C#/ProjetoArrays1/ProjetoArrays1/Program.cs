using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArrays1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com vetores em C#
            //Objetivo: Criando e exibindo valores de um array de inteiros

            //declarar e inicializar um array
            int[] numeros = { 10, 20, 30, 40, 50 };

            //os arrays inicia sua posição com 0
            //Console.WriteLine(numeros[0]);

            //exibindo cada elemento do array usando um for
            Console.WriteLine("Os números do array são: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]); //exibe cada número
            }

            Console.ReadKey();
        }
    }
}
