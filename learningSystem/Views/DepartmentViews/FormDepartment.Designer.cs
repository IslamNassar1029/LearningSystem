namespace LearningSystem.Views.DepartmentViews
{
    partial class FormDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            btnNew = new Button();
            btnSave = new Button();
            txtLocation = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(380, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(380, 38);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 42;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(380, 95);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(152, 84);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(175, 23);
            txtLocation.TabIndex = 39;
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 84);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 35;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 38);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 34;
            label2.Text = "Name";
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormDepartment";
            Text = "FormDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private TextBox txtLocation;
        private TextBox txtName;
        private Label label3;
        private Label label2;
    }
}