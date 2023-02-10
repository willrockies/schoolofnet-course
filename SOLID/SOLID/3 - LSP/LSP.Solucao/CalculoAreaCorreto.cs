using SOLID._3___LSP.LSP.Problema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___LSP.LSP.Solucao
{
    public class CalculoAreaCorreto
    {
        private static void ObterAreaRetangulo(Paralelogramo paralelogramo)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralogramo");
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Altura + " * " + paralelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            //var quad = new Quadrado(10, 5);
            var ret = new Retangulo(10, 5);



            ObterAreaRetangulo(ret);
        }
    }
}
