using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Problema
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, Conta conta)
        {
            if (conta.TipoConta == TipoConta.Corrente)
            {
                // Taxas...
                // Debita Conta Corrente
            }

            if (conta.TipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
