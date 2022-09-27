using System;

namespace AvancandoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aula01FuncoesString testFuncString = new Aula01FuncoesString();
            //testFuncString.Aula1FuncoesString();

            Aula02StringFormat testStringFormat = new Aula02StringFormat();
            testStringFormat.AulaStringFormat();

            Aula03StringBuilder testStringBuilder = new Aula03StringBuilder();
            testStringBuilder.Aula3StringBuilder();

            Aula04DateTime testDateTime = new Aula04DateTime();
            testDateTime.Aula4DateTime();

            Aula05FormandoDatas testFormatandoDatas = new Aula05FormandoDatas();
            testFormatandoDatas.AulaFormatandoDatas();
        }
    }
}
