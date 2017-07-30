using System;

namespace Equality
{
    class Program
    {
        static void Main()
        {
            var cal300 = new CalorieCount(300);
            var cal400 = new CalorieCount(400);

            Console.WriteLine(cal300.CompareTo(cal400));
            Console.WriteLine(cal300 < cal400);
            Console.WriteLine(cal300 == cal400);
        }
    }
}
