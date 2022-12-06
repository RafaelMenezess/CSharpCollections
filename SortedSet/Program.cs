using System;
using System.Collections.Generic;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>();
            alunos.IsSubsetOf(outroConjunto);

            alunos.IsSupersetOf(outroConjunto);

            alunos.SetEquals(outroConjunto);

            alunos.ExceptWith(outroConjunto);

            alunos.IntersectWith(outroConjunto);

            alunos.SymmetricExceptWith(outroConjunto);

            alunos.UnionWith(outroConjunto);


            Console.ReadKey();
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
