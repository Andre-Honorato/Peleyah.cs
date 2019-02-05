using System;

namespace Projet_FT03
{
    class Ponto
    {
        private int x;
        private int y;

        public Ponto()
        {
            x = 0;
            y = 0;
        }
        public Ponto(int x, int y)
        {
            if (!setX(x))
                x = 0;
            if (!setY(y))
                y = 0;

        }
        public Ponto(Ponto p)
        {
            x = p.x;
            y = p.y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public bool setX(int x)
        {
            this.x = x;
            return true;
        }
        public bool setY(int y)
        {
            this.y = y;
            return true;
        }
        public override string ToString()
        {
            return "(" + x.ToString() + " , " + y.ToString() + ")";
        }
        public double distEntre2Pontos(Ponto p)
        {
            return (double)Math.Sqrt(((p.x - x) * (p.x - x)) + ((p.y - y) * (p.y - y)));
        }

    }
}
