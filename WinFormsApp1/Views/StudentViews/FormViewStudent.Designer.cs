namespace LearningSystem.Views.StudentViews
{
    partial class FormViewStudent
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
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnLoad = new Button();
            btnOpen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(540, 69);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 23);
            txtPhone.TabIndex = 37;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(139, 69);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 23);
            txtLastName.TabIndex = 36;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(139, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 23);
            txtFirstName.TabIndex = 35;
            // 
            // txtId
            // 
            txtId.Location = new Point(540, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 69);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 33;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 69);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 32;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 31;
            label2.Text = "FirstName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 23);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 30;
            label1.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 268);
            dataGridView1.TabIndex = 38;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(22, 426);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 45);
            btnLoad.TabIndex = 40;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(641, 426);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(134, 45);
            btnOpen.TabIndex = 39;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // FormViewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(btnLoad);
            Controls.Add(btnOpen);
            Controls.Add(dataGridView1);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormViewStudent";
            Text = "FormViewStudent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnLoad;
        private Button btnOpen;
    }
}