namespace DefineClass_Exercise
{
    public class Person
    {
        public string name;

        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;

        }
        public Person(int age)
        {
            this.name = "No name";
            this.age = age;

        }
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

    }
}
