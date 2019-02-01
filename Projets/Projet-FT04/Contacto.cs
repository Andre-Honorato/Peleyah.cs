using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT04
{
    class Contacto
    {

        private int Id { get; set; }
        private int Telef { get; set; }
        public string Nome { get; set; }
        private string Email { get; set; }
        private Data DataNasc { get; set; }

        public Contacto()
        {
            Id = 0;
            Nome = "";
            Telef = 0;
            Email = "";
        }

        public Contacto(int id, int tel, string nome, string email, int dia, int mes, int ano)
        {
            Id = id;
            Telef = tel;
            Nome = nome;
            Email = email;
            DataNasc = new Data(dia,mes,ano);
        }

        public Contacto(Contacto c)
        {
            Id = c.Id;
            Telef = c.Telef;
            Nome = c.Nome;
            Email = c.Email;
            DataNasc = new Data(c.DataNasc);
        }

        //public int Id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        //public int Telef
        //{
        //    get { return _telef; }
        //    set { _telef = value; }
        //}

        //public string Nome
        //{
        //    get { return _nome; }
        //    set { _nome = value; }
        //}

        //public string Email
        //{
        //    get { return _email; }
        //    set { _email = value; }
        //}

        //public Data DataN
        //{
        //    get { return _dataNasc; } 
        //    set { _dataNasc = value; }
        //}

        public override string ToString()
        {
            return "\nNome: " + Nome
              + "\n\tID: " + Id
              + "\n\tEmail: " + Email
              + "\n\tTelefone: " + Telef
              + "\n\tData de nascimento: " + DataNasc.ToString();
        }

        public int Calcularidade()
        {
            int idade = DateTime.Now.Year - DataNasc.Ano; 

            if ((DataNasc.Mes > DateTime.Now.Month) || (DataNasc.Mes == DateTime.Now.Month && DataNasc.Dia > DateTime.Now.Day)) 
                idade--;

            return idade;
        }

    }

}
