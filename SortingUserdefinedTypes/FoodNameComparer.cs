using FoodEquals;
using System;
using System.Collections.Generic;

namespace SortingUserdefinedTypes
{
    //Note we are using Comparer from IComparer interface and not IComparable
    public class FoodNameComparer : Comparer<Food>
    {
        private static readonly object locker = new object();
        //Creating Singleton
        private FoodNameComparer() { }

        private static FoodNameComparer _instance;

        public static FoodNameComparer Instance()
        {
            lock (locker)
            {
                if (_instance == null)
                {
                    _instance = new FoodNameComparer();
                }
                return _instance;
            }

        }

        public override int Compare(Food x, Food y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return -1;
            }
            if (y == null)
            {
                return 1;
            }
            int nameOrder = string.Compare(x.Name, y.Name, StringComparison.CurrentCulture);
            if (nameOrder != 0)
            {
                return nameOrder;
            }

            //This is for making more specific comparison
            return string.Compare(x.FoodGroup.ToString(), y.FoodGroup.ToString(), StringComparison.CurrentCulture);
        }
    }
}
