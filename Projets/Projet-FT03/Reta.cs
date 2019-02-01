using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT03
{
    class Reta
    {
        private Ponto p1;
        private Ponto p2;

        public Reta()
        {
            p1 = new Ponto();
            p2 = new Ponto();
        }
        public Reta(int x1, int y1, int x2, int y2)
        {
            p1 = new Ponto(x1, y1);
            p2 = new Ponto(x2, y2);
        }
        public Reta(Ponto p1, Ponto p2)
        {
            this.p1 = new Ponto(p1);
            this.p2 = new Ponto(p2);
        }
        public Reta(Reta r)
        {
            p1 = r.p1;
            p2 = r.p2;
        }
        public Ponto getPonto(int x)
        {
            switch (x)
            {
                case 1:
                    return p1;
                case 2:
                    return p2;
                default:
                    return new Ponto();
            }
        }
        public override string ToString()
        {
            return "Ponto 1: " + p1.ToString() + " Ponto 2: " + p2.ToString();
        }
    }
}
