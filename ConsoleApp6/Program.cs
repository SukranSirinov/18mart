using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Name = "Taleh ",
                Surname = "Imanov",
                Salary = 20
            };
            Employee employee2 = new Employee()
            {
                Name = "Famil ",
                Surname = "Yahyayev",
                Salary = 1000
            };
            Employee employee3 = new Employee()
            {
                Name = "Adem ",
                Surname = "Osmanov",
                Salary = 500
            };
            Employee employee4 = new Employee()
            {
                Name = "Nazim",
                Surname = "Resulov",
                Salary = 2000
            };
            Employee employee5 = new Employee()
            {
                Name = "Taleh ",
                Surname = "Imanov",
                Salary = 700
            };
            Department department = new Department()
            {
                Name = "Socar",
                EmployeeLimit = 3,
                SalaryLimit = 4000
            };

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };
            foreach (Employee employee in employees )
            {
                try
                {
                    department.AddEmployee(employee);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Isciler");
            foreach (var item in department.Employees)
            {
                Console.WriteLine($"Employee: {item.Name} Employee: {item.Surname} Employee: {item.Salary}");
            }

        }



    }

    
}


