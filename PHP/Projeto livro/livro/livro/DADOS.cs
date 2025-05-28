using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livro
{
    internal class DADOS
    {

        //STRING DE CONEXAO COM O BANCO

        public static string Conexao
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\xampp\htdocs\ti32\Projeto livro\livro.mdf;Integrated Security=False;Connect Timeout=30";
            }
        }
    }
}
