namespace livro
{
    partial class frm_user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nome = new Label();
            txt_nome = new TextBox();
            lbl_cpf = new Label();
            txt_cpf = new MaskedTextBox();
            txt_end = new TextBox();
            lbl_end = new Label();
            int_num = new TextBox();
            label3 = new Label();
            data_nasc = new DateTimePicker();
            lbl_nasc = new Label();
            lbl_sexo = new Label();
            txt_sexo = new ComboBox();
            txt_cidade = new TextBox();
            lbl_cidade = new Label();
            txt_uf = new ComboBox();
            lbl_uf = new Label();
            dg_user = new DataGridView();
            btn_cadastrar = new Button();
            btn_alterar = new Button();
            btn_deletar = new Button();
            btn_conexao = new Button();
            txt_pesquisa = new TextBox();
            lbl_pesquisa = new Label();
            txt_id = new TextBox();
            user_id = new Label();
            txt_cel = new MaskedTextBox();
            lbl_cel = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_user).BeginInit();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(12, 93);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Nome";
            lbl_nome.Click += label1_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(12, 111);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(183, 23);
            txt_nome.TabIndex = 1;
            // 
            // lbl_cpf
            // 
            lbl_cpf.AutoSize = true;
            lbl_cpf.Location = new Point(12, 147);
            lbl_cpf.Name = "lbl_cpf";
            lbl_cpf.Size = new Size(28, 15);
            lbl_cpf.TabIndex = 2;
            lbl_cpf.Text = "CPF";
            lbl_cpf.Click += label1_Click_1;
            // 
            // txt_cpf
            // 
            txt_cpf.Location = new Point(12, 165);
            txt_cpf.Name = "txt_cpf";
            txt_cpf.Size = new Size(183, 23);
            txt_cpf.TabIndex = 3;
            // 
            // txt_end
            // 
            txt_end.Location = new Point(12, 219);
            txt_end.Name = "txt_end";
            txt_end.Size = new Size(183, 23);
            txt_end.TabIndex = 5;
            // 
            // lbl_end
            // 
            lbl_end.AutoSize = true;
            lbl_end.Location = new Point(12, 201);
            lbl_end.Name = "lbl_end";
            lbl_end.Size = new Size(56, 15);
            lbl_end.TabIndex = 4;
            lbl_end.Text = "Endereço";
            // 
            // int_num
            // 
            int_num.Location = new Point(219, 219);
            int_num.Name = "int_num";
            int_num.Size = new Size(57, 23);
            int_num.TabIndex = 7;
            int_num.KeyPress += int_num_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 201);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 6;
            label3.Text = "Nº";
            // 
            // data_nasc
            // 
            data_nasc.Location = new Point(307, 111);
            data_nasc.Name = "data_nasc";
            data_nasc.Size = new Size(200, 23);
            data_nasc.TabIndex = 8;
            // 
            // lbl_nasc
            // 
            lbl_nasc.AutoSize = true;
            lbl_nasc.Location = new Point(307, 93);
            lbl_nasc.Name = "lbl_nasc";
            lbl_nasc.Size = new Size(114, 15);
            lbl_nasc.TabIndex = 9;
            lbl_nasc.Text = "Data de Nascimento";
            // 
            // lbl_sexo
            // 
            lbl_sexo.AutoSize = true;
            lbl_sexo.Location = new Point(307, 147);
            lbl_sexo.Name = "lbl_sexo";
            lbl_sexo.Size = new Size(32, 15);
            lbl_sexo.TabIndex = 10;
            lbl_sexo.Text = "Sexo";
            // 
            // txt_sexo
            // 
            txt_sexo.FormattingEnabled = true;
            txt_sexo.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            txt_sexo.Location = new Point(307, 165);
            txt_sexo.Name = "txt_sexo";
            txt_sexo.Size = new Size(200, 23);
            txt_sexo.TabIndex = 11;
            // 
            // txt_cidade
            // 
            txt_cidade.Location = new Point(307, 219);
            txt_cidade.Name = "txt_cidade";
            txt_cidade.Size = new Size(200, 23);
            txt_cidade.TabIndex = 13;
            // 
            // lbl_cidade
            // 
            lbl_cidade.AutoSize = true;
            lbl_cidade.Location = new Point(307, 201);
            lbl_cidade.Name = "lbl_cidade";
            lbl_cidade.Size = new Size(44, 15);
            lbl_cidade.TabIndex = 12;
            lbl_cidade.Text = "Cidade";
            // 
            // txt_uf
            // 
            txt_uf.FormattingEnabled = true;
            txt_uf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            txt_uf.Location = new Point(525, 219);
            txt_uf.Name = "txt_uf";
            txt_uf.Size = new Size(63, 23);
            txt_uf.TabIndex = 15;
            // 
            // lbl_uf
            // 
            lbl_uf.AutoSize = true;
            lbl_uf.Location = new Point(525, 201);
            lbl_uf.Name = "lbl_uf";
            lbl_uf.Size = new Size(21, 15);
            lbl_uf.TabIndex = 14;
            lbl_uf.Text = "UF";
            // 
            // dg_user
            // 
            dg_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_user.Location = new Point(12, 290);
            dg_user.Name = "dg_user";
            dg_user.Size = new Size(750, 206);
            dg_user.TabIndex = 16;
            dg_user.CellClick += dg_user_CellClick;
            dg_user.CellContentClick += dg_user_CellContentClick;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(128, 255, 128);
            btn_cadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_cadastrar.ForeColor = SystemColors.ActiveCaptionText;
            btn_cadastrar.Location = new Point(622, 47);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(140, 45);
            btn_cadastrar.TabIndex = 17;
            btn_cadastrar.Text = "CADASTRAR";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = Color.FromArgb(255, 255, 128);
            btn_alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_alterar.Location = new Point(622, 101);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(140, 45);
            btn_alterar.TabIndex = 18;
            btn_alterar.Text = "ALTERAR";
            btn_alterar.UseVisualStyleBackColor = false;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_deletar
            // 
            btn_deletar.BackColor = Color.FromArgb(255, 128, 128);
            btn_deletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_deletar.Location = new Point(622, 152);
            btn_deletar.Name = "btn_deletar";
            btn_deletar.Size = new Size(140, 45);
            btn_deletar.TabIndex = 19;
            btn_deletar.Text = "DELETAR";
            btn_deletar.UseVisualStyleBackColor = false;
            btn_deletar.Click += btn_deletar_Click;
            // 
            // btn_conexao
            // 
            btn_conexao.Location = new Point(622, 12);
            btn_conexao.Name = "btn_conexao";
            btn_conexao.Size = new Size(140, 23);
            btn_conexao.TabIndex = 20;
            btn_conexao.Text = "TESTE CONEXAO";
            btn_conexao.UseVisualStyleBackColor = true;
            btn_conexao.Click += btn_conexao_Click;
            // 
            // txt_pesquisa
            // 
            txt_pesquisa.Location = new Point(128, 16);
            txt_pesquisa.Name = "txt_pesquisa";
            txt_pesquisa.Size = new Size(379, 23);
            txt_pesquisa.TabIndex = 22;
            txt_pesquisa.TextChanged += txt_pesquisa_TextChanged;
            // 
            // lbl_pesquisa
            // 
            lbl_pesquisa.AutoSize = true;
            lbl_pesquisa.Location = new Point(12, 16);
            lbl_pesquisa.Name = "lbl_pesquisa";
            lbl_pesquisa.Size = new Size(110, 15);
            lbl_pesquisa.TabIndex = 21;
            lbl_pesquisa.Text = "Pesquisa por Nome";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(12, 61);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(183, 23);
            txt_id.TabIndex = 23;
            // 
            // user_id
            // 
            user_id.AutoSize = true;
            user_id.Location = new Point(12, 43);
            user_id.Name = "user_id";
            user_id.Size = new Size(18, 15);
            user_id.TabIndex = 24;
            user_id.Text = "ID";
            // 
            // txt_cel
            // 
            txt_cel.Location = new Point(307, 61);
            txt_cel.Name = "txt_cel";
            txt_cel.Size = new Size(200, 23);
            txt_cel.TabIndex = 26;
            // 
            // lbl_cel
            // 
            lbl_cel.AutoSize = true;
            lbl_cel.Location = new Point(307, 43);
            lbl_cel.Name = "lbl_cel";
            lbl_cel.Size = new Size(44, 15);
            lbl_cel.TabIndex = 25;
            lbl_cel.Text = "Celular";
            // 
            // frm_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(778, 525);
            Controls.Add(txt_cel);
            Controls.Add(lbl_cel);
            Controls.Add(user_id);
            Controls.Add(txt_id);
            Controls.Add(txt_pesquisa);
            Controls.Add(lbl_pesquisa);
            Controls.Add(btn_conexao);
            Controls.Add(btn_deletar);
            Controls.Add(btn_alterar);
            Controls.Add(btn_cadastrar);
            Controls.Add(dg_user);
            Controls.Add(txt_uf);
            Controls.Add(lbl_uf);
            Controls.Add(txt_cidade);
            Controls.Add(lbl_cidade);
            Controls.Add(txt_sexo);
            Controls.Add(lbl_sexo);
            Controls.Add(lbl_nasc);
            Controls.Add(data_nasc);
            Controls.Add(int_num);
            Controls.Add(label3);
            Controls.Add(txt_end);
            Controls.Add(lbl_end);
            Controls.Add(txt_cpf);
            Controls.Add(lbl_cpf);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            ForeColor = SystemColors.ControlText;
            Name = "frm_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_user";
            Load += frm_user_Load;
            ((System.ComponentModel.ISupportInitialize)dg_user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome;
        private Label lbl_cpf;
        private MaskedTextBox txt_cpf;
        private TextBox txt_end;
        private Label lbl_end;
        private TextBox int_num;
        private Label label3;
        private DateTimePicker data_nasc;
        private Label lbl_nasc;
        private Label lbl_sexo;
        private ComboBox txt_sexo;
        private TextBox txt_cidade;
        private Label lbl_cidade;
        private ComboBox txt_uf;
        private Label lbl_uf;
        private DataGridView dg_user;
        private Button btn_cadastrar;
        private Button btn_alterar;
        private Button btn_deletar;
        private Button btn_conexao;
        private TextBox txt_pesquisa;
        private Label lbl_pesquisa;
        private TextBox txt_id;
        private Label user_id;
        private MaskedTextBox txt_cel;
        private Label lbl_cel;
    }
}