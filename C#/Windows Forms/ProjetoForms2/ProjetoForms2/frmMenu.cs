using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAlteraTela_Click(object sender, EventArgs e)
        {
            //vai chamar a tela do Forms1
            Form1 f=new Form1();//instância do form
            //f.ShowDialog(); //não permite voltar sem fechar
            f.ShowDialog();//exibindo a tela
        }
    }
}
