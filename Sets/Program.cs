using System;
using System.Collections.Generic;

namespace Sets
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SETS = Conjuntos

            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimir
            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(",", alunos));

            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(",", alunos));

            //adicionado duplicado
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(",", alunos));

            //oredenar
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(",", alunosEmLista));

            Console.ReadLine();
        }
    }
}
