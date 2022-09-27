using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula08Tuplas
    {
        public void Aula8Tuplas()
        {
            (string, string, double) sayajin = ("Goku", "kamehameha", 8000.0);

            Console.WriteLine($"O sayajin é: {sayajin.Item1} seu golpe mais forte é {sayajin.Item2} e seu poder de luta é mais de {sayajin.Item3}");

            (string nome, string nivel) ninja = ("Naruto", "Genin");
            Console.WriteLine($"Nome do ninja é: {ninja.nome}, seu nivel é: {ninja.nivel}");
        }
    }
}
