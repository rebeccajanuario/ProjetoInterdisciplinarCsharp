using System.Data;

namespace ProjetoInterdisciplinar
{
    public partial class Form1 : Form
    {
        private bool visual = false;//barra de menu
        private bool logado = false;
        private int idUsuario;
        Pessoa login;
        public Form1()
        {
            InitializeComponent();
            login = new Pessoa();
            visual = false;
            logado = false;
            idUsuario = 0;
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            if (visual == true) visual = false;
            else visual = true;

            butCadLog.Visible = visual;
            butHome.Visible = visual;

            if (panel1.Visible) panel1.Visible = false;
            if (panel2.Visible) panel2.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butCadLog.Visible = false;
            butHome.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void butCadLog_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false && logado == false) panel1.Visible = true;
            else if (panel1.Visible == true && logado == false) panel1.Visible = false;
            else if (logado == true && panel2.Visible == false) panel2.Visible = true;
            else if (logado == true && panel2.Visible == true) panel2.Visible = false;
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            login.setEmail(textUsuario.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastro TelaCad = new FormCadastro();
            TelaCad.ShowDialog();
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            login.setSenha(textSenha.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.login() == true)
            {
                MessageBox.Show("Seja Bem vindo");
                panel1.Visible = false;
                logado = true;
                idUsuario = login.id();
                textUsuario.Clear();
                textSenha.Clear();
            }
            else MessageBox.Show("Usuário não encontrado");
        }

        private void butMydados_Click(object sender, EventArgs e)
        {
            FormMyDados myDados = new FormMyDados();
            myDados.ShowDialog();
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            idUsuario = 0;
            logado = false;
            panel2.Visible = false;
        }
    }
}