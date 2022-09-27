using System;
using System.Collections.Generic;
using System.Text;

namespace AvancandoCSharp
{
    internal class Aula01FuncoesString
    {
        public void Aula1FuncoesString()
        {
            string frase = "Quem traz CD, LP, fax, engov e whisky JB?";

            string frase_trocada = frase.Replace("whisky", "vodka");

            Console.WriteLine(frase_trocada);

            //Console.WriteLine(frase.ToUpper());
            //Console.WriteLine(frase.ToLower());


            //string subFrase = "Quem";

            //Console.WriteLine(frase.Contains(subFrase));

            //int pos = frase.IndexOf(subFrase);
            //int posInicial = frase.IndexOf(subFrase);
            //int posFinal = 10;

            //string sub = frase.Substring(posInicial, posFinal);
            //Console.WriteLine(sub);

            //Console.WriteLine(pos);
            //Console.WriteLine(frase.Length);

            //string[] partes = frase.Split(",");

            //for (int i = 0; i < partes.Length; i++)
            //{
            //    Console.WriteLine(partes[i].Trim());
            //}
        }
    }
}
