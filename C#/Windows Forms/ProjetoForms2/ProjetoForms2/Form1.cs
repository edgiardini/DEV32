using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDia.Text = DateTime.Now.ToLongDateString();
            toolTip1.SetToolTip(txtDica, "Preencha o Nome!");
        }

        //Declaração de variáveis - GLOBAL
        //Estarão disponíveis para esse form inteiro
        int val1, val2, total;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Vai exibir a hora corrente
            //formato longo hh:mm:ss
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void rbAzul_CheckedChanged(object sender, EventArgs e)
        {
            //Ao clicar no rbAzul vai atribuir o texto no
            //lblCor
            lblCor.Text = rbAzul.Text;
        }

        private void rbAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            lblCor.Text = rbAmarelo.Text;
        }

        private void lblDia_Click(object sender, EventArgs e)
        {

        }

        private void ckItem1_CheckedChanged(object sender, EventArgs e)
        {
            //Ao marcar o item vai desmarcar o outro item
            if (ckItem1.Checked == true) //vai validar se está checked 
            {
                ckItem2.Checked = false;
                lblItem.Text = "Você escolheu o item 1!";
            }
            else
            {
                lblItem.Text = "";
            }

        }

        private void ckItem2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckItem2.Checked == true)
            {
                ckItem1.Checked = false;
                lblItem.Text = "Você escolheu o item 2!";
            }
            else
            {
                lblItem.Text = "";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //MULTIPLICAÇÃO
            //Validar se os textbox's estão preenchidos
            if (txtValor1.Text == "" || txtValor2.Text == "")
            {
                lblResultado.Text = "Preencha os campos!";
            }
            else
            {
                //Atribuir os valores dos textbox's para as
                //variáveis declaradas
                val1 = Convert.ToInt32(txtValor1.Text);
                val2 = Convert.ToInt32(txtValor2.Text);
                //Eefetuar o cálculo
                total = val1 * val2;
                //Exibir o resultado na lblResultado
                lblResultado.Text = total.ToString();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //DIVISÃO
            //Validar se os textbox's estão preenchidos
            if (txtValor1.Text == "" || txtValor2.Text == "")
            {
                //lblResultado.Text = "Preencha os campos!";
                //exibir a mensagem em popup
                MessageBox.Show("Preencha os campos!", "Sistema ABC");
            }
            else
            {
                //Atribuir os valores dos textbox's para as
                //variáveis declaradas
                val1 = Convert.ToInt32(txtValor1.Text);
                val2 = Convert.ToInt32(txtValor2.Text);

                //Validar o val2
                if (val2 == 0)
                {
                    lblResultado.Text = "Não existe divisão por 0";
                    txtValor2.Clear();
                    txtValor2.Focus();
                }
                else
                {
                    //Eefetuar o cálculo
                    total = val1 / val2;

                    //Exibir o resultado na lblResultado
                    lblResultado.Text = total.ToString();
                }
            }
        }

        //Função ou método sem retorno que pode ser usada apenas
        //nesse form1
        private void Limpar()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            lblResultado.Text = "";
            txtValor1.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void dtCalendario_ValueChanged(object sender, EventArgs e)
        {
            //Ao alterar o valor da data, faça...
            lblData.Text = dtCalendario.Value.ToShortDateString();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Vai restringir a digitação de letras
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d"))
            {
                e.Handled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //SOMA
            //Validar se os textbox's estão preenchidos
            if (txtValor1.Text == "" || txtValor2.Text == "")
            {
                lblResultado.Text = "Preencha os campos!";
            }
            else
            {
                //Atribuir os valores dos textbox's para as
                //variáveis declaradas
                val1 = Convert.ToInt32(txtValor1.Text);
                val2 = Convert.ToInt32(txtValor2.Text);
                //Eefetuar o cálculo
                total = val1 + val2;
                //Exibir o resultado na lblResultado
                lblResultado.Text = total.ToString();
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //SUBTRAÇÃO
            //Validar se os textbox's estão preenchidos
            if (txtValor1.Text == "" || txtValor2.Text == "")
            {
                lblResultado.Text = "Preencha os campos!";
            }
            else
            {
                //Atribuir os valores dos textbox's para as
                //variáveis declaradas
                val1 = Convert.ToInt32(txtValor1.Text);
                val2 = Convert.ToInt32(txtValor2.Text);
                //Eefetuar o cálculo
                total = val1 - val2;
                //Exibir o resultado na lblResultado
                lblResultado.Text = total.ToString();
            }
        }
    }
}
