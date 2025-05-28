using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArrays4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Somando os valores de um array de números

            //declarar e inicializar um array
            int[] numeros = { 5, 10, 15, 20, 25 };
            int soma = 0;

            //vai percorrer cada elemento do array e somar
            foreach (int valor in numeros) 
            {
                soma += valor; //soma dos valores do array
            }
            Console.WriteLine($"A soma dos valores do array: {soma}");
            Console.ReadKey();
        }
    }
}
