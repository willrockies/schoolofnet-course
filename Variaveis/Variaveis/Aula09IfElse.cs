using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula09IfElse
    {

        public void Aula9IfElse()
        {
            double salario = .0;
            double gastosMensais = 0;
            bool temDecimoTerceiro = false;
            

            Write("Informe seu salario: ");
            salario = double.Parse(ReadLine());

            Write("Informe seu gastos mensais: ");
            gastosMensais = Convert.ToDouble(ReadLine());

            Write("tem decimo terceiro? ");
            Boolean.TryParse(ReadLine(), out temDecimoTerceiro);

            if (temDecimoTerceiro)
            {
                salario += salario;
            }
            if (gastosMensais > salario)
            {
                WriteLine("Precisa economizar!");
            } 
            else if (gastosMensais == salario)
            {
                WriteLine("Estou zerado!");
            }
            else
            {
                WriteLine("Legal! Sobrou dinheiro!");
            }
        }
    }
}
