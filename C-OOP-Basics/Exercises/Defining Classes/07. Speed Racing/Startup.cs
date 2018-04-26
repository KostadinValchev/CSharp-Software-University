namespace Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int carsNumber = int.Parse(Console.ReadLine());
            List<Car> myCars = new List<Car>();

            for (int i = 0; i < carsNumber; i++)
            {
                var inputItems = Console.ReadLine().Split().ToArray();
                string model = "";
                double fuelAmount = double.Parse(inputItems[1]);
                double costPerKm = double.Parse(inputItems[2]);

                var car = new Car(inputItems[0], fuelAmount, costPerKm);
                myCars.Add(car);
            }

            var cmd = Console.ReadLine();

            while (cmd != "End")
            {
                var command = cmd.Split().ToArray();
                var currentCar = myCars.Find(n => n.model == command[1]);

                Car.Drive(currentCar, double.Parse(command[2]));
                cmd = Console.ReadLine();
            }

            foreach (Car v in myCars)
            {
                Console.WriteLine($"{v.model} {v.fuelAmount:f2} {v.distanceTraveled}");
            }

        }
    }
}
