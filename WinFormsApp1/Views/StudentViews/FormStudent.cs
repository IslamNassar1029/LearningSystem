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
using Microsoft.EntityFrameworkCore.Metadata;

namespace LearningSystem.Views.StudentViews
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            New();
        }
        public FormStudent(int id) : this()
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
        Student student;
        LearningSystemDbContext db = new LearningSystemDbContext();
        void New()
        {
            student = new Student();
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            AddOrUpdate = true;
        }
        async void Load(int id)
        {
            try
            {
                student = await db.Students.FirstAsync(x => x.Id == id);
                txtId.Text = student.Id.ToString();
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtPhone.Text = student.Phone;
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
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Phone = txtPhone.Text;
            try
            {
                if (AddOrUpdate) db.Students.Add(student);

                await db.SaveChangesAsync();
                MessageBox.Show(AddOrUpdate ? "Student Added" : "Student Updated");
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
                db.Students.Remove(student);
                await db.SaveChangesAsync();
                MessageBox.Show("Student Deleted");
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
