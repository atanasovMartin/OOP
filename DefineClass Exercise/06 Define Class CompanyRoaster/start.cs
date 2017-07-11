using System;
using System.Collections.Generic;
using System.Linq;
using Company_Roaster;

namespace Company_Roaster
{
    public class start

    {
        public static void Main()
        {

            var employeeLines = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < employeeLines; i++)
            {
                var employeeInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var employe = new Employee(
                   employeeInfo[0],
                   decimal.Parse(employeeInfo[1]),
                   employeeInfo[2],
                   employeeInfo[3]);

                if (employeeInfo.Length > 4)
                {
                    var ageOrEmail = employeeInfo[4];
                    if (ageOrEmail.Contains("@"))
                    {
                        employe.Email = ageOrEmail;
                    }
                    else
                    {
                        employe.Age = int.Parse(ageOrEmail);
                    }

                }
                if (employeeInfo.Length > 5)
                {
                    employe.Age = int.Parse(employeeInfo[5]);
                }

                employees.Add(employe);
            }
            var result = employees
              .GroupBy(e => e.Department)
              .Select(e => new
              {
                  Department = e.Key,
                  AverageSalary = e.Average(emp => emp.Salary),
                  Employes = e

              })
              .OrderByDescending(emp => emp.AverageSalary)  
              .FirstOrDefault();
            
            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (var employee in result.Employes.OrderByDescending(em => em.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }

}
