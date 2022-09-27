using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula11While
    {
        public void AulaWhile()
        {
             int i = 0;
            /*     
             while (i <= 10)
             {
                WriteLine($"Num => {i}");
                i++;
              }*/

            while(i <= 10)
            {
                if(i == 8)
                {
                    WriteLine($"Num => {i}");
                    break;
                }
                WriteLine($"Num => {i}");
                i++;
            }

           /* string[] nomes = new string[] { "Goku", "Vegeta", "Gohan", };
            int i = 0;
            while(i < nomes.Length)
            {
                *//*if (nomes[i] == nomes[0])
                {
                    WriteLine($"Olá eu sou o {nomes[i]}");
                }
                if (nomes[i] == nomes[1])
                {
                    WriteLine($"maldito Kakaroto {nomes[i]}");
                }*//*
                WriteLine($"Olá eu sou o {nomes[i]}");
                i++;
            }*/
        }
    }
}
