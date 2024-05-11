namespace LearningSystem.Views.DepartmentViews
{
    partial class FormViewDepartment
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
            btnLoad = new Button();
            btnOpen = new Button();
            dataGridView1 = new DataGridView();
            txtLocation = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(22, 443);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 51;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(641, 443);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 50;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 49;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(131, 71);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(175, 23);
            txtLocation.TabIndex = 55;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 71);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 53;
            label3.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 25);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 52;
            label2.Text = "Name";
            // 
            // FormViewDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Name = "FormViewDepartment";
            Text = "FormViewDepartment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnOpen;
        private DataGridView dataGridView1;
        private TextBox txtLocation;
        private TextBox txtName;
        private Label label3;
        private Label label2;
    }
}