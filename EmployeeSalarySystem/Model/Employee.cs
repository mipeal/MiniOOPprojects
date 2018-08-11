using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySystem.Model
{
    class Employee
    {
        public Employee()
        {
            Increment = 0;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Increment { get; set; }
        public Salary employeeSalary = null;
        public double EmployeeBasicSalary { get => employeeSalary.BasicSalary; }
        public double EmployeeConveyanceExpense { get => employeeSalary.ConveyanceExpense; }
        public double EmployeeMedicalExpense { get => employeeSalary.MedicalExpense;  }

        public double GetEmployeeSalary()
        {
            if (employeeSalary==null)
            {
                throw new Exception("Sorry.....!!");
            }
            return employeeSalary.GetSalary(Increment);
        }
    }
}
