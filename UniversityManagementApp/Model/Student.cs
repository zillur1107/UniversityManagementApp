using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementApp.Model
{
    class Student
    {
        public int Id { set; get; }

        public string RegNo { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }

        public int DepartmentId { set; get; }
    }
}
