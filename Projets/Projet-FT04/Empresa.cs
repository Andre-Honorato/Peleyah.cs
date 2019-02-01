using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT04
{
    class Empresa : Contacto2
    {
        private string Responsavel { get; set; }
        private string Morada { get; set; }
        private int Atividade { get; set; }

        public Empresa() : base()
        {
            Responsavel = "";
            Morada = "";
            Atividade = 0;
        }

        public Empresa(int id, int telef, string nome, string email, string responsavel, string morada, int atividade) : base(id, telef, nome, email)
        {
            Responsavel = responsavel;
            Morada = morada;
            Atividade = atividade;
        }

        public Empresa(Empresa e) : base(e._id, e._telefone, e._nome, e._email)
        {
            Responsavel = e.Responsavel;
            Morada = e.Morada;
            Atividade = e.Atividade;
        }
    }
}
