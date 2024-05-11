using LearningSystem.Views.CourseViews;
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
    public partial class FormViewCourseStudent : Form
    {
        public FormViewCourseStudent()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        async private void LoadData()
        {
            GetCourses();
            GetStudents();
            btnLoad.Enabled = false;
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courseStudents = db.CourseStudents.AsQueryable();

            if (comboBoxCourseId.SelectedValue != null && Convert.ToInt32(comboBoxCourseId.SelectedValue) != -1)
            {
                var courseId = Convert.ToInt32(comboBoxCourseId.SelectedValue);
                courseStudents = courseStudents.Where(x => x.CourseId == courseId);
            }

            if (comboBoxStudentId.SelectedValue != null && Convert.ToInt32(comboBoxStudentId.SelectedValue) != -1)
            {
                var studentId = Convert.ToInt32(comboBoxStudentId.SelectedValue);
                courseStudents = courseStudents.Where(x => x.StudentId == studentId);
            }
            try
            {
                dataGridView1.DataSource = await courseStudents.ToListAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");

            }
            finally
            {
                btnLoad.Enabled = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is CourseStudent courseStudent)
            {
                int courseId=courseStudent.CourseId;
                int studentId=courseStudent.StudentId;
                FormCourseStudent form = new FormCourseStudent(courseId,studentId);
                form.ShowDialog();
                LoadData();
            }

        }

        async private void GetCourses()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courses = db.Courses.AsQueryable();
            try
            {
                var courseList = await courses.ToListAsync();
                comboBoxCourseId.DisplayMember = "Name";
                comboBoxCourseId.ValueMember = "Id";

                var itemList = new List<Course>(courseList);
                var newItem = new Course { Id = -1, Name = "No Course" };
                itemList.Insert(0, newItem);

                comboBoxCourseId.DataSource = itemList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Database. Please try again.");
            }
        }

        async private void GetStudents()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();

            try
            {
                var students = db.Students.AsQueryable();
                comboBoxStudentId.DisplayMember = "FirstName";
                comboBoxStudentId.ValueMember = "Id";

                var studentList = await students.ToListAsync();
                var itemList = new List<Student>(studentList);
                var newItem = new Student { Id = -1, FirstName = "No Student" };
                itemList.Insert(0, newItem);

                comboBoxStudentId.DataSource = itemList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Database. Please try again.");
            }
        }

    }
}
