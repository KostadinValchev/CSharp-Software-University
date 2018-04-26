namespace Creating_Constructors
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age)
        {
            this.name = "No name";
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
