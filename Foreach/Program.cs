using System;
using System.Collections.Generic;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meses = new List<string>
            {
                "Janeiro","Fevereiro","Março","Abril",
                "Maio","Junho","Julho","Agosto","Setembro",
                "Outubro","Novembro","Dezembro"
            };

            foreach (var item in meses)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
