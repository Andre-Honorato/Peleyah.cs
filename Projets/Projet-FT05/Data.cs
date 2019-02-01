using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT05
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public Data()
        {
            dia = 1;
            mes = 1;
            ano = 2000;
        }
        public Data(int dia, int mes, int ano)
        {
            if (!SetAno(ano))
                ano = 2000;
            if (!SetMes(mes))
                mes = 1;
            if (!SetDia(dia))
                dia = 1;
        }

        public Data(Data d)
        {
            dia = d.dia;
            mes = d.mes;
            ano = d.ano;

        }

        public int GetDia()
        {
            return dia;
        }
        public bool SetDia(int x)
        {
            if (x <= 0 || x > 31)
            {
                return false; //Dia invalido
            }
            if (mes < 8 && mes != 2)
            {
                if (mes % 2 == 0 && x <= 30)
                {
                    dia = x;
                }
                else
                {
                    if (mes % 2 == 1 && x <= 31)
                    {
                        dia = x;
                    }
                    else
                    {
                        return false;//Dia invalido devido ao mes
                    }
                }
            }
            else
            {
                if (mes >= 8 && mes != 2)
                {
                    if (mes % 2 == 1 && x <= 30)
                    {
                        dia = x;
                    }
                    else
                    {
                        if (mes % 2 == 0 && x <= 31)
                        {
                            dia = x;
                        }
                        else
                        {
                            return false;//Dia invalido devido ao mes
                        }
                    }
                }
            }
            if (mes == 2)
            {
                if (ano % 4 == 0 && x <= 29)
                {
                    dia = x;
                }
                else
                {
                    if (ano % 4 == 1 && x <= 28)
                    {
                        dia = x;
                    }
                    else
                    {
                        return false;//Dia invalido devido ao ano e mes
                    }
                }
            }
            return true;
        }
        public int GetMes()
        {
            return mes;
        }
        public bool SetMes(int x)
        {
            if (x <= 0 || x > 12)
            {
                return false; //Mes invalido
            }
            if (x < 8 && x != 2)
            {
                if (x % 2 == 0 && dia <= 30)
                {
                    mes = x;
                }
                else
                {
                    if (x % 2 == 1 && dia <= 31)
                    {
                        mes = x;
                    }
                    else
                    {
                        return false;//Mes invalido devido ao dia
                    }
                }
            }
            else
            {
                if (x >= 8 && x != 2)
                {
                    if (x % 2 == 1 && dia <= 30)
                    {
                        mes = x;
                    }
                    else
                    {
                        if (x % 2 == 0 && dia <= 31)
                        {
                            mes = x;
                        }
                        else
                        {
                            return false;//Mes invalido devido ao dia
                        }
                    }
                }
            }
            if (x == 2)
            {
                if (ano % 4 == 0 && dia <= 29)
                {
                    mes = x;
                }
                else
                {
                    if (ano % 4 == 1 && dia <= 28)
                    {
                        mes = x;
                    }
                    else
                    {
                        return false;//Mes invalido devido ao dia e ano
                    }
                }
            }
            return true;
        }
        public int GetAno()
        {
            return ano;
        }
        public bool SetAno(int x)
        {
            if (x <= 0)
            {
                return false; //Ano invalido
            }
            if (mes == 2 && dia == 29 && x % 4 != 0)
            {
                return false; // Ano invalido devido a ser dia 29/2 num ano nao bissexto
            }
            ano = x;
            return true;
        }
        
        public override string ToString()
        {
            return (dia.ToString() + "/" + mes.ToString() + "/" + ano.ToString());
        }
        public int DifEntre2Anos(Data d)
        {
            int maior = -1;
            if (d.mes > mes)
                maior = 0;
            if (d.mes == mes && d.dia >= dia)
                maior = 0;
            return (d.ano - ano) + maior;
        }
    }
}
