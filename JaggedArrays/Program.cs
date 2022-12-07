using System;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] familias = new string[3][];
            //{
            //    { "Fred","Wilma","Pedrita" },
            //    { "Homer","Marge","Lisa","Bart","Marggie" },
            //    { "Florinda","Kiko" }
            //};

            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Marggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach (var familia in familias)
            {
                Console.WriteLine(string.Join(",", familia));
            }

            Console.ReadKey();
        }
    }
}
