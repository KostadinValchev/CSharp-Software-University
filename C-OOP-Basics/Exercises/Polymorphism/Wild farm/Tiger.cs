namespace Wild_farm
{
    using System;

    public class Tiger : Felime
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                throw new ApplicationException("Tigers are not eating that type of food!");
            }

            base.Eat(food);
        }

        public override string ToString()
        {
            return
                $"{base.ToString()}[{base.AnimalName}, {base.AnimalWeight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
