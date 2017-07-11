using System;
using System.Collections.Generic;
using System.Linq;


namespace DefineClass_Exercise
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }


        public void AddMember(Person member)
        {
            members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.members
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
        }
    }
}


