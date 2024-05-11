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

namespace LearningSystem.Views.CourseStudentViews
{
    public partial class FormCourseStudent : Form
    {
        public FormCourseStudent()
        {
            InitializeComponent();
            New();
        }
        public FormCourseStudent(int courseId,int studentId) : this()
        {
            Load(courseId, studentId);
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
        CourseStudent courseStudent;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            courseStudent = new CourseStudent();
            GetStudents();
            GetCourses();
            AddOrUpdate = true;
        }
        async void Load(int courseId, int studentId)
        {
            try
            {
                courseStudent = await db.CourseStudents.FirstAsync(x => x.CourseId == courseId && x.StudentId==studentId);


                var selectedCourse = comboBoxCourseId.Items
                                        .Cast<Course>()
                                        .Select((c, index) => new { Course = c, Index = index })
                                        .FirstOrDefault(x => x.Course.Id == courseStudent.CourseId);

                if (selectedCourse != null)
                {
                    comboBoxCourseId.SelectedIndex = selectedCourse.Index;
                }

                var selectedStudent = comboBoxStudentId.Items
                                        .Cast<Student>()
                                        .Select((s, index) => new { student = s, Index = index })
                                        .FirstOrDefault(x => x.student.Id == courseStudent.StudentId);

                if (selectedStudent != null)
                {
                    comboBoxStudentId.SelectedIndex = selectedStudent.Index;
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

            courseStudent.StudentId = Convert.ToInt32(comboBoxStudentId.SelectedValue);
            courseStudent.CourseId = Convert.ToInt32(comboBoxCourseId.SelectedValue);

            try
            {
                if (AddOrUpdate) db.CourseStudents.Add(courseStudent);

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
                db.CourseStudents.Remove(courseStudent);
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
