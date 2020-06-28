namespace Client.Forms
{
    partial class FrmMain
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
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateActivity = new System.Windows.Forms.Button();
            this.btnAddEngagement = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchMember);
            this.panel1.Controls.Add(this.btnDeleteMember);
            this.panel1.Controls.Add(this.btnUpdateMember);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 195);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(23, 151);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(101, 23);
            this.btnSearchMember.TabIndex = 3;
            this.btnSearchMember.Text = "Pretraga članova";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(23, 109);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Brisanje člana";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(23, 62);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(101, 23);
            this.btnUpdateMember.TabIndex = 1;
            this.btnUpdateMember.Text = "Izmena člana";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(23, 17);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(101, 23);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Unos člana";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateActivity);
            this.panel2.Controls.Add(this.btnAddEngagement);
            this.panel2.Controls.Add(this.btnAddActivity);
            this.panel2.Location = new System.Drawing.Point(204, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 195);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdateActivity
            // 
            this.btnUpdateActivity.Location = new System.Drawing.Point(26, 62);
            this.btnUpdateActivity.Name = "btnUpdateActivity";
            this.btnUpdateActivity.Size = new System.Drawing.Size(118, 23);
            this.btnUpdateActivity.TabIndex = 6;
            this.btnUpdateActivity.Text = "Izmena aktivnosti";
            this.btnUpdateActivity.UseVisualStyleBackColor = true;
            this.btnUpdateActivity.Click += new System.EventHandler(this.btnUpdateActivity_Click);
            // 
            // btnAddEngagement
            // 
            this.btnAddEngagement.Location = new System.Drawing.Point(26, 109);
            this.btnAddEngagement.Name = "btnAddEngagement";
            this.btnAddEngagement.Size = new System.Drawing.Size(118, 23);
            this.btnAddEngagement.TabIndex = 5;
            this.btnAddEngagement.Text = "Unos angažovanja";
            this.btnAddEngagement.UseVisualStyleBackColor = true;
            this.btnAddEngagement.Click += new System.EventHandler(this.btnAddEngagement_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(26, 17);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(118, 23);
            this.btnAddActivity.TabIndex = 4;
            this.btnAddActivity.Text = "Unos aktivnosti";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Članovi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktivnosti";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "HR sistem";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdateActivity;
        private System.Windows.Forms.Button btnAddEngagement;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}