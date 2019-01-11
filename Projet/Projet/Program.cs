using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{


    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;

            string[] vec = new string[n];

            for (int i = 0; i < n; i++)
            {
                vec[i] =String.Empty;

            }

            int opc;
            do
            {
                Console.WriteLine("<-------------------------FT01------------------------->");
                Console.WriteLine("|-------------------------EXE1-------------------------|");
                Console.WriteLine("| [1] - Mensagem Boas Vindas - [A. B. C.]              |");
                Console.WriteLine("| [2] - Nome completo = Primeiro e Último Nome - [D.]  |");
                Console.WriteLine("| [3] - Ler N do Vec das Strings - []                  |");
                Console.WriteLine("| [4] -  Ler Vec das Strings - []                      |");
                Console.WriteLine("| [5] - Maior string - [E.]                            |");
                Console.WriteLine("| [6] - Strings mesmo tamanho? - [F.]                  |");
                Console.WriteLine("| [7] - Soma Lenghts                                   |");
                Console.WriteLine("| [0] Sair do Programa                                 |");
                Console.WriteLine("<------------------------------------------------------>");
                Console.Write("Digite uma opção: ");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        welcomeMsg();
                        break;
                    case 2:
                        firstLastName();
                        break;
                    case 3:
                        n=lerN();
                        break;
                    case 4:
                        vec=lerVec(n);
                        break;
                    case 5:
                        longerString(n, vec);
                        break;
                    case 6:
                        if (!sameSizeStrings(n, vec))
                        {
                            Console.WriteLine("As strings introduzidas não são iguais.");
                        }
                        else
                        {
                            Console.WriteLine("As strings introduzidas são iguais.");
                        }

                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 7:
                        if (somaLenghts(n,vec) > 0)
                        {
                            Console.Write("Soma das Lenghts: " + somaLenghts(n,vec) + ".");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opc != 0);
        }

        public static int lerN()
        {
            Console.WriteLine("Quantas o valor de N? ");
            int n = Convert.ToInt32(Console.ReadLine());

            return n;
        }

        public static string [] lerVec(int n)
        {
            string[] vec = new string[n];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("String[ " + i + 1 + "]: ");
                vec[i] = Console.ReadLine();

            }

            return vec;

        }

        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Saiu do programa. Clique qualquer tecla para fechar...");
        }

        private static void welcomeMsg()
        {
            Console.WriteLine("Digite o seu primeiro nome: ");
            string firstName = Console.ReadLine();
            // https://docs.microsoft.com/en-us/dotnet/csharp/how-to/search-strings
            bool endsWithSearchResult = firstName.EndsWith("eu", System.StringComparison.CurrentCultureIgnoreCase);
 
            if (firstName == "Bartolomeu" || endsWithSearchResult)
                Console.WriteLine("Olá " + firstName + "! " + "Dá cá o meu!");
            else   
                Console.WriteLine("Olá " + firstName + "!");

            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");

        }

        private static void firstLastName()
        {
            Console.WriteLine("Digite o seu nome completo: ");
            string fullName = Console.ReadLine();


            string firstName = fullName.Split(' ').First();
            string lastName = fullName.Split(' ').Last();
  

            Console.WriteLine("Olá " + firstName + " " + lastName + ".");

            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");

        }

        private static void longerString(int n, string[] vec)
        {
            
            string biggestString = "";

            for (int i = 0; i < n; i++)
            {


                int biggestDim = vec[0].Length;
                

                if (vec[i].Length > biggestDim)
                    biggestString = vec[i];

 
            }

            Console.WriteLine("A string que tem o comprimento superior é " + biggestString + ".");
            




        }

        private static bool sameSizeStrings(int n, string []vec)
        {

            int contStrings = 0;

            int lenghtVec0 = vec[0].Length;

            for (int i = 0; i < n; i++)
            {

                if(lenghtVec0 == vec[i].Length)
                    contStrings++;

            }

            if (contStrings == n)
                return true;
            return false;

        }

        private static int somaLenghts(int n, string[] vec)
        {

            int somaLenghts = vec[0].Length;

            for (int i = 1; i < n; i++)
            {

                somaLenghts += vec[i].Length;

            }

                return somaLenghts;

        }

    }
}
