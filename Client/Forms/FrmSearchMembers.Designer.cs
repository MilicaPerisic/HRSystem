namespace Client.Forms
{
    partial class FrmSearchMembers
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
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnFindMembers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(12, 101);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.Size = new System.Drawing.Size(345, 150);
            this.dgvSearchResults.TabIndex = 4;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(119, 57);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(100, 20);
            this.txtSearchValue.TabIndex = 10;
            // 
            // btnFindMembers
            // 
            this.btnFindMembers.Location = new System.Drawing.Point(249, 55);
            this.btnFindMembers.Name = "btnFindMembers";
            this.btnFindMembers.Size = new System.Drawing.Size(107, 23);
            this.btnFindMembers.TabIndex = 8;
            this.btnFindMembers.Text = "Pretraži članove";
            this.btnFindMembers.UseVisualStyleBackColor = true;
            this.btnFindMembers.Click += new System.EventHandler(this.btnFindMembers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vrednost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kriterijum pretrage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Location = new System.Drawing.Point(119, 27);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchCriteria.TabIndex = 11;
            // 
            // FrmSearchMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 280);
            this.Controls.Add(this.cmbSearchCriteria);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.btnFindMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchResults);
            this.Name = "FrmSearchMembers";
            this.Text = "Pretraga članova";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnFindMembers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchCriteria;
    }
}