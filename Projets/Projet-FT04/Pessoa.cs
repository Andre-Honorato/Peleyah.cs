using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT04
{
    class Pessoa : Contacto2
    {
        private Data DataNasc { get; set; }

        public Pessoa() : base()
        {
            DataNasc = new Data();
        }

        public Pessoa(int id, int telef, string nome, string email, int dia, int mes, int ano) : base(id, telef, nome, email)
        {
            DataNasc = new Data(dia, mes, ano);
        }

        public Pessoa(Pessoa p) : base(p._id, p._telefone, p._nome, p._email)
        {
            DataNasc = new Data(p.DataNasc);
        }

        public override string ToString()
        {
            return "ID: " + Id
                 + "\nNome: " + Nome
                 + "\nTelefone: " + Telefone
                 + "\nEmail: " + Email
                 + "\nData de nascimento: " + DataNasc.ToString();
            ;
        }

        public int calcularidade()
        {
            int idade = DateTime.Now.Year - DataNasc.Ano;

            if ((DataNasc.Mes > DateTime.Now.Month) || (DataNasc.Mes == DateTime.Now.Month && DataNasc.Dia > DateTime.Now.Day))
                idade--;

            return idade;
        }
    }
}