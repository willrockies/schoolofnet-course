using System.Data.SqlClient;
using System.Data;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }


        public bool IsUsuarioValid()
        {
            return EmailServices.IsValid(Email) && CPFServices.isValid(CPF);
        }

    }
}
