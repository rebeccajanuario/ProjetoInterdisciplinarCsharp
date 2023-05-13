using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterdisciplinar
{
    internal class ValidarCPF
    {

        private long cpf;
        private int parte;
        private long digito1;
        private long digito2;

        public ValidarCPF()
        {
            this.parte = 1;
            this.cpf = 00000000000;
            this.digito1 = 0;
            this.digito2 = 0;
        }

        public void setCPF(long cpf)
        {
            this.cpf = cpf;
        }
        public void controlePart(int parte)
        {
            this.parte = parte;
        }
        //soma dos numeros do cpf
        public long somaNums(long cpf)
        {
            string numeros;
            long cpfnum = 0;
            long n0 = 0;
            long num = 0;
            int valor = 0;
            bool control = true;
            int condicao = 2;
            if (this.parte == 1) valor = 10;//primeiro digito
            if (this.parte == 2)//segundo digito
            {
                valor = 11;
                control = false;
                condicao = 1;
            }
            long soma = 0;
            //separ os digitos, somar e multiplicar
            for (int cont = 10; cont >= condicao; cont -= 1)
            {
                // primeiro digito do cpf / com 1ºdigito verificador
                if (cont == 10 && control == true)//operação de verificação do 1ºdigito verificador
                {
                    numeros = (Math.Pow(10, cont)).ToString();//elevar a uma potencia
                    cpfnum = cpf / (long.Parse(numeros)); //dividir cpf pela valor gerado pela potencia(divisão inteira/resultado considerado somente a parte inteira)
                    num = cpfnum;
                }
                //primeiro digito do cpf / com 2ºdigito verificador
                else if (cont == 11 && control == false)//operação de verificação do 2ºdigito verificador
                {
                    numeros = (Math.Pow(10, cont)).ToString();//elevar a uma potencia
                    cpfnum = cpf / (long.Parse(numeros)); //dividir cpf pela valor gerado pela potencia
                    num = cpfnum;
                }
                //gerar os outros digitos do cpf
                else//verificação com ambos digitos verificadores
                {
                    numeros = (Math.Pow(10, cont)).ToString();
                    cpfnum = cpf / (long.Parse(numeros));
                    n0 = (cpfnum / 10) * 10;
                    num = cpfnum - n0;
                }
                num = num * valor;
                soma += num;
                valor--;
            }
            return soma;
        }
        //divisão do resultada da soma
        public long opDivisao()
        {
            long soma = somaNums(this.cpf);//soma os 9 numeros e multiplicacaoa
            long resto = soma % 11;
            long digitoveri = 0;

            if (resto < 2) digitoveri = 0;
            else digitoveri = 11 - resto;

            return digitoveri;
        }
        //digito verificador do cpf digitado pelo usuario
        public long digitoVeri1(long cpf)//primeiro digito
        {
            long resul = 0;
            long digi = cpf / 10;
            resul = digi - ((digi / 10) * 10);

            return resul;
        }
        public long digitoVeri2(long cpf)//segundo digito
        {
            long resul = 0;
            long digi = cpf / 1;
            resul = digi - ((digi / 10) * 10);

            return resul;
        }

        //retorno para o usuario
        public bool getSomaDigiti()
        {
            bool situacao = true;
            long digi1 = digitoVeri1(this.cpf);//digito verificador digitado pelo usuario
            long digi2 = digitoVeri2(this.cpf);//digito verificador digitado pelo usuario

            int parte = this.parte;

            if (parte == 1)
            {
                this.digito1 = opDivisao();//recebe o primeiro digito verificador
                if (this.digito1 != digi1) situacao = false;//digito gerado for diferente do digito digitado
                else parte += 1;
            }
            if (parte == 2)
            {
                controlePart(parte);
                this.digito2 = opDivisao();//recebe o segundo digito verificador
                if (this.digito2 != digi2) situacao = false;//digito gerado for diferente do digito digitado
            }
            /*if(situacao == false)
            {
                digito1 = 0;
                digito2 = 0;
            }
            string aviso;
            if (situacao == true)
            {
                Console.WriteLine("CPF válido");
            }
            else Console.WriteLine("CPF Inválido");
            /*Console.WriteLine("digito 1 CPF: {0}",this.digito1);
            Console.WriteLine("digito 2 CPF: {0}", this.digito2);
            Console.WriteLine("{0}{1}",digi1, digi2);*/
            return situacao;
        }
    }
}
