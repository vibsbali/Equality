namespace FoodEquals
{
    public class Food
    {
        private string name;

        public string Name => name;

        public Food(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }


    }
}
