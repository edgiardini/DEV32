using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoExtra
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validar os campos preenchidos
            if (txtUsuario.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos!", "Sistema TI 32", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //testar com usuario admin e senha 123 vai acessar o form1
                if (txtUsuario.Text == "admin" && txtSenha.Text == "123")
                {
                    FrmCliente f = new FrmCliente();
                    f.Show();
                    this.Hide();//vai ocultar a tela de login
                }
                else
                {
                    lblStatus.Text = "Usuário e/ou senha inválidos!";
                }
            }
        }
    }
}
