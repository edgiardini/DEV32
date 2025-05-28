using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //Ao clicar no botão vai executar a ação de 
            //enviar o nome para a lblStatus

            //a lblStatus vai receber o valor do txtNome
            lblStatus.Text=txtNome.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            lblStatus.Text = "";
            //lblStatus.Text=String.Empty;
            txtNome.Focus();
        }
    }
}
