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

namespace LearningSystem.Views.DepartmentViews
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
            New();

        }

        public FormDepartment(string name) : this()
        {
            Load(name);

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
        Department department;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            department = new Department();
            txtName.Text = "";
            txtLocation.Text = "";
            AddOrUpdate = true;
        }
        async void Load(string name)
        {
            try
            {
                department = await db.Departments.FirstAsync(x => x.Name == name);
                txtName.Text = department.Name;
                txtLocation.Text = department.Location;
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







        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            department.Name = txtName.Text;
            department.Location = txtLocation.Text;
            try
            {
                if (AddOrUpdate) db.Departments.Add(department);

                await db.SaveChangesAsync();
                MessageBox.Show(AddOrUpdate ? "Department Added" : "Department Updated");
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
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                db.Departments.Remove(department);
                await db.SaveChangesAsync();
                MessageBox.Show("Department Deleted");
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
    }
}
