namespace Client.Forms
{
    partial class FrmAddEngagement
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
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.btnAddEngagement = new System.Windows.Forms.Button();
            this.btnSelectActivity = new System.Windows.Forms.Button();
            this.txtActivityNameToFind = new System.Windows.Forms.TextBox();
            this.dgvFoundActivities = new System.Windows.Forms.DataGridView();
            this.btnFindActivities = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurnameToFind = new System.Windows.Forms.TextBox();
            this.txtNameToFind = new System.Windows.Forms.TextBox();
            this.dgvFoundMembers = new System.Windows.Forms.DataGridView();
            this.btnFindMembers = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSurnameToFind);
            this.panel1.Controls.Add(this.txtNameToFind);
            this.panel1.Controls.Add(this.dgvFoundMembers);
            this.panel1.Controls.Add(this.btnFindMembers);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeleteMember);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvMembers);
            this.panel1.Controls.Add(this.btnAddMember);
            this.panel1.Location = new System.Drawing.Point(25, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 353);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteMember.Location = new System.Drawing.Point(306, 326);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(141, 23);
            this.btnDeleteMember.TabIndex = 5;
            this.btnDeleteMember.Text = "Obriši člana";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unos članova";
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(3, 198);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(444, 124);
            this.dgvMembers.TabIndex = 2;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(306, 170);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(141, 23);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Dodaj člana";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "(dd/mm/yyyy)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum početka aktivnosti";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(31, 575);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(126, 20);
            this.txtStartDate.TabIndex = 12;
            // 
            // btnAddEngagement
            // 
            this.btnAddEngagement.Location = new System.Drawing.Point(31, 599);
            this.btnAddEngagement.Name = "btnAddEngagement";
            this.btnAddEngagement.Size = new System.Drawing.Size(446, 27);
            this.btnAddEngagement.TabIndex = 15;
            this.btnAddEngagement.Text = "Unesi angažovanje";
            this.btnAddEngagement.UseVisualStyleBackColor = true;
            this.btnAddEngagement.Click += new System.EventHandler(this.btnAddEngagement_Click);
            // 
            // btnSelectActivity
            // 
            this.btnSelectActivity.Location = new System.Drawing.Point(332, 156);
            this.btnSelectActivity.Name = "btnSelectActivity";
            this.btnSelectActivity.Size = new System.Drawing.Size(140, 23);
            this.btnSelectActivity.TabIndex = 46;
            this.btnSelectActivity.Text = "Izaberi aktivnost";
            this.btnSelectActivity.UseVisualStyleBackColor = true;
            this.btnSelectActivity.Click += new System.EventHandler(this.btnSelectActivity_Click);
            // 
            // txtActivityNameToFind
            // 
            this.txtActivityNameToFind.Location = new System.Drawing.Point(78, 38);
            this.txtActivityNameToFind.Name = "txtActivityNameToFind";
            this.txtActivityNameToFind.Size = new System.Drawing.Size(107, 20);
            this.txtActivityNameToFind.TabIndex = 45;
            // 
            // dgvFoundActivities
            // 
            this.dgvFoundActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundActivities.Location = new System.Drawing.Point(25, 65);
            this.dgvFoundActivities.Name = "dgvFoundActivities";
            this.dgvFoundActivities.Size = new System.Drawing.Size(447, 85);
            this.dgvFoundActivities.TabIndex = 44;
            // 
            // btnFindActivities
            // 
            this.btnFindActivities.Location = new System.Drawing.Point(332, 38);
            this.btnFindActivities.Name = "btnFindActivities";
            this.btnFindActivities.Size = new System.Drawing.Size(140, 23);
            this.btnFindActivities.TabIndex = 43;
            this.btnFindActivities.Text = "Pretraži aktivnosti";
            this.btnFindActivities.UseVisualStyleBackColor = true;
            this.btnFindActivities.Click += new System.EventHandler(this.btnFindActivities_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unos aktivnosti";
            // 
            // txtSurnameToFind
            // 
            this.txtSurnameToFind.Location = new System.Drawing.Point(59, 58);
            this.txtSurnameToFind.Name = "txtSurnameToFind";
            this.txtSurnameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameToFind.TabIndex = 30;
            // 
            // txtNameToFind
            // 
            this.txtNameToFind.Location = new System.Drawing.Point(59, 32);
            this.txtNameToFind.Name = "txtNameToFind";
            this.txtNameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtNameToFind.TabIndex = 29;
            // 
            // dgvFoundMembers
            // 
            this.dgvFoundMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundMembers.Location = new System.Drawing.Point(6, 85);
            this.dgvFoundMembers.Name = "dgvFoundMembers";
            this.dgvFoundMembers.Size = new System.Drawing.Size(441, 80);
            this.dgvFoundMembers.TabIndex = 28;
            // 
            // btnFindMembers
            // 
            this.btnFindMembers.Location = new System.Drawing.Point(306, 55);
            this.btnFindMembers.Name = "btnFindMembers";
            this.btnFindMembers.Size = new System.Drawing.Size(140, 23);
            this.btnFindMembers.TabIndex = 27;
            this.btnFindMembers.Text = "Pretraži članove";
            this.btnFindMembers.UseVisualStyleBackColor = true;
            this.btnFindMembers.Click += new System.EventHandler(this.btnFindMembers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ime";
            // 
            // FrmAddEngagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectActivity);
            this.Controls.Add(this.txtActivityNameToFind);
            this.Controls.Add(this.dgvFoundActivities);
            this.Controls.Add(this.btnFindActivities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddEngagement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtStartDate);
            this.Name = "FrmAddEngagement";
            this.Text = "Unos angazovanja";
            this.Load += new System.EventHandler(this.FrmAddEngagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEngagement;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnSelectActivity;
        private System.Windows.Forms.TextBox txtActivityNameToFind;
        private System.Windows.Forms.DataGridView dgvFoundActivities;
        private System.Windows.Forms.Button btnFindActivities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurnameToFind;
        private System.Windows.Forms.TextBox txtNameToFind;
        private System.Windows.Forms.DataGridView dgvFoundMembers;
        private System.Windows.Forms.Button btnFindMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}