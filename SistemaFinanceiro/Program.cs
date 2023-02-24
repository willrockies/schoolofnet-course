using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using static System.Console;
using System.Data.SqlClient;
using ConsoleTables;

namespace SistemaFinanceiro
{
    internal class Program
    {
        private List<Conta> contas;
        private List<Categoria> categorias;

        private ContaDAL conta;
        private CategoriaDAL categoria;

        public Program() 
        {
            string strConn = Db.Conexao.GetStringConnection();
            this.conta = new ContaDAL(new SqlConnection(strConn));
            this.categoria = new CategoriaDAL(new SqlConnection(strConn));

        }
        static void Main(string[] args)
        {

            int opcao;

            Program program =  new Program();
            
            do
            {
                Title = "CONTROLE FINANCEIRO";
                Uteis.MontaMenu();
                opcao = int.Parse(ReadLine());

                if(!(opcao >= 1 && opcao <= 6))
                {
                    Clear();
                    BackgroundColor = ConsoleColor.Red;
                    ForegroundColor= ConsoleColor.White;
                    Uteis.MontaHeader("INFORME UMA OPÇÃO VÁLIDA!", 'X', 30);
                    ResetColor();
                }
                else
                {
                    Clear();
                    switch (opcao)
                    {

                        case 1:
                            Title = "LISTAGEM DE CONTAS - CONTROLE FINANCEIRO";
                            Uteis.MontaHeader("LISTAGEM DE CONTAS");
                            program.contas = program.conta.ListarTodos();
                            ConsoleTable table = new ConsoleTable("ID", "Descrição", "Tipo", "Valor");
                            foreach(var c in program.contas)
                            {
                                table.AddRow(c.id, c.Descricao, c.Tipo.Equals('R') ? "Receber" : "Pagar", String.Format("{0:c}", c.Valor));
                                WriteLine("Descrição: " + c.Descricao);

                            }

                            table.Write();
                            ReadLine();
                            Clear();
                            break;
                        case 2:
                            WriteLine("CADASTRAR");
                            break;
                        case 3:
                            WriteLine("Editar");
                            break;
                        case 4:
                            WriteLine("EXCLUIR");
                            break;
                        case 5:
                            WriteLine("RELATORIO");
                            break;
                        default:
                            break;
                    }
                }


            } while (opcao != 6);

        }
    }
}
