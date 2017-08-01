using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodEquals;

namespace SortingUserdefinedTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] list =
            {
                new Food("Orange", FoodGroup.Fruit),
                new Food("banana", FoodGroup.Fruit),
                new Food("pear", FoodGroup.Fruit),
                new Food("apple", FoodGroup.Fruit),
            };

            Array.Sort(list, FoodNameComparer.Instance());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
