using System;
using System.Collections.Generic;

namespace FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferenceEquality();

            //StringEquality();

            //DefaultStaticObjectBoolEqualsOfDotNet();

            ValueTypeEquality();
        }

        private static void ValueTypeEquality()
        {
            var banana = new FoodItem("Banana", FoodGroup.Fruit);
            var bananaTwo = new FoodItem("Banana", FoodGroup.Fruit);
            var chocolate = new FoodItem("Chocolate", FoodGroup.Vegetables);
            var bananaSmoothie = new FoodItem("Chocolate Smoothie", FoodGroup.Fruit);

            var areEqual = object.Equals(banana, chocolate);

            Console.WriteLine(areEqual);
            Console.WriteLine(banana == bananaSmoothie);

            var dictionaryOfFoodGroups = new Dictionary<FoodItem, string>();
            Console.WriteLine(banana.GetHashCode());
            dictionaryOfFoodGroups.Add(banana, banana.Name);
            //This line should throw an exception as both banana and bananaTwo should have same hash code
            Console.WriteLine(bananaTwo.GetHashCode());
            dictionaryOfFoodGroups.Add(bananaTwo, bananaTwo.Name);
        }

        private static void StringEquality()
        {
            string banana = "banana";
            string banana2 = string.Copy(banana);

            object bananaObj = (object)banana;
            object banana2Obj = (object)banana2;

            Console.WriteLine(bananaObj.Equals(banana2Obj)); //Answers true  
        }

        private static void DefaultVirtualBoolEqualsOfDotNet()
        {
            var banana = new Food("Banana");
            var banana2 = new Food("Banana");
            var chocolate = new Food("Chocolate");

            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2));
        }

        private static void DefaultStaticObjectBoolEqualsOfDotNet()
        {
            var banana = new Food("Banana");
            var banana2 = new Food("Banana");
            var chocolate = new Food("Chocolate");

            object nullBanana = null;
            object nullBanana2 = null;

            Console.WriteLine(banana.Equals(null)); //False
            Console.WriteLine(nullBanana.Equals(nullBanana2)); //Exception

            Console.WriteLine(object.Equals(banana, null)); //False 
            Console.WriteLine(object.Equals(null, null)); //True!! .net is different NULL equals NULL
        }

        private static void DefaultStaticBoolReferenceEqualsOfDotNet()
        {

        }
    }
}
