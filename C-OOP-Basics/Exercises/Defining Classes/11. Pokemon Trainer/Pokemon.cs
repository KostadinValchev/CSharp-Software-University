namespace Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private double health;

        public string Name { get { return this.name; } set { this.name = value; } }
        public string Element { get { return this.element; } set { this.element = value; } }
        public double Health { get { return this.health; } set { this.health = value; } }
    }
}