namespace LearningSystem.Views.CourseSessionViews
{
    partial class FormViewCourseSession
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
            label6 = new Label();
            txtTitle = new TextBox();
            txtDate = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxCourseId = new ComboBox();
            label5 = new Label();
            btnLoad = new Button();
            btnOpen = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxInstructorId
            // 
            comboBoxInstructorId.FormattingEnabled = true;
            comboBoxInstructorId.Location = new Point(578, 63);
            comboBoxInstructorId.Name = "comboBoxInstructorId";
            comboBoxInstructorId.Size = new Size(175, 23);
            comboBoxInstructorId.TabIndex = 99;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 66);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 98;
            label6.Text = "Instructor Name";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(149, 61);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(175, 23);
            txtTitle.TabIndex = 97;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(149, 15);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(175, 23);
            txtDate.TabIndex = 96;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 61);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 95;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 15);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 94;
            label2.Text = "Date";
            // 
            // comboBoxCourseId
            // 
            comboBoxCourseId.FormattingEnabled = true;
            comboBoxCourseId.Location = new Point(578, 15);
            comboBoxCourseId.Name = "comboBoxCourseId";
            comboBoxCourseId.Size = new Size(175, 23);
            comboBoxCourseId.TabIndex = 93;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 23);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 92;
            label5.Text = "Course Name";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(28, 391);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 91;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(640, 391);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 90;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 89;
            // 
            // FormViewCourseSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(comboBoxInstructorId);
            Controls.Add(label6);
            Controls.Add(txtTitle);
            Controls.Add(txtDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxCourseId);
            Controls.Add(label5);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Name = "FormViewCourseSession";
            Text = "FormViewCourseSession";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxInstructorId;
        private Label label6;
        private TextBox txtTitle;
        private TextBox txtDate;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxCourseId;
        private Label label5;
        private Button btnLoad;
        private Button btnOpen;
        private DataGridView dataGridView1;
    }
}