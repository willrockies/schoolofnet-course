using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula13ForEach
    {
        public void AulaForEach()
        {
            string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

            foreach(string dia in diasSemanas)
            {
                Console.WriteLine($"Hoje é {dia}");
            }
        }
    }
}
