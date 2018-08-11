using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem.Model
{
    class University
    {
        public University()
        {
            departments=new List<Department>();
            students=new List<Student>();
        }
        private List<Department> departments;
        private List<Student> students;

        public void AddStudent(Student student)
        {
            if (student==null)
            {
                MessageBox.Show("Student not Added!");
                return;
            }
            students.Add(student);
        }
        public void AddDepartment(Department department)
        {
            if (department == null)
            {
                MessageBox.Show("Department not Added!");
                return;
            }
            departments.Add(department);
        }

        public List<Student> GetStudents(string department)
        {
            if (department == null)
            {
                MessageBox.Show("Particular department not found!");
                return null;
            }
            List<Student> studentList=new List<Student>();
            foreach (var item in students)
            {
                if (item.DepartmentCode == department)
                {
                    studentList.Add(item);
                }
            }
            return studentList;
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }
        
    }
}
