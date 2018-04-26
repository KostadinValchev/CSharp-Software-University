namespace Raw_Data
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }

        public string CargoType
        {
            get { return this.cargoType; }
            set { this.cargoType = value; }
        }

        public int CargoWeight
        {
            get { return this.cargoWeight; }
            set { this.cargoWeight = value; }
        }

    }
}
