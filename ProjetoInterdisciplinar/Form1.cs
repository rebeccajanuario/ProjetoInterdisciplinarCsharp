namespace ProjetoInterdisciplinar
{
    public partial class Form1 : Form
    {
        bool visual = false;//barra de menu
        public Form1()
        {
            InitializeComponent();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            if (visual == true) visual = false;
            else visual = true;

            butCadLog.Visible = visual;
            butHome.Visible = visual;
            if (panel1.Visible )panel1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butCadLog.Visible = false;
            butHome.Visible = false;
            panel1.Visible = false;
        }

        private void butCadLog_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false) panel1.Visible = true;
            else panel1.Visible = false;
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            //Não utilizado
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastro TelaCad = new FormCadastro();
            TelaCad.ShowDialog();
        }
    }
}