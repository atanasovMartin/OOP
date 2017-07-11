namespace ManKind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Mankind.Human
    {
        private string facultyNum;

        public Student(string firtsName, string lastName, string facultyNum) : base(firtsName, lastName)
        {
            
            this.FacultyNum = facultyNum;
        }

        public string FacultyNum
        {
            get => this.facultyNum;

            set
            {
                    if (!value.All(char.IsLetterOrDigit) || value.Length < 5 || value.Length > 10)
                    {
                        throw new ArgumentException("Invalid faculty number!");
                    }

                    this.facultyNum = value;
                     
            }

        }
        public override string ToString()
        {
                 var sb = new StringBuilder();

                 sb.Append("First Name: ").AppendLine(this.FirstName)
                .Append("Last Name: ").AppendLine(this.LastName)
                .Append("Faculty number: ").Append($"{this.FacultyNum}")
               
                .AppendLine();
                 return sb.ToString();
        }
    }
}
