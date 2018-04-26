namespace Wild_farm
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void Eat(Food food)
        {
            {
                if (food is Meat)
                {
                    throw new ApplicationException($"{this.GetType().Name}s are not eating that type of food!");
                }
                base.Eat(food);
            }
        }

        public override string ToString()
        {
            return
                $"{base.ToString()}[{base.AnimalName}, {base.AnimalWeight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
