namespace BugTrackingSystem
{
    partial class Bug
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
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtProject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bugtableview = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugtableview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtstatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtLine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.txtProject);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIssue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 482);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Active",
            "Solved"});
            this.txtstatus.Location = new System.Drawing.Point(232, 334);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(199, 21);
            this.txtstatus.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Status";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(157, 372);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 37);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(297, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 37);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "File / Form Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(24, 119);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(339, 25);
            this.txtFile.TabIndex = 24;
            this.txtFile.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Line No";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(24, 170);
            this.txtLine.Multiline = true;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(339, 25);
            this.txtLine.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Bugs";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(20, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 37);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Date";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(28, 334);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(188, 20);
            this.txtdate.TabIndex = 18;
            // 
            // txtProject
            // 
            this.txtProject.FormattingEnabled = true;
            this.txtProject.Location = new System.Drawing.Point(24, 70);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(273, 21);
            this.txtProject.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Issue";
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(26, 221);
            this.txtIssue.Multiline = true;
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(337, 87);
            this.txtIssue.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Project";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bugtableview
            // 
            this.bugtableview.AllowUserToAddRows = false;
            this.bugtableview.AllowUserToDeleteRows = false;
            this.bugtableview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugtableview.Location = new System.Drawing.Point(461, 88);
            this.bugtableview.Name = "bugtableview";
            this.bugtableview.ReadOnly = true;
            this.bugtableview.Size = new System.Drawing.Size(452, 394);
            this.bugtableview.TabIndex = 2;
            this.bugtableview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberListdataView_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Bug Reports";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Maroon;
            this.close.Location = new System.Drawing.Point(874, 13);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 31;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Bug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 482);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bugtableview);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bug";
            this.Load += new System.EventHandler(this.Bug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugtableview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.ComboBox txtProject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView bugtableview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label close;
    }
}