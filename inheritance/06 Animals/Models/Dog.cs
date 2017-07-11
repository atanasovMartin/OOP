using System;
using _06.Animals.Models;

namespace _06.Models
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public override string ProduceSound()
        {
            return "BauBau";
        }
    }
    
}
