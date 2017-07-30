using System;
using System.Collections.Generic;

namespace FoodEquals
{
    class Program
    {
        static void Main()
        {
            //ReferenceEquality();

            //StringEquality();

            //DefaultStaticObjectBoolEqualsOfDotNet();

            //ValueTypeEquality();

            var apple = new Food("apple", FoodGroup.Fruit);
            var stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            var bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            var stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            var apple2 = new Food("apple", FoodGroup.Fruit);

            DisplayWhetherEqualUsingEqualityOperator(apple, stewedApple);
            DisplayWhetherEqualUsingEqualityOperator(stewedApple, bakedApple);
            DisplayWhetherEqualUsingEqualityOperator(stewedApple, stewedApple2);
            DisplayWhetherEqualUsingEqualityOperator(apple, apple2);
            DisplayWhetherEqualUsingEqualityOperator(apple, apple);

            Console.WriteLine("Using class's equals method");
            DisplayWhetherEqualUsingFoodsEquality(apple, stewedApple);
            DisplayWhetherEqualUsingFoodsEquality(stewedApple, bakedApple);
            DisplayWhetherEqualUsingFoodsEquality(stewedApple, stewedApple2);
            DisplayWhetherEqualUsingFoodsEquality(apple, apple2);
            DisplayWhetherEqualUsingFoodsEquality(apple, apple);

            Console.WriteLine("Using static Object.Equals");
            DisplayWhetherEqualUsingStaticObjectEquality(apple, stewedApple);
            DisplayWhetherEqualUsingStaticObjectEquality(stewedApple, bakedApple);
            DisplayWhetherEqualUsingStaticObjectEquality(stewedApple, stewedApple2);
            DisplayWhetherEqualUsingStaticObjectEquality(apple, apple2);
            DisplayWhetherEqualUsingStaticObjectEquality(apple, apple);
        }

        static void DisplayWhetherEqualUsingEqualityOperator(Food food1, Food food2)
        {
            if (food1 == food2)
            {
                Console.WriteLine($"{food1} is == {food2}");
            }
            else
            {
                Console.WriteLine($"{food1} is != {food2}");
            }
        }

        static void DisplayWhetherEqualUsingFoodsEquality(Food food1, Food food2)
        {
            if (food1.Equals(food2))
            {
                Console.WriteLine($"{food1} is equal to {food2}");
            }
            else
            {
                Console.WriteLine($"{food1} is not equal to {food2}");
            }
        }

        //This will use the Food's equal's implementation
        static void DisplayWhetherEqualUsingStaticObjectEquality(Food food1, Food food2)
        {
            if (object.Equals(food1, food2))
            {
                Console.WriteLine($"{food1} is equal to {food2}");
            }
            else
            {
                Console.WriteLine($"{food1} is not equal to {food2}");
            }
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
            var banana = new Food("Banana", FoodGroup.Fruit);
            var banana2 = new Food("Banana", FoodGroup.Fruit);
            var chocolate = new Food("Chocolate", FoodGroup.Sweets);

            Console.WriteLine(banana.Equals(chocolate));
            Console.WriteLine(banana.Equals(banana2));
        }

        private static void DefaultStaticObjectBoolEqualsOfDotNet()
        {
            var banana = new Food("Banana", FoodGroup.Fruit);
            var banana2 = new Food("Banana", FoodGroup.Fruit);
            var chocolate = new Food("Chocolate", FoodGroup.Sweets);

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
