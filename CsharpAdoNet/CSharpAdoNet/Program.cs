using System;
using System.Data.SqlClient;
using static System.Console;

namespace CSharpAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SalvarCliente("Wilson Alves", "wilson@email.com", 7);
            //DeletarCliente(7);
            //ListarClientes();

            WriteLine("======================== CONTROLE DE CLIENTES===================\n");
            WriteLine("Selecione uma opção: ");
            WriteLine("1 - Listar");
            WriteLine("2 - Cadastrar");
            WriteLine("3 - Editar");
            WriteLine("4 - Excluir");
            WriteLine("5 - Visualizar");
            Write("Opção: ");

            int opc = Convert.ToInt32(ReadLine());
            Clear();
            switch (opc)
            {
                case 1:
                    Title = "Listagem de clientes";
                    WriteLine("================ Listagem de clientes =====================");
                    ListarClientes();
                    break;
                case 2:
                    Title = "Novos Clientes";
                    WriteLine("================ Cadastro de clientes =====================");
                    Write("Informe um nome: ");
                    string nome = ReadLine();

                    Write("Informe um email: ");
                    string email = ReadLine();

                    SalvarCliente(nome, email);
                    break;
                case 3:
                    Title = "Alteração de Clientes";
                    WriteLine("================ Alteração de clientes =====================");

                    ListarClientes();
                    Write("Selecione um cliente pela ID: ");
                    int idOp = int.Parse(ReadLine());
                    //int idOp = Convert.ToInt32(ReadLine());
                    (int _id, string _nome, string _email) = SelecionarCliente(idOp);
                    Clear();

                    Title = "Alteração de Clientes" + _nome;
                    WriteLine($"================ Alteração de clientes - {_nome} =====================");
                    Write("Informe um nome: ");
                    nome = ReadLine();

                    Write("Informe um email: ");
                    email = ReadLine();

                    nome = nome.Equals("") ? _nome : nome;
                    email = email.Equals("") ? _email : email;

                    SalvarCliente(nome, email, idOp);

                    break;
                case 4:
                    Title = "Exclusão de Clientes";
                    WriteLine("================ Exclusão de clientes =====================");

                    ListarClientes();
                    Write("Selecione um cliente pela ID: ");
                    idOp = Convert.ToInt32(ReadLine());
                    (_id, _nome, _email) = SelecionarCliente(idOp);

                    Title = "Exclusão de Clientes" + _nome;
                    WriteLine($"================ Exclusão de clientes - {_nome} =====================");
                    WriteLine("\n\n*********** ATENÇÂO ***********\n");
                    Write("Deseja continuar ? (S para sim, N para não): ");
                    string confirmar = ReadLine().ToUpper();

                    if (confirmar.Equals("S"))
                    {
                        DeletarCliente(idOp);
                    }

                    break;
                case 5:
                    Title = "Visualização de Clientes";
                    WriteLine("================ Ver detalhes de clientes =====================");

                    ListarClientes();

                    Write("Selecione um cliente pelo ID: ");
                    idOp = Convert.ToInt32(ReadLine());
                    (_id, _nome, _email) = SelecionarCliente(idOp);
                    Clear();

                    Title = "Visualização de Clientes" + _nome;
                    WriteLine($"================ Ver detalhes de clientes - {_nome} =====================");

                    WriteLine("ID: {0}", _id);
                    WriteLine("ID: {0}", _nome);
                    WriteLine("ID: {0}", _email);


                    break;
                default:
                    Title = "Opção Inválida";
                    WriteLine("================ Selecione uma opção valida! =====================");
                    break;
            }


            ReadLine();
        }

        static void ListarClientes()
        {
            string connString = getStringConn();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from clientes order by id";


                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        WriteLine("ID: {0}", dr["id"]);
                        WriteLine("Nome: {0}", dr["nome"]);
                       // WriteLine("Email: {0 }", dr["email"]);
                        WriteLine("---------------------------");
                    }

                }
            }
        }
        static void SalvarCliente(string nome, string email)
        {
            string connString = getStringConn();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into clientes(nome, email) values(@nome, @email)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
            }
        }

        static void SalvarCliente(string nome, string email, int id)
        {
            string connString = getStringConn();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update clientes set nome = @nome, email = @email where id = @id ";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        static void DeletarCliente(int id)
        {
            string connString = getStringConn();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "delete from clientes where id = @id ";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        static (int, string, string) SelecionarCliente(int id)
        {
            string connString = getStringConn();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from clientes where id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    return (Convert.ToInt32(dr["id"].ToString()), dr["nome"].ToString(), dr["email"].ToString());
                }
            }
        }
        static string getStringConn()
        {
            string connString = "Server=SILVAWX-MOBL\\SQLEXPRESS;Database=CSharpAdoNET;User Id=sa;Password=W!ls0ntr";
            return connString;
        }
    }
}
