namespace Date_Modifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();

            DateModifier.CalculatesDays(firstLine, secondLine);   
        }
    }
}
