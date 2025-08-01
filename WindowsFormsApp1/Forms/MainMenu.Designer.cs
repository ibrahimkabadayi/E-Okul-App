namespace WindowsFormsApp1
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentSignInButton = new System.Windows.Forms.Button();
            this.studentLoginButton = new System.Windows.Forms.Button();
            this.teacherSignInButton = new System.Windows.Forms.Button();
            this.teacherLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to School Registiration System!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.label2.Location = new System.Drawing.Point(258, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "You are a Student?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F);
            this.label3.Location = new System.Drawing.Point(637, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "You are a Teacher?";
            // 
            // studentSignInButton
            // 
            this.studentSignInButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentSignInButton.Location = new System.Drawing.Point(193, 258);
            this.studentSignInButton.Name = "studentSignInButton";
            this.studentSignInButton.Size = new System.Drawing.Size(315, 38);
            this.studentSignInButton.TabIndex = 7;
            this.studentSignInButton.Text = "Sign in";
            this.studentSignInButton.UseVisualStyleBackColor = true;
            this.studentSignInButton.Click += new System.EventHandler(this.studentSignInButton_Click);
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentLoginButton.Location = new System.Drawing.Point(193, 334);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(315, 38);
            this.studentLoginButton.TabIndex = 8;
            this.studentLoginButton.Text = "Login";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            this.studentLoginButton.Click += new System.EventHandler(this.studentLoginButton_Click);
            // 
            // teacherSignInButton
            // 
            this.teacherSignInButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherSignInButton.Location = new System.Drawing.Point(580, 258);
            this.teacherSignInButton.Name = "teacherSignInButton";
            this.teacherSignInButton.Size = new System.Drawing.Size(315, 38);
            this.teacherSignInButton.TabIndex = 9;
            this.teacherSignInButton.Text = "Sign in";
            this.teacherSignInButton.UseVisualStyleBackColor = true;
            this.teacherSignInButton.Click += new System.EventHandler(this.teacherSignInButton_Click);
            // 
            // teacherLoginButton
            // 
            this.teacherLoginButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherLoginButton.Location = new System.Drawing.Point(580, 334);
            this.teacherLoginButton.Name = "teacherLoginButton";
            this.teacherLoginButton.Size = new System.Drawing.Size(315, 38);
            this.teacherLoginButton.TabIndex = 10;
            this.teacherLoginButton.Text = "Login";
            this.teacherLoginButton.UseVisualStyleBackColor = true;
            this.teacherLoginButton.Click += new System.EventHandler(this.teacherLoginButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 714);
            this.Controls.Add(this.teacherLoginButton);
            this.Controls.Add(this.teacherSignInButton);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.studentSignInButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button studentSignInButton;
        private System.Windows.Forms.Button studentLoginButton;
        private System.Windows.Forms.Button teacherSignInButton;
        private System.Windows.Forms.Button teacherLoginButton;
    }
}