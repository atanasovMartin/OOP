namespace DefineClass_Exercise
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Start
    {
        public static void Main()

        {
            List<Person> personList = new List<Person>();
            int input = int.Parse(Console.ReadLine());
   
            for (int i = 0; i < input; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var personName = personInfo[0];
                var personAge =  int.Parse(personInfo[1]);
                
                var @newPerson = new Person(personName, personAge);

                if (personAge > 30)
                {
                    personList.Add(newPerson);
                }

            }

            personList.Sort((a, b) => a.name.CompareTo(b.name));
            personList.ForEach(p => Console.WriteLine($"{p.name} - {p.age}"));
        
        }
    }
}
