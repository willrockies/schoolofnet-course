using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace SistemaFinanceiro
{
    public static class Uteis
    {
        public static void MontaMenu()
        {
            MontaHeader("CONTROLE FINANCEIRO");
            
            WriteLine("Selecione uma opção abaixo: ");
            WriteLine("--------------------------");
            WriteLine("1 - Listar");
            WriteLine("2 - Cadastrar");
            WriteLine("3 - Editar");
            WriteLine("4 - Excluir");
            WriteLine("5 - Relatório");
            WriteLine("6 - Sair");
            Write("Opção: ");


        }

        public static void MontaHeader(string titulo, char code = '=', int leng = 30)
        {
            WriteLine(new string(code, leng) + " " + titulo + " " + new string(code,leng));
            Write("\n");
        }
    }
}
