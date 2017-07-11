namespace DefineClass_Exercise
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Start
    {
        public static void Main()

        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");

            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

            if (oldestMemberMethod == null || addMemberMethod == null)

            {

                throw new Exception();

            }

            int input = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < input; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var personName = personInfo[0];
                var personAge =  int.Parse(personInfo[1]);

                var person = new Person(personName, personAge);
                family.AddMember(person);

            }   
            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.name} {oldestPerson.age}");


        }
    }
}
