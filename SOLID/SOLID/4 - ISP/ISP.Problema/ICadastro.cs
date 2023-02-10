using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4___ISP.ISP.Problema
{
    public interface ICadastro
    {
        void ValidarDados();
        void Salvar();
        void EnviarEmail();
    }
}
