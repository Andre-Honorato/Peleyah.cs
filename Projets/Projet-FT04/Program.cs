using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-------------------Empresa e Pessoa---------------------");
            Pessoa p1 = new Pessoa(2, 911111111, "Miguel", "miguel@mail.com", 22, 01, 2001);
            Console.Write(p1.ToString());
            Console.WriteLine("\n\nIdade do " + p1.Nome + ":" + p1.calcularidade() + " anos");
            Console.WriteLine("\n----------------------------------------------------------");
            //Console.WriteLine("\n----------------------------------------------------------");
            //Console.WriteLine("\n---------------------Contactos----------------------------");
            //Contacto c1 = new Contacto(1, 933333333, "Samuel", "smauel@mail.com", 05, 07, 2007);
            //Console.Write(c1.ToString());

            //Console.WriteLine("\n\nCalcular idades: ");
            //Console.WriteLine("\n\nIdade do " + c1.Nome + ":"  + c1.calcularidade() + " anos");

            //Console.WriteLine("\n----------------------------------------------------------");
            //Console.WriteLine("\n--------------------------Datas---------------------------");
            //Data dt1 = new Data(25, 11, 2004);
            //Data dt2 = new Data(01, 1, 2005);
            //Console.WriteLine("\nDiferença entre 2 anos: " + dt1.difEntre2anos(dt2));
            //Console.WriteLine("\n----------------------------------------------------------");
            //Console.WriteLine("\n--------------------------Conta---------------------------");
            //Conta ct1 = new Conta("Joao", 1, 3500, 1);
            //ct1.depositar(500);
            //ct1.levantar(250);
            //Console.WriteLine(ct1.ToString());
            //ct1.AlterarEstado();
            //ct1.Credito();
            //Console.WriteLine("\n----------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
