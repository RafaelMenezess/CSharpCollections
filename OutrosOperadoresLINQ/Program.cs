﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OutrosOperadoresLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro   ", 31),
                new Mes("Fevereiro ", 28),
                new Mes("Março     ", 28),
                new Mes("Abril     ", 30),
                new Mes("Maio      ", 31),
                new Mes("Junho     ", 30),
                new Mes("Julho     ", 31),
                new Mes("Agosto    ", 31),
                new Mes("Setembro  ", 30),
                new Mes("Outubro   ", 31),
                new Mes("Novembro  ", 30),
                new Mes("Dezembro  ", 31)
            };

            var consulta = meses.Take(3);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta2 = meses.Skip(3);
            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta3 = meses.Skip(6).Take(3);
            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));
            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
