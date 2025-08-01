using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        private Form currentForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowFormAsPanel(Form formToShow)
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                this.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            currentForm = formToShow;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            this.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();

            this.Text = formToShow.Text;
        }

        public void ShowMainMenu()
        {
            if (currentForm != null)
            {
                currentForm.Hide();
                this.Controls.Remove(currentForm);
                currentForm.Close();
                currentForm.Dispose();
                currentForm = null;
            }

            this.Text = "Main Menu";

            foreach (Control control in this.Controls)
            {
                if (control is Button || control is Label)
                {
                    control.Visible = true;
                }
            }
        }

        private void studentSignInButton_Click(object sender, EventArgs e)
        {
            ShowFormAsPanel(new StudentSignIn());
        }

        private void studentLoginButton_Click(object sender, EventArgs e)
        {
            ShowFormAsPanel(new StudentLogin());
        }

        private void teacherSignInButton_Click(object sender, EventArgs e)
        {
            ShowFormAsPanel(new TeacherSignIn());
        }

        private void teacherLoginButton_Click(object sender, EventArgs e)
        {
            ShowFormAsPanel(new TeacherLogin());
        }
    }
}