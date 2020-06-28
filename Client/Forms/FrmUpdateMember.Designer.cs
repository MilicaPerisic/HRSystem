namespace Client.Forms
{
    partial class FrmUpdateMember
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.cmbMembershipStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateOfMembership = new System.Windows.Forms.TextBox();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfPoints = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindMembers = new System.Windows.Forms.Button();
            this.dgvFoundMembers = new System.Windows.Forms.DataGridView();
            this.txtNameToFind = new System.Windows.Forms.TextBox();
            this.txtSurnameToFind = new System.Windows.Forms.TextBox();
            this.btnSelectMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "(dd/mm/yyyy)";
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(208, 393);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(121, 23);
            this.btnUpdateMember.TabIndex = 22;
            this.btnUpdateMember.Text = "Izmeni člana";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // cmbMembershipStatus
            // 
            this.cmbMembershipStatus.FormattingEnabled = true;
            this.cmbMembershipStatus.Location = new System.Drawing.Point(208, 341);
            this.cmbMembershipStatus.Name = "cmbMembershipStatus";
            this.cmbMembershipStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbMembershipStatus.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Status članstva";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(208, 284);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Datum učlanjenja";
            // 
            // txtDateOfMembership
            // 
            this.txtDateOfMembership.Location = new System.Drawing.Point(28, 342);
            this.txtDateOfMembership.Name = "txtDateOfMembership";
            this.txtDateOfMembership.Size = new System.Drawing.Size(112, 20);
            this.txtDateOfMembership.TabIndex = 16;
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(28, 284);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(112, 20);
            this.txtMemberSurname.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prezime";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(28, 234);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(112, 20);
            this.txtMemberName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ime";
            // 
            // txtNumberOfPoints
            // 
            this.txtNumberOfPoints.Location = new System.Drawing.Point(208, 234);
            this.txtNumberOfPoints.Name = "txtNumberOfPoints";
            this.txtNumberOfPoints.Size = new System.Drawing.Size(112, 20);
            this.txtNumberOfPoints.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Broj poena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // btnFindMembers
            // 
            this.btnFindMembers.Location = new System.Drawing.Point(222, 49);
            this.btnFindMembers.Name = "btnFindMembers";
            this.btnFindMembers.Size = new System.Drawing.Size(107, 23);
            this.btnFindMembers.TabIndex = 2;
            this.btnFindMembers.Text = "Pretraži članove";
            this.btnFindMembers.UseVisualStyleBackColor = true;
            this.btnFindMembers.Click += new System.EventHandler(this.btnFindMembers_Click);
            // 
            // dgvFoundMembers
            // 
            this.dgvFoundMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundMembers.Location = new System.Drawing.Point(28, 90);
            this.dgvFoundMembers.Name = "dgvFoundMembers";
            this.dgvFoundMembers.Size = new System.Drawing.Size(301, 85);
            this.dgvFoundMembers.TabIndex = 3;
            // 
            // txtNameToFind
            // 
            this.txtNameToFind.Location = new System.Drawing.Point(81, 22);
            this.txtNameToFind.Name = "txtNameToFind";
            this.txtNameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtNameToFind.TabIndex = 4;
            // 
            // txtSurnameToFind
            // 
            this.txtSurnameToFind.Location = new System.Drawing.Point(81, 52);
            this.txtSurnameToFind.Name = "txtSurnameToFind";
            this.txtSurnameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameToFind.TabIndex = 5;
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Location = new System.Drawing.Point(222, 182);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(107, 23);
            this.btnSelectMember.TabIndex = 24;
            this.btnSelectMember.Text = "Izaberi člana";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 428);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumberOfPoints);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.cmbMembershipStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateOfMembership);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSurnameToFind);
            this.Controls.Add(this.txtNameToFind);
            this.Controls.Add(this.dgvFoundMembers);
            this.Controls.Add(this.btnFindMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateMember";
            this.Text = "Izmeni člana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.ComboBox cmbMembershipStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDateOfMembership;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfPoints;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFindMembers;
        private System.Windows.Forms.DataGridView dgvFoundMembers;
        private System.Windows.Forms.TextBox txtNameToFind;
        private System.Windows.Forms.TextBox txtSurnameToFind;
        private System.Windows.Forms.Button btnSelectMember;
    }
}