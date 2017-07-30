namespace FoodEquals
{
    public class Food
    {
        private string name;
        private FoodGroup foodGroup;

        public string Name => name;
        public FoodGroup FoodGroup => foodGroup;

        public Food(string name, FoodGroup foodGroup)
        {
            this.name = name;
            this.foodGroup = foodGroup;
        }

        public override string ToString()
        {
            return name;
        }
    }

    public sealed class CookedFood : Food
    {
        private string cookingMethod;
        public string CookingMethod => cookingMethod;

        public CookedFood(string cookingMethod, string name, FoodGroup foodGroup)
            : base(name, foodGroup)
        {
            this.cookingMethod = cookingMethod;
        }

        public override string ToString()
        {
            return $"{cookingMethod} {Name}";
        }
    }
}
