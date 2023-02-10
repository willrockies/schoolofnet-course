using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ISP = Príncipio da segregação da interface
// A Ideia do ISP é ter varias interfaces com contrato especifico,
// do que uma interface com muitos metodos, quando a classe não é obrigada a cumprir todos os metodos da interface
// ponto focal do principio é quebrar a interface de forma que faça sentido cumprir o contrato da interface
// de forma que não quebre a classe


namespace SOLID._4___ISP.ISP.Problema
{
    internal class CadastroUsuario : ICadastro
    {
        public void EnviarEmail()
        {
            // Validar CPF, Email
            throw new NotImplementedException();
        }

        public void Salvar()
        {
            //Insert na tabela Usuario
            throw new NotImplementedException();
        }

        public void ValidarDados()
        {
            //Enviar email para o usuario
            throw new NotImplementedException();
        }
    }
}
