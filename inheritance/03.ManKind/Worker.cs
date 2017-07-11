namespace ManKind
{
    using System;
    using System.Text;
    using Mankind;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workingHours;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }
        public decimal WeekSalary
        {
            get => this.weekSalary;

            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument:weekSalary");
                }
                this.weekSalary = value;
            }

        }
        public decimal WorkingHours
        {
            get => this.workingHours;

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHours = value;
            }
        }
        public decimal SalaryPerHour()
        {
            var result = (this.WeekSalary / 5) / this.WorkingHours;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
                  sb.Append($"First Name: {base.FirstName}")
                .AppendLine($"Last Name: {base.LastName}")      
                .AppendLine($"Week Salary: {this.WeekSalary:F2}")
                .AppendLine($"Hours per day: {this.WorkingHours:F2}")
                .Append($"Salary per hour: {SalaryPerHour():F2}");

            return sb.ToString();
        }

   

    }
}
