using System;
using System.Text;
using System.Collections.Generic;

namespace AvancandoCSharp
{
    internal class Aula03StringBuilder
    {
        public void Aula3StringBuilder()
        {

            StringBuilder builder = new StringBuilder();
            builder.Append("C");

            Console.WriteLine(builder);

            string nome = "Wilson Alves";
            int idade = 34;
            double rendimento = 80000.00;
            DateTime dataCadastro = new DateTime(2022, 07, 22);
            StringBuilder frase = new StringBuilder("O cliente {0} tem {1} anos de idade e tem rendimento de {2:c}");
            frase.Append("e é cliente desde {3:dd/MM/yyyy}");

            builder.AppendFormat(frase.ToString(), nome, idade, rendimento, dataCadastro);
            Console.WriteLine(builder);
        }

    }
}
