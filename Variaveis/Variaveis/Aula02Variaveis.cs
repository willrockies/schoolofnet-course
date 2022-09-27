using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula02Variaveis
    {
        public void variaveis()
        {
            int idadeAtual = 34;
            string nome = "Wilson Alves";
            bool ativo = true;
            decimal salario = 1345.98m;
            float descontos = 397.99f;

            Console.WriteLine($"O Usuario {nome} tem {idadeAtual} anos de idade, está {ativo} no sistema e ganha {salario} por mês e tem {descontos} de descontos no salario");

            dynamic x = "Está variavel é uma string";
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x);

            x = false;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
