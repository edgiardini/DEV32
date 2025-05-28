using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivro
{
    internal class dados
    {

        //STRING DE CONEXÃO COM O BANCO

        public static string Conexao
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eduardo.hgiardini\Documents\livro.mdf;Integrated Security=False;Connect Timeout=30";
            }
        }
    }
}
