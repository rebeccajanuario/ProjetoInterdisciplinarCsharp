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
        bool senhaIgula;
        Pessoa cadastro;
        public FormCadastro()
        {
            InitializeComponent();
            cadastro = new Pessoa();
            senhaIgula = false;
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
            cadastro.setCpf(textCpf.Text);
            if (cadastro.getCpf() == true)
            {
                labelSituacao.Text = "CPF Válido";
                labelSituacao.ForeColor = Color.DarkGreen;
            }
            else
            {
                labelSituacao.Text = "CPF Inválido";
                labelSituacao.ForeColor = Color.DarkRed;
            }

        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro.setGenero(comboGenero.Text);

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            cadastro.setNome(textNome.Text);
            if (cadastro.getNome() == true)
            {
                labelNome.Visible = false;
            }
            else
            {
                labelNome.Visible = true;
                labelNome.Text = "Nome Inválido";
                labelNome.ForeColor = Color.DarkRed;
            }
        }

        private void comboNasDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro.setNasDia(comboNasDia.Text);
        }

        private void comboNasMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro.setNasMes(comboNasMes.Text);
            if (cadastro.data() == true)
            {
                labeldata.Visible = false;
            }
            else
            {
                labeldata.Visible = true;
                labeldata.Text = "Data Inválido";
                labeldata.ForeColor = Color.DarkRed;
            }
        }

        private void comboNasAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro.setNasAno(comboNasAno.Text);
        }

        private void butCadastro_Click(object sender, EventArgs e)
        {
            if (cadastro.validarDados() == 1)
            {
                MessageBox.Show("Cadastro realizado com Sucesso");
                //Close();
            }
            else if (cadastro.validarDados() == 0) MessageBox.Show("Dados Inválidos");
            else if (cadastro.validarDados() == 2) MessageBox.Show("CPF já existe");
            else if (cadastro.validarDados() == 3) MessageBox.Show("E-mail já possui cadastro");
        }

        private void textCelular_TextChanged(object sender, EventArgs e)
        {
            cadastro.setCelular(textCelular.Text);
            if (cadastro.getCelular() == true)
            {
                labelCelular.Visible = false;
            }
            else
            {
                labelCelular.Visible = true;
                labelCelular.Text = "Número inválido";
                labelCelular.ForeColor = Color.DarkRed;
            }
        }

        private void textCep_TextChanged(object sender, EventArgs e)
        {
            cadastro.setCEP(textCep.Text);
            if (cadastro.getCEP() == true)
            {
                labelCEP.Visible = false;
            }
            else
            {
                labelCEP.Visible = true;
                labelCEP.Text = "CEP Inválido";
                labelCEP.ForeColor = Color.DarkRed;
            }
        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {
            cadastro.setEndereco(textEndereco.Text);
            if (cadastro.getEndereco() == true)
            {
                labelEdereco.Visible = false;
            }
            else
            {
                labelEdereco.Visible = true;
                labelEdereco.Text = "Endereço Inválido";
                labelEdereco.ForeColor = Color.DarkRed;
            }
        }

        private void textNum_TextChanged(object sender, EventArgs e)
        {
            cadastro.setNumero(textNum.Text);
            if (cadastro.getNumero() == true)
            {
                labelNumero.Visible = false;
            }
            else
            {
                labelNumero.Visible = true;
                labelNumero.Text = "Número Inválido";
                labelNumero.ForeColor = Color.DarkRed;
            }
        }

        private void textComple_TextChanged(object sender, EventArgs e)
        {
            cadastro.setComplemento(textComple.Text);
            if (cadastro.getComplemento() == true)
            {
                labelComplemento.Visible = false;
            }
            else
            {
                labelComplemento.Visible = true;
                labelComplemento.Text = "Inválido";
                labelComplemento.ForeColor = Color.DarkRed;
            }
        }

        private void textBairro_TextChanged(object sender, EventArgs e)
        {
            cadastro.setBairro(textBairro.Text);
            if (cadastro.getBairro() == true)
            {
                labelBairro.Visible = false;
            }
            else
            {
                labelBairro.Visible = true;
                labelBairro.Text = "Inválido";
                labelBairro.ForeColor = Color.DarkRed;
            }
        }

        private void textCidade_TextChanged(object sender, EventArgs e)
        {
            cadastro.setCidade(textCidade.Text);
            if (cadastro.getCidade() == true)
            {
                labelCidade.Visible = false;
            }
            else
            {
                labelCidade.Visible = true;
                labelCidade.Text = "Inválido";
                labelCidade.ForeColor = Color.DarkRed;
            }
        }

        private void comboUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cadastro.setUF(comboUf.Text);

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            cadastro.setEmail(textEmail.Text);
            if (cadastro.getEmail() == true)
            {
                labelEmail.Visible = false;
            }
            else
            {
                labelEmail.Visible = true;
                labelEmail.Text = "E-mail Inválido";
                labelEmail.ForeColor = Color.DarkRed;
            }
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            cadastro.setSenha(textSenha.Text);
            if (cadastro.getSenha() == true)
            {
                labelSenha.Visible = false;
            }
            else
            {
                labelSenha.Visible = true;
                labelSenha.Text = "Senha Inválida";
                labelSenha.ForeColor = Color.DarkRed;
            }

        }

        private void checkExibiSenha_CheckedChanged(object sender, EventArgs e)
        {
            textSenha.PasswordChar = '\0';
        }
    }
}
