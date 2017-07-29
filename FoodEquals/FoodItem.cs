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

        //Returns a 32-bit hash of the value of the object
        //Hash tables require that if x.Equals(y) then we must have
        //x.GetHashCode() == y.GetHashCode()
        public override int GetHashCode()
        {
            //using exclusive Or operator XOR
            return name.GetHashCode() ^ group.GetHashCode();
        }

        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !lhs.Equals(rhs);
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
