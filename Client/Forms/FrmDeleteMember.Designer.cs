namespace Client.Forms
{
    partial class FrmDeleteMember
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
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.txtSurnameToFind = new System.Windows.Forms.TextBox();
            this.txtNameToFind = new System.Windows.Forms.TextBox();
            this.dgvFoundMembers = new System.Windows.Forms.DataGridView();
            this.btnFindMembers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(216, 176);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteMember.TabIndex = 31;
            this.btnDeleteMember.Text = "Izbriši člana";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // txtSurnameToFind
            // 
            this.txtSurnameToFind.Location = new System.Drawing.Point(75, 46);
            this.txtSurnameToFind.Name = "txtSurnameToFind";
            this.txtSurnameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameToFind.TabIndex = 30;
            // 
            // txtNameToFind
            // 
            this.txtNameToFind.Location = new System.Drawing.Point(75, 16);
            this.txtNameToFind.Name = "txtNameToFind";
            this.txtNameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtNameToFind.TabIndex = 29;
            // 
            // dgvFoundMembers
            // 
            this.dgvFoundMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundMembers.Location = new System.Drawing.Point(22, 84);
            this.dgvFoundMembers.Name = "dgvFoundMembers";
            this.dgvFoundMembers.Size = new System.Drawing.Size(301, 85);
            this.dgvFoundMembers.TabIndex = 28;
            // 
            // btnFindMembers
            // 
            this.btnFindMembers.Location = new System.Drawing.Point(216, 43);
            this.btnFindMembers.Name = "btnFindMembers";
            this.btnFindMembers.Size = new System.Drawing.Size(107, 23);
            this.btnFindMembers.TabIndex = 27;
            this.btnFindMembers.Text = "Pretraži članove";
            this.btnFindMembers.UseVisualStyleBackColor = true;
            this.btnFindMembers.Click += new System.EventHandler(this.btnFindMembers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ime";
            // 
            // FrmDeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 213);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.txtSurnameToFind);
            this.Controls.Add(this.txtNameToFind);
            this.Controls.Add(this.dgvFoundMembers);
            this.Controls.Add(this.btnFindMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeleteMember";
            this.Text = "Izbriši člana";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.TextBox txtSurnameToFind;
        private System.Windows.Forms.TextBox txtNameToFind;
        private System.Windows.Forms.DataGridView dgvFoundMembers;
        private System.Windows.Forms.Button btnFindMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}