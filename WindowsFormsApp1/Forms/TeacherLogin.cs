using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TeacherLogin : Form
    {
        private string teacherSubject; 
        public TeacherLogin()
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(connectionString);
            ServerDecoder serverDecoder = new ServerDecoder(conn);

            if (nameTextBox.Text.Length == 0 || surnameTextBox.Text.Length == 0 ||
                IdTextBox.Text.Length == 0 || passWordTextBox.Text.Length == 0 ||
                subjectTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please write something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string subject = subjectTextBox.Text.Trim();
            int id = Convert.ToInt32(IdTextBox.Text.Trim());
            string password = passWordTextBox.Text;

            if (checkTeacher(serverDecoder.getTeachers(), name, surname, subject, password, id))
            {
                teacherSubject = subject; 
                LoadStudentsWithGrades(serverDecoder);
                MessageBox.Show("Login successful! You can now edit grades for your subject: " + subject, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is no teacher with this data, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadStudentsWithGrades(ServerDecoder serverDecoder)
        {
            List<Student> students = serverDecoder.getStudents();
            List<Grades> allGrades = serverDecoder.getGrades();

            table.Rows.Clear();

            for (int i = 0; i < students.Count(); i++)
            {
                Student student = students[i];
                Grades studentGrades = FindStudentGrade(allGrades, student.getId());

                if (studentGrades != null)
                {                    
                    double currentGrade = GetGradeBySubject(studentGrades, teacherSubject);
                    string letterGrade = CalculateLetterGrade(currentGrade);
                    string passingStatus = CalculatePassingStatus(currentGrade);
                    
                    table.Rows.Add(
                        student.getId(),
                        student.getName(),
                        student.getSurname(),
                        currentGrade,
                        letterGrade,
                        passingStatus
                    );
                }
            }
        }

        private double GetGradeBySubject(Grades grades, string subject)
        {
            switch (subject.ToLower())
            {
                case "math":
                    return grades.GetMath();
                case "physics":
                    return grades.GetPhysics();
                case "chemistry":
                    return grades.GetChemistiry();
                case "biology":
                    return grades.GetBiology();
                case "english":
                    return grades.GetEnglish();
                case "history":
                    return grades.GetHistory();
                default:
                    return 0;
            }
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

        private void table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = table.Rows[e.RowIndex];

                    int newGrade = Convert.ToInt32(row.Cells[3].Value);
                   
                    if (newGrade < 0 || newGrade > 100)
                    {
                        MessageBox.Show("Grade must be between 0 and 100", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                  
                    string letterGrade = CalculateLetterGrade(newGrade);
                    string passingStatus = CalculatePassingStatus(newGrade);
                  
                    row.Cells[4].Value = letterGrade;   
                    row.Cells[5].Value = passingStatus; 
                   
                    int studentId = Convert.ToInt32(row.Cells[0].Value);
                    UpdateGradeInDatabase(studentId, newGrade);

                    MessageBox.Show($"Grade updated successfully!\nStudent ID: {studentId}\nGrade: {newGrade}\nLetter Grade: {letterGrade}\nStatus: {passingStatus}",
                                   "Grade Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateGradeInDatabase(int studentId, double newGrade)
        {
            string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=StudentsDB;Integrated Security=SSPI;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateQuery = "";

                switch (teacherSubject.ToLower())
                {
                    case "math":
                        updateQuery = "UPDATE Grades SET Math = @grade WHERE StudentId = @studentId"; // Id yerine StudentId
                        break;
                    case "physics":
                        updateQuery = "UPDATE Grades SET Physics = @grade WHERE StudentId = @studentId";
                        break;
                    case "chemistry":
                        updateQuery = "UPDATE Grades SET Chemistry = @grade WHERE StudentId = @studentId";
                        break;
                    case "biology":
                        updateQuery = "UPDATE Grades SET Biology = @grade WHERE StudentId = @studentId";
                        break;
                    case "english":
                        updateQuery = "UPDATE Grades SET English = @grade WHERE StudentId = @studentId";
                        break;
                    case "history":
                        updateQuery = "UPDATE Grades SET History = @grade WHERE StudentId = @studentId";
                        break;
                }

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@grade", newGrade);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool checkTeacher(List<Teacher> teachers, string name, string surname, string subject, string password, int id)
        {
            for (int i = 0; i < teachers.Count(); i++)
            {
                Teacher teacher = teachers[i];
                if (name.Equals(teacher.getName()) &&
                    surname.Equals(teacher.getSurname()) &&
                    subject.Equals(teacher.getSubject()) &&
                    password.Equals(teacher.getPassword()) &&
                    id == teacher.getId())
                {
                    return true;
                }
            }
            return false; 
        }

        private Grades FindStudentGrade(List<Grades> grades, int studentId)
        {
            for (int i = 0; i < grades.Count(); i++)
            {
                if (grades[i].GetId() == studentId)
                {
                    return grades[i];
                }
            }
            return null;
        }
    }
}

