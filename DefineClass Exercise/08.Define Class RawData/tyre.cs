namespace RawData
{
    public class tyre
    {
        private double pressure;
        private int age;

        public tyre(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }

        public double Pressure
        {
             get { return pressure; }
             set { this.pressure = value;}
        }           
    }
}
