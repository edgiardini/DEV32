namespace ProjetoExtra
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listLeitura = new System.Windows.Forms.ListBox();
            this.txtInformacoes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ckEstiloMusical = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGerarDados = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblLeitura = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblMusica = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.dtDataNasc);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(651, 197);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(113, 29);
            this.dtDataNasc.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(461, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(184, 24);
            this.label22.TabIndex = 15;
            this.label22.Text = "Data de Nascimento:";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(126, 217);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(108, 28);
            this.rbFeminino.TabIndex = 8;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 217);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(114, 28);
            this.rbMasculino.TabIndex = 7;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sexo:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(651, 152);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(113, 29);
            this.txtEstado.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(118, 152);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(425, 29);
            this.txtCidade.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(118, 80);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(646, 29);
            this.txtEndereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(399, 29);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listLeitura);
            this.groupBox2.Controls.Add(this.txtInformacoes);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ckEstiloMusical);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interesses Pessoais";
            // 
            // listLeitura
            // 
            this.listLeitura.FormattingEnabled = true;
            this.listLeitura.ItemHeight = 24;
            this.listLeitura.Items.AddRange(new object[] {
            "Ação",
            "Drama",
            "Policial",
            "Ficção",
            "Informática"});
            this.listLeitura.Location = new System.Drawing.Point(177, 68);
            this.listLeitura.Name = "listLeitura";
            this.listLeitura.Size = new System.Drawing.Size(124, 124);
            this.listLeitura.TabIndex = 11;
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Location = new System.Drawing.Point(353, 68);
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.Size = new System.Drawing.Size(411, 124);
            this.txtInformacoes.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "Informações Adicionais";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Leitura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Estilo Musical";
            // 
            // ckEstiloMusical
            // 
            this.ckEstiloMusical.FormattingEnabled = true;
            this.ckEstiloMusical.Items.AddRange(new object[] {
            "Axé",
            "Funk",
            "Forró",
            "Rock",
            "POP"});
            this.ckEstiloMusical.Location = new System.Drawing.Point(10, 68);
            this.ckEstiloMusical.Name = "ckEstiloMusical";
            this.ckEstiloMusical.Size = new System.Drawing.Size(120, 124);
            this.ckEstiloMusical.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cadastro de Clientes";
            // 
            // btnGerarDados
            // 
            this.btnGerarDados.Location = new System.Drawing.Point(416, 527);
            this.btnGerarDados.Name = "btnGerarDados";
            this.btnGerarDados.Size = new System.Drawing.Size(150, 58);
            this.btnGerarDados.TabIndex = 13;
            this.btnGerarDados.Text = "Gerar Dados";
            this.btnGerarDados.UseVisualStyleBackColor = true;
            this.btnGerarDados.Click += new System.EventHandler(this.btnGerarDados_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(595, 527);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(150, 58);
            this.btnLimparCampos.TabIndex = 14;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblInformacoes);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.lblDataNasc);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.lblEstado);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.lblCEP);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.lblCPF);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.lblLeitura);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lblMusica);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblSexo);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblCidade);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblEndereco);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lblNome);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(22, 591);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(766, 186);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.Location = new System.Drawing.Point(612, 133);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(15, 24);
            this.lblInformacoes.TabIndex = 22;
            this.lblInformacoes.Text = ".";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(471, 133);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 24);
            this.label24.TabIndex = 21;
            this.label24.Text = "Observações:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(612, 109);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(15, 24);
            this.lblDataNasc.TabIndex = 20;
            this.lblDataNasc.Text = ".";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(474, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 24);
            this.label23.TabIndex = 19;
            this.label23.Text = "Nascido aos:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(612, 85);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(15, 24);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = ".";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(474, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 24);
            this.label21.TabIndex = 17;
            this.label21.Text = "Estado:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(612, 61);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(15, 24);
            this.lblCEP.TabIndex = 16;
            this.lblCEP.Text = ".";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(474, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 24);
            this.label20.TabIndex = 15;
            this.label20.Text = "CEP:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(612, 37);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(15, 24);
            this.lblCPF.TabIndex = 14;
            this.lblCPF.Text = ".";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(474, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 24);
            this.label19.TabIndex = 13;
            this.label19.Text = "Seu CPF:";
            // 
            // lblLeitura
            // 
            this.lblLeitura.AutoSize = true;
            this.lblLeitura.Location = new System.Drawing.Point(175, 157);
            this.lblLeitura.Name = "lblLeitura";
            this.lblLeitura.Size = new System.Drawing.Size(15, 24);
            this.lblLeitura.TabIndex = 12;
            this.lblLeitura.Text = ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 24);
            this.label18.TabIndex = 11;
            this.label18.Text = "Sua Leitura:";
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.Location = new System.Drawing.Point(175, 133);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(15, 24);
            this.lblMusica.TabIndex = 10;
            this.lblMusica.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 24);
            this.label17.TabIndex = 9;
            this.label17.Text = "Sua Música:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(175, 109);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(15, 24);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 24);
            this.label15.TabIndex = 7;
            this.label15.Text = "Seu Sexo:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(175, 85);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(15, 24);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cidade:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 24);
            this.label16.TabIndex = 4;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(175, 61);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(15, 24);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "Seu endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(175, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(15, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seu nome:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(583, 43);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(181, 29);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(118, 115);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(183, 29);
            this.txtCEP.TabIndex = 4;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 786);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnGerarDados);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox ckEstiloMusical;
        private System.Windows.Forms.ListBox listLeitura;
        private System.Windows.Forms.TextBox txtInformacoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGerarDados;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLeitura;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCEP;
    }
}

