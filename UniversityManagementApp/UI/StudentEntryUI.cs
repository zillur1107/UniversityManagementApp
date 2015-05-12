using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementApp.Model;
using UniversityManagementApp.BLL;

namespace UniversityManagementApp.UI
{
    public partial class StudentEntryUI : Form
    {
        StudentManager aStudentManager = new StudentManager();
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Name = studentNameTextBox.Text;
            student.RegNo = regNoTextBox.Text;
            student.DepartmentId = int.Parse(departmentComboBox.Text.ToString());
            student.Address = addressTextBox.Text;

            if (aStudentManager.Insert(student))
            {
                MessageBox.Show("Student Informaton Save Successfully");
                student.Name = String.Empty;
                student.RegNo = String.Empty;
                student.Address = String.Empty;
            }
        }
    }
}
