namespace Opinion_Poll
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var personName = string.Empty;
            var personAge = 0;
            var over30 = new Over30();


            int numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ').ToArray();
                personName = inputTokens[0];
                personAge = int.Parse(inputTokens[1]);

                var person = new Person(personName, personAge);
                if (personAge > 30)
                {
                    over30.AddMember(person);
                }

            }

            foreach (var p in over30.Members.OrderBy(m => m.Name))
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }

        }
    }
}
