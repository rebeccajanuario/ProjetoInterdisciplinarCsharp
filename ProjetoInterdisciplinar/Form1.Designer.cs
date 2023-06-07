namespace ProjetoInterdisciplinar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            butMenu = new Button();
            butCadLog = new Button();
            panel1 = new Panel();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textSenha = new TextBox();
            textUsuario = new TextBox();
            panel2 = new Panel();
            butSair = new Button();
            butMydados = new Button();
            butHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(651, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // butMenu
            // 
            butMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            butMenu.BackColor = Color.Transparent;
            butMenu.BackgroundImage = (Image)resources.GetObject("butMenu.BackgroundImage");
            butMenu.BackgroundImageLayout = ImageLayout.Stretch;
            butMenu.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            butMenu.FlatStyle = FlatStyle.Flat;
            butMenu.Location = new Point(12, 2);
            butMenu.Name = "butMenu";
            butMenu.Size = new Size(43, 40);
            butMenu.TabIndex = 2;
            butMenu.TabStop = false;
            butMenu.UseVisualStyleBackColor = false;
            butMenu.Click += butMenu_Click;
            // 
            // butCadLog
            // 
            butCadLog.BackColor = Color.Transparent;
            butCadLog.BackgroundImage = Properties.Resources.usuario;
            butCadLog.BackgroundImageLayout = ImageLayout.Zoom;
            butCadLog.FlatAppearance.BorderSize = 0;
            butCadLog.FlatAppearance.MouseDownBackColor = Color.Gray;
            butCadLog.FlatStyle = FlatStyle.Flat;
            butCadLog.Location = new Point(12, 145);
            butCadLog.Name = "butCadLog";
            butCadLog.Size = new Size(74, 60);
            butCadLog.TabIndex = 4;
            butCadLog.TabStop = false;
            butCadLog.UseVisualStyleBackColor = false;
            butCadLog.Click += butCadLog_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textSenha);
            panel1.Controls.Add(textUsuario);
            panel1.Location = new Point(92, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 209);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 165);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 6;
            label3.Text = "Não tem conta?";
            // 
            // button2
            // 
            button2.Location = new Point(121, 161);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(65, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 67);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuário:";
            // 
            // textSenha
            // 
            textSenha.Location = new Point(24, 85);
            textSenha.Name = "textSenha";
            textSenha.PasswordChar = '*';
            textSenha.Size = new Size(180, 23);
            textSenha.TabIndex = 1;
            textSenha.TextChanged += textSenha_TextChanged;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.White;
            textUsuario.Location = new Point(24, 37);
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(180, 23);
            textUsuario.TabIndex = 0;
            textUsuario.TextChanged += textUsuario_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(butSair);
            panel2.Controls.Add(butMydados);
            panel2.Location = new Point(92, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 115);
            panel2.TabIndex = 7;
            // 
            // butSair
            // 
            butSair.Location = new Point(28, 63);
            butSair.Name = "butSair";
            butSair.Size = new Size(120, 23);
            butSair.TabIndex = 5;
            butSair.Text = "Sair";
            butSair.UseVisualStyleBackColor = true;
            butSair.Click += butSair_Click;
            // 
            // butMydados
            // 
            butMydados.Location = new Point(28, 25);
            butMydados.Name = "butMydados";
            butMydados.Size = new Size(120, 23);
            butMydados.TabIndex = 4;
            butMydados.Text = "Meus dados";
            butMydados.UseVisualStyleBackColor = true;
            butMydados.Click += butMydados_Click;
            // 
            // butHome
            // 
            butHome.BackColor = Color.Transparent;
            butHome.BackgroundImage = Properties.Resources.home1;
            butHome.BackgroundImageLayout = ImageLayout.Stretch;
            butHome.FlatAppearance.BorderSize = 0;
            butHome.FlatAppearance.MouseDownBackColor = Color.Gray;
            butHome.FlatStyle = FlatStyle.Flat;
            butHome.Location = new Point(12, 70);
            butHome.Name = "butHome";
            butHome.Size = new Size(74, 60);
            butHome.TabIndex = 7;
            butHome.TabStop = false;
            butHome.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(820, 390);
            Controls.Add(panel2);
            Controls.Add(butHome);
            Controls.Add(panel1);
            Controls.Add(butCadLog);
            Controls.Add(butMenu);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Home";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button butMenu;
        private Button butCadLog;
        private Panel panel1;
        private TextBox textSenha;
        private TextBox textUsuario;
        private Label label3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button butHome;
        private Panel panel2;
        private Button butSair;
        private Button butMydados;
    }
}