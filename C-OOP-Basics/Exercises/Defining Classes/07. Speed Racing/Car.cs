namespace Speed_Racing
{
    using System;

    public class Car
    {

        public string model;
        public double fuelAmount;
        public double costPerKm;
        public double distanceTraveled;

        public Car(string model, double fuelAmount, double costPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.costPerKm = costPerKm;
            this.distanceTraveled = 0;
        }

        public static void Drive(Car model, double distance)
        {

            if (model.fuelAmount < distance * model.costPerKm)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                model.fuelAmount -= distance * model.costPerKm;
                model.distanceTraveled += distance;
            }

        }
    }
}


