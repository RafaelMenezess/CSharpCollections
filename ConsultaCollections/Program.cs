using ConsultaCollections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultandoCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 28),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31)
            };

            //meses.Sort();
            //foreach (var mes in meses)
            //{
            //    if (mes.Dias == 31)
            //    {
            //        Console.WriteLine(mes.Nome.ToUpper());
            //    }
            //}

            IEnumerable<string>
                consulta = meses
                            .Where(m => m.Dias == 31)
                            .OrderBy(m => m.Nome)
                            .Select(m => m.Nome.ToUpper());

            foreach (var mes in consulta)
            {
                Console.WriteLine(mes);
            }

            Console.ReadKey();
        }
    }
}
