using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT04
{
    class Conta
    {
        private string _titular;
        private int _numero;
        private int _estado;
        private double _saldo;

        public Conta()
        {
            _titular = "";
            _numero = 0;
            _saldo = 0;
            _estado = -1;
        }

        public Conta(string t, int n, double s, int e)
        {
            _titular = t;
            _numero = n;
            _saldo = s;
            _estado = e;
        }

        public Conta(Conta c)
        {
            _titular = c.Titular;
            _numero = c.Numero;
            _saldo = c._saldo;
            _estado = c.Estado;
        }


        public double Saldo{
            get { return _saldo; }
            set
            {
                if(_saldo > 0)
                _saldo = value;
            }
        }


        public string Titular
        {
            get { return _titular; }
            set
            {
                if (string.IsNullOrEmpty(_titular))
                    _titular = value;
            }
        }

        public int Numero
        {
            get { return _numero; }
            set
            {
                if (_numero > 0)
                    _numero = value;
            }
        }

        public int Estado
        {
            get { return _estado; }
            set
            {
                if (_estado == -1 || _estado ==1)
                    _estado = value;
            }
        }


        public override string ToString()
        {
            return "\nTitular: " + Titular
              + "\n\tNúmero: " + Numero
              + "\n\tSaldo: " + Saldo
              + "\n\tEstado: " + Estado;
        }

        public int Levantar(int valor)
        {
            
            if (valor > 0 && valor <= _saldo)
            {
               _saldo -= valor;
                return 0; 
            }
            return -1; 
        } 

        public int Depositar(int valor)
        {
           
            if (valor > 0)
            {
                _saldo += valor;
                return 0; 
            }
            return -1; 
        }

        public void AlterarEstado()
        {
            if (Estado == 1)
                Estado = -1;
            Estado = 1;
            
        }

        public double Credito()
        {
            if (_saldo >= 5000)
                return _saldo * 0.5;
            else if (_saldo >= 1000)
                return _saldo * 0.3;
            else if (_saldo >= 500)
                return _saldo * 0.1;
            else return 0;
        }
    }
}
