namespace Date_Modifier
{
    using System;
    using System.Linq;

    public class DateModifier
    {
        public DateTime date;

        public DateModifier(DateTime date)
        {
            this.date = date;
        }

        public static void CalculatesDays(string date1, string date2)
        {
            var firstDate = date1.Split().ToArray();
            var secondDate = date2.Split().ToArray();
            DateTime date111 = new DateTime(int.Parse(firstDate[0]), int.Parse(firstDate[1]), int.Parse(firstDate[2]));
            DateTime date211 = new DateTime(int.Parse(secondDate[0]), int.Parse(secondDate[1]), int.Parse(secondDate[2]));

            TimeSpan t = date111 - date211;
            double NrOfDays = Math.Abs(t.TotalDays);
            Console.WriteLine(NrOfDays);
        }
    }
}
