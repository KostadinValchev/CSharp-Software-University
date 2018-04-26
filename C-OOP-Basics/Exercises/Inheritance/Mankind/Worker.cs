namespace Mankind
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        private double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }

        //private override string LastName
        //{
        //    get { return base.LastName; }
        //    set
        //    {
        //        if (value.Length > 4)
        //        {
        //            throw new ArgumentException($"Expected length more than 3 symbols! Argument: {base.LastName}");

        //        }
        //        base.LastName = value;
        //    }
        //}

        private decimal SalaryPerHoure()
        {
            return this.weekSalary / (5 * Convert.ToDecimal(this.workHoursPerDay));
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nWeek Salary: {weekSalary:f2}\nHours per day: {WorkHoursPerDay:f2}\nSalary per hour: {SalaryPerHoure():f2}";
            //var sb = new StringBuilder();
            //sb.Append("First Name: ").AppendLine(this.firstName)
            //    .Append("Last Name: ").AppendLine(this.LastName)
            //    .Append("Week Salary: ").AppendLine($"{this.WeekSalary:f2}")
            //    .Append("Hours per day: ").AppendLine($"{this.WorkHoursPerDay:f2}")
            //    .Append("Salary per hour: ").AppendLine($"{SalaryPerHoure(this.WeekSalary, this.WorkHoursPerDay):f2}");
            //return sb.ToString();
        }
    }
}
