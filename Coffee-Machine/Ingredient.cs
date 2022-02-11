namespace Coffee_Machine
{
    abstract class Ingredient
    {
        public string Name { get; }
        public int Amount { get; }

        protected Ingredient(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
