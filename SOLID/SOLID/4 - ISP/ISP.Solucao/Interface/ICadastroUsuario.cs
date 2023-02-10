using SOLID._4___ISP.ISP.Solucao.Interface;
using System;


namespace SOLID._4___ISP.ISP.Solucao
{
    internal interface ICadastroUsuario : ICadastro
    {
        void EnviarEmail();
    }
}
