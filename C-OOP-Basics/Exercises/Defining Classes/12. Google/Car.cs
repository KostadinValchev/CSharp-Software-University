namespace Google
{
    public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }
        public string Model { get; set; }
        public long Speed { get; set; }
    }
}
