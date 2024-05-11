namespace LearningSystem.Views.CourseStudentViews
{
    partial class FormCourseStudent
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
            comboBoxStudentId = new ComboBox();
            comboBoxCourseId = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // comboBoxStudentId
            // 
            comboBoxStudentId.FormattingEnabled = true;
            comboBoxStudentId.Location = new Point(245, 179);
            comboBoxStudentId.Name = "comboBoxStudentId";
            comboBoxStudentId.Size = new Size(175, 23);
            comboBoxStudentId.TabIndex = 58;
            // 
            // comboBoxCourseId
            // 
            comboBoxCourseId.FormattingEnabled = true;
            comboBoxCourseId.Location = new Point(245, 126);
            comboBoxCourseId.Name = "comboBoxCourseId";
            comboBoxCourseId.Size = new Size(175, 23);
            comboBoxCourseId.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 182);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 56;
            label6.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(128, 134);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 55;
            label5.Text = "Course Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(505, 119);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 53;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(505, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 52;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FormCourseStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStudentId);
            Controls.Add(comboBoxCourseId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Name = "FormCourseStudent";
            Text = "FormCourseStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxStudentId;
        private ComboBox comboBoxCourseId;
        private Label label6;
        private Label label5;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
    }
}