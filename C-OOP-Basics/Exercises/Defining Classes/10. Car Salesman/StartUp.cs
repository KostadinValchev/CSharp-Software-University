namespace Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < engineCount; i++)
            {
                string[] command =
                    Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command.Length == 2)
                {
                    //“<Model> <Power> <Displacement> <Efficiency>
                    Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]));
                    engines.Add(currentEngine);
                }

                if (command.Length == 3)
                {
                    int disp = 0;
                    int.TryParse(command[2], out disp);
                    if (disp != 0)
                    {
                        //<Model> <Power> <Displacement>
                        Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]), displacement: command[2]);
                        engines.Add(currentEngine);
                    }
                    else
                    {
                        //“<Model> <Power> <Efficiency>
                        Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]), efficiency: command[2]);
                        engines.Add(currentEngine);
                    }
                }

                if (command.Length == 4)
                {
                    //“<Model> <Power> <Displacement> <Efficiency>
                    Engine currentEngine = new Engine(model: command[0], power: int.Parse(command[1]), efficiency: command[3], displacement: command[2]);
                    engines.Add(currentEngine);
                }
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                string[] command =
                    Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine eng = engines.FirstOrDefault(x => x.Model == command[1]);

                if (command.Length == 2)
                {
                    //“<Model> <Engine> <Weight> <Color>
                    Car car = new Car(model: command[0], engine: eng);
                    cars.Add(car);
                }

                if (command.Length == 3)
                {
                    int wei = 0;
                    int.TryParse(command[2], out wei);

                    if (wei != 0)
                    {
                        Car car = new Car(model: command[0], engine: eng, weight: int.Parse(command[2]));

                        //“<Model> <Engine> <Weight> 
                        cars.Add(car);

                    }
                    else
                    {
                        //“<Model> <Engine> <Weight> <Color>
                        Car car = new Car(model: command[0], engine: eng, color: command[2]);
                        cars.Add(car);

                    }
                }

                if (command.Length == 4)
                {
                    //“<Model> <Engine> <Weight> <Color>
                    Car car = new Car(model: command[0], engine: eng, weight: int.Parse(command[2]), color: command[3]);
                    cars.Add(car);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");

                if (!string.IsNullOrEmpty(car.Engine.Displacement))
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else
                {
                    Console.WriteLine($"    Displacement: n/a");
                }

                if (!string.IsNullOrEmpty(car.Engine.Efficiency))
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }

                if (car.Weight != 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else
                {
                    Console.WriteLine($"  Weight: n/a");
                }

                if (!string.IsNullOrEmpty(car.Color))
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else
                {
                    Console.WriteLine($"  Color: n/a");
                }
            }
        }
    }
}
