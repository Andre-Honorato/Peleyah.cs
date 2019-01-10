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
            int opc;
            do
            {
                Console.WriteLine("[1] - Mensagem Boas Vindas");
                Console.WriteLine("[2] - Primeiro e Último Nome");
                Console.WriteLine("[3] ");
                Console.WriteLine("[4] ");
                Console.WriteLine("[5] ");
                Console.WriteLine("[0] Sair do Programa");
                Console.WriteLine("-------------------------------------");
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
                        topString();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opc != 0);
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

        private static void topString()
        {
            

            Console.WriteLine("Quantas strings deseja adicionar? ");
            int n = Console.ReadLine();


            Console.WriteLine("Prima qualquer tecla para voltar ao menu...");


        }


    }
}
