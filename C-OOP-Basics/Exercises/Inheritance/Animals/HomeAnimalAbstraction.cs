namespace Animals
{
    public abstract class HomeAnimalAbstraction
    {
        private string name;
        private int age;
        private string gender;

        public HomeAnimalAbstraction(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected virtual string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }


        protected virtual int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


        protected virtual string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public virtual string ProduceSound()
        {
            return string.Empty;
        }
    }
}
