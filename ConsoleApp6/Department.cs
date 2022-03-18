using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Department
    {
        public string Name;
        public int EmployeeLimit;
        public int SalaryLimit;
        public Employee[] Employees=new Employee[0];
        public void AddEmployee(Employee employee)
        {
            if(this.Employees.Length < this.EmployeeLimit)
            {
                if (employee.Salary > this.SalaryLimit || employee.Salary<250)
                {
                    throw new Exception($"Maas 250 manata qederdir");

                }
                else
                {
                    Array.Resize(ref this.Employees, this.Employees.Length+1);
                    this.Employees[this.Employees.Length - 1] = employee;   
                }

            }
            else
            {
                throw new Exception($"Limiti kecmisiz!");
            }
        }
    }
}
