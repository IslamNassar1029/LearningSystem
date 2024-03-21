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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LearningSystem.Views.InstructorViews
{
    public partial class FormInstructor : Form
    {
        public FormInstructor()
        {
            InitializeComponent();
            New();
        }
        public FormInstructor(int id) : this()
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
        Instructor instructor;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            instructor = new Instructor();
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            GetDepartment();
            GetHeadedBy();
            AddOrUpdate = true;
        }
        async void Load(int id)
        {
            try
            {
                instructor = await db.Instructors.FirstAsync(x => x.Id == id);
                txtId.Text = instructor.Id.ToString();
                txtFirstName.Text = instructor.FirstName;
                txtLastName.Text = instructor.LastName;
                txtPhone.Text = instructor.Phone;

                var selectedDepartment = comboBoxDepartmentName.Items
                                        .Cast<Department>()
                                        .Select((d, index) => new { Department = d, Index = index })
                                        .FirstOrDefault(x => x.Department.Name == instructor.DepartmentName);

                if (selectedDepartment != null)
                {
                    comboBoxDepartmentName.SelectedIndex = selectedDepartment.Index;
                }

                var selectedInstructor = comboBoxHeadedBy.Items
                                        .Cast<Instructor>()
                                        .Select((i, index) => new { Instructor = i, Index = index })
                                        .FirstOrDefault(x => x.Instructor.Id == instructor.HeadedBy);
                comboBoxHeadedBy.SelectedIndex = selectedInstructor.Index;
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
            instructor.FirstName = txtFirstName.Text;
            instructor.LastName = txtLastName.Text;
            instructor.Phone = txtPhone.Text;
            instructor.DepartmentName = comboBoxDepartmentName.SelectedValue.ToString();
            if (Convert.ToInt32(comboBoxHeadedBy.SelectedValue) != -1)
            {
                instructor.HeadedBy = Convert.ToInt32(comboBoxHeadedBy.SelectedValue);
            }
            else
            {
                instructor.HeadedBy = null;
            }

        
            try
            {
                if (AddOrUpdate) db.Instructors.Add(instructor);

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
                db.Instructors.Remove(instructor);
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
