using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal nota1, nota2, nota3, nota4, media;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validar campos em branco
            if (txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtNota4.Text == "")
            {
                lblResultado.Text = "Preencha os campos em branco";
            }
            else
            {

                nota1 = Convert.ToDecimal(txtNota1.Text);
                nota2 = Convert.ToDecimal(txtNota2.Text);
                nota3 = Convert.ToDecimal(txtNota3.Text);
                nota4 = Convert.ToDecimal(txtNota4.Text);

                media = (nota1 + nota2 + nota3 + nota4) / 4;


                if (media >= 8)
                {
                    lblResultado.Text = $"Média: {media:F2} - Aprovado";
                }
                else if (media >= 5 && media <8)
                {
                    lblResultado.Text = $"Média: {media:F2} - Recuperação";
                }
                else
                {
                    lblResultado.Text = $"Média: {media:F2} - Reprovado";
                }

            }
        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            lblResultado.Text = String.Empty; 
        }
    }
}
