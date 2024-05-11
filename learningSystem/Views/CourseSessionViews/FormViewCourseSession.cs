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

namespace LearningSystem.Views.CourseSessionViews
{
    public partial class FormViewCourseSession : Form
    {
        public FormViewCourseSession()
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
            GetInstructorId();
            btnLoad.Enabled = false;
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courseSessions = db.CourseSessions.AsQueryable();
            if (txtDate.Text.Length > 0)
            {
                if (DateOnly.TryParse(txtDate.Text, out DateOnly dateValue))
                {
                    courseSessions = courseSessions.Where(x => x.Date == dateValue);
                }
                else
                {
                    MessageBox.Show("Invalid Date Format. Please enter a valid date.");
                    return;
                }
            }
            if (txtTitle.Text.Length > 0)
            {
                courseSessions = courseSessions.Where(x => x.Title.Contains(txtTitle.Text.Trim()));
            }

            if (comboBoxInstructorId.SelectedValue != null && Convert.ToInt32(comboBoxInstructorId.SelectedValue) != -1)
            {
                var instrcutorId = Convert.ToInt32(comboBoxInstructorId.SelectedValue);

                courseSessions = courseSessions.Where(x => x.InstructorId == instrcutorId);
               }
                if (comboBoxCourseId.SelectedValue != null && Convert.ToInt32(comboBoxCourseId.SelectedValue) != -1)
            {
                var courseId = Convert.ToInt32(comboBoxCourseId.SelectedValue);
                courseSessions = courseSessions.Where(x => x.CourseId == courseId);
            }

            try
            {
                dataGridView1.DataSource = await courseSessions.ToListAsync();

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
            if (dataGridView1.CurrentRow.DataBoundItem is CourseSession courseSession)
            {
                int id = courseSession.Id;
                FormCourseSession form = new FormCourseSession(id);
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

        async private void GetInstructorId()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var instructors = db.Instructors.AsQueryable();
            try
            {
                var instructorList = await instructors.ToListAsync();
                comboBoxInstructorId.DisplayMember = "FirstName";
                comboBoxInstructorId.ValueMember = "Id";

                var itemList = new List<Instructor>(instructorList);
                var newItem = new Instructor { Id = -1, FirstName = "No Supervisor" };
                itemList.Insert(0, newItem);

                comboBoxInstructorId.DataSource = itemList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }
    }
    }
