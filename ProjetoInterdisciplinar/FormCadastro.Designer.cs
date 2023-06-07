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
            comboNasDia = new ComboBox();
            comboNasMes = new ComboBox();
            label15 = new Label();
            textEmail = new TextBox();
            label16 = new Label();
            textSenha = new TextBox();
            labelSituacao = new Label();
            butCadastro = new Button();
            comboNasAno = new ComboBox();
            labeldata = new Label();
            labelNome = new Label();
            labelGenero = new Label();
            labelCelular = new Label();
            labelCEP = new Label();
            labelEdereco = new Label();
            labelNumero = new Label();
            labelBairro = new Label();
            labelCidade = new Label();
            labelComplemento = new Label();
            labelUF = new Label();
            labelEmail = new Label();
            label4 = new Label();
            labelSenha = new Label();
            checkExibiSenha = new CheckBox();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(24, 76);
            textNome.Name = "textNome";
            textNome.Size = new Size(526, 23);
            textNome.TabIndex = 0;
            textNome.TextChanged += textNome_TextChanged;
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
            label3.Location = new Point(200, 121);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 3;
            label3.Text = "Data de nascimento:";
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
            label5.Location = new Point(15, 176);
            label5.Name = "label5";
            label5.Size = new Size(356, 37);
            label5.TabIndex = 7;
            label5.Text = "Informações para contato:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textCelular
            // 
            textCelular.Location = new Point(25, 243);
            textCelular.Name = "textCelular";
            textCelular.Size = new Size(99, 23);
            textCelular.TabIndex = 8;
            textCelular.TextChanged += textCelular_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(25, 225);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "Celular:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(144, 225);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 11;
            label7.Text = "CEP:";
            // 
            // textCep
            // 
            textCep.Location = new Point(144, 243);
            textCep.Name = "textCep";
            textCep.Size = new Size(133, 23);
            textCep.TabIndex = 10;
            textCep.TextChanged += textCep_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(294, 225);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 13;
            label8.Text = "Endereço:";
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(294, 243);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(345, 23);
            textEndereco.TabIndex = 12;
            textEndereco.TextChanged += textEndereco_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(661, 225);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 15;
            label9.Text = "Número:";
            // 
            // textNum
            // 
            textNum.Location = new Point(661, 243);
            textNum.Name = "textNum";
            textNum.Size = new Size(99, 23);
            textNum.TabIndex = 14;
            textNum.TextChanged += textNum_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(25, 296);
            label10.Name = "label10";
            label10.Size = new Size(146, 15);
            label10.TabIndex = 17;
            label10.Text = "Complemento (Opcional):";
            // 
            // textComple
            // 
            textComple.Location = new Point(25, 314);
            textComple.Name = "textComple";
            textComple.Size = new Size(343, 23);
            textComple.TabIndex = 16;
            textComple.TextChanged += textComple_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(25, 353);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 19;
            label11.Text = "Bairro:";
            // 
            // textBairro
            // 
            textBairro.Location = new Point(25, 371);
            textBairro.Name = "textBairro";
            textBairro.Size = new Size(193, 23);
            textBairro.TabIndex = 18;
            textBairro.TextChanged += textBairro_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(239, 353);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 21;
            label12.Text = "Cidade:";
            // 
            // textCidade
            // 
            textCidade.Location = new Point(239, 371);
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(177, 23);
            textCidade.TabIndex = 20;
            textCidade.TextChanged += textCidade_TextChanged;
            // 
            // comboUf
            // 
            comboUf.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUf.FormattingEnabled = true;
            comboUf.Items.AddRange(new object[] { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Praíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" });
            comboUf.Location = new Point(442, 371);
            comboUf.Name = "comboUf";
            comboUf.Size = new Size(127, 23);
            comboUf.TabIndex = 22;
            comboUf.SelectedIndexChanged += comboUf_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Location = new Point(442, 353);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 23;
            label13.Text = "UF:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Location = new Point(19, 121);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 25;
            label14.Text = "Gênero:";
            // 
            // comboGenero
            // 
            comboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGenero.FormattingEnabled = true;
            comboGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            comboGenero.Location = new Point(19, 139);
            comboGenero.Name = "comboGenero";
            comboGenero.Size = new Size(146, 23);
            comboGenero.TabIndex = 24;
            comboGenero.SelectedIndexChanged += comboGenero_SelectedIndexChanged;
            // 
            // comboNasDia
            // 
            comboNasDia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNasDia.FormattingEnabled = true;
            comboNasDia.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboNasDia.Location = new Point(200, 139);
            comboNasDia.Name = "comboNasDia";
            comboNasDia.Size = new Size(45, 23);
            comboNasDia.TabIndex = 26;
            comboNasDia.SelectedIndexChanged += comboNasDia_SelectedIndexChanged;
            // 
            // comboNasMes
            // 
            comboNasMes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNasMes.FormattingEnabled = true;
            comboNasMes.Items.AddRange(new object[] { "jan", "fev", "mar", "abr", "mai", "jun", "jul", "ago", "set", "out", "nov", "dez" });
            comboNasMes.Location = new Point(251, 139);
            comboNasMes.Name = "comboNasMes";
            comboNasMes.Size = new Size(48, 23);
            comboNasMes.TabIndex = 27;
            comboNasMes.SelectedIndexChanged += comboNasMes_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Location = new Point(24, 423);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 29;
            label15.Text = "E-mail::";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(24, 441);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(295, 23);
            textEmail.TabIndex = 28;
            textEmail.TextChanged += textEmail_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(25, 479);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 31;
            label16.Text = "Senha:";
            // 
            // textSenha
            // 
            textSenha.Location = new Point(25, 497);
            textSenha.Name = "textSenha";
            textSenha.PasswordChar = '*';
            textSenha.Size = new Size(216, 23);
            textSenha.TabIndex = 30;
            textSenha.TextChanged += textSenha_TextChanged;
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
            butCadastro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butCadastro.Location = new Point(678, 441);
            butCadastro.Name = "butCadastro";
            butCadastro.Size = new Size(115, 27);
            butCadastro.TabIndex = 33;
            butCadastro.Text = "Cadastrar";
            butCadastro.UseVisualStyleBackColor = false;
            butCadastro.Click += butCadastro_Click;
            // 
            // comboNasAno
            // 
            comboNasAno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboNasAno.FormattingEnabled = true;
            comboNasAno.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900" });
            comboNasAno.Location = new Point(305, 139);
            comboNasAno.Name = "comboNasAno";
            comboNasAno.Size = new Size(67, 23);
            comboNasAno.TabIndex = 34;
            comboNasAno.SelectedIndexChanged += comboNasAno_SelectedIndexChanged;
            // 
            // labeldata
            // 
            labeldata.AutoSize = true;
            labeldata.BackColor = Color.Transparent;
            labeldata.Location = new Point(200, 165);
            labeldata.Name = "labeldata";
            labeldata.Size = new Size(0, 15);
            labeldata.TabIndex = 35;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(24, 102);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(0, 15);
            labelNome.TabIndex = 36;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(20, 165);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(0, 15);
            labelGenero.TabIndex = 37;
            // 
            // labelCelular
            // 
            labelCelular.AutoSize = true;
            labelCelular.ForeColor = Color.DarkRed;
            labelCelular.Location = new Point(25, 269);
            labelCelular.Name = "labelCelular";
            labelCelular.Size = new Size(0, 15);
            labelCelular.TabIndex = 38;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(144, 269);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(0, 15);
            labelCEP.TabIndex = 39;
            // 
            // labelEdereco
            // 
            labelEdereco.AutoSize = true;
            labelEdereco.Location = new Point(294, 269);
            labelEdereco.Name = "labelEdereco";
            labelEdereco.Size = new Size(0, 15);
            labelEdereco.TabIndex = 40;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(661, 269);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(0, 15);
            labelNumero.TabIndex = 41;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(24, 397);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(0, 15);
            labelBairro.TabIndex = 42;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(239, 397);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(0, 15);
            labelCidade.TabIndex = 43;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(372, 314);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(0, 15);
            labelComplemento.TabIndex = 44;
            // 
            // labelUF
            // 
            labelUF.AutoSize = true;
            labelUF.Location = new Point(442, 397);
            labelUF.Name = "labelUF";
            labelUF.Size = new Size(0, 15);
            labelUF.TabIndex = 45;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(23, 467);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(0, 15);
            labelEmail.TabIndex = 46;
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
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(25, 523);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(0, 15);
            labelSenha.TabIndex = 50;
            // 
            // checkExibiSenha
            // 
            checkExibiSenha.AutoSize = true;
            checkExibiSenha.Location = new Point(263, 501);
            checkExibiSenha.Name = "checkExibiSenha";
            checkExibiSenha.Size = new Size(90, 19);
            checkExibiSenha.TabIndex = 51;
            checkExibiSenha.Text = "Exibir Senha";
            checkExibiSenha.UseVisualStyleBackColor = true;
            checkExibiSenha.CheckedChanged += checkExibiSenha_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(859, 555);
            Controls.Add(checkExibiSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(labelUF);
            Controls.Add(labelComplemento);
            Controls.Add(labelCidade);
            Controls.Add(labelBairro);
            Controls.Add(labelNumero);
            Controls.Add(labelEdereco);
            Controls.Add(labelCEP);
            Controls.Add(labelCelular);
            Controls.Add(labelGenero);
            Controls.Add(labelNome);
            Controls.Add(labeldata);
            Controls.Add(comboNasAno);
            Controls.Add(butCadastro);
            Controls.Add(labelSituacao);
            Controls.Add(label16);
            Controls.Add(textSenha);
            Controls.Add(label15);
            Controls.Add(textEmail);
            Controls.Add(comboNasMes);
            Controls.Add(comboNasDia);
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
        private ComboBox comboNasDia;
        private ComboBox comboNasMes;
        private Label label15;
        private TextBox textEmail;
        private Label label16;
        private TextBox textSenha;
        private Label labelSituacao;
        private Button butCadastro;
        private ComboBox comboNasAno;
        private Label labeldata;
        private Label labelNome;
        private Label labelGenero;
        private Label labelCelular;
        private Label labelCEP;
        private Label labelEdereco;
        private Label labelNumero;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelComplemento;
        private Label labelUF;
        private Label labelEmail;
        private Label label4;
        private Label labelSenha;
        private CheckBox checkExibiSenha;
    }
}