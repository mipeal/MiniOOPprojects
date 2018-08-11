using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySystem.Model
{
    class Salary
    {
        double _increment;
        double _salary;
        double _basicSalary;
        double _medicalExpense;
        double _conveyanceExpense;
        public Salary(Employee employee)
        {
            _increment = employee.Increment;
        }
        public double ConveyanceExpense { get => GetConveyanceExpense(_basicSalary); set =>_conveyanceExpense = value; }
        public double MedicalExpense { get => GetMedicalExpense(_basicSalary); set => _medicalExpense=value; }
        public double BasicSalary {   get => GetBasicSalary(_basicSalary, _increment); set => _basicSalary = value; }

        private double GetBasicSalary(double basicSalary,double increment)
        {
            return _basicSalary += (basicSalary / 100) * increment;
        }
        private double GetMedicalExpense(double basicSalary)
        {
            return (basicSalary / 100) * _medicalExpense;
        }
        private double GetConveyanceExpense(double basicSalary)
        {
            return (basicSalary / 100) * _conveyanceExpense;
        }

        public double GetSalary(double increment)
        {
            _salary = GetBasicSalary(_basicSalary,increment) + GetMedicalExpense(_basicSalary) + GetConveyanceExpense(_basicSalary);
            return _salary;
        }

    }
}
