using LearningSystem.Views.StudentViews;
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

namespace LearningSystem.Views.InstructorViews
{
    public partial class FormViewInstructor : Form
    {
        public FormViewInstructor()
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
            GetHeadedBy();
            btnLoad.Enabled = false;
            LearningSystemDbContext db = new LearningSystemDbContext();
            var instructors = db.Instructors.AsQueryable();
            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                instructors = instructors.Where(x => x.Id == id);
            }
            if (txtFirstName.Text.Length > 0)
            {
                instructors = instructors.Where(x => x.FirstName.Contains(txtFirstName.Text.Trim()));
            }
            if (txtLastName.Text.Length > 0)
            {
                instructors = instructors.Where(x => x.LastName.Contains(txtLastName.Text.Trim()));
            }
            if (txtPhone.Text.Length > 0)
            {
                instructors = instructors.Where(x => x.Phone.Contains(txtPhone.Text.Trim()));
            }
            if (comboBoxHeadedBy.SelectedValue != null && Convert.ToInt32(comboBoxHeadedBy.SelectedValue) != -1)
            {
                var Headedid = Convert.ToInt32(comboBoxHeadedBy.SelectedValue);

                instructors = instructors.Where(x => x.HeadedBy==Headedid);
            }
            if (comboBoxDepartmentName.SelectedValue != null && comboBoxDepartmentName.SelectedValue.ToString() != "No Department")
            {
                var departmentName = comboBoxDepartmentName.SelectedValue.ToString();

                instructors = instructors.Where(x => x.DepartmentName.Contains(departmentName) );
            }
            try
            {
                dataGridView1.DataSource = await instructors.ToListAsync();

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
            if (dataGridView1.CurrentRow.DataBoundItem is Instructor instructor)
            {
                int id = instructor.Id;
                FormInstructor form = new FormInstructor(id);
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

        async private void GetHeadedBy()
        {
            LearningSystemDbContext db = new LearningSystemDbContext();
            var instructors = db.Instructors.AsQueryable();
            try
            {
                var instructorList = await instructors.ToListAsync();
                comboBoxHeadedBy.DisplayMember = "FirstName";
                comboBoxHeadedBy.ValueMember = "Id";

                var itemList = new List<Instructor>(instructorList);
                var newItem = new Instructor { Id = -1, FirstName = "No Supervisor" };
                itemList.Insert(0, newItem);

                comboBoxHeadedBy.DataSource = itemList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Data Base Please Try Again");
            }
        }

    }
}
