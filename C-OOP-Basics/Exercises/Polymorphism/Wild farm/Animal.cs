namespace Wild_farm
{
   public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
        }

        protected int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }


        protected double AnimalWeight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }


        protected string AnimalType
        {
            get { return this.animalType; }
            set { this.animalType = value; }
        }


        protected string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        public abstract void MakeSound();

        public virtual void Eat(Food food)
        {
            this.foodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
