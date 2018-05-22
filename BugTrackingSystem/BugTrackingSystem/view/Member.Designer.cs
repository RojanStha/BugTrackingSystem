namespace BugTrackingSystem
{
    partial class Member
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
            this.lblMember = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdob = new System.Windows.Forms.DateTimePicker();
            this.txtrole = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MemberListdataView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberListdataView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(32, 25);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(92, 24);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Memeber";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdob);
            this.panel1.Controls.Add(this.txtrole);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMember);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 537);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(31, 276);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(273, 20);
            this.txtdob.TabIndex = 19;
            this.txtdob.ValueChanged += new System.EventHandler(this.txtdob_ValueChanged);
            // 
            // txtrole
            // 
            this.txtrole.FormattingEnabled = true;
            this.txtrole.Items.AddRange(new object[] {
            "Admin",
            "Developer",
            "Tester"});
            this.txtrole.Location = new System.Drawing.Point(31, 84);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(273, 21);
            this.txtrole.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(222, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 37);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(120, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(18, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(31, 403);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(273, 34);
            this.txtPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DOB";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(31, 199);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 34);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(31, 335);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 34);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(31, 134);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(273, 34);
            this.txtname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.Red;
            this.lblclose.Location = new System.Drawing.Point(674, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(20, 20);
            this.lblclose.TabIndex = 22;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Memeber List";
            // 
            // MemberListdataView
            // 
            this.MemberListdataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberListdataView.Location = new System.Drawing.Point(354, 51);
            this.MemberListdataView.Name = "MemberListdataView";
            this.MemberListdataView.Size = new System.Drawing.Size(340, 474);
            this.MemberListdataView.TabIndex = 20;
            this.MemberListdataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberListdataView_CellContentClick_1);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 537);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MemberListdataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Member";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Member_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberListdataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox txtrole;
        private System.Windows.Forms.DateTimePicker txtdob;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView MemberListdataView;
    }
}