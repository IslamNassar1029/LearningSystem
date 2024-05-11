namespace LearningSystem.Views.CourseStudentViews
{
    partial class FormViewCourseStudent
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
            btnLoad = new Button();
            btnOpen = new Button();
            dataGridView1 = new DataGridView();
            comboBoxStudentId = new ComboBox();
            comboBoxCourseId = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(28, 379);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 73;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(640, 379);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 72;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 71;
            // 
            // comboBoxStudentId
            // 
            comboBoxStudentId.FormattingEnabled = true;
            comboBoxStudentId.Location = new Point(580, 32);
            comboBoxStudentId.Name = "comboBoxStudentId";
            comboBoxStudentId.Size = new Size(175, 23);
            comboBoxStudentId.TabIndex = 77;
            // 
            // comboBoxCourseId
            // 
            comboBoxCourseId.FormattingEnabled = true;
            comboBoxCourseId.Location = new Point(145, 32);
            comboBoxCourseId.Name = "comboBoxCourseId";
            comboBoxCourseId.Size = new Size(175, 23);
            comboBoxCourseId.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(477, 40);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 75;
            label6.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 40);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 74;
            label5.Text = "Course Name";
            // 
            // FormViewCourseStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxStudentId);
            Controls.Add(comboBoxCourseId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Name = "FormViewCourseStudent";
            Text = "FormViewCourseStudent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnOpen;
        private DataGridView dataGridView1;
        private ComboBox comboBoxStudentId;
        private ComboBox comboBoxCourseId;
        private Label label6;
        private Label label5;
    }
}