using System;

namespace DefineClass_Exercise
{
    public class Person : IComparable<Person>
    {
        public string name;
      
        public int age;

       
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
