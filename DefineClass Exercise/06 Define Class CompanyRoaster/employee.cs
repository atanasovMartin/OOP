namespace Company_Roaster
{
    public class Employee
    {
        private string name;
        private int age;
        private decimal salary;
        private string position;
        private string department;
        private string email;

        public Employee(string name,
            decimal salary,
            string position,
            string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }

        public string Name
        {
            get => this.name; set { this.name = value; }
        }
        public int Age
        {
            get => this.age; set { this.age = value; }
        }
        public string Department
        {
            get => this.department; set => department = value;
        }
        public string Email
        {
            get => this.email; set { email = value; }
        }
        public decimal Salary
        {
            get => salary; set { salary = value; }
        }
        public string Position
        {
            get => position; set { position = value; }

        }

    }
}