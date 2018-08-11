using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Model;

namespace UniversitySystem
{
    public partial class UniversitySystemUI : Form
    {
        University university=new University();
        private Department department;
        private Student student;
        List<Department> departmentList = new List<Department>();
        List<Student> studentList = new List<Student>();
        string deptCode = null;
        public UniversitySystemUI()
        {
            departmentList = university.GetDepartments();
            InitializeComponent();
            studentDeptComboBox.Text = @"Select";
            deptComboBox.Text = @"Select";
        }

        private void DeptSaveButton_Click(object sender, EventArgs e)
        {
            department=new Department();
            department.Code = codeTextBox.Text;
            department.Name = deptNameTextBox.Text;
            
            university.AddDepartment(department);
            MessageBox.Show("Department Added!");
            codeTextBox.Text = "";
            deptNameTextBox.Text = "";
        }

        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
            student=new Student();
           
            student.RegNo = Convert.ToInt32(regNoTextBox.Text);
            student.Name = nameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.DepartmentCode = studentDeptComboBox.SelectedValue.ToString();
            MessageBox.Show("Student Added!");
            university.AddStudent(student);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            studentList = university.GetStudents(deptComboBox.SelectedValue.ToString());
            string output=string.Join("\n","Reg. No  Name      Email\n");
            foreach (var item in studentList)
            {
                output += item.RegNo + " \t" + item.Name + " \t" + item.Email + "\n";
            }
            MessageBox.Show("Student of Selected Departments are:"+Environment.NewLine
                            +output);
        }

        private void studentDeptComboBox_Click(object sender, EventArgs e)
        {
            studentDeptComboBox.DataSource = departmentList;
            studentDeptComboBox.ValueMember = "Code";
            studentDeptComboBox.DisplayMember = "Name";
        }

        private void deptComboBox_Click(object sender, EventArgs e)
        {
                deptComboBox.DataSource = departmentList;
            deptComboBox.ValueMember = "Code";
            deptComboBox.DisplayMember = "Name";
        }
    }
}
