using EmployeeSalarySystem.Model;
using System;
using System.Windows.Forms;

namespace EmployeeSalarySystem
{
    public partial class ESSUI : Form
    {
        double noOfIncrement = 0;
        Employee employee;
        public ESSUI()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                employee = new Employee();
                employee.Id = Convert.ToInt32(idTextBox.Text);
                employee.Name = nameTextBox.Text;
                employee.Email = emailTextBox.Text;
                employee.employeeSalary = new Salary(employee);
                employee.employeeSalary.BasicSalary = Convert.ToDouble(basicTextBox.Text);
                employee.employeeSalary.ConveyanceExpense = Convert.ToDouble(conveyanceTextBox.Text);
                employee.employeeSalary.MedicalExpense = Convert.ToDouble(medicalTextBox.Text);
                
                if (employee!=null)
                {
                    incrementTextBox.Text = employee.Increment.ToString();
                    MessageBox.Show("Succesfully Saved!");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }   
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                MessageBox.Show("No employee found!");
                return;
            }
            displayTotalTextBox.Text = employee.GetEmployeeSalary().ToString();
            noOfIncrementTextBox.Text = noOfIncrement.ToString();
            displayBasicTextBox.Text = employee.EmployeeBasicSalary.ToString();
            displayConveyanceTextBox.Text = employee.EmployeeConveyanceExpense.ToString();
            displayMedicalTextBox.Text = employee.EmployeeMedicalExpense.ToString();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            employee.Increment = Convert.ToDouble(incrementTextBox.Text);
            noOfIncrement++;
        }
    }
}
