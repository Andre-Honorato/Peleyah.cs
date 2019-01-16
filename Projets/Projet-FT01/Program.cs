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
                vec[i] = String.Empty;

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
                Console.WriteLine("| [5] -  Escrever Vec das Strings - []                 |");
                Console.WriteLine("| [6] - Maior string - [E.]                            |");
                Console.WriteLine("| [7] - Strings mesmo tamanho? - [F.]                  |");
                Console.WriteLine("| [8] - Soma Lenghts -  [G.]                           |");
                Console.WriteLine("| [9] - v -> b ão -> om -  [H.]                        |");
                Console.WriteLine("| [10] - Só números? - [I.]                            |");
                Console.WriteLine("| [11] - String Só números? - [J.]                     |");
                Console.WriteLine("| [12] - Topo ordem alfabética - [K.]                  |");
                Console.WriteLine("| [13] - 10 Nomes - [L.]                               |");
                Console.WriteLine("| [14] - Quiz - []                                     |");
                Console.WriteLine("| [15] - Palíndromo - []                               |");
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
                        n = lerN();
                        break;
                    case 4:
                        vec = lerVec(n);
                        break;
                    case 5:
                        escreverVec(n, vec);
                        break;
                    case 6:
                        longerString(n, vec);
                        break;
                    case 7:
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
                    case 8:
                        if (somaLenghts(n, vec) > 0)
                        {
                            Console.Write("Soma das Lenghts: " + somaLenghts(n, vec) + ".");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 9:
                        vbaom(n, vec);
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 10:
                        if (justNumbers())
                        {
                            Console.WriteLine("A string introduzida só contem números.");
                        }
                        else
                        {
                            Console.WriteLine("A string introduzida não contem apenas números.");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 11:
                        Console.WriteLine("Digite a string:");
                        string str = Console.ReadLine();
                        if (stringJustNumbers(str))
                        {
                            Console.WriteLine("A string introduzida só contem números.");
                        }
                        else
                        {
                            Console.WriteLine("A string introduzida não contem apenas números.");
                        }
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 12:
                        twoStrings();
                        Console.WriteLine("Prima qualquer tecla para voltar ao menu...");
                        break;
                    case 13:
                        tenNames();
                        break;
                    case 14:
                        quiz();
                        break;
                    case 15:
                        palindromo();
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

        public static string[] lerVec(int n)
        {
            string[] vec = new string[n];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("String[" + (i + 1) + "]: ");
                vec[i] = Console.ReadLine();

            }

            return vec;

        }

        public static void escreverVec(int n, string[] vec)
        {

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("String[" + (i + 1) + "]: ");
                Console.WriteLine(vec[i]);

            }

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

        private static bool sameSizeStrings(int n, string[] vec)
        {

            int contStrings = 0;

            int lenghtVec0 = vec[0].Length;

            for (int i = 0; i < n; i++)
            {

                if (lenghtVec0 == vec[i].Length)
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

        private static void vbaom(int n, string[] vec)
        {

            Console.WriteLine("Digite a string para ser convertida: ");
            string oldStr = Console.ReadLine();
            int posicaoV = oldStr.IndexOf("v");
            int posicaoAo = oldStr.IndexOf("ão");
            if (oldStr.IndexOf("v") != -1 && oldStr.IndexOf("ão") != -1)
            {
                string newStr = oldStr.Remove(posicaoV, 1);
                string newStr2 = newStr.Insert(posicaoV, "b");
                string newStr3 = newStr2.Remove(posicaoAo, 2);
                string newStr4 = newStr3.Insert(posicaoAo, "om");
                Console.WriteLine(newStr4);
            }
            else
                if (oldStr.IndexOf("v") != -1)
            {
                string newStr = oldStr.Remove(posicaoV, 1);
                string newStr2 = newStr.Insert(posicaoV, "b");
                Console.WriteLine(newStr2);
            }
            else
                if (oldStr.IndexOf("ão") != -1)
            {
                string newStr = oldStr.Remove(posicaoAo, 2);
                string newStr2 = newStr.Insert(posicaoAo, "om");
                Console.WriteLine(newStr2);
            }
            else
            {
                Console.WriteLine(oldStr);
            }




        }

        private static bool justNumbers()
        {
            {
                Console.WriteLine("Digite a string:");
                string str = Console.ReadLine();
                double Num;
                bool isNum = double.TryParse(str, out Num);
                if (isNum)
                    return true;
                else
                    return false;
            }

        }

        private static bool stringJustNumbers(string str)
        {
            {

                double Num;
                bool isNum = double.TryParse(str, out Num);
                if (isNum)
                    return true;
                else
                    return false;
            }

        }

        private static void twoStrings()
        {

                Console.WriteLine("Digite a primeira string:");
                string str1 = Console.ReadLine();
                Console.WriteLine("Digite a segunda string:");
                string str2 = Console.ReadLine();

                if(string.Compare(str1, str2) < 0)
                {
                    Console.WriteLine("A string " + str1 + " está no topo alfabeticamente");
                }
                if (string.Compare(str1, str2) > 0)
                {
                    Console.WriteLine("A string " + str2 + " está no topo alfabeticamente");
                }
                if (string.Compare(str1, str2) == 0)
                {
                    Console.WriteLine("As string estão empatadas");
                }
            

        }

        public static void tenNames()
        {
            string[] vec = new string[10];

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("String[" + (i + 1) + "]: ");
                vec[i] = Console.ReadLine();

            }

           var sortedWords =
           from w in vec
           orderby w
           select w;

            Console.WriteLine("String ordenada alfabeticamente:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }



        }

        public static void quiz()
        {

            int c = 0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("              QUIZ!             ");
            Console.WriteLine("--------------------------------");


            Console.WriteLine("\nAdivinha 1. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer1 = Console.ReadLine();


            if (answer1.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 2. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer2 = Console.ReadLine();


            if (answer2.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 3. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer3 = Console.ReadLine();


            if (answer3.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 4. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer4 = Console.ReadLine();


            if (answer4.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 5. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer5 = Console.ReadLine();


            if (answer5.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 6. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer6 = Console.ReadLine();


            if (answer6.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 7. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer7 = Console.ReadLine();


            if (answer7.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 8. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer8 = Console.ReadLine();


            if (answer8.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 9. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer9 = Console.ReadLine();


            if (answer9.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Próxima questão...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Próxima questão...");
            }

            Console.WriteLine("\nAdivinha 10. Qual a cor do cavalo branco do Napoleão ? ");
            Console.WriteLine("\nA. Opção....");
            Console.WriteLine("B. Opção....");
            Console.WriteLine("C. Opção....");
            Console.WriteLine("D. Opção....");

            Console.WriteLine("\n");
            Console.WriteLine("Digite A, B, ou C.");

            string answer10 = Console.ReadLine();


            if (answer10.ToUpper() == "A")
            {
                Console.WriteLine("------Correto!------");
                Console.WriteLine("\n Fim do Quiz...");
                c++;
            }
            else
            {
                Console.WriteLine("------Errado!------");
                Console.WriteLine("\n Fim do Quiz...");
            }

            Console.WriteLine("\n Acertou " + c + " em 10.");
            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");

        }

        public static void palindromo()
        {
            Console.WriteLine("Digite a string para verificar se é palíndromo:");
            string str = Console.ReadLine();
            Console.WriteLine(str.Reverse().ToArray());
            if (str.SequenceEqual(str.Reverse()))
                Console.WriteLine("Palindromo");
            else
                Console.WriteLine("Não é palindromo");
            




        }


    }
}
