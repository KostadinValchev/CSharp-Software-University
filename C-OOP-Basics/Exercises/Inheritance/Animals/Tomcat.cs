namespace Animals
{
    public class Tomcat : HomeAnimalFactory
    {
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {
        }

        public override string ProduceSound()
        {
            return base.ProduceSound() + $"\nGive me one million b***h";
        }
    }
}
