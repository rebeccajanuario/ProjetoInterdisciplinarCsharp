using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;

//biblioteca MySql
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace ProjetoInterdisciplinar
{
    internal class Pessoa
    {

        private string nome;
        private string cpf;
        private string genero;
        private int nasDia;
        private int nasMes;
        private int nasAno;
        private string datas;

        private string celular;
        private string cep;
        private string endereco;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;

        private bool auxBancocpf;//Existencia de outro cpf igual
        private bool auxBancoemail;//Existencia de outro email igual
        private bool auxLogi;//Realizar login

        private string email;
        private string senha;

        private int idUsuario;
       
        

        public Pessoa()
        {
            
            this.nome = "nome";
            this.cpf = "00000000000";
            this.genero = "nome";
            this.nasDia = 0;
            this.nasMes = 0;
            this.nasAno = 0;
            this.datas = "0000-00-00";

            this.celular = "0";
            this.cep = "0";
            this.endereco = "rua";
            this.numero = "0";
            this.complemento = null;
            this.bairro = "bairro";
            this.cidade = "cidade";
            this.uf = "uf";

            this.auxBancocpf = true;
            this.auxBancoemail = true;
            this.auxLogi = false;

            this.email = "a@a.com";
            this.senha = "12";

            this.idUsuario = 0;
        }
        public void setCpf(string cpf)
        {
            this.cpf= cpf;
        }
        public bool getCpf()
        {
            ValidarCPF validacao = new ValidarCPF();
            try
            {
                if (this.cpf.Length == 11)
                {
                    long cpf = long.Parse(this.cpf);
                    validacao.setCPF(cpf);
                    if (validacao.getSomaDigiti() == true) return true;
                    else return false;
                }
                else
                {
                    return false;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public bool getNome()
        {
            if (this.nome.Length >=2 && this.nome.Length <=100) return true;
            else return false;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public bool getGenero()
        {
            if(this.genero == "Masculino" || this.genero == "Feminino" || this.genero == "Outros") return true;
            else return false;
        }
        public void setNasDia(string dia)
        {
            this.nasDia = int.Parse(dia);
        }
        public bool getNasDia()
        {
            if (this.nasDia >= 1 && this.nasDia <= 31) return true;
            else return false;
        }
        public void setNasMes(string mes)
        {
            switch (mes)
            {
                case "jan":
                    this.nasMes = 01;
                    break;
                case "fev":
                    this.nasMes = 02;
                    break;
                case "mar":
                    this.nasMes = 03;
                    break;
                case "abr":
                    this.nasMes = 04;
                    break;
                case "mai":
                    this.nasMes = 05;
                    break;
                case "jun":
                    this.nasMes = 06;
                    break;
                case "jul":
                    this.nasMes = 07;
                    break;
                case "ago":
                    this.nasMes = 08;
                    break;
                case "set":
                    this.nasMes = 09;
                    break;
                case "out":
                    this.nasMes = 10;
                    break;
                case "nov":
                    this.nasMes = 11;
                    break;
                case "dez":
                    this.nasMes = 12;
                    break;
            }
            
        }
        public bool getNasMes()
        {
            if (this.nasMes >= 1 && this.nasMes <= 12) return true;
            else return false;
        }
        public void setNasAno(string ano)
        {
            this.nasAno = int.Parse(ano);
        }
        public bool getNasAno()
        {
            if (this.nasAno >= 1900 && this.nasAno <= 2023) return true;
            else return false;
        }
        public bool data()
        {
            if (this.nasMes == 4 || this.nasMes == 6 || this.nasMes == 9 || this.nasMes == 11)
            {
                if (this.nasDia >= 1 && this.nasDia <= 30) return true;
                else return false;
            }
            else if (this.nasMes == 2)
            {
                if (this.nasDia >= 1 && this.nasDia <= 29) return true;
                else return false;
            }
            else return true;

        }
        public bool dadosPessaoais()//Validar todos os dados pessoais
        {
            if (data() == true && getCpf() == true && getNome() == true && getGenero() == true && getNasDia() == true && getNasMes() == true && getNasAno() == true) return true;
            else return false;
        }

        //informações para contato
        public void setCelular(string celular)
        {
            this.celular = celular;
        }
        public bool getCelular()
        {
            try
            {
                if (this.celular.Length == 11 && long.Parse(this.celular) > 0) return true;
                else return false;
            }
            catch (FormatException)
            {
                return false;
            }     
        }
        public void setCEP(string cep)
        {
            this.cep = cep;
        }
        public bool getCEP()
        {
            try
            {
                if (this.cep.Length == 8 && long.Parse(this.cep) > 0) return true;
                else return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public bool getEndereco()
        {
            if(this.endereco.Length >3 && this.endereco.Length <=100)return true;
            else return false;
        }
        public void setNumero(string numero)
        {
            this.numero = numero;
        }
        public bool getNumero()
        {
            try
            {
                if (this.numero.Length > 0 && this.numero.Length <= 5 && int.Parse(this.numero)>0) return true;
                else return false;
            }
            catch (FormatException)
            {
                return false;
            }
            
        }
        public void setComplemento(string compemento)
        {
            this.complemento = compemento;
        }
        public bool getComplemento()
        {
            if (this.complemento != null)//exceção
            {
                if (this.complemento.Length == 0 || (this.complemento.Length >= 2 && this.complemento.Length <= 100)) return true;
                else return false;
            }
            else return true;
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public bool getBairro()
        {
            if (this.bairro.Length >= 2 && this.bairro.Length <= 100) return true;
            else return false;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public bool getCidade()
        {
            if (this.cidade.Length >= 2 && this.cidade.Length <= 100) return true;
            else return false;
        }
        public void setUF(string uf)
        {
            this.uf = uf;
        }
        public bool getUF()
        {
            if (this.uf.Length <= 20 && this.uf.Length > 3) return true;
            else return false;
        }
        public bool infCotatos()
        {
            if (getCelular() == true && getCEP() == true && getEndereco() == true && getNumero() == true && getComplemento() == true && getBairro() == true && getCidade() == true && getUF() == true) return true;
            else return false;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public bool getEmail()
        {
            if (this.email.Length >= 8 && this.email.Length <= 100) return true;
            else return false;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public bool getSenha()
        {
            if (this.senha.Length >= 8) return true;
            else return false;
        }
        public bool validarEmailSenha()
        {
            if (getEmail() == true && getSenha() == true) return true;
            else return false;
        }

        //Validar todos os dados
        public int validarDados()
        {
            
            if (dadosPessaoais() == true && infCotatos()==true && validarEmailSenha()==true)
            {
                cadastrarBanco();
                if (this.auxBancocpf == false) return 2;//Verificar se CPF já é cadastrado
                else if (this.auxBancoemail == false) return 3;//Verificar se E-mail já é cadastrado
                else return 1;//Cadastro realizado
            }
            else return 0;
        }
        //Coneção com Banco
        public void cadastrarBanco()
        {
            this.auxBancocpf = true;
            this.auxBancoemail = true;
            //string de conexão com o banco de dados
            string connectionStr = @"server=127.0.0.1;uid=root;pwd=130521;database=cadastros;ConnectionTimeout=1";

            MySqlConnection connectionBD = null;
            MySqlCommand cmdInsert = null;
            MySqlCommand cmdSelect = null;

            try
            {
                //tenta criar uma conexão com o banco
                connectionBD = new MySqlConnection(connectionStr);

                //abre a conexão com o banco
                connectionBD.Open();

                cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connectionBD;

                cmdSelect = new MySqlCommand();
                cmdSelect.Connection = connectionBD;

                string nome = this.nome;
                string cpf = this.cpf;
                string genero = this.genero;
                DateTime dataNas = new DateTime(this.nasAno, this.nasMes, this.nasDia, 00, 00, 00);///

                string celular = this.celular;
                string cep = this.cep;
                string endereco = this.endereco;
                string numero = this.numero;
                string complemento = this.complemento;
                string bairro = this.bairro;
                string cidade = this.cidade;
                string uf = this.uf;
                string email = this.email;
                string senha = this.senha;

                //vericar se já tem uma cpf cadastrado
                cmdSelect.CommandText = "SELECT cpf FROM pessoas WHERE cpf = @cpf";
                cmdSelect.Parameters.AddWithValue("@cpf", cpf);
                object result = cmdSelect.ExecuteScalar();

                if (result != null)
                {
                    this.auxBancocpf = false;
                    return;
                }
                //Verricica se já tem um emmail cadastrado
                cmdSelect.CommandText = "SELECT email FROM contato WHERE email = @email";
                cmdSelect.Parameters.AddWithValue("@email", email);
                result = cmdSelect.ExecuteScalar();

                if (result != null)
                {
                    this.auxBancoemail = false;
                    return;
                }

                //Informações Pessoais
                cmdInsert.CommandText = "INSERT INTO pessoas (nome, cpf, genero, data_nascimento)" +
                                        "VALUES (@nome, @cpf, @genero, @data_nascimento)";

                cmdInsert.Parameters.AddWithValue("@nome", nome);
                cmdInsert.Parameters.AddWithValue("@cpf", cpf);
                cmdInsert.Parameters.AddWithValue("@genero", genero);
                cmdInsert.Parameters.AddWithValue("@data_nascimento", dataNas);

                cmdInsert.ExecuteNonQuery();// Executa o comando de inserção

                //chave estrangeira que referencia a tabela pessoas
                cmdSelect.CommandText = "SELECT LAST_INSERT_ID()";
                result = cmdSelect.ExecuteScalar();
                int pessoaId = Convert.ToInt32(result);
                

                //Informações de contato
                cmdInsert.CommandText = "INSERT INTO contato (pessoa_id, celular, cep, endereco, numero, complemento, bairro, cidade, uf, email, senha)" +
                                        "VALUES (@pessoa_id, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @uf, @email, @senha)";

                cmdInsert.Parameters.AddWithValue("@pessoa_id", pessoaId);
                cmdInsert.Parameters.AddWithValue("@celular", celular);
                cmdInsert.Parameters.AddWithValue("@cep", cep);
                cmdInsert.Parameters.AddWithValue("@endereco", endereco);
                cmdInsert.Parameters.AddWithValue("@numero", numero);
                cmdInsert.Parameters.AddWithValue("@complemento", complemento);
                cmdInsert.Parameters.AddWithValue("@bairro", bairro);
                cmdInsert.Parameters.AddWithValue("@cidade", cidade);
                cmdInsert.Parameters.AddWithValue("@uf", uf);
                cmdInsert.Parameters.AddWithValue("@email", email);
                cmdInsert.Parameters.AddWithValue("@senha", senha);

                cmdInsert.ExecuteNonQuery();// Executa o comando de inserção
            }
            catch (MySqlException erro)
            {
                Console.WriteLine("Erro Banco!");
                Console.WriteLine(erro.GetType());
                Console.WriteLine(erro.Message);
                Console.WriteLine("\n" + erro.StackTrace);
            }
            //tratamento dos demais erros que possam ocorrer
            catch (Exception erro)
            {
                Console.WriteLine("Exceção Desconhecida !!!");
                Console.WriteLine(erro.GetType());
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
            finally
            {
                //libera a memória utilizada pelos comandos
                if (cmdInsert != null) cmdInsert.Dispose();
                if (cmdSelect != null) cmdSelect.Dispose();

                //fecha a conexão com o banco!
                if (connectionBD != null && connectionBD.State == ConnectionState.Open)
                    connectionBD.Close();
            }

        }
        //retornar id da pessoa que fez o login
        public void idPessoa(int id)
        {
            idUsuario = id;
        }
        //retornar para o form1
        public int id()
        {
            return idUsuario;
        }
        public bool login()
        {
            pesquisarBanco();
            if (auxLogi == true) return true;
            else return false;
        }
        public void pesquisarBanco()
        {
            this.auxLogi = false;
            int pessoa_id;
            //string de conexão com o banco de dados
            string connectionStr = @"server=127.0.0.1;uid=root;pwd=130521;database=cadastros;ConnectionTimeout=1";

            MySqlConnection connectionBD = null;
            MySqlCommand cmdInsert = null;
            MySqlCommand cmdSelect = null;

            try
            {
                //tenta criar uma conexão com o banco
                connectionBD = new MySqlConnection(connectionStr);

                //abre a conexão com o banco
                connectionBD.Open();

                cmdSelect = new MySqlCommand();
                cmdSelect.Connection = connectionBD;

                string email = this.email;
                string senha = this.senha;

                
                cmdSelect.CommandText = "SELECT pessoa_id FROM contato WHERE email = @email AND senha = @senha";
                cmdSelect.Parameters.AddWithValue("@email", email);
                cmdSelect.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader reader = cmdSelect.ExecuteReader();

                if (reader.HasRows)
                {
                    this.auxLogi = true;

                    reader.Read();//guardar valor
                    pessoa_id = reader.GetInt32(0);//id da pessoa que realizou o cadastro
                    idPessoa(pessoa_id);
                }
                




            }

            catch (MySqlException erro)
            {
                Console.WriteLine("Erro Banco!");
                Console.WriteLine(erro.GetType());
                Console.WriteLine(erro.Message);
                Console.WriteLine("\n" + erro.StackTrace);
            }
            //tratamento dos demais erros que possam ocorrer
            catch (Exception erro)
            {
                Console.WriteLine("Exceção Desconhecida !!!");
                Console.WriteLine(erro.GetType());
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
            }
            finally
            {
                //libera a memória utilizada pelos comandos
                if (cmdInsert != null) cmdInsert.Dispose();
                if (cmdSelect != null) cmdSelect.Dispose();

                //fecha a conexão com o banco!
                if (connectionBD != null && connectionBD.State == ConnectionState.Open)
                    connectionBD.Close();
            }
        }
    }
    
}
