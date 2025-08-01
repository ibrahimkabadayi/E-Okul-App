using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class ServerDecoder
    {
        SqlConnection conn;
        List<Student> students;
        List<Teacher> teachers;
        List<Grades> grades;

        public ServerDecoder(SqlConnection conn)
        {
            this.conn = conn;
            students = returnAllStudents(conn);
            teachers = returnAllTeachers(conn);
            grades = returnAllGrades(conn);
        }

        private List<Student> returnAllStudents(SqlConnection conn)
        {
            List<Student> students = new List<Student>();
            conn.Open();
            string Quary = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(@Quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["StudentId"]);
                string name = reader["StudentName"].ToString();
                string surname = reader["StudentSurname"].ToString();
                int age = Convert.ToInt32(reader["StudentAge"]);
                string password = reader["StudentPassword"].ToString();
                Student student = new Student(id, name, surname, age, password);
                students.Add(student);
            }
            conn.Close();
            return students;
        }

        private List<Teacher> returnAllTeachers(SqlConnection conn)
        {
            List<Teacher> teachers = new List<Teacher>();
            conn.Open();
            string Quary = "SELECT * FROM Teachers";
            SqlCommand cmd = new SqlCommand(@Quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["Name"].ToString();
                string surname = reader["Surname"].ToString();
                string subject = reader["Subject"].ToString();
                string password = reader["Password"].ToString();
                Teacher teacher = new Teacher(id, name, surname, subject, password);
                teachers.Add(teacher);
            }
            conn.Close();
            return teachers;
        }

        private List<Grades> returnAllGrades(SqlConnection conn)
        {
            List<Grades> grades = new List<Grades>();
            conn.Open();
            string Quary = "SELECT * FROM Grades";
            SqlCommand cmd = new SqlCommand(@Quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["StudentId"]);

                // NULL değerleri kontrol et ve varsayılan değer ata
                double Math = reader["Math"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["Math"]);
                double Physics = reader["Physics"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["Physics"]);
                double Biology = reader["Biology"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["Biology"]);
                double Chemistry = reader["Chemistry"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["Chemistry"]);
                double History = reader["History"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["History"]);
                double English = reader["English"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["English"]);

                Grades grade = new Grades(id, Math, Physics, Chemistry, Biology, English, History);
                grades.Add(grade);
            }
            conn.Close();
            return grades;
        }

        public List<Student> getStudents() { return students; }
        public List<Teacher> getTeachers() { return teachers; }
        public List<Grades> getGrades() { return grades; }
    }
}
