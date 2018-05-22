namespace BugTrackingSystem.view
{
    partial class ProjectListView
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
            this.projectList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            this.SuspendLayout();
            // 
            // projectList
            // 
            this.projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectList.Location = new System.Drawing.Point(12, 63);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(720, 391);
            this.projectList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(683, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project List";
            // 
            // ProjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectListView";
            this.Text = "ProjectListView";
            this.Load += new System.EventHandler(this.ProjectListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}