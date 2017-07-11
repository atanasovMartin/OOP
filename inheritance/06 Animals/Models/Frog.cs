using System;
using _06.Animals.Models;

namespace _06.Models
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }
        public override string ProduceSound()
        {
            return "Forggg";
        }
    }
}
