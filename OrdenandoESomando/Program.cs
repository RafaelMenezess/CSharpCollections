using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoESomando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            Imprimir(csharpColecoes.Aulas);

            //adicionar 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções", 19));

            //imprimir
            Imprimir(csharpColecoes.Aulas);

            //copiar a lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            
            //ordenar cópia
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            //totalizar tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            //imprimir detalhes do curso
            Console.WriteLine(csharpColecoes);

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
