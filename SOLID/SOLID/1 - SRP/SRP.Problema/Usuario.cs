using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP.Problema
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public string AdicionarUsuario()
        {
            if (!Email.Contains("@"))
            {
                return "Email Invalido";
            }

            if (CPF.Length != 11)
                return "CPF Inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "StringConexao";

                cmd.Connection= cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO (NOME, EMAIL, CPF, DATANASCIMENTO) VALUES () ";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("nome", DataNascimento);

                cn.Open();  
                cmd.ExecuteNonQuery();

            }


            var mail = new MailMessage("csharp@solid.com", Email);

            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Você está cadastrado";
            client.Send(mail);

            return "Usuario cadastrado com sucesso";
        }
    }
}
