namespace Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;

    public class Family
    {
        private List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public List<Person> Persons { get; set; }
        public void AddMember(Person member)
        {
            this.persons.Add(member);
        }
        public static void GetOldestMember(List<Person> persons)
        {
            int age = Int32.MinValue;

            foreach (var p in persons)
            {
                if (p.age > age)
                {
                    age = p.age;
                }
            }
            var oldestPerson = persons.Find(p => p.age == age);
            Console.WriteLine($"{oldestPerson.name} {oldestPerson.age}");
        }
    }
}

