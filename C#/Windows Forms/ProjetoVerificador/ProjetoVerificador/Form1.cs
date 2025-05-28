using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVerificador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int numero;
        private void txtNumero_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                lblResultado.Text = "Preencha o número";
            }
            else
            {
                numero=Convert.ToInt32(txtNumero.Text);
                if (numero % 2 == 0)
                {
                    lblResultado.Text = "PAR";
                }
                else
                {
                    lblResultado.Text = "ÍMPAR";
                }
            }

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
