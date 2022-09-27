using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula04Operadores
    {
        public void Aula4Operadores()
        {
            var x = 10;
            var y = 5;
            var soma = x + y;
            var subtrair = x - y;
            var multiplicar = x * y;
            var dividir = x / y;
            Console.WriteLine(soma);
            Console.WriteLine(subtrair);
            soma += subtrair;
            Console.WriteLine(soma);

        }
    }
}
