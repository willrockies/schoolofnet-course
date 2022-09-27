using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula10SwitchCase
    {
        public void SwitchCase()
        {
            Write("Informe o saldo do cartão/branco: ");
            var eSaldo = Convert.ToDouble(ReadLine());

            Write("Informe o valor da compra: ");
            var eValor = Convert.ToDouble(ReadLine());

            Write("Informe o tipo de pagamento (C para credito e D para debito): ");
            char eTipo = Convert.ToChar(ReadLine());

            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de credito não aprovado!");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de Debito não aprovado!");
                    break;
                default:
                    WriteLine("Compra aprovada");
                    break;
            }


        }
    }
}
