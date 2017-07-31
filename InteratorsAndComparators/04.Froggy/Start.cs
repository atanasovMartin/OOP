using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new [] { ',',' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Lake myLake = new Lake(input);

            Console.WriteLine(String.Join(", ",myLake));

   
           
        }
    }
}
