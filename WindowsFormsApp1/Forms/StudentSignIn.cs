using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class StudentSignIn : Form
    {
        public StudentSignIn()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=SSPI;";
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0 || surnameTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0 || ageTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please write something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = nameTextBox.Text.Trim();
            string surname = surnameTextBox.Text.Trim();
            int age = Convert.ToInt32(ageTextBox.Text.Trim());
            string password = passwordTextBox.Text.Trim();

            SqlConnection conn = new SqlConnection(connectionString);
            ServerDecoder serverDecoder = new ServerDecoder(conn);

            if (checkStudent(serverDecoder.getStudents(), name, surname, age, password)) 
            {
                using (conn)
                {
                    conn.Open();
                    string query = "INSERT INTO Students (StudentName, StudentSurname, StudentAge, StudentPassword) VALUES (@Name,@Surname, @Age, @Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Password", password);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("This student is already registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        private bool checkStudent(List<Student> students, string name, string surname, int age, string password)
        {
            for(int i = 0; i < students.Count(); i++)
            {
                Student student = students[i];
                if (name.Equals(student.getName()) && age == student.getAge() && password.Equals(student.getPassword()) && surname.Equals(student.getSurname())){
                    return false;
                }
            }
            return true;  
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
    }
}
