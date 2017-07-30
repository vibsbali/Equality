namespace FoodEquals
{
    public class Food
    {
        private readonly string name;
        private readonly FoodGroup foodGroup;

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

        public static bool operator ==(Food x, Food y)
        {
            return object.Equals(x, y);
        }

        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            Food rhs = obj as Food;
            if (rhs == null)
            {
                return false;
            }

            return this.name == rhs.name && this.foodGroup == rhs.foodGroup;
        }

        public override int GetHashCode()
        {
            if (name == null)
            {
                return 0 ^ foodGroup.GetHashCode();
            }

            return name.GetHashCode() ^ foodGroup.GetHashCode();
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
