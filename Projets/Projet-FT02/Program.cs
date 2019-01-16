using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_FT02
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rdExe1 = new StreamReader(@"VENCIMENTOS.txt");
            StreamWriter wrExe1 = new StreamWriter(@"SUPMIL.txt", true);

            while (!rdExe1.EndOfStream)
            {
                string linha = rdExe1.ReadLine();
                string[] palavras = linha.Split(' ');

                if (int.Parse(palavras[2]) > 1000)
                {
                    wrExe1.WriteLine(linha);
                }
            }
            wrExe1.Close();
            rdExe1.Close();
            System.Threading.Thread.Sleep(3000);

            StreamReader rdExe2 = new StreamReader(@"NOTAS.txt");
            StreamWriter wrExe2 = new StreamWriter(@"APROVADOS.txt", true);
            StreamWriter wr2Exe2 = new StreamWriter(@"REPROVADOS.txt", true);

            while (!rdExe2.EndOfStream)
            {
                string linha = rdExe2.ReadLine();
                string[] palavras = linha.Split(' ');

                if (int.Parse(palavras[2]) > 9.5)
                {
                    wrExe2.WriteLine(linha);
                }
                else
                {
                    wr2Exe2.WriteLine(linha);
                }
            }
            wrExe2.Close();
            wr2Exe2.Close();
            rdExe2.Close();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
