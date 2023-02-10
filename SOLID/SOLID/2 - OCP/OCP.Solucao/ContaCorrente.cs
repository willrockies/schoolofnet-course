using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Solucao
{
    //OCP = Princípio Aberto/Fechado
    public class ContaCorrente : Conta
    {
        public decimal TaxaMovimentacao { get; set; }

        public ContaCorrente()
        {
            this.TaxaMovimentacao= 0.01m;
        }
        public override void Sacar(decimal valor, string conta)
        {
            this.Saldo -= (valor + (valor * TaxaMovimentacao));
        }

        public override void Depositar(decimal valor, string conta)
        {
            this.Saldo += valor;
        }
    }
}
