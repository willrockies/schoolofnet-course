using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula12For
    {
        public void AulaFor()
        {
            /*for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"num => {i}");
            }*/

            string[] nomes = new string[] { "Goku", "Vegeta", "Gohan", };
            for (int i = 0; i < nomes.Length; i++)
            {
                string s = nomes[i];
                Console.WriteLine($"Olá {s}");
            }
        }
    }
}
