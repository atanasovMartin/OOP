namespace _06.StrategyPatterns
{
    using System;
    using System.Collections.Generic;

    public class Start
    {
        public static void Main()
        {
            SortedSet<Person> peopleSortedByName = new SortedSet<Person>(new NameComparator());
            SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new AgeComparators());

            int peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var tokens = Console.ReadLine().Split(' ');

                Person person = new Person(tokens[0],int.Parse(tokens[1]));

                peopleSortedByName.Add(person);
                peopleSortedByAge.Add(person);


            }

            foreach (var person in peopleSortedByName)
            {
                Console.WriteLine(person);
            }
            foreach (var person in peopleSortedByAge)
            {
                Console.WriteLine(person);
            }


        }
    }
}
