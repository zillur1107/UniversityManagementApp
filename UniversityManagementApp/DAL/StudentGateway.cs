using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.DAL
{
    internal class StudentGateway
    {
        Student aStudent = new Student();
        private string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;

        public int Insert(Student student)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Students VALUES('" + aStudent.Name + "," + aStudent.RegNo + "," + aStudent.DepartmentId + "," + aStudent.Address + "')";

            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;
        }

    }
}
