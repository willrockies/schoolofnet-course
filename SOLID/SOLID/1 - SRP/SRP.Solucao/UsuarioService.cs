using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class UsuarioService
    {
        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsUsuarioValid()) return "Dados Inválidos";

            var repo = new UsuarioRepository();
            repo.AdicionarUsuario(usuario);

            EmailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabens");

            return "Usuário cadastrado com sucesso";
        }


    }
}
