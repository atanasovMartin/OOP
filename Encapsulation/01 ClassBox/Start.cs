using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace _01
{
    public class Program
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());


            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            box.SurfaceArea();
            box.LateralSurfaceArea();
            box.Volume();

        }
    }
}
