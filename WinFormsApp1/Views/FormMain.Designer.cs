namespace WinFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuStudent = new ToolStripMenuItem();
            viewToolStripMenuStudent = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuDepartment = new ToolStripMenuItem();
            viewToolStripMenuDepartment = new ToolStripMenuItem();
            instructorToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuInstructor = new ToolStripMenuItem();
            viewToolStripMenuInstructor = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuCourse = new ToolStripMenuItem();
            viewToolStripMenuCourse = new ToolStripMenuItem();
            courseStudentsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuCourseStudent = new ToolStripMenuItem();
            viewToolStripMenuCourseStudent = new ToolStripMenuItem();
            courseSessionsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuCourseSession = new ToolStripMenuItem();
            viewToolStripMenuCourseSession = new ToolStripMenuItem();
            courseSessionAttendancesToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuCourseSessionAttendance = new ToolStripMenuItem();
            viewToolStripMenuCourseSessionAttendance = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, departmentsToolStripMenuItem, instructorToolStripMenuItem, coursesToolStripMenuItem, courseStudentsToolStripMenuItem, courseSessionsToolStripMenuItem, courseSessionAttendancesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(707, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuStudent, viewToolStripMenuStudent });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(65, 20);
            studentToolStripMenuItem.Text = "Students";
            // 
            // addToolStripMenuStudent
            // 
            addToolStripMenuStudent.Name = "addToolStripMenuStudent";
            addToolStripMenuStudent.Size = new Size(99, 22);
            addToolStripMenuStudent.Text = "Add";
            addToolStripMenuStudent.Click += addToolStripMenuStudent_Click;
            // 
            // viewToolStripMenuStudent
            // 
            viewToolStripMenuStudent.Name = "viewToolStripMenuStudent";
            viewToolStripMenuStudent.Size = new Size(99, 22);
            viewToolStripMenuStudent.Text = "View";
            viewToolStripMenuStudent.Click += viewToolStripMenuStudent_Click;
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuDepartment, viewToolStripMenuDepartment });
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(87, 20);
            departmentsToolStripMenuItem.Text = "Departments";
            // 
            // addToolStripMenuDepartment
            // 
            addToolStripMenuDepartment.Name = "addToolStripMenuDepartment";
            addToolStripMenuDepartment.Size = new Size(99, 22);
            addToolStripMenuDepartment.Text = "Add";
            addToolStripMenuDepartment.Click += addToolStripMenuDepartment_Click;
            // 
            // viewToolStripMenuDepartment
            // 
            viewToolStripMenuDepartment.Name = "viewToolStripMenuDepartment";
            viewToolStripMenuDepartment.Size = new Size(99, 22);
            viewToolStripMenuDepartment.Text = "View";
            viewToolStripMenuDepartment.Click += viewToolStripMenuDepartment_Click;
            // 
            // instructorToolStripMenuItem
            // 
            instructorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuInstructor, viewToolStripMenuInstructor });
            instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            instructorToolStripMenuItem.Size = new Size(75, 20);
            instructorToolStripMenuItem.Text = "Instructors";
            // 
            // addToolStripMenuInstructor
            // 
            addToolStripMenuInstructor.Name = "addToolStripMenuInstructor";
            addToolStripMenuInstructor.Size = new Size(99, 22);
            addToolStripMenuInstructor.Text = "Add";
            addToolStripMenuInstructor.Click += addToolStripMenuInstructor_Click;
            // 
            // viewToolStripMenuInstructor
            // 
            viewToolStripMenuInstructor.Name = "viewToolStripMenuInstructor";
            viewToolStripMenuInstructor.Size = new Size(99, 22);
            viewToolStripMenuInstructor.Text = "View";
            viewToolStripMenuInstructor.Click += viewToolStripMenuInstructor_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuCourse, viewToolStripMenuCourse });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // addToolStripMenuCourse
            // 
            addToolStripMenuCourse.Name = "addToolStripMenuCourse";
            addToolStripMenuCourse.Size = new Size(99, 22);
            addToolStripMenuCourse.Text = "Add";
            addToolStripMenuCourse.Click += addToolStripMenuCourse_Click;
            // 
            // viewToolStripMenuCourse
            // 
            viewToolStripMenuCourse.Name = "viewToolStripMenuCourse";
            viewToolStripMenuCourse.Size = new Size(99, 22);
            viewToolStripMenuCourse.Text = "View";
            viewToolStripMenuCourse.Click += viewToolStripMenuCourse_Click;
            // 
            // courseStudentsToolStripMenuItem
            // 
            courseStudentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuCourseStudent, viewToolStripMenuCourseStudent });
            courseStudentsToolStripMenuItem.Name = "courseStudentsToolStripMenuItem";
            courseStudentsToolStripMenuItem.Size = new Size(102, 20);
            courseStudentsToolStripMenuItem.Text = "CourseStudents";
            // 
            // addToolStripMenuCourseStudent
            // 
            addToolStripMenuCourseStudent.Name = "addToolStripMenuCourseStudent";
            addToolStripMenuCourseStudent.Size = new Size(99, 22);
            addToolStripMenuCourseStudent.Text = "Add";
            addToolStripMenuCourseStudent.Click += addToolStripMenuCourseStudent_Click;
            // 
            // viewToolStripMenuCourseStudent
            // 
            viewToolStripMenuCourseStudent.Name = "viewToolStripMenuCourseStudent";
            viewToolStripMenuCourseStudent.Size = new Size(99, 22);
            viewToolStripMenuCourseStudent.Text = "View";
            viewToolStripMenuCourseStudent.Click += viewToolStripMenuCourseStudent_Click;
            // 
            // courseSessionsToolStripMenuItem
            // 
            courseSessionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuCourseSession, viewToolStripMenuCourseSession });
            courseSessionsToolStripMenuItem.Name = "courseSessionsToolStripMenuItem";
            courseSessionsToolStripMenuItem.Size = new Size(100, 20);
            courseSessionsToolStripMenuItem.Text = "CourseSessions";
            // 
            // addToolStripMenuCourseSession
            // 
            addToolStripMenuCourseSession.Name = "addToolStripMenuCourseSession";
            addToolStripMenuCourseSession.Size = new Size(180, 22);
            addToolStripMenuCourseSession.Text = "Add";
            addToolStripMenuCourseSession.Click += addToolStripMenuCourseSession_Click;
            // 
            // viewToolStripMenuCourseSession
            // 
            viewToolStripMenuCourseSession.Name = "viewToolStripMenuCourseSession";
            viewToolStripMenuCourseSession.Size = new Size(180, 22);
            viewToolStripMenuCourseSession.Text = "View";
            viewToolStripMenuCourseSession.Click += viewToolStripMenuCourseSession_Click;
            // 
            // courseSessionAttendancesToolStripMenuItem
            // 
            courseSessionAttendancesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuCourseSessionAttendance, viewToolStripMenuCourseSessionAttendance });
            courseSessionAttendancesToolStripMenuItem.Name = "courseSessionAttendancesToolStripMenuItem";
            courseSessionAttendancesToolStripMenuItem.Size = new Size(161, 20);
            courseSessionAttendancesToolStripMenuItem.Text = "CourseSessionAttendances";
            // 
            // addToolStripMenuCourseSessionAttendance
            // 
            addToolStripMenuCourseSessionAttendance.Name = "addToolStripMenuCourseSessionAttendance";
            addToolStripMenuCourseSessionAttendance.Size = new Size(180, 22);
            addToolStripMenuCourseSessionAttendance.Text = "Add";
            addToolStripMenuCourseSessionAttendance.Click += addToolStripMenuCourseSessionAttendance_Click;
            // 
            // viewToolStripMenuCourseSessionAttendance
            // 
            viewToolStripMenuCourseSessionAttendance.Name = "viewToolStripMenuCourseSessionAttendance";
            viewToolStripMenuCourseSessionAttendance.Size = new Size(180, 22);
            viewToolStripMenuCourseSessionAttendance.Text = "View";
            viewToolStripMenuCourseSessionAttendance.Click += viewToolStripMenuCourseSessionAttendance_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 420);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuStudent;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem instructorToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem courseStudentsToolStripMenuItem;
        private ToolStripMenuItem courseSessionsToolStripMenuItem;
        private ToolStripMenuItem courseSessionAttendancesToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuStudent;
        private ToolStripMenuItem addToolStripMenuDepartment;
        private ToolStripMenuItem viewToolStripMenuDepartment;
        private ToolStripMenuItem addToolStripMenuInstructor;
        private ToolStripMenuItem viewToolStripMenuInstructor;
        private ToolStripMenuItem addToolStripMenuCourse;
        private ToolStripMenuItem viewToolStripMenuCourse;
        private ToolStripMenuItem addToolStripMenuCourseStudent;
        private ToolStripMenuItem viewToolStripMenuCourseStudent;
        private ToolStripMenuItem addToolStripMenuCourseSession;
        private ToolStripMenuItem viewToolStripMenuCourseSession;
        private ToolStripMenuItem addToolStripMenuCourseSessionAttendance;
        private ToolStripMenuItem viewToolStripMenuCourseSessionAttendance;
    }
}
