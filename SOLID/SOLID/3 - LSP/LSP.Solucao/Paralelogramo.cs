using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP.LSP.Solucao
{
    internal class Paralelogramo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }

        public double Area { get { return Altura * Largura; } }
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

    }
}
