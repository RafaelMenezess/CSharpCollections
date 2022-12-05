using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    internal class Navegador
    {
        private readonly Stack<string> hitoricoAnterior = new Stack<string>();
        private readonly Stack<string> hitoricoProximo = new Stack<string>();
        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Anterior()
        {
            if (hitoricoAnterior.Any())
            {
                hitoricoProximo.Push(atual);
                atual = hitoricoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }

        internal void NavegarPara(string url)
        {
            hitoricoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Proximo()
        {
            if (hitoricoProximo.Any())
            {
                hitoricoAnterior.Push(atual);
                atual = hitoricoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}