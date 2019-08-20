using System;
using System.Collections.Generic;
using System.Globalization;

namespace SisCliente
{
   class Program
        {
            static void PrintMenu()
            {
                Console.WriteLine("__________________");
                Console.WriteLine("|1 - Listar Todos|");
                Console.WriteLine("|2 - Adicionar   |");
                Console.WriteLine("|3 - Consultar   |");
                Console.WriteLine("|4 - Excluir     |");
                Console.WriteLine("------------------");
            }

            static void Main(string[] args)
            {
            
            while (true)
                {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                PrintMenu();
                    int opc = LerOpcao();

                    if (opc == 1)
                    {
                        ListarTodos();
                    }
                    else if (opc == 2)
                    {
                        Adicionar();
                    }
                    else if (opc == 3)
                    {
                        Consultar();
                    }
                    else if (opc == 4)
                    {
                            Excluir();
                    }
                    else
                    {
                        OpcaoInvalida();
                    }
                }
            }

            static void OpcaoInvalida()
            {

            }


            static int LerOpcao()
            {
                int opc;
                while (!int.TryParse(Console.ReadLine(), out opc))
                {
                    Console.WriteLine("Entrada inválida");
                }
            return opc;
            }
            static void ListarTodos()
            {
                var cli = Repositorio.Listar();

            foreach (var item in cli)
                {
                    Console.WriteLine("Id - "+item.Id+" Nome - " + item.Nome + " Data de nascimento - " + item.DtNascimento);
                }
            }

            static void Adicionar()
            {
                Console.Write("Nome: ");
                var nome = Console.ReadLine();


            Console.Write("Data de Nascimento (dd/mm/aaaa): ");
                var nascimentoStr = Console.ReadLine();

                DateTime dtNascimento;
                var sucesso = DateTime.TryParseExact(
                    nascimentoStr,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out dtNascimento);

                if (!sucesso)
                {
                    Console.WriteLine("Data de nascimento inválida, tente novamente");
                    return;
                }

                Repositorio.Cadastrar(nome, dtNascimento);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Mensagem: Usuário cadastrado com sucesso!");
                Console.ResetColor();
            }

            static void Consultar()
            {
                Console.Write("Id: ");
                var _id = int.Parse(Console.ReadLine());
                var con = Repositorio.Consultar(_id);
                foreach (var item in con)
                {
                    Console.WriteLine(" Nome - " + item.Nome+ " Data de nascimento - " + item.DtNascimento);
                }
        }

            static void Excluir()
            {
                Console.Write("Id: ");
                var _id = int.Parse(Console.ReadLine());
                var sucesso = Repositorio.Excluir(_id);
            }
        }
    }
