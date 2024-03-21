using LearningSystem.Views.CourseSessionAttendendanceViews;
using LearningSystem.Views.CourseSessionViews;
using LearningSystem.Views.CourseStudentViews;
using LearningSystem.Views.CourseViews;
using LearningSystem.Views.DepartmentViews;
using LearningSystem.Views.InstructorViews;
using LearningSystem.Views.StudentViews;

namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //private async void btnCreateDatabase_Click(object sender, EventArgs e)
        //{
        //    btnCreateDatabase.Enabled = false;
        //    LearningSystemDbContext db = new LearningSystemDbContext();
        //    bool didNewDBCreated = await db.Database.EnsureCreatedAsync();
        //    MessageBox.Show(didNewDBCreated ? "Data Base Created" : "Data Base Exist");
        //    btnCreateDatabase.Enabled = true;
        //}

        private void addToolStripMenuStudent_Click(object sender, EventArgs e)
        {
            FormStudent studentForm = new FormStudent();
            studentForm.ShowDialog();

        }

        private void viewToolStripMenuStudent_Click(object sender, EventArgs e)
        {
            FormViewStudent studentViewForm = new FormViewStudent();
            studentViewForm.ShowDialog();
        }

        private void addToolStripMenuDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment departmentForm = new FormDepartment();
            departmentForm.ShowDialog();

        }

        private void viewToolStripMenuDepartment_Click(object sender, EventArgs e)
        {
            FormViewDepartment departmentViewForm = new FormViewDepartment();
            departmentViewForm.ShowDialog();
        }

        private void addToolStripMenuInstructor_Click(object sender, EventArgs e)
        {
            FormInstructor form = new FormInstructor();
            form.ShowDialog();
        }

        private void viewToolStripMenuInstructor_Click(object sender, EventArgs e)
        {
            FormViewInstructor form = new FormViewInstructor();
            form.ShowDialog();
        }

        private void addToolStripMenuCourse_Click(object sender, EventArgs e)
        {
            FormCourse form = new FormCourse();
            form.ShowDialog();
        }

        private void viewToolStripMenuCourse_Click(object sender, EventArgs e)
        {
            FormViewCourse form = new FormViewCourse();
            form.ShowDialog();
        }

        private void addToolStripMenuCourseStudent_Click(object sender, EventArgs e)
        {
            FormCourseStudent form = new FormCourseStudent();
            form.ShowDialog();
        }

        private void viewToolStripMenuCourseStudent_Click(object sender, EventArgs e)
        {
            FormViewCourseStudent form = new FormViewCourseStudent();
            form.ShowDialog();
        }

        private void addToolStripMenuCourseSession_Click(object sender, EventArgs e)
        {
            FormCourseSession form = new FormCourseSession();
            form.ShowDialog();
        }

        private void viewToolStripMenuCourseSession_Click(object sender, EventArgs e)
        {
            FormViewCourseSession form = new FormViewCourseSession();
            form.ShowDialog();
        }

        private void addToolStripMenuCourseSessionAttendance_Click(object sender, EventArgs e)
        {
            FormCourseSessionAttendendance form = new FormCourseSessionAttendendance();
            form.ShowDialog();
        }

        private void viewToolStripMenuCourseSessionAttendance_Click(object sender, EventArgs e)
        {
            FormViewCourseSessionAttendendance form = new FormViewCourseSessionAttendendance();
            form.ShowDialog();
        }
    }
}
