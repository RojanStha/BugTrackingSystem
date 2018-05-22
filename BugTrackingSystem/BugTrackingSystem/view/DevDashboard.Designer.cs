namespace BugTrackingSystem.view
{
    partial class DevDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnBug = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnVersion = new System.Windows.Forms.Button();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 69);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo.Location = new System.Drawing.Point(66, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(122, 24);
            this.logo.TabIndex = 2;
            this.logo.Text = "Bug Tracking";
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProject.Location = new System.Drawing.Point(6, 107);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(188, 44);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "Project";
            this.btnProject.UseVisualStyleBackColor = false;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMember.Location = new System.Drawing.Point(6, 157);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(188, 44);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnBug
            // 
            this.btnBug.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBug.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBug.Location = new System.Drawing.Point(6, 207);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(188, 44);
            this.btnBug.TabIndex = 4;
            this.btnBug.Text = "Bug";
            this.btnBug.UseVisualStyleBackColor = false;
            this.btnBug.Click += new System.EventHandler(this.btnBug_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(43, 340);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 29);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnVersion
            // 
            this.btnVersion.BackColor = System.Drawing.Color.Crimson;
            this.btnVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVersion.Location = new System.Drawing.Point(6, 257);
            this.btnVersion.Name = "btnVersion";
            this.btnVersion.Size = new System.Drawing.Size(188, 44);
            this.btnVersion.TabIndex = 7;
            this.btnVersion.Text = "Version Control";
            this.btnVersion.UseVisualStyleBackColor = false;
            this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideMenu.Controls.Add(this.btnVersion);
            this.SideMenu.Controls.Add(this.btnLogOut);
            this.SideMenu.Controls.Add(this.btnBug);
            this.SideMenu.Controls.Add(this.btnMember);
            this.SideMenu.Controls.Add(this.btnProject);
            this.SideMenu.Controls.Add(this.panel1);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(200, 628);
            this.SideMenu.TabIndex = 3;
            this.SideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.SideMenu_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.lblClose);
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.lbluser);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 69);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Maroon;
            this.lblClose.Location = new System.Drawing.Point(831, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 18);
            this.lblClose.TabIndex = 8;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRole.Location = new System.Drawing.Point(572, 40);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(63, 15);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Developer";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbluser.Location = new System.Drawing.Point(563, 20);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(83, 20);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 427);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 69);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(878, 559);
            this.contentPanel.TabIndex = 5;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // DevDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 628);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevDashboard";
            this.Text = "DevDashboard";
            this.Load += new System.EventHandler(this.DevDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnBug;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnVersion;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lbluser;
    }
}