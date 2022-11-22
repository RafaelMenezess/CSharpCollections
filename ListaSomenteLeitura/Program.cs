using System;
using System.Collections.Generic;

namespace ListaSomenteLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);


            Console.ReadKey();
        }
        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
