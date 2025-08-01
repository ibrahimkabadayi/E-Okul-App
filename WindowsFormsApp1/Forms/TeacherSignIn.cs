using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TeacherSignIn : Form
    {
        public TeacherSignIn()
        {
            InitializeComponent();
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainMenu)
                {
                    MainMenu mainMenu = (MainMenu)form;
                    mainMenu.ShowMainMenu();
                    break;
                }
            }
        }

        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=SSPI;";

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0 || surnameTextBox.Text.Length == 0 || subjectTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please write something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            string subject = subjectTextBox.Text.Trim(); 
            string password = passwordTextBox.Text.Trim();

            if (!IsValidSubject(subject))
            {
                MessageBox.Show("Subject must be one of: History, Math, Physics, English, Chemistry, Biology", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            ServerDecoder serverDecoder = new ServerDecoder(conn);

            if (checkTeacher(serverDecoder.getTeachers(), name, surname, subject, password))
            {
                using (conn)
                {
                    conn.Open();
                    string query = "INSERT INTO Teachers (Name, Surname, Subject, Password) VALUES (@Name,@Surname, @Subject, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Subject", subject);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Teacher registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("This teacher is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool IsValidSubject(string subject)
        {
            string[] validSubjects = { "History", "Math", "Physics", "English", "Chemistry", "Biology" };

            foreach (string validSubject in validSubjects)
            {
                if (subject.Equals(validSubject, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkTeacher(List<Teacher> teachers, string name, string surname, string subject, string password)
        {
            for (int i = 0; i < teachers.Count(); i++)
            {
                Teacher teacher = teachers[i];
                if (name.Equals(teacher.getName()) && subject.Equals(teacher.getSubject()) && password.Equals(teacher.getPassword()) && surname.Equals(teacher.getSurname()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
