using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //add para funcionamento do banco
using livro.CLASSES;
using System.Linq.Expressions;


namespace livro
{
    public partial class frm_user : Form
    {
        public frm_user()
        {
            InitializeComponent();
            AtualizarGrid();
            dg_user.DataBindingComplete += dg_users_DataBindingComplete; // add para funcionamento da grid
        }


        //CONEXAO COM O BANCO - SQLCONNECTION
        SqlConnection con = new SqlConnection(DADOS.Conexao);



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        //teste de conexão com o banco
        private void btn_conexao_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MessageBox.Show("Conexão OK");
                con.Close();
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //CADASTRO DE USUARIOS
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //validação de campos se estão preenchidos
                if (txt_nome.Text == "" || txt_uf.Text == "" ||
                    txt_end.Text == "" || int_num.Text == string.Empty)
                {
                    MessageBox.Show("Preencha ps campos necessarios", "preenche ai",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    con.Close();
                    con.Open(); //abrimos o banco
                    //string de insert no banco
                    string sql = "Insert into Usuario(user_nome,user_cpf," +
                        "user_end,user_end_num,user_nasc,user_sexo," +
                        "user_cel,user_cidade,user_uf) values (@nome,@cpf," +
                        "@end,@end_num,@nasc,@sexo,@cel,@cidade,@uf)";
                    SqlCommand cmd = new SqlCommand(sql, con); //aplicando o insert
                    //PEGANDO AS VARIAVEIS NOS CAMPOS
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome.Text;
                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txt_cpf.Text;
                    cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = txt_end.Text;
                    cmd.Parameters.Add("@end_num", SqlDbType.VarChar).Value = Convert.ToInt32(int_num.Text);
                    cmd.Parameters.Add("@nasc", SqlDbType.DateTime).Value = Convert.ToDateTime(data_nasc.Text);
                    cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = txt_sexo.Text;
                    cmd.Parameters.Add("@cel", SqlDbType.VarChar).Value = txt_cel.Text;
                    cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txt_cidade.Text;
                    cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = txt_uf.Text;
                    //EXECUTANDO O QUERY
                    cmd.ExecuteNonQuery();
                    con.Close();

                    LimparTudo();  //LIMPA OS CAMPOS
                    AtualizarGrid(); //ATUALIZA A GRID

                    MessageBox.Show("Cadastro OK", "Sistema Funcional",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
            }
            catch (SqlException erro) { MessageBox.Show("Erro:" + erro.Message); }
        }


        //FUNÇÃO LIMPAR TODOS OS CAMPOS
        public void LimparTudo()
        {
            //date time não é necessario;
            txt_nome.Clear();
            txt_end.Clear();
            txt_cel.Clear();
            txt_cidade.Clear();
            txt_cpf.Clear();
            txt_sexo.SelectedIndex = -1;
            txt_uf.SelectedIndex = -1;
            int_num.Clear();
            txt_nome.Focus();
        }
        //PREENCHIMENTO DA GRID
        private void dg_users_DataBindingComplete(object sender,
            DataGridViewBindingCompleteEventArgs e)
        {
            if (dg_user.Columns.Count >= 10)
            {
                //cabeçalhos
                dg_user.Columns[0].HeaderText = "ID";
                dg_user.Columns[1].HeaderText = "NOME";
                dg_user.Columns[2].HeaderText = "CPF";
                dg_user.Columns[3].HeaderText = "ENDEREÇO";
                dg_user.Columns[4].HeaderText = "NUM.";
                dg_user.Columns[5].HeaderText = "DT_NASCIMENTO";
                dg_user.Columns[6].HeaderText = "SEXO";
                dg_user.Columns[7].HeaderText = "CEL";
                dg_user.Columns[8].HeaderText = "CIDADE";
                dg_user.Columns[9].HeaderText = "UF";

                //LARGURA COLUNAS

                dg_user.Columns[0].Width = 50;
                dg_user.Columns[1].Width = 150;
                dg_user.Columns[2].Width = 100;
                dg_user.Columns[3].Width = 200;
                dg_user.Columns[4].Width = 50;
                dg_user.Columns[5].Width = 100;
                dg_user.Columns[6].Width = 70;
                dg_user.Columns[7].Width = 100;
                dg_user.Columns[8].Width = 200;
                dg_user.Columns[9].Width = 50;

            }
        }

        // LISTAR USUARIOS
        public static DataTable ListarUsuario()
        {
            try
            {
                SqlConnection con = new SqlConnection(DADOS.Conexao);
                string sqlListar = "select * from Usuario";
                SqlDataAdapter da = new SqlDataAdapter(sqlListar, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
                con.Close();
            }
            catch (SqlException erro)
            {
                return null;
            }

        }
        // ATUALIZAR GRID
        public void AtualizarGrid()
        {
            try
            {
                dg_user.AutoGenerateColumns = true; //gera automaticamente as colunas
                dg_user.DataSource = ListarUsuario(); //chama a função de listar os usuários
                dg_user.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //configurações de segurança abaixo
                dg_user.AllowUserToAddRows = false;
                dg_user.AllowUserToDeleteRows = false;
                dg_user.ReadOnly = true;
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void dg_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // SELECIONAR ITEM GRID
        private void dg_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex; //para selecionar a linha inteira em qualquer parte
            //preenchimento dos campos do select do dg_user
            txt_id.Text = dg_user.Rows[linha].Cells[0].Value?.ToString();
            txt_nome.Text = dg_user.Rows[linha].Cells[1].Value?.ToString();
            txt_cpf.Text = dg_user.Rows[linha].Cells[2].Value?.ToString();
            txt_end.Text = dg_user.Rows[linha].Cells[3].Value?.ToString();
            int_num.Text = dg_user.Rows[linha].Cells[4].Value?.ToString();
            //data em padrão brasileiro
            var valorData = dg_user.Rows[linha].Cells[5].Value;
            if (valorData != null && DateTime.TryParse(valorData.ToString(), out DateTime dataNasc))
            {
                data_nasc.Text = dataNasc.ToString("dd/MM/yyy");
            }
            else
            {
                data_nasc.Text = string.Empty;
            }
            txt_sexo.Text = dg_user.Rows[linha].Cells[6].Value?.ToString();
            txt_cel.Text = dg_user.Rows[linha].Cells[7].Value?.ToString();
            txt_cidade.Text = dg_user.Rows[linha].Cells[8].Value?.ToString();
            txt_uf.Text = dg_user.Rows[linha].Cells[9].Value?.ToString();


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //CRIAÇÃO DO UPDATE
            string sql = @"UPDATE Usuario SET " + "user_nome = @nome," + "user_cpf = @cpf," + "user_end = @end," + "user_end_num = @num," + "user_nasc = @nasc," + "user_sexo = @sexo," + "user_cel = @cel," + "user_cidade = @cidade," + "user_uf = @uf " + "WHERE user_id = @id";
            //EXECUTAR O COMANDO
            using (var con = new SqlConnection(DADOS.Conexao))
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id.Text));
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                cmd.Parameters.AddWithValue("@end", txt_end.Text);
                cmd.Parameters.AddWithValue("@num", Convert.ToInt32(int_num.Text));
                cmd.Parameters.AddWithValue("@nasc", Convert.ToDateTime(data_nasc.Text));
                cmd.Parameters.AddWithValue("@sexo", txt_sexo.Text);
                cmd.Parameters.AddWithValue("@cel", txt_cel.Text);
                cmd.Parameters.AddWithValue("@cidade", txt_cidade.Text);
                cmd.Parameters.AddWithValue("@uf", txt_uf.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            AtualizarGrid();
            LimparTudo();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            //Pergunta de confirmação
            var resp = MessageBox.Show("Tem certeza que deseja escluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                //Executar o delete sem sim
                string sql = "DELETE from Usuario WHERE user_id = @id";
                using (var con = new SqlConnection(DADOS.Conexao))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_id.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                AtualizarGrid();
                LimparTudo();
            }
        }

        //FUNÇÃO DE PESQUISAR USUARIO POR NOME
        public static DataTable PesquisarNome(string termo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DADOS.Conexao))
                {
                    string sql = "SELECT * FROM Usuario WHERE user_nome LIKE @termo";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }

        }

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            dg_user.DataSource = PesquisarNome(txt_pesquisa.Text);
            dg_user.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //normnas de acesso (igual do celecionar usuario)
            dg_user.AllowUserToAddRows = false;
            dg_user.AllowUserToDeleteRows = false;
            dg_user.ReadOnly = true;
        }

        //FORMATAÇÃO EXTRA
        private void frm_user_Load(object sender, EventArgs e)
        {
            //MÁSCARA PARA O CEL
            txt_cel.Mask = "(00)00000-0000";
            txt_cel.PromptChar = '_'; //Caracter de preenchimento
            txt_cel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; //salva apenas os numeros

            //MASCARA PARA O CPF
            txt_cpf.Mask = "000.000.000-00";
            txt_cpf.PromptChar = '_';
            txt_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            //MASCARA PARA SELEÇÃO DE SEXO
            txt_sexo.DropDownStyle = ComboBoxStyle.DropDownList;

            //MASCARA PARA SELEÇÃO E ESTADO
            txt_uf.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void int_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}





