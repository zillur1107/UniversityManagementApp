using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementApp.DAL;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.BLL
{
    class StudentManager
    {
        StudentGateway studentGateway = new StudentGateway();
        public bool Insert(Student student)
        {
            return studentGateway.Insert(student) > 0;
        }
    }
}
