using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdoDAL
{
    public class StudentDAL
    {
        private string _ConnectionString;

        public StudentDAL(string connectionString)
        { 
            _ConnectionString = connectionString;
        }

        public IEnumerable<Student> GetAllStudents()
        { 
            List<Student> students = new List<Student>();
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            { 
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                { 
                    Student student = new Student();
                    student.ID = (int)rdr["ID"];
                    student.Name = rdr["Name"].ToString();
                    student.Email = rdr["Email"].ToString();
                    student.Address = rdr["Address"].ToString();
                    student.Course = rdr["Course"].ToString();
                    student.Grades = (int)rdr["Grades"];

                    students.Add(student);
                }
            }

            return students;
        }
    }
}
