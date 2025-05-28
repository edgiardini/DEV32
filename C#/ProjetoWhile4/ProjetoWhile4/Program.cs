using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWhile4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Solicite números ao usuário e vai somar
            //apenas os valores positivos.
            //O programa encerra quando o usuário
            //digitar um número negativo

            int soma = 0;
            int numero;


            Console.WriteLine("Digite números positivos para somar. Digite um número negativo para sair: ");
            
            while (true)
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                    break; //Encerra o loop ao receber um número negativo

                soma += numero; //Soma os números positivos
                
                
               
            }

            Console.WriteLine($"A soma dos números positivos " + $"digitados é: {soma}");
            Console.ReadKey();

        }
    }
}
