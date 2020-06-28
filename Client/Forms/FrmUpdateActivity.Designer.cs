namespace Client.Forms
{
    partial class FrmUpdateActivity
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
            this.rtbActivityDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.cmbTypeOfActivity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfPoints = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectActivity = new System.Windows.Forms.Button();
            this.txtActivityNameToFind = new System.Windows.Forms.TextBox();
            this.dgvFoundActivities = new System.Windows.Forms.DataGridView();
            this.btnFindActivities = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbActivityDescription
            // 
            this.rtbActivityDescription.Location = new System.Drawing.Point(185, 194);
            this.rtbActivityDescription.Name = "rtbActivityDescription";
            this.rtbActivityDescription.Size = new System.Drawing.Size(155, 178);
            this.rtbActivityDescription.TabIndex = 34;
            this.rtbActivityDescription.Text = "";
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(185, 393);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(155, 23);
            this.btnAddActivity.TabIndex = 33;
            this.btnAddActivity.Text = "Izmeni aktivnost";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // cmbTypeOfActivity
            // 
            this.cmbTypeOfActivity.FormattingEnabled = true;
            this.cmbTypeOfActivity.Location = new System.Drawing.Point(26, 351);
            this.cmbTypeOfActivity.Name = "cmbTypeOfActivity";
            this.cmbTypeOfActivity.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeOfActivity.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tip aktivnosti";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(25, 294);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Grad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Opis aktivnosti";
            // 
            // txtNumberOfPoints
            // 
            this.txtNumberOfPoints.Location = new System.Drawing.Point(25, 244);
            this.txtNumberOfPoints.Name = "txtNumberOfPoints";
            this.txtNumberOfPoints.Size = new System.Drawing.Size(122, 20);
            this.txtNumberOfPoints.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Broj bodova";
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(25, 194);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(122, 20);
            this.txtActivityName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Naziv aktivnosti";
            // 
            // btnSelectActivity
            // 
            this.btnSelectActivity.Location = new System.Drawing.Point(219, 136);
            this.btnSelectActivity.Name = "btnSelectActivity";
            this.btnSelectActivity.Size = new System.Drawing.Size(121, 23);
            this.btnSelectActivity.TabIndex = 41;
            this.btnSelectActivity.Text = "Izaberi aktivnost";
            this.btnSelectActivity.UseVisualStyleBackColor = true;
            this.btnSelectActivity.Click += new System.EventHandler(this.btnSelectActivity_Click);
            // 
            // txtActivityNameToFind
            // 
            this.txtActivityNameToFind.Location = new System.Drawing.Point(78, 18);
            this.txtActivityNameToFind.Name = "txtActivityNameToFind";
            this.txtActivityNameToFind.Size = new System.Drawing.Size(100, 20);
            this.txtActivityNameToFind.TabIndex = 39;
            // 
            // dgvFoundActivities
            // 
            this.dgvFoundActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoundActivities.Location = new System.Drawing.Point(25, 45);
            this.dgvFoundActivities.Name = "dgvFoundActivities";
            this.dgvFoundActivities.Size = new System.Drawing.Size(315, 85);
            this.dgvFoundActivities.TabIndex = 38;
            // 
            // btnFindActivities
            // 
            this.btnFindActivities.Location = new System.Drawing.Point(219, 16);
            this.btnFindActivities.Name = "btnFindActivities";
            this.btnFindActivities.Size = new System.Drawing.Size(121, 23);
            this.btnFindActivities.TabIndex = 37;
            this.btnFindActivities.Text = "Pretraži aktivnosti";
            this.btnFindActivities.UseVisualStyleBackColor = true;
            this.btnFindActivities.Click += new System.EventHandler(this.btnFindActivities_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Naziv";
            // 
            // FrmUpdateActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 435);
            this.Controls.Add(this.btnSelectActivity);
            this.Controls.Add(this.txtActivityNameToFind);
            this.Controls.Add(this.dgvFoundActivities);
            this.Controls.Add(this.btnFindActivities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbActivityDescription);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.cmbTypeOfActivity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumberOfPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtActivityName);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateActivity";
            this.Text = "Izmeni aktivnost";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoundActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbActivityDescription;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.ComboBox cmbTypeOfActivity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectActivity;
        private System.Windows.Forms.TextBox txtActivityNameToFind;
        private System.Windows.Forms.DataGridView dgvFoundActivities;
        private System.Windows.Forms.Button btnFindActivities;
        private System.Windows.Forms.Label label7;
    }
}