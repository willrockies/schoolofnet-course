using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___SRP.SRP.Solucao
{
    public static class CPFServices
    {
        public static bool isValid(string cpf)
        {
            return cpf.Length == 11;

        }

    }
}
