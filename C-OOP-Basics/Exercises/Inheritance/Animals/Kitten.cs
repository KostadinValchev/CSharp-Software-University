namespace Animals
{
    public class Kitten : HomeAnimalFactory
    {
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {
        }

        public override string ProduceSound()
        {
            return base.ProduceSound() + $"\nMiau";
        }
    }
}
