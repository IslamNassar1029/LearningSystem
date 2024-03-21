using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp1.Entities;
using WinFormsApp1;
using Microsoft.EntityFrameworkCore;

namespace LearningSystem.Views.CourseSessionAttendendanceViews
{
    public partial class FormCourseSessionAttendendance : Form
    {
        public FormCourseSessionAttendendance()
        {
            InitializeComponent();
            New();
        }
        public FormCourseSessionAttendendance(int id) : this()
        {
            Load(id);
        }
        bool addOrUpdate;
        public bool AddOrUpdate
        {
            get => addOrUpdate;
            set
            {
                addOrUpdate = value;
                btnSave.Text = addOrUpdate ? "Add" : "Update";
                btnDelete.Enabled = !addOrUpdate;
            }
        }
        CourseSessionAttendance courseSessionAttendance;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            courseSessionAttendance = new CourseSessionAttendance();
            txtId.Text = "";
            txtGrade.Text = "";
            txtNotes.Text = "";
            GetCourseSession();
            GetStudents();
            AddOrUpdate = true;
        }
        async void Load(int id)
        {
            try
            {
                courseSessionAttendance = await db.CourseSessionAttendances.FirstAsync(x => x.Id == id);
                txtId.Text = courseSessionAttendance.Id.ToString();
                txtGrade.Text = courseSessionAttendance.Grade.ToString();
                txtNotes.Text = courseSessionAttendance.Notes.ToString();

                var selectedStudent = comboBoxStudentId.Items
                        .Cast<Student>()
                        .Select((s, index) => new { student = s, Index = index })
                        .FirstOrDefault(x => x.student.Id == courseSessionAttendance.StudentId);

                if (selectedStudent != null)
                {
                    comboBoxStudentId.SelectedIndex = selectedStudent.Index;
                }

                var selectedCourseSession = comboBoxCourseSessionId.Items
                                                       .Cast<CourseSession>()
                                                       .Select((cs, index) => new { CourseSession = cs, Index = index })
                                                       .FirstOrDefault(x => x.CourseSession.Id == courseSessionAttendance.CourseSessionId);

                if (selectedCourseSession != null)
                {
                    comboBoxCourseSessionId.SelectedIndex = selectedCourseSession.Index;
                }
                AddOrUpdate = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");

            }
            finally
            {

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            courseSessionAttendance.Notes = txtNotes.Text;
            courseSessionAttendance.Grade = Convert.ToInt32(txtGrade.Text);
            courseSessionAttendance.CourseSessionId = Convert.ToInt32(comboBoxCourseSessionId.SelectedValue);
            courseSessionAttendance.StudentId = Convert.ToInt32(comboBoxStudentId.SelectedValue);




            try
            {
                if (AddOrUpdate) db.CourseSessionAttendances.Add(courseSessionAttendance);

                await db.SaveChangesAsync();
                MessageBox.Show(AddOrUpdate ? " Added" : " Updated");
                AddOrUpdate = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");

            }
            finally
            {

            }


        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.CourseSessionAttendances.Remove(courseSessionAttendance);
                await db.SaveChangesAsync();
                MessageBox.Show(" Deleted");
                New();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");

            }
            finally
            {

            }

        }
        async private void GetCourseSession()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courseSessions = db.CourseSessions.AsQueryable();
            try
            {
                comboBoxCourseSessionId.DataSource = await courseSessions.ToListAsync();
                comboBoxCourseSessionId.DisplayMember = "Title";
                comboBoxCourseSessionId.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }
        async private void GetStudents()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();

            try
            {
                var students = db.Students.AsQueryable();
                comboBoxStudentId.DataSource = await students.ToListAsync();
                comboBoxStudentId.DisplayMember = "FirstName";
                comboBoxStudentId.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }
    }
}
