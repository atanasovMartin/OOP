using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class START
    {
        static void Main()
        {
            var numOfCars = int.Parse(Console.ReadLine());
            var cars = new List<car>();


            for (int i = 0; i < numOfCars; i++)
            {
                var carsInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



                string model = carsInfo[0];
                int speed = int.Parse(carsInfo[1]);
                int power = int.Parse(carsInfo[2]);
                int weight = int.Parse(carsInfo[3]);
                string type = carsInfo[4];
                double tyre1Pressure = double.Parse(carsInfo[5]);
                int tyre1Age = int.Parse(carsInfo[6]);
                double tyre2Pressure = double.Parse(carsInfo[7]);
                int tyre2Age = int.Parse(carsInfo[8]);
                double tyre3Pressure = double.Parse(carsInfo[9]);
                int tyre3Age = int.Parse(carsInfo[10]);
                double tyre4Pressure = double.Parse(carsInfo[11]);
                int tyre4Age = int.Parse(carsInfo[12]);


                cars.Add(new car(model,
                    new engine(speed, power),
                    new Cargo(type, weight),
                    new List<tyre> { new tyre(tyre1Pressure, tyre1Age),
                        new tyre(tyre2Pressure, tyre2Age),
                        new tyre(tyre3Pressure, tyre3Age),
                        new tyre(tyre4Pressure, tyre4Age) }));
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.cargo.Type == "fragile")
               .Where(c => c.tyres.Any(t => t.Pressure < 1))
               .Select(c => c.model)
               .ToList()
               .ForEach(m => Console.WriteLine(m));


            }               
            
            else
            {
                cars.Where(c => c.cargo.Type == "flamable")
                    .Where(c => c.engine.Power > 250)
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(model => Console.WriteLine(model));
            }


        }
    }
}
