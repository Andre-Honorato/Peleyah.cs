using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT05
{
    class Gerente : Funcionario
    {
        private string especialidade;
        private int extensao;

        public Gerente() : base()
        {
            especialidade = "Nenhuma";
            extensao = 0;
        }
        public Gerente(int id, string n, string e, double v, int d, int m, int a, string esp, int ext) : base(id, n, e, v, d, m, a)
        {
            if (!SetEspecialidade(esp))
                especialidade = "Especialidade inválida.";
            if (!SetExtensao(ext))
                extensao = 0;
        }
        public Gerente(Gerente g) : base(g.id, g.nome, g.email, g.valorHora, g.dataNasc)
        {
            especialidade = g.especialidade;
            extensao = g.extensao;
        }

        public string GetEspecialidade()
        {
            return especialidade;
        }
        public bool SetEspecialidade(string e)
        {
            if (!string.IsNullOrEmpty(e))
            {
                especialidade = e;
                return true;
            }
            return false;
        }
        public int GetExtensao()
        {
            return extensao;
        }
        public bool SetExtensao(int e)
        {
            if (e >= 0)
            {
                extensao = e;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "Gerente Nº" + id.ToString() + ":"
                 + "\nNome:" + nome
                 + "\nEmail:" + email
                 + "\nValor Hora:" + valorHora.ToString()
                 + "\nEspecialidade:" + especialidade
                 + "\nExtensao: " + extensao.ToString()
                 + "\nData Nascimento:" + dataNasc.ToString() + " Idade: " + CalcularIdade().ToString()
                 ;
        }
    }
}
