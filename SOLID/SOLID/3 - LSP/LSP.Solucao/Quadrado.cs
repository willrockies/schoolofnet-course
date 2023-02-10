using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP.LSP.Solucao
{
    internal class Quadrado : Paralelogramo
    {

        public Quadrado(int altura, int largura) : base(altura,largura) 
        {
            if(largura != altura)
            {
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
            }
        }
    }
}
