using System;
using System.Collections.Generic;
using System.Text;

namespace AvancandoCSharp
{
    internal class Aula02StringFormat
    {
        public void AulaStringFormat()
        {
            string nome = "Wilson Alves";
            int idade = 34;
            double rendimento = 80000.00;
            DateTime dataCadastro = new DateTime(2022, 07, 22);

            string str = String.Format("O cliente {0} tem {1} anos de idade e tem rendimento de {2:c}", nome, idade, rendimento);
            str += " e é cliente desde {3:dd/MM/yyyy}";
            string frase = String.Format(str, nome, idade, rendimento, dataCadastro);
            Console.WriteLine(frase);
        }
    }
}
