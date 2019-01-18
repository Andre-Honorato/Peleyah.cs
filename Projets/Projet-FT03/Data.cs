using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT03
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;
        private Hora hora;
        private string diaSemana;

        public Data()
        {
            dia = 01;
            mes = 01;
            ano = 2000;
        }
        public Data(int d, int m, int a, int dia, int hor, int min, int seg)
        {
            if (!SetAno(a))
                ano = 2000;
            if (!SetMes(m))
                mes = 1;
            if (!SetDia(d))
                dia = 1;
            if (!SetDiaSemana(dia))
                SetDiaSemana(1);
            this.hora = new Hora(hor, min, seg);
        }

        public Data(Data d)
        {
            dia=d.ano;
		    mes=d.mes;
		    ano=d.dia;
        }


		public bool SetAno(int a)//Propz to Mr. , for more info check @mikasonwar
        {
            if (a < 1900)
            {
                return false; //Ano invalido
            }
            if (mes == 2 && dia == 29 && a % 4 != 0)
            {
                return false; // Ano invalido devido a ser dia 29/2 num ano nao bissexto
            }
            ano = a;
            return true;
        }
        public bool SetMes(int m)
        {
            if(m<=0 || m>12) {
			return false; //Mes invalido
		}
		if(m<8 && m!=2) {
			if(m%2==0 && dia<=30) {
				mes=m;		
			}
			else {
				if(m%2==1 && dia<=31) {
					mes=m;
				}
				else {
					return false;//Mes invalido devido ao dia
				}
			}
		} else {
			if(m>=8 && m!=2) {
				if(m%2==1 && dia<=30) {
					mes=m;		
				}
				else {
					if(m%2==0 && dia<=31) {
						mes=m;
					}
					else {
						return false;//Mes invalido devido ao dia
					}
				}
			}
		}
		if(m==2) {
			if(ano%4==0 && dia<=29){
				mes=m;
			} else {
				if(ano%4==1 && dia<=28){
					mes=m;
				} else {
					return false;//Mes invalido devido ao dia e ano
				}
			}
		}
		return true;
        }
        public bool SetDia(int d)
        {
        if (d <= 0 || d > 31)
        {
            return false; //Dia invalido
        }
        if (mes < 8 && mes != 2)
        {
            if (mes % 2 == 0 && d <= 30)
            {
                dia = d;
            }
            else
            {
                if (mes % 2 == 1 && d <= 31)
                {
                    dia = d;
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
                if (mes % 2 == 1 && d <= 30)
                {
                    dia = d;
                }
                else
                {
                    if (mes % 2 == 0 && d <= 31)
                    {
                        dia = d;
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
            if (ano % 4 == 0 && d <= 29)
            {
                dia = d;
            }
            else
            {
                if (ano % 4 == 1 && d <= 28)
                {
                    dia = d;
                }
                else
                {
                    return false;//Dia invalido devido ao ano e mes
                }
            }
        }
        return true;
    }
        public bool SetDiaSemana(int dia)
        {
            switch (dia)
            {
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Segunda-feira";
                    break;
                case 3:
                    diaSemana = "Terça-feira";
                    break;
                case 4:
                    diaSemana = "Quarta-feira";
                    break;
                case 5:
                    diaSemana = "Quinta-feira";
                    break;
                case 6:
                    diaSemana = "Sexta-feira";
                    break;
                case 7:
                    diaSemana = "Sábado";
                    break;
                default:
                    return false;
            }
            return true;
        }
        public int getAno()
        {
            return ano;
        }
        public int getMes()
        {
            return mes;
        }
        public int getDia()
        {
            return dia;
        }
        public Hora getHora()
        {
            return hora;
        }
        public string getDiaSemana()
        {
            return diaSemana;
        }
        public string toString()
        {
            return ("Data:" + dia.ToString() + " / " + mes.ToString() + " / " + ano.ToString() + "\n\tHora: " + hora.toString());
            
        }
        public int difEntre2anos(Data d)
        {
            return d.ano - ano;
        }
    }
}
