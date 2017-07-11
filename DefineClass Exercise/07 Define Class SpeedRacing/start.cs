namespace _07_SpeedRacing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class start
    {
        public static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var car = new Car(
                carInfo[0],
                double.Parse(carInfo[1]),
                double.Parse(carInfo[2])
                );


                cars.Add(car);

            }

            string cmmnd;

            while ((cmmnd = Console.ReadLine()) != "End")
            {
                var tokens = cmmnd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                var distance = double.Parse(tokens[2]);
  
                cars.Where(c => c.Model == model).ToList().ForEach(c => c.Drive(distance));

            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.DistanceTraveled}");
            }

        }

    }
}

