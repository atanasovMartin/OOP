using System;

public class Person : IComparable<Person>
{
    private string Name { get; set; }
    private int Age { get; set; }
    private string Town { get; set; }

    public Person(string name, int age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public int CompareTo(Person other)
    {
        var comparison = this.Name.CompareTo(other.Name);
        if (comparison != 0)
        {
            return comparison;
        }

        comparison = this.Age.CompareTo(other.Age);
        if (comparison != 0)
        {
            return comparison;
        }

        return this.Town.CompareTo(other.Town);

    }
}

