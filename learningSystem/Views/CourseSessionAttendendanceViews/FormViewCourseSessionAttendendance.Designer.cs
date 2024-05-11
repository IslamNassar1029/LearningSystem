namespace LearningSystem.Views.CourseSessionAttendendanceViews
{
    partial class FormViewCourseSessionAttendendance
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
            txtNotes = new TextBox();
            txtGrade = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            comboBoxCourseSessionId = new ComboBox();
            label4 = new Label();
            comboBoxStudentId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(28, 398);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 80;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(640, 398);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 79;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 78;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(143, 70);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(175, 23);
            txtNotes.TabIndex = 96;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(143, 24);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(175, 23);
            txtGrade.TabIndex = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 70);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 94;
            label3.Text = "Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 24);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 93;
            label2.Text = "Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 32);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 91;
            label5.Text = "CourseSession Date";
            // 
            // comboBoxCourseSessionId
            // 
            comboBoxCourseSessionId.FormattingEnabled = true;
            comboBoxCourseSessionId.Location = new Point(590, 24);
            comboBoxCourseSessionId.Name = "comboBoxCourseSessionId";
            comboBoxCourseSessionId.Size = new Size(175, 23);
            comboBoxCourseSessionId.TabIndex = 92;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 73);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 97;
            label4.Text = "Student Name";
            // 
            // comboBoxStudentId
            // 
            comboBoxStudentId.FormattingEnabled = true;
            comboBoxStudentId.Location = new Point(590, 70);
            comboBoxStudentId.Name = "comboBoxStudentId";
            comboBoxStudentId.Size = new Size(175, 23);
            comboBoxStudentId.TabIndex = 98;
            // 
            // FormViewCourseSessionAttendendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(comboBoxStudentId);
            Controls.Add(label4);
            Controls.Add(txtNotes);
            Controls.Add(txtGrade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxCourseSessionId);
            Controls.Add(label5);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Name = "FormViewCourseSessionAttendendance";
            Text = "FormViewCourseSessionAttendendance";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoad;
        private Button btnOpen;
        private DataGridView dataGridView1;
        private TextBox txtNotes;
        private TextBox txtGrade;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox comboBoxCourseSessionId;
        private Label label4;
        private ComboBox comboBoxStudentId;
    }
}