using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterdisciplinar
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            /*ValidarCPF validacao = new ValidarCPF();

            validacao.setCPF();
            if (validacao.getSomaDigiti() == true) Console.WriteLine("Válido");
            else Console.WriteLine("Inválido");*/
        }

        private void textCpf_TextChanged(object sender, EventArgs e)
        {
            ValidarCPF validacao = new ValidarCPF();

            if ((textCpf.Text).Length == 11)
            {
                long cpf = long.Parse(textCpf.Text);//alterar tipo string para long
                validacao.setCPF(cpf);
                string situacao;
                if (validacao.getSomaDigiti() == true) situacao = "CPF Válido";
                else situacao = "CPF Inválido";
                labelSituacao.Text = situacao;
                labelSituacao.ForeColor = Color.DarkGreen;
            }
            else
            {
                labelSituacao.Text = "CPF Inválido";
                labelSituacao.ForeColor = Color.DarkRed;
            }

            //corrigir erros de cpf terminado em 0
        }
    }
}
