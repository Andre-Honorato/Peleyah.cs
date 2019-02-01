using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT04
{
    class Contacto2
    {

        protected int _id;
        protected int _telefone;
        protected string _nome;
        protected string _email;

        public Contacto2()
        {
            _id = 0;
            _telefone = 0;
            _nome = "";
            _email = "";
        }

        public Contacto2(int id, int telef, string nome, string email)
        {
            _id = id;
            _telefone = telef;
            _nome = nome;
            _email = email;
        }

        public Contacto2(Contacto2 c)
        {
            _id = c._id;
            _telefone = c._telefone;
            _nome = c._nome;
            _email = c._email;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //To String
        public override string ToString()
        {
            return "ID: " + Id
                 + "\nNome: " + Nome
                 + "\nTelefone: " + Telefone
                 + "\nEmail: " + Email
                 ;
        }
    }
}
  
