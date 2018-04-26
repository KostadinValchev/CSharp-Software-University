namespace Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> myCarsList = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                var items = Console.ReadLine().Split();

                string model = items[0];
                int engineSpeed = int.Parse(items[1]);
                int enginePower = int.Parse(items[2]);
                int cargoWeight = int.Parse(items[3]);
                string cargoType = items[4];


                double tire1Pressure = double.Parse(items[5]);

                int tire1Age = int.Parse(items[6]);

                double tire2Pressure = double.Parse(items[7]);

                int tire2Age = int.Parse(items[8]);

                double tire3Pressure = double.Parse(items[9]);

                int tire3Age = int.Parse(items[10]);

                double tire4Pressure = double.Parse(items[11]);

                int tire4Age = int.Parse(items[12]);

                Car myCar = new Car(model);
                Engine myEngine = new Engine(enginePower, engineSpeed);
                Cargo myCargo = new Cargo(cargoWeight, cargoType);
                Tire myTires = new Tire(tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                myCar.Engine = myEngine;
                myCar.Cargo = myCargo;
                myCar.Tire = myTires;

                myCarsList.Add(myCar);
            }

            string command = Console.ReadLine();
            var fragile = myCarsList.FindAll(c => c.Cargo.CargoType == command)
                .Where(t => t.Tire.Tire1Pressure < 1 && t.Tire.Tire2Pressure < 1
                            && t.Tire.Tire3Pressure < 1 && t.Tire.Tire4Pressure < 1)
                .ToArray();

            var flamable = myCarsList.FindAll(c => c.Cargo.CargoType == command)
                .Where(e => e.Engine.EnginePower > 250)
                .ToArray();

            if (command == "fragile")
            {
                foreach (var v in fragile)
                {
                    Console.WriteLine($"{v.Model}");
                }
            }
            else
            {
                foreach (var v in flamable)
                {
                    Console.WriteLine($"{v.Model}");
                }

            }  
        }
    }
}
