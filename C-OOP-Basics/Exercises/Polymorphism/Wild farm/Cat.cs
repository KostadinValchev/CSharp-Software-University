namespace Wild_farm
{
    using System;

    public class Cat : Felime
    {
        private string breed;

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        private string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return
                $"{base.ToString()}[{base.AnimalName}, {this.breed}, {base.AnimalWeight}, {base.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
