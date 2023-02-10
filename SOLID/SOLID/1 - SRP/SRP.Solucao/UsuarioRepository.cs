using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class UsuarioRepository
    {
        public void AdicionarUsuario(Usuario usuario)
        {

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "StringConexao";

                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO (NOME, EMAIL, CPF, DATANASCIMENTO) VALUES ((@nome, @email, @cpf, @dataNas)) ";

                cmd.Parameters.AddWithValue("nome", usuario.Nome);
                cmd.Parameters.AddWithValue("email", usuario.Email);
                cmd.Parameters.AddWithValue("cpf", usuario.CPF);
                cmd.Parameters.AddWithValue("nome", usuario.DataNascimento);

                cn.Open();
                cmd.ExecuteNonQuery();

            }



        }
    }
}
