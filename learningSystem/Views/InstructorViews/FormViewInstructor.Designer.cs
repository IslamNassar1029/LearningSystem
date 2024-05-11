namespace LearningSystem.Views.InstructorViews
{
    partial class FormViewInstructor
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
            comboBoxHeadedBy = new ComboBox();
            comboBoxDepartmentName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            btnLoad = new Button();
            btnOpen = new Button();
            dataGridView1 = new DataGridView();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxHeadedBy
            // 
            comboBoxHeadedBy.FormattingEnabled = true;
            comboBoxHeadedBy.Location = new Point(368, 476);
            comboBoxHeadedBy.Name = "comboBoxHeadedBy";
            comboBoxHeadedBy.Size = new Size(175, 23);
            comboBoxHeadedBy.TabIndex = 100;
            // 
            // comboBoxDepartmentName
            // 
            comboBoxDepartmentName.FormattingEnabled = true;
            comboBoxDepartmentName.Location = new Point(368, 423);
            comboBoxDepartmentName.Name = "comboBoxDepartmentName";
            comboBoxDepartmentName.Size = new Size(175, 23);
            comboBoxDepartmentName.TabIndex = 99;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(251, 479);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 98;
            label6.Text = "HeadedBy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(251, 431);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 97;
            label5.Text = "DepartmentName";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(22, 439);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 96;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(641, 439);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 95;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 94;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(540, 82);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 23);
            txtPhone.TabIndex = 93;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(139, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 23);
            txtLastName.TabIndex = 92;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(139, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 23);
            txtFirstName.TabIndex = 91;
            // 
            // txtId
            // 
            txtId.Location = new Point(540, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 82);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 89;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 82);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 88;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 36);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 87;
            label2.Text = "FirstName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 36);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 86;
            label1.Text = "Id";
            // 
            // FormViewInstructor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(comboBoxHeadedBy);
            Controls.Add(comboBoxDepartmentName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormViewInstructor";
            Text = "FormViewInstructor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxHeadedBy;
        private ComboBox comboBoxDepartmentName;
        private Label label6;
        private Label label5;
        private Button btnLoad;
        private Button btnOpen;
        private DataGridView dataGridView1;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}