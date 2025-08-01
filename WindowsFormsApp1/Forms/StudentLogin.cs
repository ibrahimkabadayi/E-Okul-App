using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connectionString);
            ServerDecoder serverDecoder = new ServerDecoder(conn);

            if (nameTextBox.Text.Length == 0 || surnameTextBox.Text.Length == 0 || IdTextBox.Text.Length == 0 || passWordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please write something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text.Trim());
            int id = Convert.ToInt32(IdTextBox.Text.Trim());
            string password = passWordTextBox.Text;

            if (checkStudent(serverDecoder.getStudents(), name, surname, age, password)) 
            {
                List<Grades> allGrades = serverDecoder.getGrades();
                Grades studentGrades = findStudentGrade(allGrades, id);

                grades.Rows.Add(studentGrades.GetMath(), studentGrades.GetPhysics(), studentGrades.GetChemistiry(), studentGrades.GetBiology(), studentGrades.GetEnglish(), studentGrades.GetHistory());
                grades.Rows.Add(CalculateLetterGrade(studentGrades.GetMath()), CalculateLetterGrade(studentGrades.GetPhysics()), CalculateLetterGrade(studentGrades.GetChemistiry()), CalculateLetterGrade(studentGrades.GetBiology()), CalculateLetterGrade(studentGrades.GetEnglish()), CalculateLetterGrade(studentGrades.GetHistory()));
                grades.Rows.Add(CalculatePassingStatus(studentGrades.GetMath()), CalculatePassingStatus(studentGrades.GetPhysics()), CalculatePassingStatus(studentGrades.GetChemistiry()), CalculatePassingStatus(studentGrades.GetBiology()), CalculatePassingStatus(studentGrades.GetEnglish()), CalculatePassingStatus(studentGrades.GetHistory()));
            }
            else 
            {
                MessageBox.Show("There is no student with this data, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
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

        private bool checkStudent(List<Student> students, string name, string surname, int age, string password)
        {
            for (int i = 0; i < students.Count(); i++)
            {
                Student student = students[i];
                if (name.Equals(student.getName()) && age == student.getAge() && password.Equals(student.getPassword()) && surname.Equals(student.getSurname()))
                {
                    return false;
                }
            }
            return true;
        }

        private Grades findStudentGrade(List<Grades> grades, int id) 
        {
            for (int i = 0; i < grades.Count(); i++)
            {
                Grades grade = grades[i];

                if (grade.GetId() == id)
                {
                    return grade;
                }
            }
            return null;
        }

        private string CalculateLetterGrade(double numericGrade)
        {
            if (numericGrade >= 90) return "A";
            else if (numericGrade >= 80) return "B";
            else if (numericGrade >= 70) return "C";
            else if (numericGrade >= 60) return "D";
            else return "F";
        }

        private string CalculatePassingStatus(double numericGrade)
        {
            return numericGrade >= 60 ? "Pass" : "Fail";
        }
        
    }
}
