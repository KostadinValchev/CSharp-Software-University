namespace Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int numberOfPersons = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < numberOfPersons; i++)
            {
                string[] inputItems = Console.ReadLine().Split();
                string name = inputItems[0];
                int age = int.Parse(inputItems[1]);

                Person person = new Person(name, age);
                Family asd = new Family();
                persons.Add(person);
                asd.AddMember(person);
            }

            Family.GetOldestMember(persons);
        }
    }
}
