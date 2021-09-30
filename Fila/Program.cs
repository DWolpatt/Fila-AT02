using System;
using System.Collections.Generic;

namespace Fila
{
    class Program
    {
        static void Main()
        {
            Queue<string> clientes = new Queue<string>();
            clientes.Enqueue("Cliente 1");
            clientes.Enqueue("Cliente 2");
            clientes.Enqueue("Cliente 3");
            clientes.Enqueue("Cliente 4");
            clientes.Enqueue("Cliente 5");

            foreach(string cliente in clientes) //Percorrendo a lista.
            {
                Console.WriteLine(cliente);
            }

            clientes.Dequeue(); //Removendo item da fila, no conceito de fila, onde primeiro a entrar é primeiro a sair.


            foreach (string cliente in clientes) //Percorrendo a lista novamente para analisar a saída do primeiro.
            {
                Console.WriteLine(cliente);
            }

        }
    }
}
