using System;

namespace Equality
{
    public struct CalorieCount : IComparable<CalorieCount>, IEquatable<CalorieCount>, IComparable
    {
        private readonly double calorie;
        public double Calorie => calorie;

        public CalorieCount(double calorie)
        {
            this.calorie = calorie;
        }

        public int CompareTo(CalorieCount other)
        {
            return Calorie.CompareTo(other.Calorie);
        }

        public static bool operator <(CalorieCount lhs, CalorieCount rhs)
        {
            return lhs.Calorie < rhs.Calorie;
        }

        public static bool operator >(CalorieCount lhs, CalorieCount rhs)
        {
            return lhs.Calorie > rhs.Calorie;
        }

        public static bool operator <=(CalorieCount lhs, CalorieCount rhs)
        {
            return lhs.Calorie <= rhs.Calorie;
        }

        public static bool operator >=(CalorieCount lhs, CalorieCount rhs)
        {
            return lhs.Calorie >= rhs.Calorie;
        }

        public static bool operator ==(CalorieCount lhs, CalorieCount rhs)
        {
            return lhs.Calorie == rhs.Calorie;
        }
        public static bool operator !=(CalorieCount lhs, CalorieCount rhs)
        {
            return lhs.Calorie != rhs.Calorie;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is CalorieCount))
            {
                return false;
            }
            return Calorie == ((CalorieCount)obj).Calorie;
        }

        public override int GetHashCode()
        {
            //returning Hash of Calorie as this is the value we are using to compare
            return Calorie.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            if (!(obj is CalorieCount))
                throw new ArgumentException("Expected CalorieCount instance", "obj");
            return CompareTo((CalorieCount)obj);
        }

        public bool Equals(CalorieCount other)
        {
            return Calorie == other.Calorie;
        }

        public override string ToString()
        {
            return $"{calorie} cal";
        }
    }
}
