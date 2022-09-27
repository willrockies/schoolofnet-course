using System;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula06Pilhas
    {
        public void Aula6Pilha()
        {
            Stack<int> p1 = new Stack<int>();

            p1.Push(2);
            p1.Push(3);
            p1.Push(5);
            p1.Push(7);
            p1.Push(11);
            Console.WriteLine("A pilha tem " + p1.Count + " itens");
            Console.WriteLine(p1.Peek());
            p1.Pop();
            Console.WriteLine("Agora pilha tem " + p1.Count + " itens");

            Console.WriteLine(p1.Peek());
        }
    }
}
