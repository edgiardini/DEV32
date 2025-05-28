using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArrays3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Criando um array de strings e buscando um valor

            //declarando um array string com nomes
            string[] nomes = { "alice", "bruno", "carla", "danilo", "eliane" };
            

            Console.WriteLine("Digite um nome para procurar: ");
            string busca=Console.ReadLine();


            busca = busca.ToLower();

            bool encontrado = false;

            foreach (string nome in nomes) //vai percorrer a lista de nomes
            {
                if (nome == busca) //se encontrar algum nome da lista
                {
                    encontrado = true; //vai atribuir true para encontrado
                    break;
                }
                if (encontrado)
                {
                    Console.WriteLine("Nome encontrado na lista!");
                }
                else
                {
                    Console.WriteLine("Nome não encontrado!");
                }
            }
            Console.ReadKey();
        }
    }
}
