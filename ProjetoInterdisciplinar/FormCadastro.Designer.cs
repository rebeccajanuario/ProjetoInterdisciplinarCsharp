namespace ProjetoInterdisciplinar
{
    partial class FormCadastro
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
            textNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textCpf = new TextBox();
            label5 = new Label();
            textCelular = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textCep = new TextBox();
            label8 = new Label();
            textEndereco = new TextBox();
            label9 = new Label();
            textNum = new TextBox();
            label10 = new Label();
            textComple = new TextBox();
            label11 = new Label();
            textBairro = new TextBox();
            label12 = new Label();
            textCidade = new TextBox();
            comboUf = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            comboGenero = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label15 = new Label();
            textEmail = new TextBox();
            label16 = new Label();
            textSenha = new TextBox();
            labelSituacao = new Label();
            butCadastro = new Button();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(24, 76);
            textNome.Name = "textNome";
            textNome.Size = new Size(526, 23);
            textNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(578, 58);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(205, 126);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 3;
            label3.Text = "Data de nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(292, 37);
            label4.TabIndex = 4;
            label4.Text = "Informações pessoais";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(578, 76);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(181, 23);
            textCpf.TabIndex = 5;
            textCpf.TextChanged += textCpf_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(356, 37);
            label5.TabIndex = 7;
            label5.Text = "Informações para contato:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textCelular
            // 
            textCelular.Location = new Point(25, 264);
            textCelular.Name = "textCelular";
            textCelular.Size = new Size(99, 23);
            textCelular.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(25, 246);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "Celular:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(144, 246);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 11;
            label7.Text = "CEP:";
            // 
            // textCep
            // 
            textCep.Location = new Point(144, 264);
            textCep.Name = "textCep";
            textCep.Size = new Size(133, 23);
            textCep.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(294, 246);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 13;
            label8.Text = "Endereço:";
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(294, 264);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(345, 23);
            textEndereco.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(661, 246);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 15;
            label9.Text = "Número:";
            // 
            // textNum
            // 
            textNum.Location = new Point(661, 264);
            textNum.Name = "textNum";
            textNum.Size = new Size(99, 23);
            textNum.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(25, 301);
            label10.Name = "label10";
            label10.Size = new Size(146, 15);
            label10.TabIndex = 17;
            label10.Text = "Complemento (Opcional):";
            // 
            // textComple
            // 
            textComple.Location = new Point(25, 319);
            textComple.Name = "textComple";
            textComple.Size = new Size(343, 23);
            textComple.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(25, 356);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 19;
            label11.Text = "Bairro:";
            // 
            // textBairro
            // 
            textBairro.Location = new Point(25, 374);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(193, 23);
            textBairro.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(239, 356);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 21;
            label12.Text = "Cidade:";
            // 
            // textCidade
            // 
            textCidade.Location = new Point(239, 374);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(177, 23);
            textCidade.TabIndex = 20;
            // 
            // comboUf
            // 
            comboUf.FormattingEnabled = true;
            comboUf.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Praíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            comboUf.Location = new Point(442, 374);
            comboUf.Name = "comboUf";
            comboUf.Size = new Size(108, 23);
            comboUf.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(442, 356);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 23;
            label13.Text = "UF:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(24, 126);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 25;
            label14.Text = "Gênero:";
            // 
            // comboGenero
            // 
            comboGenero.FormattingEnabled = true;
            comboGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboGenero.Location = new Point(24, 144);
            comboGenero.Name = "comboGenero";
            comboGenero.Size = new Size(146, 23);
            comboGenero.TabIndex = 24;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox3.Location = new Point(205, 144);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(40, 23);
            comboBox3.TabIndex = 26;
            comboBox3.Text = "Dia";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "jan", "fev", "mar", "abr", "mai", "jun", "jul", "ago", "set", "out", "nov", "dez" });
            comboBox4.Location = new Point(251, 144);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(53, 23);
            comboBox4.TabIndex = 27;
            comboBox4.Text = "Mês";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(25, 437);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 29;
            label15.Text = "E-mail::";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(25, 455);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(295, 23);
            textEmail.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(356, 437);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 31;
            label16.Text = "Senha:";
            // 
            // textSenha
            // 
            textSenha.Location = new Point(356, 455);
            textSenha.Name = "textSenha";
            textSenha.PasswordChar = '*';
            textSenha.Size = new Size(216, 23);
            textSenha.TabIndex = 30;
            // 
            // labelSituacao
            // 
            labelSituacao.AutoSize = true;
            labelSituacao.BackColor = Color.Transparent;
            labelSituacao.Location = new Point(578, 102);
            labelSituacao.Name = "labelSituacao";
            labelSituacao.Size = new Size(0, 15);
            labelSituacao.TabIndex = 32;
            // 
            // butCadastro
            // 
            butCadastro.BackColor = Color.Transparent;
            butCadastro.Location = new Point(626, 505);
            butCadastro.Name = "butCadastro";
            butCadastro.Size = new Size(75, 23);
            butCadastro.TabIndex = 33;
            butCadastro.Text = "Cadastrar";
            butCadastro.UseVisualStyleBackColor = false;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(859, 555);
            Controls.Add(butCadastro);
            Controls.Add(labelSituacao);
            Controls.Add(label16);
            Controls.Add(textSenha);
            Controls.Add(label15);
            Controls.Add(textEmail);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label14);
            Controls.Add(comboGenero);
            Controls.Add(label13);
            Controls.Add(comboUf);
            Controls.Add(label12);
            Controls.Add(textCidade);
            Controls.Add(label11);
            Controls.Add(textBairro);
            Controls.Add(label10);
            Controls.Add(textComple);
            Controls.Add(label9);
            Controls.Add(textNum);
            Controls.Add(label8);
            Controls.Add(textEndereco);
            Controls.Add(label7);
            Controls.Add(textCep);
            Controls.Add(label6);
            Controls.Add(textCelular);
            Controls.Add(label5);
            Controls.Add(textCpf);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNome);
            Name = "FormCadastro";
            Text = "Cadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textCpf;
        private Label label5;
        private TextBox textCelular;
        private Label label6;
        private Label label7;
        private TextBox textCep;
        private Label label8;
        private TextBox textEndereco;
        private Label label9;
        private TextBox textNum;
        private Label label10;
        private TextBox textComple;
        private Label label11;
        private TextBox textBairro;
        private Label label12;
        private TextBox textCidade;
        private ComboBox comboUf;
        private Label label13;
        private Label label14;
        private ComboBox comboGenero;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label15;
        private TextBox textEmail;
        private Label label16;
        private TextBox textSenha;
        private Label labelSituacao;
        private Button butCadastro;
    }
}