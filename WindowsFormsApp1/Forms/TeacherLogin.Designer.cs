namespace WindowsFormsApp1
{
    partial class TeacherLogin
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
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LetterGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.registerButton.Location = new System.Drawing.Point(340, 290);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(182, 37);
            this.registerButton.TabIndex = 21;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F);
            this.label1.Location = new System.Drawing.Point(379, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome Teacher!";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.StudentSurname,
            this.Grade,
            this.LetterGrade,
            this.PassingStatus});
            this.table.Location = new System.Drawing.Point(76, 345);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(937, 357);
            this.table.TabIndex = 26;
            this.table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellValueChanged);
            // 
            // StudentId
            // 
            this.StudentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentSurname
            // 
            this.StudentSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentSurname.HeaderText = "Student Surname";
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // LetterGrade
            // 
            this.LetterGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LetterGrade.HeaderText = "Letter Grade";
            this.LetterGrade.Name = "LetterGrade";
            this.LetterGrade.ReadOnly = true;
            // 
            // PassingStatus
            // 
            this.PassingStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PassingStatus.HeaderText = "Passing Status";
            this.PassingStatus.Name = "PassingStatus";
            this.PassingStatus.ReadOnly = true;
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.returnToMainMenuButton.Location = new System.Drawing.Point(588, 290);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(182, 37);
            this.returnToMainMenuButton.TabIndex = 27;
            this.returnToMainMenuButton.Text = "Return to Menu";
            this.returnToMainMenuButton.UseVisualStyleBackColor = true;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.subjectTextBox.Location = new System.Drawing.Point(477, 202);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(173, 33);
            this.subjectTextBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(472, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Subject";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.surnameTextBox.Location = new System.Drawing.Point(246, 202);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(173, 33);
            this.surnameTextBox.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(241, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "Surname";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.IdTextBox.Location = new System.Drawing.Point(904, 202);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(173, 33);
            this.IdTextBox.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label9.Location = new System.Drawing.Point(899, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 26);
            this.label9.TabIndex = 32;
            this.label9.Text = "Id";
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.passWordTextBox.Location = new System.Drawing.Point(693, 202);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(173, 33);
            this.passWordTextBox.TabIndex = 31;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.nameTextBox.Location = new System.Drawing.Point(30, 202);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 33);
            this.nameTextBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.Location = new System.Drawing.Point(688, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            // 
            // TeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 714);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.table);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label1);
            this.Name = "TeacherLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn LetterGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassingStatus;
        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}