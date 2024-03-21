﻿namespace LearningSystem.Views.CourseViews
{
    partial class FormCourse
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
            comboBoxInstructorId = new ComboBox();
            comboBoxDepartmentName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDuration = new TextBox();
            SuspendLayout();
            // 
            // comboBoxInstructorId
            // 
            comboBoxInstructorId.FormattingEnabled = true;
            comboBoxInstructorId.Location = new Point(279, 308);
            comboBoxInstructorId.Name = "comboBoxInstructorId";
            comboBoxInstructorId.Size = new Size(175, 23);
            comboBoxInstructorId.TabIndex = 59;
            // 
            // comboBoxDepartmentName
            // 
            comboBoxDepartmentName.FormattingEnabled = true;
            comboBoxDepartmentName.Location = new Point(279, 255);
            comboBoxDepartmentName.Name = "comboBoxDepartmentName";
            comboBoxDepartmentName.Size = new Size(175, 23);
            comboBoxDepartmentName.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 311);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 57;
            label6.Text = "Instructor Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 263);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 56;
            label5.Text = "DepartmentName";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 55;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(505, 119);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 54;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(505, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 53;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(279, 160);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 52;
            // 
            // txtId
            // 
            txtId.Location = new Point(279, 119);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 206);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 50;
            label3.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 160);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 49;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 119);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 48;
            label1.Text = "Id";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(279, 203);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(175, 23);
            txtDuration.TabIndex = 60;
            // 
            // FormCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDuration);
            Controls.Add(comboBoxInstructorId);
            Controls.Add(comboBoxDepartmentName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCourse";
            Text = "FormCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxInstructorId;
        private ComboBox comboBoxDepartmentName;
        private Label label6;
        private Label label5;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private TextBox txtName;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDuration;
    }
}