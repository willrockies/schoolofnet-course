using System;
using System.Collections.Generic;
using System.Text;

namespace AvancandoCSharp
{
    internal class Aula05FormandoDatas
    {
        public void AulaFormatandoDatas()
        {
            string dataDoBanco = "2020-04-02 08:30:00";
            DateTime data = DateTime.Parse(dataDoBanco);
            //DateTime data = new DateTime(2022, 04, 02, 08, 30, 00);

            string dataFormatada = String.Format("{0:HH}h{0:mm}", data);
            Console.WriteLine(dataFormatada);

            Console.WriteLine(data);
        }
    }
}
