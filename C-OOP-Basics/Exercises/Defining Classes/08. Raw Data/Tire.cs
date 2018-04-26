namespace Raw_Data
{
    public class Tire
    {
        private double tire1Pressure;

        private int tire1Age;

        private double tire2Pressure;

        private int tire2Age;

        private double tire3Pressure;

        private int tire3Age;

        private double tire4Pressure;

        private int tire4Age;

        public Tire(double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.tire1Pressure = tire1Pressure;
            this.tire1Age = tire1Age;
            this.tire2Pressure = tire2Pressure;
            this.tire2Age = tire2Age;
            this.tire3Pressure = tire3Pressure;
            this.tire3Age = tire3Age;
            this.tire4Pressure = tire4Pressure;
            this.tire4Age = tire4Age;
        }

        public double Tire1Pressure
        {
            get { return this.tire1Pressure; }
            set { this.tire1Pressure = value; }
        }

        public int Tire1Age
        {
            get { return this.tire1Age; }
            set { this.tire1Age = value; }
        }

        public double Tire2Pressure
        {
            get { return this.tire2Pressure; }
            set { this.tire2Pressure = value; }
        }

        public int Tire2Age
        {
            get { return this.tire2Age; }
            set { this.tire2Age = value; }
        }

        public double Tire3Pressure
        {
            get { return this.tire3Pressure; }
            set { this.tire3Pressure = value; }
        }

        public int Tire3Age
        {
            get { return this.tire3Age; }
            set { this.tire3Age = value; }
        }

        public double Tire4Pressure
        {
            get { return this.tire3Pressure; }
            set { this.tire3Pressure = value; }
        }

        public int Tire4Age
        {
            get { return this.tire3Age; }
            set { this.tire3Age = value; }
        }
    }
}
