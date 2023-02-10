using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___ISP.ISP.Problema
{
    internal class CadrastoProduto : ICadastro
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
