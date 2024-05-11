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

namespace LearningSystem.Views.CourseSessionAttendendanceViews
{
    public partial class FormViewCourseSessionAttendendance : Form
    {
        public FormViewCourseSessionAttendendance()
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
            GetCourseSession();
            GetStudents();
            btnLoad.Enabled = false;
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courseSessionAttendances = db.CourseSessionAttendances.AsQueryable();
            if (txtNotes.Text.Length > 0)
            {
                courseSessionAttendances = courseSessionAttendances.Where(x => x.Notes.Contains(txtNotes.Text.Trim()));
            }

            if (int.TryParse(txtGrade.Text, out int grade) && grade > 0)
            {
                courseSessionAttendances = courseSessionAttendances.Where(x => x.Grade == grade);
            }

            if (comboBoxCourseSessionId.SelectedValue != null && Convert.ToInt32(comboBoxCourseSessionId.SelectedValue) != -1)
            {
                var courseSessionId = Convert.ToInt32(comboBoxCourseSessionId.SelectedValue);

                courseSessionAttendances = courseSessionAttendances.Where(x => x.CourseSessionId == courseSessionId);
            }
            if (comboBoxStudentId.SelectedValue != null && Convert.ToInt32(comboBoxStudentId.SelectedValue) != -1)
            {
                var studentId = Convert.ToInt32(comboBoxStudentId.SelectedValue);
                courseSessionAttendances = courseSessionAttendances.Where(x => x.StudentId == studentId);
            }
            try
            {
                dataGridView1.DataSource = await courseSessionAttendances.ToListAsync();

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
            if (dataGridView1.CurrentRow.DataBoundItem is CourseSessionAttendance courseSessionAttendance)
            {
                int id = courseSessionAttendance.Id;
                FormCourseSessionAttendendance form = new FormCourseSessionAttendendance(id);
                form.ShowDialog();
                LoadData();
            }

        }
        async private void GetCourseSession()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();

            try
            {
                var courseSessions = db.CourseSessions.AsQueryable();

                comboBoxCourseSessionId.DisplayMember = "Date";
                comboBoxCourseSessionId.ValueMember = "Id";

                var courseSessionList = await courseSessions.ToListAsync();

                var itemList = new List<CourseSession>(courseSessionList);


                var newItem = new CourseSession { Id = -1, Date = new DateOnly(0001, 1, 1) };
                itemList.Insert(0, newItem);

                comboBoxCourseSessionId.DataSource = itemList;
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
