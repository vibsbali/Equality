using System;

namespace FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReferenceEquality();

            //StringEquality();

            //DefaultStaticObjectBoolEqualsOfDotNet();

            var banana = new FoodItem("Banana", FoodGroup.Fruit);
            var chocolate = new FoodItem("Chocolate", FoodGroup.Vegetables);

            var areEqual = object.Equals(banana, chocolate);

            Console.WriteLine(areEqual);
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
