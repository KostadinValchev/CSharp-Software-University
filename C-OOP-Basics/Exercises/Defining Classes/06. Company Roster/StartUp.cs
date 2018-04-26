namespace Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> myEmployees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                switch (input.Length)
                {
                    case 4:
                        myEmployees.Add(new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]));
                        break;
                    case 5:
                        int num;
                        bool successfullyParsed = int.TryParse(input[4], out num);
                        if (successfullyParsed)
                        {
                            myEmployees.Add(new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], int.Parse(input[4])));
                        }
                        else
                        {
                            myEmployees.Add(new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4]));
                        }
                        break;
                    case 6:
                        myEmployees.Add(new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5])));
                        break;
                }

            }

            Dictionary<string, decimal> myDepartaments = new Dictionary<string, decimal>();
            decimal check = Decimal.MinValue;
            string departament = "";
            foreach (var v in myEmployees)
            {
                if (myDepartaments.ContainsKey(v.department))
                {
                    var averagesalary = myDepartaments[v.department] += v.salary;
                    if (averagesalary > check)
                    {
                        check = averagesalary;
                        departament = v.department;
                    }
                }
                else
                {
                    myDepartaments.Add(v.department, v.salary);
                    if (v.salary > check)
                    {
                        check = v.salary;
                        departament = v.department;
                    }
                }
            }

            Console.WriteLine($"Highest Average Salary: {departament}");
            foreach (var e in myEmployees.Where(d => d.department == departament).OrderByDescending(s => s.salary).ToArray())
            {
                Console.WriteLine($"{e.name} {e.salary:f2} {e.email} {e.age}");
            }

        }
    }
}
