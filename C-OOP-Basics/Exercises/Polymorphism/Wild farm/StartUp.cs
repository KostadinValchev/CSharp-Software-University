namespace Wild_farm
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    return;
                }

                var animalData = input.Split(new char[] { ' ' }).ToArray();

                var animalType = animalData[0];
                var animalName = animalData[1];
                var animalWeight = double.Parse(animalData[2]);
                var animalLivingRegion = animalData[3];
                string catBreed = "";
                if (animalType == "Cat")
                {
                    catBreed = animalData[4];
                }

                var animal = TryAnimalCreate(animalType, animalName, animalWeight, animalLivingRegion, catBreed);
                animal.MakeSound();
                var foodData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
                var foodType = foodData[0];
                var foodQuantity = int.Parse(foodData[1]);
                var food = CreateFood(foodType, foodQuantity);
                try
                {
                    animal.Eat(food);
                }
                catch (ApplicationException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                Console.WriteLine(animal);
            }
        }
        private static Food CreateFood(string foodType, int foodQuantity)
        {
            if (foodType == "Vegetable")
            {
                return new Vegetable(foodQuantity);
            }

            return new Meat(foodQuantity);

        }

        private static Mammal TryAnimalCreate(string animalType, string animalName, double animalWeight, string animalLivingRegion, string catBreed)
        {
            Mammal result = null;
            switch (animalType)
            {
                case "Mouse":
                    result = new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                    break;
                case "Zebra":
                    result = new Zebra(animalName, animalType, animalWeight, animalLivingRegion);
                    break;
                case "Cat":
                    result = new Cat(animalName, animalType, animalWeight, animalLivingRegion, catBreed);
                    break;
                case "Tiger":
                    result = new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                    break;
            }

            return result;
        }
    }
}
