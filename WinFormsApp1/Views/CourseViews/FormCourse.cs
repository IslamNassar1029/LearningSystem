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
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
            New();
        }
        public FormCourse(int id) : this()
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
        Course course;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            course = new Course();
            txtId.Text = "";
            txtName.Text = "";
            txtDuration.Text = "";
            GetDepartment();
            GetInstructorId();
            AddOrUpdate = true;
        }
        async void Load(int id)
        {
            try
            {
                course = await db.Courses.FirstAsync(x => x.Id == id);
                txtId.Text = course.Id.ToString();
                txtName.Text = course.Name;
                txtDuration.Text = course.Duration.ToString();

                var selectedDepartment = comboBoxDepartmentName.Items
                                        .Cast<Department>()
                                        .Select((d, index) => new { Department = d, Index = index })
                                        .FirstOrDefault(x => x.Department.Name == course.DepartmentName);

                if (selectedDepartment != null)
                {
                    comboBoxDepartmentName.SelectedIndex = selectedDepartment.Index;
                }

                var selectedInstructor = comboBoxInstructorId.Items
                                        .Cast<Instructor>()
                                        .Select((i, index) => new { Instructor = i, Index = index })
                                        .FirstOrDefault(x => x.Instructor.Id == course.InstructorId);
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
            course.Name = txtName.Text;
            course.Duration = Convert.ToInt32(txtDuration.Text);
            course.DepartmentName = comboBoxDepartmentName.SelectedValue.ToString();
            course.InstructorId = Convert.ToInt32(comboBoxInstructorId.SelectedValue);




            try
            {
                if (AddOrUpdate) db.Courses.Add(course);

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
                db.Courses.Remove(course);
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
        async private void GetDepartment()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var departments = db.Departments.AsQueryable();
            try
            {
                comboBoxDepartmentName.DataSource = await departments.ToListAsync();
                comboBoxDepartmentName.DisplayMember = "Name";
                comboBoxDepartmentName.ValueMember = "Name";

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
