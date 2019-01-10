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
                Console.WriteLine("[1] - O");
                Console.WriteLine("[2] ");
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
                        mensagemBoasVindas();
                        break;
                    default:
                        saiPrograma();
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

        private static void mensagemBoasVindas()
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            // https://docs.microsoft.com/en-us/dotnet/csharp/how-to/search-strings
            bool endsWithSearchResult = nome.EndsWith("eu", System.StringComparison.CurrentCultureIgnoreCase);
 
            if (nome == "Bartolomeu" || endsWithSearchResult)
                Console.WriteLine("Olá " + nome + "! " + "Dá cá o meu!");
            else   
                Console.WriteLine("Olá " + nome + "!");
        }
    }
}
