using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityManagementApp.BLL;
using UniversityManagementApp.Model;

namespace UniversityManagementApp
{
    public partial class DepartmentEntryUI : Form
    {
        DepartmentManager departmentmanager = new DepartmentManager();
        public DepartmentEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            Department department = new Department();

            department.Name = nameEntryTextBox.Text;

            if (departmentmanager.Insert(department))
            {
                MessageBox.Show("Department Inserted Successfully");
                nameEntryTextBox.Clear();
            }
        }
    }
}
