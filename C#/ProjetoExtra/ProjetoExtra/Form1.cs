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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void btnGerarDados_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCPF.Text == "" || txtEndereco.Text == "")
            {
                MessageBox.Show("Preencha os campos faltantes!");
            }
            else
            {
                groupBox3.Visible = true;
                lblNome.Text = txtNome.Text;
                lblCPF.Text = txtCPF.Text;
                lblEndereco.Text = txtEndereco.Text;
                lblCidade.Text = txtCidade.Text;
                lblCEP.Text = txtCEP.Text;
                lblEstado.Text = txtEstado.Text;
                lblDataNasc.Text = dtDataNasc.Text;
                if (rbFeminino.Checked)
                {

                    lblSexo.Text = rbFeminino.Text;
                }
                else
                {

                    lblSexo.Text = rbMasculino.Text;
                }
                lblMusica.Text = ckEstiloMusical.Text;
                lblLeitura.Text = listLeitura.Text;
                lblInformacoes.Text = txtInformacoes.Text;
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            //desmarcar os elementos do estilo musical
            foreach (int i in ckEstiloMusical.CheckedIndices)
            {
                ckEstiloMusical.SetItemChecked(i, false);
            }


            txtCidade.Clear();
            txtCPF.Clear();
            txtEndereco.Clear();
            txtEstado.Clear();
            txtCEP.Clear();
            txtNome.Clear();
            dtDataNasc.Text = DateTime.Today.ToShortDateString();//vai deixar com a data de hoje
            rbFeminino.Checked = false;//vai desmarcar a opção feminino
            rbMasculino.Checked = false;//vai desmarcar a opção masculino
            listLeitura.ClearSelected();//vai limpar a lista de leitura
            txtInformacoes.Clear();//vai limpar o campo Informações Adicionais
            groupBox3.Visible = false;//vai deixar o bloco de resultados invisíveis
        }
    }
}
