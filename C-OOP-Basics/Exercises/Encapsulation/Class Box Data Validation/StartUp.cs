namespace Class_Box_Data_Validation
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box myBox = new Box(length, width, height);
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            Console.WriteLine($"Surface Area - {myBox.Surface_Area():f2}");
            Console.WriteLine($"Lateral Surface Area - {myBox.Lateral_Surface_Area():f2}");
            Console.WriteLine($"Volume - {myBox.Volume():f2}");
        }
    }
}
