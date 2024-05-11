namespace LearningSystem.Views.InstructorViews
{
    partial class FormInstructor
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
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            txtId = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            comboBoxHeadedBy = new ComboBox();
            comboBoxDepartmentName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(505, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(505, 119);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 83;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(505, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 82;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(279, 119);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 79;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 119);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 76;
            label1.Text = "Id";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(279, 210);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 23);
            txtLastName.TabIndex = 96;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(279, 164);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 23);
            txtFirstName.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 210);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 94;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 164);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 93;
            label2.Text = "FirstName";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(279, 263);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 23);
            txtPhone.TabIndex = 98;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 263);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 97;
            label4.Text = "Phone";
            // 
            // comboBoxHeadedBy
            // 
            comboBoxHeadedBy.FormattingEnabled = true;
            comboBoxHeadedBy.Location = new Point(279, 363);
            comboBoxHeadedBy.Name = "comboBoxHeadedBy";
            comboBoxHeadedBy.Size = new Size(175, 23);
            comboBoxHeadedBy.TabIndex = 104;
            // 
            // comboBoxDepartmentName
            // 
            comboBoxDepartmentName.FormattingEnabled = true;
            comboBoxDepartmentName.Location = new Point(279, 310);
            comboBoxDepartmentName.Name = "comboBoxDepartmentName";
            comboBoxDepartmentName.Size = new Size(175, 23);
            comboBoxDepartmentName.TabIndex = 103;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 366);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 102;
            label6.Text = "HeadedBy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 318);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 101;
            label5.Text = "DepartmentName";
            // 
            // FormInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxHeadedBy);
            Controls.Add(comboBoxDepartmentName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FormInstructor";
            Text = "FormInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPhone;
        private TextBox txtLastName;
        private Label label4;
        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private TextBox txtId;
        private Label label1;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxHeadedBy;
        private ComboBox comboBoxDepartmentName;
        private Label label6;
        private Label label5;
    }
}