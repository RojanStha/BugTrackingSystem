namespace BugTrackingSystem
{
    partial class ProjectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEndDate);
            this.panel1.Controls.Add(this.txtCreatedDate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProject);
            this.panel1.Controls.Add(this.lblMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 484);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(31, 232);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(273, 20);
            this.txtEndDate.TabIndex = 22;
            // 
            // txtCreatedDate
            // 
            this.txtCreatedDate.Location = new System.Drawing.Point(31, 173);
            this.txtCreatedDate.Name = "txtCreatedDate";
            this.txtCreatedDate.Size = new System.Drawing.Size(273, 20);
            this.txtCreatedDate.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(31, 322);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 37);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(176, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 37);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(31, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 37);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "End Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Created date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Name";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(31, 105);
            this.txtProject.Multiline = true;
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(273, 34);
            this.txtProject.TabIndex = 8;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(27, 32);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(68, 24);
            this.lblMember.TabIndex = 7;
            this.lblMember.Text = "Project";
            this.lblMember.Click += new System.EventHandler(this.lblMember_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.projectList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(334, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 484);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Project List";
            // 
            // projectList
            // 
            this.projectList.AllowUserToAddRows = false;
            this.projectList.AllowUserToDeleteRows = false;
            this.projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectList.Location = new System.Drawing.Point(2, 58);
            this.projectList.Name = "projectList";
            this.projectList.ReadOnly = true;
            this.projectList.Size = new System.Drawing.Size(339, 417);
            this.projectList.TabIndex = 1;
            this.projectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberListdataView_CellContentClick);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectForm";
            this.Text = "AddProject";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView projectList;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.DateTimePicker txtCreatedDate;
    }
}