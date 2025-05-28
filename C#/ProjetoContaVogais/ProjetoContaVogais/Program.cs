using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaVogais
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine().ToLower();
            int contadorVogais = 0;

            for (int i = 0; i < palavra.Length; i++) 
            {
                char letra = palavra[i];
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contadorVogais++;
                }
            }
            Console.WriteLine($"A palavra '{palavra}' contém {contadorVogais} vogal(is)!");

            Console.ReadKey();
        }
    }
}
