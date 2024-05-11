using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp1.Entities;

namespace LearningSystem.Views.StudentViews
{
    public partial class FormViewStudent : Form
    {
        public FormViewStudent()
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
            var students = db.Students.AsQueryable();
            if (int.TryParse(txtId.Text, out int id) && id > 0)
            {
                students = students.Where(x => x.Id == id);
            }
            if (txtFirstName.Text.Length > 0)
            {
                students = students.Where(x => x.FirstName.Contains(txtFirstName.Text.Trim()));
            }
            if (txtLastName.Text.Length > 0)
            {
                students = students.Where(x => x.LastName.Contains(txtLastName.Text.Trim()));
            }
            if (txtPhone.Text.Length > 0)
            {
                students = students.Where(x => x.Phone.Contains(txtPhone.Text.Trim()));
            }

            try
            {
                dataGridView1.DataSource = await students.ToListAsync();

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
            if (dataGridView1.CurrentRow.DataBoundItem is Student student)
            {
                int id = student.Id;    
                FormStudent studentForm = new FormStudent(id);
                studentForm.ShowDialog();
                LoadData();
            }

        }
    }
}
