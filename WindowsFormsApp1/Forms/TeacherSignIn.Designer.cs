namespace WindowsFormsApp1
{
    partial class TeacherSignIn
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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.surnameTextBox.Location = new System.Drawing.Point(659, 238);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(365, 31);
            this.surnameTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(655, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Teacher\'s Password:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 26.25F);
            this.label5.Location = new System.Drawing.Point(279, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(541, 95);
            this.label5.TabIndex = 20;
            this.label5.Text = "Welcome to Teacher Submit Site!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.submitButton.Location = new System.Drawing.Point(287, 493);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(233, 50);
            this.submitButton.TabIndex = 19;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(80, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Teacher\'s Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Teacher\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(655, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Teacher\'s Surname:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(660, 378);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(365, 31);
            this.passwordTextBox.TabIndex = 15;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subjectTextBox.Location = new System.Drawing.Point(85, 378);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(365, 31);
            this.subjectTextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.Location = new System.Drawing.Point(85, 238);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(365, 31);
            this.nameTextBox.TabIndex = 13;
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.returnToMainMenuButton.Location = new System.Drawing.Point(577, 493);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(233, 50);
            this.returnToMainMenuButton.TabIndex = 23;
            this.returnToMainMenuButton.Text = "Return to Menu";
            this.returnToMainMenuButton.UseVisualStyleBackColor = true;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // TeacherSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 714);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "TeacherSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button returnToMainMenuButton;
    }
}