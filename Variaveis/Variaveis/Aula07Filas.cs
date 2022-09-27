using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Variaveis
{
    internal class Aula07Filas
    {
        public void Aula7Filas()
        {
            Queue fila = new Queue();
            fila.Enqueue("Wilson");
            fila.Enqueue("Josi");
            fila.Enqueue("Severino");
            fila.Enqueue("Zé");

            Console.WriteLine("O primeiro da fila é: " + fila.Peek());
            Console.WriteLine($"A fila tem {fila.Count} pessoas");
            Console.WriteLine($" {fila.Dequeue()} saiu da fila");

            Console.WriteLine("O primeiro da fila é: " + fila.Peek());
            Console.WriteLine($"A fila tem agora {fila.Count} pessoas");
            Console.WriteLine($" {fila.Dequeue()}  saiu da fila");

            Console.WriteLine($"A fila tem agora {fila.Count} pessoas");

            Console.WriteLine("O primeiro da fila é: " + fila.Peek());
            
        }
    }
}
