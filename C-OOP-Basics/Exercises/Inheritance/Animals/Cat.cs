namespace Animals
{
    public class Cat : HomeAnimalFactory
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }
        public override string ProduceSound()
        {
            return base.ProduceSound() + $"\nMiauMiau";
        }
    }
}
