namespace Class_Box_Data_Validation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double Lateral_Surface_Area()
        {
            return (2 * (this.length * this.height)) + (2 * (this.width * this.height));

        }
        public double Surface_Area()
        {
            return (2 * (this.length * this.width)) + (2 * (this.length * this.height)) + (2 * (this.width * this.height));

        }
        public double Volume()
        {
            return (this.length * this.width) * this.height;
        }
        public double Lenght
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
    }
}
