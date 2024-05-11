namespace LearningSystem.Views.CourseSessionViews
{
    partial class FormCourseSession
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
            comboBoxCourseId = new ComboBox();
            label5 = new Label();
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            txtTitle = new TextBox();
            txtDate = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxInstructorId = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBoxCourseId
            // 
            comboBoxCourseId.FormattingEnabled = true;
            comboBoxCourseId.Location = new Point(270, 274);
            comboBoxCourseId.Name = "comboBoxCourseId";
            comboBoxCourseId.Size = new Size(175, 23);
            comboBoxCourseId.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 282);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 62;
            label5.Text = "Course Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(522, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 61;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(522, 146);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 60;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(522, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 59;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(270, 233);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(175, 23);
            txtTitle.TabIndex = 71;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(270, 187);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(175, 23);
            txtDate.TabIndex = 70;
            // 
            // txtId
            // 
            txtId.Location = new Point(270, 146);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 233);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 68;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 187);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 67;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 146);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 66;
            label1.Text = "Id";
            // 
            // comboBoxInstructorId
            // 
            comboBoxInstructorId.FormattingEnabled = true;
            comboBoxInstructorId.Location = new Point(270, 322);
            comboBoxInstructorId.Name = "comboBoxInstructorId";
            comboBoxInstructorId.Size = new Size(175, 23);
            comboBoxInstructorId.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 325);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 72;
            label6.Text = "Instructor Name";
            // 
            // FormCourseSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxInstructorId);
            Controls.Add(label6);
            Controls.Add(txtTitle);
            Controls.Add(txtDate);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCourseId);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Name = "FormCourseSession";
            Text = "FormCourseSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxCourseId;
        private Label label5;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private TextBox txtTitle;
        private TextBox txtDate;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxInstructorId;
        private Label label6;
    }
}