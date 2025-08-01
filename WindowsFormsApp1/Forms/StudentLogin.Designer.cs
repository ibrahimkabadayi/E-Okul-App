namespace WindowsFormsApp1
{
    partial class StudentLogin
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.grades = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F);
            this.label1.Location = new System.Drawing.Point(410, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Student!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label3.Location = new System.Drawing.Point(683, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.nameTextBox.Location = new System.Drawing.Point(25, 223);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 33);
            this.nameTextBox.TabIndex = 3;
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.passWordTextBox.Location = new System.Drawing.Point(688, 223);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(173, 33);
            this.passWordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.registerButton.Location = new System.Drawing.Point(344, 321);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(182, 37);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.label9.Location = new System.Drawing.Point(894, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.IdTextBox.Location = new System.Drawing.Point(899, 223);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(173, 33);
            this.IdTextBox.TabIndex = 12;
            // 
            // grades
            // 
            this.grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column6});
            this.grades.Location = new System.Drawing.Point(97, 409);
            this.grades.Name = "grades";
            this.grades.Size = new System.Drawing.Size(937, 218);
            this.grades.TabIndex = 13;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Math";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Physics";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Chemistry";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Biology";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "English";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "History";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.surnameTextBox.Location = new System.Drawing.Point(241, 223);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(173, 33);
            this.surnameTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(236, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Surname";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.mainMenuButton.Location = new System.Drawing.Point(592, 321);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(182, 37);
            this.mainMenuButton.TabIndex = 16;
            this.mainMenuButton.Text = "Return to Main";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.ageTextBox.Location = new System.Drawing.Point(472, 223);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(173, 33);
            this.ageTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(467, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Age";
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 714);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grades);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.DataGridView grades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label5;
    }
}