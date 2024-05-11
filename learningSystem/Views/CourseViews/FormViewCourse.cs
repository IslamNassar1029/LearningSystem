using LearningSystem.Views.InstructorViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1;
using Microsoft.EntityFrameworkCore;

namespace LearningSystem.Views.CourseViews
{
    public partial class FormViewCourse : Form
    {
        public FormViewCourse()
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
            GetDepartment();
            GetInstructorId();
            btnLoad.Enabled = false;
            LearningSystemDbContext db = new LearningSystemDbContext();
            var courses = db.Courses.AsQueryable();
            if (txtName.Text.Length > 0)
            {
                courses = courses.Where(x => x.Name.Contains(txtName.Text.Trim()));
            }

            if (int.TryParse(txtDuration.Text, out int duration) && duration > 0)
            {
                courses = courses.Where(x => x.Duration == duration);
            }

            if (comboBoxinstructorId.SelectedValue != null && Convert.ToInt32(comboBoxinstructorId.SelectedValue) != -1)
            {
                var instrcutorId = Convert.ToInt32(comboBoxinstructorId.SelectedValue);

                courses = courses.Where(x => x.InstructorId == instrcutorId);
            }
            if (comboBoxDepartmentName.SelectedValue != null && comboBoxDepartmentName.SelectedValue.ToString() != "No Department")
            {
                var departmentName = comboBoxDepartmentName.SelectedValue.ToString();

                courses = courses.Where(x => x.DepartmentName.Contains(departmentName));
            }
            try
            {
                dataGridView1.DataSource = await courses.ToListAsync();

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
            if (dataGridView1.CurrentRow.DataBoundItem is Course course)
            {
                int id = course.Id;
                FormCourse form = new FormCourse(id);
                form.ShowDialog();
                LoadData();
            }

        }
        async private void GetDepartment()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var departments = db.Departments.AsQueryable();
            try
            {
                var departmentList = await departments.ToListAsync();
                comboBoxDepartmentName.DisplayMember = "Name";
                comboBoxDepartmentName.ValueMember = "Name";

                var itemList = new List<Department>(departmentList);
                var newItem = new Department { Name = "No Department" };
                itemList.Insert(0, newItem);

                comboBoxDepartmentName.DataSource = itemList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }

        async private void GetInstructorId()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var instructors = db.Instructors.AsQueryable();
            try
            {
                var instructorList = await instructors.ToListAsync();
                comboBoxinstructorId.DisplayMember = "FirstName";
                comboBoxinstructorId.ValueMember = "Id";

                var itemList = new List<Instructor>(instructorList);
                var newItem = new Instructor { Id = -1, FirstName = "No Supervisor" };
                itemList.Insert(0, newItem);

                comboBoxinstructorId.DataSource = itemList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }
    }
}
