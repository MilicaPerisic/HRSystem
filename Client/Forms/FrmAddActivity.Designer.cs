namespace Client.Forms
{
    partial class FrmAddActivity
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
            this.rtbActivityDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(172, 241);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(155, 23);
            this.btnAddActivity.TabIndex = 22;
            this.btnAddActivity.Text = "Unesi aktivnost";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // cmbTypeOfActivity
            // 
            this.cmbTypeOfActivity.FormattingEnabled = true;
            this.cmbTypeOfActivity.Location = new System.Drawing.Point(13, 199);
            this.cmbTypeOfActivity.Name = "cmbTypeOfActivity";
            this.cmbTypeOfActivity.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeOfActivity.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tip aktivnosti";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(12, 142);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Opis aktivnosti";
            // 
            // txtNumberOfPoints
            // 
            this.txtNumberOfPoints.Location = new System.Drawing.Point(12, 92);
            this.txtNumberOfPoints.Name = "txtNumberOfPoints";
            this.txtNumberOfPoints.Size = new System.Drawing.Size(122, 20);
            this.txtNumberOfPoints.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Broj bodova";
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(12, 42);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(122, 20);
            this.txtActivityName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv aktivnosti";
            // 
            // rtbActivityDescription
            // 
            this.rtbActivityDescription.Location = new System.Drawing.Point(172, 42);
            this.rtbActivityDescription.Name = "rtbActivityDescription";
            this.rtbActivityDescription.Size = new System.Drawing.Size(155, 178);
            this.rtbActivityDescription.TabIndex = 23;
            this.rtbActivityDescription.Text = "";
            // 
            // FrmAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 293);
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
            this.Name = "FrmAddActivity";
            this.Text = "Unos aktivnosti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.RichTextBox rtbActivityDescription;
    }
}