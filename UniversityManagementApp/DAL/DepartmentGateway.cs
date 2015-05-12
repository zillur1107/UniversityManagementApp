using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using UniversityManagementApp.Model;

namespace UniversityManagementApp.DAL
{
    class DepartmentGateway
    {

        
        
        Department department = new Department();
        public int Insert(Department department)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UniversityConString"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Departments VALUES('"+department.Name+"')";
            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
