using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___OCP.OCP.Solucao
{
    //OCP = Princípio Aberto/Fechado
    public abstract class Conta
    {
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal valor, string conta);
        public abstract void Sacar(decimal valor, string conta);
    }
}
