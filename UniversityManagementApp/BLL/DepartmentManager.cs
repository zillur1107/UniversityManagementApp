using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementApp.DAL;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.BLL
{
    class DepartmentManager
    {
        DepartmentGateway departmentGateway = new DepartmentGateway();

        public bool Insert(Department department)
        {
            return departmentGateway.Insert(department) > 0;
        }

    }
}
