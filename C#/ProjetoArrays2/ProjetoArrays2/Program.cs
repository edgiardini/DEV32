using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArrays2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Preenchendo um array com entrada de valores do usuário

            //declaração do array com o tamanho
            int[] numeros = new int[3]; //array tem 3 posições

            //vamos utilizar o for para percorrer o array e solicitar algo do usuário
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite um número para a posição {i}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Os números informados foram: ");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
