namespace Client.Forms
{
    partial class FrmAddMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.txtDateOfMembership = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMembershipStatus = new System.Windows.Forms.ComboBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumberOfPoints = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.Color.White;
            this.txtMemberName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMemberName.Location = new System.Drawing.Point(26, 42);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(112, 20);
            this.txtMemberName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.Location = new System.Drawing.Point(26, 92);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(112, 20);
            this.txtMemberSurname.TabIndex = 3;
            // 
            // txtDateOfMembership
            // 
            this.txtDateOfMembership.Location = new System.Drawing.Point(26, 150);
            this.txtDateOfMembership.Name = "txtDateOfMembership";
            this.txtDateOfMembership.Size = new System.Drawing.Size(112, 20);
            this.txtDateOfMembership.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum učlanjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grad";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(206, 91);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status članstva";
            // 
            // cmbMembershipStatus
            // 
            this.cmbMembershipStatus.FormattingEnabled = true;
            this.cmbMembershipStatus.Location = new System.Drawing.Point(206, 149);
            this.cmbMembershipStatus.Name = "cmbMembershipStatus";
            this.cmbMembershipStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbMembershipStatus.TabIndex = 9;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(206, 183);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(121, 23);
            this.btnAddMember.TabIndex = 10;
            this.btnAddMember.Text = "Unesi člana";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(dd/mm/yyyy)";
            // 
            // txtNumberOfPoints
            // 
            this.txtNumberOfPoints.BackColor = System.Drawing.Color.White;
            this.txtNumberOfPoints.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumberOfPoints.Location = new System.Drawing.Point(206, 42);
            this.txtNumberOfPoints.Name = "txtNumberOfPoints";
            this.txtNumberOfPoints.Size = new System.Drawing.Size(112, 20);
            this.txtNumberOfPoints.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Broj poena";
            // 
            // FrmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 227);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumberOfPoints);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cmbMembershipStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDateOfMembership);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddMember";
            this.Text = "Unos člana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.TextBox txtDateOfMembership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMembershipStatus;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumberOfPoints;
        private System.Windows.Forms.Label label7;
    }
}