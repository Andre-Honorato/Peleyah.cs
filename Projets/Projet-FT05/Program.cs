using System;
using System.IO;
using System.Collections.Generic;

namespace Projet_FT05
{
    class Program
    {
        public static object Ler(Type e)
        {
            if (e == typeof(string))
            {
                return Console.ReadLine();
            }
            else if (e == typeof(int))
            {
                int vint = 0;
                while (!int.TryParse(Console.ReadLine(), out vint))
                    Console.WriteLine("Erro, deve introduzir um valor inteiro.");
                return vint;
            }
            else if (e == typeof(double))
            {
                double vdouble = 0;
                while (!double.TryParse(Console.ReadLine(), out vdouble))
                    Console.WriteLine("Erro, deve introduzir um valor double.");
                return vdouble;
            }
            return "Erro.";
        }

        public static List<Gerente> CarregarGerentes(List<Gerente> gerentes)
        {

            StreamReader rdgerentes = new StreamReader(@"Gerentes.txt");
            while (!rdgerentes.EndOfStream)
            {
                string linha = rdgerentes.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';');
                if (atributos.Length == 9)
                {
                    gerentes.Add(new Gerente(
                                             int.Parse(atributos[0]),
                                             atributos[1],
                                             atributos[2],
                                             double.Parse(atributos[3]),
                                             int.Parse(atributos[4]),
                                             int.Parse(atributos[5]),
                                             int.Parse(atributos[6]),
                                             atributos[7],
                                             int.Parse(atributos[8])
                                            ));
                }
            }
            rdgerentes.Close();
            return gerentes;
        }

        public static List<Operario> CarregarOperarios(List<Operario> operarios)
        {

            StreamReader rdoperarios = new StreamReader(@"Operarios.txt");
            while (!rdoperarios.EndOfStream)
            {
                string linha = rdoperarios.ReadLine();
                linha = linha.Replace('/', ';');
                string[] atributos = linha.Split(';');
                if (atributos.Length == 8)
                {
                    operarios.Add(new Operario(
                                             int.Parse(atributos[0]),
                                             atributos[1],
                                             atributos[2],
                                             double.Parse(atributos[3]),
                                             int.Parse(atributos[4]),
                                             int.Parse(atributos[5]),
                                             int.Parse(atributos[6]),
                                             atributos[7]
                                            ));
                }
            }
            rdoperarios.Close();

            return operarios;
        }

        public static void GuardarGerentes(List<Gerente> gerentes)
        {

            StreamWriter wdgerentes = new StreamWriter(@"Gerentes.txt");

            foreach (Gerente obj in gerentes)
            {

                string linha = obj.GetId().ToString() + ";"
                                + obj.GetNome() + ";"
                                + obj.GetEmail() + ";"
                                + obj.GetValorHora().ToString() + ";"
                                + obj.GetDataNascimento().ToString() + ";"
                                + obj.GetEspecialidade() + ";"
                                + obj.GetExtensao().ToString()
                                ;
                wdgerentes.WriteLine(linha);

            }
            wdgerentes.Close();

        }

        public static void GuardarOperarios(List<Operario> operarios)
        {
            StreamWriter wdoperarios = new StreamWriter(@"Operarios.txt");
            foreach (Operario obj in operarios)
            {
                string linha = obj.GetId().ToString() + ";"
                             + obj.GetNome() + ";"
                             + obj.GetEmail() + ";"
                             + obj.GetValorHora().ToString() + ";"
                             + obj.GetDataNascimento().ToString() + ";"
                             + obj.GetDepartamento()
                             ;
                wdoperarios.WriteLine(linha);
            }
            wdoperarios.Close();
        }

        public static void OpcInvalida()
        {
            Console.WriteLine("Opção inválida.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            //ArrayList gerentes = new ArrayList();
            List<Gerente> gerentes = new List<Gerente>();

            //ArrayList operarios = new ArrayList();
            List<Operario> operarios = new List<Operario>();

            gerentes = CarregarGerentes(gerentes);
            operarios = CarregarOperarios(operarios);

            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("<---------------------------FT04------------------------->");
                Console.WriteLine("|---------------------------EXE1-------------------------|");
                Console.WriteLine("| [1] -               Inserir Gerente              - [1] |");
                Console.WriteLine("| [2] -               Inserir Operário             - [2] |");
                Console.WriteLine("| [3] -              Visualizar Gerentes           - [3] |");
                Console.WriteLine("| [4] -             Visualizar Operários           - [4] |");
                Console.WriteLine("| [5] -            Visualizar Funcionários         - [5] |");
                Console.WriteLine("| [6] -             Sair do Programa               - [6] |");
                Console.WriteLine("<-------------------------------------------------------->");
                Console.Write("Digite a opção pretendida: ");
                opc = ((int)Ler((typeof(int))));

                switch (opc)
                {
                    case 1:
                        InserirGerente(gerentes);
                        break;
                    case 2:
                        InserirOperario(operarios);
                        break;
                    case 3:
                        gerentes = MenuGerentes(gerentes);
                        break;
                    case 4:
                        operarios = MenuOperarios(operarios);
                        break;
                    case 5:
                        VisualizarFuncionarios(gerentes, operarios);
                        break;
                    case 6:
                        Fechar();
                        break;
                    default:
                        OpcInvalida();
                        break;
                }
            } while (opc != 6);
            GuardarGerentes(gerentes);
            GuardarOperarios(operarios);
        }

        public static void Fechar()
        {
            Console.Clear();
            Console.WriteLine("Até à próxima! ;)");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);
        }


        public static void VisualizarFuncionarios(List<Gerente> gerentes, List<Operario> operarios)
        {

            Console.WriteLine("\nGerentes:\n");
            foreach (Gerente obj in gerentes)
            {
                Console.WriteLine("\n" + obj.ToString());
            }
            Console.WriteLine("\nOperarios:\n");
            foreach (Operario obj in operarios)
            {
                Console.WriteLine("\n" + obj.toString());
            }
            Console.WriteLine("\n\nClique numa tecla para voltar ao menu...");
            Console.ReadKey();
        }

        public static void InserirGerente(List<Gerente> gerentes)
        {
            int ano, dia, mes;
            Gerente ger;
            ger = new Gerente();
            Console.WriteLine("Digite o ID:");
            ger.SetId((int)Ler((typeof(int))));
            Console.WriteLine("Digite o Nome:");
            ger.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o E-mail:");
            ger.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o Valor Hora:");
            ger.SetValorHora((double)Ler((typeof(double))));
            Console.WriteLine("Digite a especialidade:");
            ger.SetEspecialidade(Console.ReadLine());
            Console.WriteLine("Digite a extensao:");
            ger.SetExtensao((int)Ler((typeof(int))));
            Console.WriteLine("Digite a data (DD/MM/AAAA):");
            Console.WriteLine("Insira o dia: ");
            dia = ((int)Ler((typeof(int))));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Insira o mês: ");
            Console.Write(dia + "/");
            mes = ((int)Ler((typeof(int))));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Insira o ano: ");
            Console.Write(dia + "/" + mes + "/");
            ano = ((int)Ler((typeof(int))));
            ger.SetDataNascimento(dia, mes, ano);
            gerentes.Add(ger);
            GuardarGerentes(gerentes);
            
        }

        public static void InserirOperario(List<Operario> operarios)
        {

            int ano, dia, mes;
            Operario op;
            op = new Operario();
            Console.WriteLine("Digite o ID:");
            op.SetId((int)Ler((typeof(int))));
            Console.WriteLine("Digite o Nome:");
            op.SetNome(Console.ReadLine());
            Console.WriteLine("Digite o E-mail:");
            op.SetEmail(Console.ReadLine());
            Console.WriteLine("Digite o Valor Hora:");
            op.SetValorHora((double)Ler((typeof(double))));
            Console.WriteLine("Digite o Departamento:");
            op.setDepartamento(Console.ReadLine());
            Console.WriteLine("Digite a data (DD/MM/AAAA):");
            Console.WriteLine("Insira o dia: ");
            dia = ((int)Ler((typeof(int))));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Insira o mês: ");
            Console.Write(dia + "/");
            mes = ((int)Ler((typeof(int))));
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
            Console.WriteLine("Insira o ano: ");
            Console.Write(dia + "/" + mes + "/");
            ano = ((int)Ler((typeof(int))));
            op.SetDataNascimento(dia, mes, ano);
            operarios.Add(op);
            GuardarOperarios(operarios);

            
        }

        public static List<Operario> MenuOperarios(List<Operario> operarios)
        {
            int i;
            int opc = 0;
            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Editar Operario:");
                foreach (Operario obj in operarios)
                {
                    Console.WriteLine((i + 1) + " - " + obj.GetNome());
                    i++;
                }
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = ((int)Ler((typeof(int))));
                if (opc <= i && opc > 0)
                    operarios[opc - 1] = MenuEditarOperario((Operario)operarios[opc - 1]);
            } while (opc != 0);
            return operarios;
        }
        public static Operario MenuEditarOperario(Operario operario)
        {
            int opc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Editar dados do operário: " + operario.GetNome());
                Console.WriteLine("1 - ID: " + operario.GetId().ToString());
                Console.WriteLine("2 - Nome: " + operario.GetNome());
                Console.WriteLine("3 - Email: " + operario.GetEmail());
                Console.WriteLine("4 - Valor Hora: " + operario.GetValorHora().ToString());
                Console.WriteLine("5 - Departamento: " + operario.GetDepartamento());
                Console.WriteLine("6 - Data de Nascimento: " + operario.GetDataNascimento().ToString());
                Console.WriteLine("7 - Calcular Idade");
                Console.WriteLine("8 - Calcular Salário");
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Digite o ID:");
                        operario.SetId((int)Ler((typeof(int))));
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome:");
                        operario.SetNome(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite o E-mail:");
                        operario.SetEmail(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o Valor por hora:");
                        operario.SetValorHora((double)Ler((typeof(double))));
                break;
                    case 5:
                        Console.WriteLine("Digite o Departamento:");
                        operario.setDepartamento(Console.ReadLine());
                        break;
                    case 6:
                        int ano, dia, mes;
                        Console.WriteLine("Digite a data(DD/MM/AAAA):");
                        Console.WriteLine("Insira o dia: ");
                        dia = ((int)Ler((typeof(int))));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Insira o mês: ");
                        Console.Write(dia + "/");
                        mes = ((int)Ler((typeof(int))));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Insira o ano: ");
                        Console.Write(dia + "/" + mes + "/");
                        ano = ((int)Ler((typeof(int))));
                        operario.SetDataNascimento(dia, mes, ano);
                        break;
                    case 7:
                        Console.WriteLine("Idade do " + operario.GetNome() + ": " + operario.CalcularIdade().ToString());
                        Console.WriteLine("\n\nClique numa tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("Indique o número de horas que trabalhou: ");
                        double r;
                        r = operario.CalcularSalario((double)Ler((typeof(double))));
                        Console.WriteLine("Salário bruto sem subsídios: " + r.ToString() + "euros");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            return operario;
        }
        public static List<Gerente> MenuGerentes(List<Gerente> gerentes)
        {
            int i;
            int opc = 999;

            do
            {
                i = 0;
                Console.Clear();
                Console.WriteLine("Editar Gerente:");
                foreach (Gerente obj in gerentes)
                {
                    Console.WriteLine((i + 1) + " - " + obj.GetNome());
                    i++;
                }
                Console.WriteLine("\n0 - Voltar ao menu anterior");
                opc = ((int)Ler((typeof(int))));
                if (opc <= i && opc > 0)
                    gerentes[opc - 1] = MenuEditarGerente((Gerente)gerentes[opc - 1]);
            } while (opc != 0);

            return gerentes;
        }
        public static Gerente MenuEditarGerente(Gerente gerente)
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - ID: " + gerente.GetId().ToString());
                Console.WriteLine("2 - Nome: " + gerente.GetNome());
                Console.WriteLine("3 - Email: " + gerente.GetEmail());
                Console.WriteLine("4 - Valor Hora: " + gerente.GetValorHora().ToString());
                Console.WriteLine("5 - Especialidade: " + gerente.GetEspecialidade());
                Console.WriteLine("6 - Extensão: " + gerente.GetExtensao().ToString());
                Console.WriteLine("7 - Data de Nascimento: " + gerente.GetDataNascimento().ToString());
                Console.WriteLine("8 - Calcular Idade");
                Console.WriteLine("9 - Calcular Salário");
                Console.WriteLine("\n0 - Sair");
                opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite o ID:");
                        gerente.SetId((int)Ler((typeof(int))));
                        break;
                    case 2:
                        Console.WriteLine("Digite o Nome:");
                        gerente.SetNome(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Digite o E-mail:");
                        gerente.SetEmail(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite o Valor por hora:");
                        gerente.SetValorHora((double)Ler((typeof(double))));
                        break;
                    case 5:
                        Console.WriteLine("Digite a Especialidade:");
                        gerente.SetEspecialidade(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Digite a Extensão:");
                        gerente.SetExtensao(Int32.Parse(Console.ReadLine()));
                        break;
                    case 7:
                        int ano, dia, mes;
                        Console.WriteLine("Digite a data(DD/MM/AAAA):");
                        Console.WriteLine("Insira o dia: ");
                        dia = ((int)Ler((typeof(int))));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Insira o mês: ");
                        Console.Write(dia + "/");
                        mes = ((int)Ler((typeof(int))));
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        ClearCurrentConsoleLine();
                        Console.WriteLine("Insira o ano: ");
                        Console.Write(dia + "/" + mes + "/");
                        ano = ((int)Ler((typeof(int))));
                        gerente.SetDataNascimento(dia, mes, ano);
                        break;
                    case 8:
                        Console.WriteLine("Idade do " + gerente.GetNome() + ": " + gerente.CalcularIdade().ToString());
                        Console.WriteLine("\n\nClique numa tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("Indique o número de horas que trabalhou: ");
                        double r;
                        r = gerente.CalcularSalario((double)Ler((typeof(double))));
                        Console.WriteLine("Salário bruto sem subsídios: " + r.ToString() + "euros");
                        Console.ReadKey();
                        break;
                }
            } while (opc != 0);
            return gerente;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
