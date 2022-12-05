using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    internal class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            Enfilerar("Van");
            Enfilerar("Kombi");
            Enfilerar("Guincho");
            Enfilerar("Pick-up");

            Desenfilerar();
            Desenfilerar();
            Desenfilerar();
            Desenfilerar();
            Desenfilerar();

            Console.Read();
        }

        private static void Desenfilerar()
        {
            if (pedagio.Any())
            {
                Console.WriteLine();
                if (pedagio.Peek() == "Guincho")
                {
                    Console.WriteLine("Guincho está fazendo pagamento");
                }

                Console.WriteLine();
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfilerar(string veiculo)
        {
            Console.WriteLine();
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila: ");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
