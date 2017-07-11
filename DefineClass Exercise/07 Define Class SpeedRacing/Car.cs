using System.Collections.Generic;
using System;
namespace _07_SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuel;
        private double consumPer1km;
        private double distanceTraveled;

        public Car(string model, double fuel, double consumPer1km)
        {
            this.model = model;
            this.fuel = fuel;
            this.consumPer1km = consumPer1km;
            this.distanceTraveled = 0;
        }
        public string Model
        {
            get => this.model; set { this.model = value; }
        }
        public double Fuel
        {
            get => this.fuel; set { this.fuel = value; }
        }
        public double ConsumPer1km
        {
            get => this.consumPer1km; set { this.consumPer1km = value; }
        }
        public double DistanceTraveled
        {
            get {  return this.distanceTraveled; }
            set { this.distanceTraveled = value; }
        }
        public void Drive(double distance)
        {
            if (this.fuel < distance * this.consumPer1km)
            {
                Console.WriteLine("Insufficient fuel for the drive");  
            }
            else
            {
                this.fuel -= distance * this.consumPer1km;
                this.distanceTraveled += distance;
            }


        }
    }
}
