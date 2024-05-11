namespace LearningSystem.Views.CourseSessionAttendendanceViews
{
    partial class FormCourseSessionAttendendance
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
            txtNotes = new TextBox();
            txtGrade = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxCourseSessionId = new ComboBox();
            label5 = new Label();
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            comboBoxStudentId = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(266, 213);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(175, 23);
            txtNotes.TabIndex = 84;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(266, 167);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(175, 23);
            txtGrade.TabIndex = 83;
            // 
            // txtId
            // 
            txtId.Location = new Point(266, 126);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 213);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 81;
            label3.Text = "Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 167);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 80;
            label2.Text = "Grade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 126);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 79;
            label1.Text = "Id";
            // 
            // comboBoxCourseSessionId
            // 
            comboBoxCourseSessionId.FormattingEnabled = true;
            comboBoxCourseSessionId.Location = new Point(266, 254);
            comboBoxCourseSessionId.Name = "comboBoxCourseSessionId";
            comboBoxCourseSessionId.Size = new Size(175, 23);
            comboBoxCourseSessionId.TabIndex = 78;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 262);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 77;
            label5.Text = "CourseSession Title";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(518, 240);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 76;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(518, 126);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 75;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(518, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 74;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBoxStudentId
            // 
            comboBoxStudentId.FormattingEnabled = true;
            comboBoxStudentId.Location = new Point(266, 300);
            comboBoxStudentId.Name = "comboBoxStudentId";
            comboBoxStudentId.Size = new Size(175, 23);
            comboBoxStudentId.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 303);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 88;
            label4.Text = "StudentName";
            // 
            // FormCourseSessionAttendendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStudentId);
            Controls.Add(label4);
            Controls.Add(txtNotes);
            Controls.Add(txtGrade);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCourseSessionId);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Name = "FormCourseSessionAttendendance";
            Text = "FormCourseSessionAttendendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNotes;
        private TextBox txtGrade;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxCourseSessionId;
        private Label label5;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private ComboBox comboBoxStudentId;
        private Label label4;
    }
}