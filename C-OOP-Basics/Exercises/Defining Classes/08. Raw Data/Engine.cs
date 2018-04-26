namespace Raw_Data
{
    public class Engine
    {
        private int enginePower;
        private int engineSpeed;

        public Engine(int enginePower, int engineSpeed)
        {
            this.enginePower = enginePower;
            this.engineSpeed = engineSpeed;
        }

        public int EnginePower
        {
            get { return this.enginePower; }
            set { this.enginePower = value; }
        }

        public int EngineSpeed
        {
            get { return this.engineSpeed; }
            set { this.engineSpeed = value; }
        }
    }
}
