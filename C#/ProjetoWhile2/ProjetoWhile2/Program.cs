using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWhile2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ter 3 tentativas para acertar a
            //senha correta, caso contrário,
            //o acesso será negado.
            //Utilizando estrutura de repetição...

            string senhaCorreta = "1234";
            string senhaDigitada;
            int tentativas = 3; //inicializador

            //while vai analisar as tentativas
            while (tentativas>0) //condição
            {
                Console.WriteLine("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                //verificar se a senhaDigitada é igual a senhaCorreta
                if (senhaDigitada == senhaCorreta)
                {
                    Console.WriteLine("Acesso OK!");
                    Console.ReadKey();
                    return; //ao inserir a senha correta, o return faz sair!
                }
                else
                {
                    tentativas--; //decrementador
                    Console.WriteLine($"Senha Inválida!\n" +
                        $"Tentativas Restantes: {tentativas}");
                }
                Console.ReadKey();
                
            }


        }
    }
}
