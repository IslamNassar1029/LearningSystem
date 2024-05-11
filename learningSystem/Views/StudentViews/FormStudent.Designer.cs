namespace LearningSystem.Views.StudentViews
{
    partial class FormStudent
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
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(394, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 45);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(394, 49);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(134, 45);
            btnNew.TabIndex = 31;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(394, 106);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 45);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(168, 185);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 23);
            txtPhone.TabIndex = 29;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(168, 136);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 23);
            txtLastName.TabIndex = 28;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(168, 90);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 23);
            txtFirstName.TabIndex = 27;
            // 
            // txtId
            // 
            txtId.Location = new Point(168, 49);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(175, 23);
            txtId.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 185);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 25;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 136);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 24;
            label3.Text = "LastName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 90);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 23;
            label2.Text = "FirstName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 49);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 22;
            label1.Text = "Id";
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormStudent";
            Text = "FormStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnNew;
        private Button btnSave;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}