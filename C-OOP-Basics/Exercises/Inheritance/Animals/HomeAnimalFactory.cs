namespace Animals
{
    using System;

    public class HomeAnimalFactory : HomeAnimalAbstraction
    {
        public HomeAnimalFactory(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        protected override int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                base.Age = value;
            }
        }

        protected override string Name
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                base.Name = value;
            }
        }

        protected override string Gender
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value != "Female" && value != "Male"))
                {
                    throw new ArgumentException("Invalid input!");
                }
                base.Gender = value;
            }
        }

        public override string ProduceSound()
        {
            return $"{this.GetType().Name}\n{base.Name} {base.Age} {base.Gender}";
        }
    }
}
