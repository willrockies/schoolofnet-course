using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Solucao
{
    //OCP = Princípio Aberto/Fechado
    internal class ContaPoupanca : Conta
    {
        public override void Sacar(decimal valor, string conta)
        {
            this.Saldo -= valor;
        }

        public override void Depositar(decimal valor, string conta)
        {
            this.Saldo += valor;
        }
    }
}
