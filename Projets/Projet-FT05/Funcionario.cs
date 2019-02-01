using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT05
{
    abstract class Funcionario
    {
        protected int id;
        protected string nome;
        protected string email;
        protected double valorHora;
        protected Data dataNasc;

        public Funcionario()
        {
            id = 0;
            nome = "Sem nome";
            email = "";
            valorHora = 0;
            dataNasc = new Data();
        }
        public Funcionario(int id, string n, string e, double v, int d, int m, int a)
        {
            if (!SetId(id))
                id = 0;
            if (!SetNome(n))
                nome = "Nome inválido";
            if (!SetEmail(e))
                email = "E-mail inválido";
            if (!SetValorHora(v))
                valorHora = 0;
            dataNasc = new Data(d, m, a);
        }
        public Funcionario(int id, string n, string e, double v, Data d)
        {
            if (!SetId(id))
                id = 0;
            if (!SetNome(n))
                nome = "Nome inválido";
            if (!SetEmail(e))
                email = "E-mail inválido";
            if (!SetValorHora(v))
                valorHora = 0;
            dataNasc = d;
        }
        public Funcionario(Funcionario f)
        {
            id = f.id;
            nome = f.nome;
            email = f.email;
            valorHora = f.valorHora;
            dataNasc = f.dataNasc;
        }


        public int GetId()
        {
            return id;
        }
        public bool SetId(int x)
        {
            if (x >= 0)
            {
                id = x;
                return true;
            }
            return false;
        }
        public string GetNome()
        {
            return nome;
        }
        public bool SetNome(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                nome = n;
                return true;
            }
            return false;
        }
        public string GetEmail()
        {
            return email;
        }
        public bool SetEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                this.email = email;
                return true;
            }
            return false;
        }
        public double GetValorHora()
        {
            return valorHora;
        }
        public bool SetValorHora(double valor)
        {
            if (valor >= 0)
            {
                valorHora = valor;
                return true;
            }
            return false;
        }
        public Data GetDataNascimento()
        {
            return dataNasc;
        }
        public bool SetDataNascimento(int dia, int mes, int ano)
        {
            return (dataNasc.SetAno(ano) && dataNasc.SetMes(mes) && dataNasc.SetDia(dia));
        }
        public bool SetDataNascimento(Data d)
        {
            return (dataNasc.SetAno(d.GetAno()) && dataNasc.SetMes(d.GetMes()) && dataNasc.SetDia(d.GetDia()));
        }
        public int CalcularIdade()
        {
            int ano = int.Parse(DateTime.Now.Year.ToString());
            int mes = int.Parse(DateTime.Now.Month.ToString());
            int dia = int.Parse(DateTime.Now.Day.ToString());
            return this.dataNasc.DifEntre2Anos(new Data(dia, mes, ano));
        }
        public double CalcularSalario(double h)
        {
            if (h > 0)
                return h * valorHora;
            return -1;
        }
    }
}
