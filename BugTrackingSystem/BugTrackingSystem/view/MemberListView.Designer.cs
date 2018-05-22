namespace BugTrackingSystem.view
{
    partial class MemberListView
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
            this.userView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userView)).BeginInit();
            this.SuspendLayout();
            // 
            // userView
            // 
            this.userView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userView.Location = new System.Drawing.Point(0, 60);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(690, 379);
            this.userView.TabIndex = 0;
            this.userView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(643, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MemberListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberListView";
            this.Text = "MemberListView";
            this.Load += new System.EventHandler(this.MemberListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}