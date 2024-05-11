namespace LearningSystem.Views.CourseViews
{
    partial class FormViewCourse
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
            comboBoxinstructorId = new ComboBox();
            comboBoxDepartmentName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtDuration = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnLoad = new Button();
            btnOpen = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxinstructorId
            // 
            comboBoxinstructorId.FormattingEnabled = true;
            comboBoxinstructorId.Location = new Point(559, 109);
            comboBoxinstructorId.Name = "comboBoxinstructorId";
            comboBoxinstructorId.Size = new Size(175, 23);
            comboBoxinstructorId.TabIndex = 74;
            // 
            // comboBoxDepartmentName
            // 
            comboBoxDepartmentName.FormattingEnabled = true;
            comboBoxDepartmentName.Location = new Point(559, 56);
            comboBoxDepartmentName.Name = "comboBoxDepartmentName";
            comboBoxDepartmentName.Size = new Size(175, 23);
            comboBoxDepartmentName.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(442, 112);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 72;
            label6.Text = "Instructor Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 64);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 71;
            label5.Text = "DepartmentName";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(133, 102);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(175, 23);
            txtDuration.TabIndex = 70;
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 102);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 68;
            label3.Text = "Duration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 67;
            label2.Text = "Name";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(18, 467);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 66;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(637, 467);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 65;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 64;
            // 
            // FormViewCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 568);
            Controls.Add(comboBoxinstructorId);
            Controls.Add(comboBoxDepartmentName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtDuration);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Name = "FormViewCourse";
            Text = "FormViewCourse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxinstructorId;
        private ComboBox comboBoxDepartmentName;
        private Label label6;
        private Label label5;
        private TextBox txtDuration;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Button btnLoad;
        private Button btnOpen;
        private DataGridView dataGridView1;
    }
}