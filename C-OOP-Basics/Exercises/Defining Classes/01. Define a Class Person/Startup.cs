namespace Define_a_class_Person
{
    using System;
    using System.Reflection;

    public class Startup
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            Person person1 = new Person()
            {
                name = "Pesho",
                age = 20
            };

            Person person2 = new Person();
            person2.name = "Gosho";
            person2.age = 18;

            Person person3 = new Person()
            {
                name = "Stamat",
                age = 43
            };
        }
    }
}
