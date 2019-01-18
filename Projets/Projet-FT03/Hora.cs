using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT03
{
    class Hora
    {
        private int hora;
        private int minuto;
        private int segundo;

        public Hora()
        {
            hora = 00;
            minuto = 00;
            segundo = 00;
        }
        public Hora(int h, int m, int s)
        {
            SetHora(h);
            SetMinuto(m);
            SetSegundo(s);
        }

        public Hora(Hora h)
        {
            hora = h.hora;
            minuto = h.minuto;
            segundo = h.segundo;
        }


        public bool SetHora(int h)
        {
            if (h > 0 && h < 24)
            {
                hora = h;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SetMinuto(int m)
        {
            if(m>=0 && m < 60)
            {
                minuto = m;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SetSegundo(int s)
        {
            if (s >= 0 && s < 60)
            {
                segundo = s;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int getHora()
        {
            return hora;
        }
        public int getMinuto()
        {
            return minuto;
        }
        public int getSegundo()
        {
            return segundo;
        }
        public string toString()
        {

            return (hora.ToString() + " : " + minuto.ToString() + " : " + segundo.ToString());

        }
        public int difEntre2Horas(Hora h)
        {
       
            int segsHora1 = segundo + (minuto * 60) + (hora * 60 * 60); //calcular segundos hora 1
            int segsHora2 = h.segundo + (h.minuto * 60) + (h.hora * 60 * 60); //calcular segundos hora 2


            return (Math.Abs((segsHora1 - segsHora2) / (60 * 60))); //converter em horas

        }

    }
}
