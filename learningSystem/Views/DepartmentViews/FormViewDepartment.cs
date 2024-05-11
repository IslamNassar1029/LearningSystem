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

namespace LearningSystem.Views.DepartmentViews
{
    public partial class FormViewDepartment : Form
    {
        public FormViewDepartment()
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
            btnLoad.Enabled = false;
            LearningSystemDbContext db = new LearningSystemDbContext();
            var departments = db.Departments.AsQueryable();

            if (txtName.Text.Length > 0)
            {
                departments = departments.Where(x => x.Name.Contains(txtName.Text.Trim()));
            }
            if (txtLocation.Text.Length > 0)
            {
                departments = departments.Where(x => x.Location.Contains(txtLocation.Text.Trim()));
            }
            try
            {
                dataGridView1.DataSource = await departments.ToListAsync();

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
            if (dataGridView1.CurrentRow.DataBoundItem is Department department)
            {
                string name = department.Name;
                FormDepartment departmentForm = new FormDepartment(name);
                departmentForm.ShowDialog();
                LoadData();
            }

        }
    }
}
