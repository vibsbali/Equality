using System;
using System.Globalization;

namespace StringComparisonExamples
{
    class Program
    {
        static void Main()
        {
            //Ordinal();

            StringEquality();
        }

        private static void StringEquality()
        {
            //To do an equals for which there is no Equals method:
            bool areEqual = string.Equals("Apple", "Pineapple", StringComparison.CurrentCultureIgnoreCase);

            //or
            int cmpResult = string.Compare("Apple", "Pineapple", CultureInfo.GetCultureInfo("fr-FR"), CompareOptions.IgnoreSymbols);
            areEqual = (cmpResult == 0);

            //case sensitive ordinal:
            areEqual = ("Apple" == "Pineapple");

        }

        private static void Ordinal()
        {
            //Ordinal
            //Ignore the Culture and Unicode issues
            //Compare numeric values of chars only until we find the first difference
            //Note! it stops as soon as it finds the first difference
            var a = 'a';
            var A = 'A';
            Console.WriteLine((uint)a);
            Console.WriteLine((uint)A);
            Console.WriteLine(string.Compare(a.ToString(), A.ToString(), StringComparison.Ordinal));

            var lemon = "lemon";
            var lime = "lime";
            Console.WriteLine("Comparing e and i");
            Console.WriteLine(string.Compare(lemon[1].ToString(), lime[1].ToString(), StringComparison.Ordinal));
            Console.WriteLine("Comparing lemon and lime");
            Console.WriteLine(string.Compare(lemon, lime, StringComparison.Ordinal));
            Console.WriteLine("lemon comes before lime hence negative value");

            var b = 'b';
            var B = 'B';
            Console.WriteLine((uint)b);
            Console.WriteLine((uint)B);

            Console.WriteLine(string.Compare(b.ToString(), B.ToString(), StringComparison.Ordinal));

            string ab = "ab";
            string AB = "Abc";
            Console.WriteLine(string.Compare(ab, AB, StringComparison.Ordinal));
        }
    }
}
