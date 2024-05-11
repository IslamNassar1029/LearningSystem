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

namespace LearningSystem.Views.CourseSessionViews
{
    public partial class FormCourseSession : Form
    {
        public FormCourseSession()
        {
            InitializeComponent();
            New();
        }
        public FormCourseSession(int id) : this()
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
        CourseSession courseSession;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            courseSession = new CourseSession();
            txtId.Text = "";
            txtDate.Text = "";
            txtTitle.Text = "";
            GetCourses();
            GetInstructorId();
            AddOrUpdate = true;
        }
        async void Load(int id)
        {
            try
            {
                courseSession = await db.CourseSessions.FirstAsync(x => x.Id == id);
                txtId.Text = courseSession.Id.ToString();
                txtTitle.Text = courseSession.Title;
                txtDate.Text = courseSession.Date.ToString();

                var selectedCourse = comboBoxCourseId.Items
                                        .Cast<Course>()
                                        .Select((c, index) => new { Course = c, Index = index })
                                        .FirstOrDefault(x => x.Course.Id == courseSession.CourseId);

                if (selectedCourse != null)
                {
                    comboBoxCourseId.SelectedIndex = selectedCourse.Index;
                }


                var selectedInstructor = comboBoxInstructorId.Items
                                        .Cast<Instructor>()
                                        .Select((i, index) => new { Instructor = i, Index = index })
                                        .FirstOrDefault(x => x.Instructor.Id == courseSession.InstructorId);
                comboBoxInstructorId.SelectedIndex = selectedInstructor.Index;
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
            courseSession.Title = txtTitle.Text;
            if (DateTime.TryParseExact(txtDate.Text, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dateValue))
            {
                courseSession.Date = DateOnly.FromDateTime(dateValue);
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter the date in 'd/M/yyyy' format.");
                return;
            }
            courseSession.CourseId = Convert.ToInt32(comboBoxCourseId.SelectedValue);
            courseSession.InstructorId = Convert.ToInt32(comboBoxInstructorId.SelectedValue);




            try
            {
                if (AddOrUpdate) db.CourseSessions.Add(courseSession);

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
                db.CourseSessions.Remove(courseSession);
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
        async private void GetCourses()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courses = db.Courses.AsQueryable();
            try
            {
                comboBoxCourseId.DataSource = await courses.ToListAsync();
                comboBoxCourseId.DisplayMember = "Name";
                comboBoxCourseId.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }
        async private void GetInstructorId()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();

            try
            {
                var instructors = db.Instructors.AsQueryable();
                comboBoxInstructorId.DataSource = await instructors.ToListAsync();
                comboBoxInstructorId.DisplayMember = "FirstName";
                comboBoxInstructorId.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }
    }
}
