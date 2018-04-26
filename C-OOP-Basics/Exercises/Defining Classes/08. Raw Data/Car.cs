namespace Raw_Data
{
    public class Car
    {
        private string model;
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

        public Car(string model)
        {
            this.model = model;
        }

        public Tire Tire { get; set; }

        public string Model
        {
            get { return this.model; }

            set { this.model = value; }
        }
    }
}
