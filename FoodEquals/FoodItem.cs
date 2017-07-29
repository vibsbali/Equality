using System;

namespace FoodEquals
{
    public struct FoodItem : IEquatable<FoodItem>
    {
        private readonly string name;
        private readonly FoodGroup group;

        public string Name => name;
        public FoodGroup Group => group;

        public FoodItem(string name, FoodGroup group)
        {
            this.name = name;
            this.group = group;
        }

        public bool Equals(FoodItem other)
        {
            return Name == other.Name && Group == other.Group;
        }

        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
            {
                return Equals((FoodItem)obj);
            }
            return false;
        }



        public override string ToString()
        {
            return name;
        }
    }

    public enum FoodGroup
    {
        Meat,
        Fruit,
        Vegetables,
        Sweets
    }
}
