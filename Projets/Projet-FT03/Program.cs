using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------Data e Hora-----------------");
            Data dt1 = new Data(22,05,1998,6,12,50,40);
            Data dt2 = new Data(17, 01, 2019,5, 22, 51, 50);
            Console.WriteLine("Data 1:" + dt1.toString());
            Console.WriteLine("Data 2:" + dt2.toString());

            Console.WriteLine("\nDiferença entre 2 horas: " + dt1.getHora().difEntre2Horas(dt2.getHora()));
            Console.WriteLine("\n\tDiferença entre 2 anos: " + dt1.difEntre2anos(dt2));

            Console.WriteLine("-----------------Pontos----------------");

            Ponto pt1 = new Ponto(4, 5);
            Ponto pt2 = new Ponto(9, 10);


            Console.WriteLine("\nPT1:" + pt1.toString());
            Console.WriteLine("\n\tPT2:" + pt2.toString());
            Console.WriteLine("\n\t\tDistancia entre PT1 e PT2:"+pt1.distEntre2Pontos(pt2));

            Console.WriteLine("-----------------Retas----------------");
            Reta rt1 = new Reta(pt1, pt2);
            Reta rt2 = new Reta(rt1);
            Console.WriteLine("\nReta 1: " + rt1.toString());
            Console.WriteLine("\n\tReta 2: " + rt2.toString());

            Console.ReadKey();
        }
    }
}
