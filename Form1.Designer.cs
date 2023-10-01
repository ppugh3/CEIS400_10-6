namespace GBManufacturing
{
    partial class Form1
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
            this.DateTimeEmp = new System.Windows.Forms.DateTimePicker();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.EmployeeIDText = new System.Windows.Forms.TextBox();
            this.FindMyRecButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimeEmp
            // 
            this.DateTimeEmp.Location = new System.Drawing.Point(75, 67);
            this.DateTimeEmp.Name = "DateTimeEmp";
            this.DateTimeEmp.Size = new System.Drawing.Size(200, 20);
            this.DateTimeEmp.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(75, 159);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(180, 20);
            this.LastNameText.TabIndex = 1;
            this.LastNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(277, 159);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(180, 20);
            this.FirstNameText.TabIndex = 2;
            // 
            // EmployeeIDText
            // 
            this.EmployeeIDText.Location = new System.Drawing.Point(75, 243);
            this.EmployeeIDText.Name = "EmployeeIDText";
            this.EmployeeIDText.Size = new System.Drawing.Size(180, 20);
            this.EmployeeIDText.TabIndex = 3;
            // 
            // FindMyRecButton
            // 
            this.FindMyRecButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FindMyRecButton.Location = new System.Drawing.Point(277, 318);
            this.FindMyRecButton.Name = "FindMyRecButton";
            this.FindMyRecButton.Size = new System.Drawing.Size(135, 46);
            this.FindMyRecButton.TabIndex = 4;
            this.FindMyRecButton.Text = "Find My Record";
            this.FindMyRecButton.UseVisualStyleBackColor = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(75, 139);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(107, 13);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Employee Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(274, 139);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 13);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "Employee First Name";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(76, 226);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIDLabel.TabIndex = 7;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GBManufacturing.Properties.Resources.GBManufacturingLogo;
            this.pictureBox1.Location = new System.Drawing.Point(501, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 198);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FindMyRecButton);
            this.Controls.Add(this.EmployeeIDText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.DateTimeEmp);
            this.Name = "Form1";
            this.Text = "Equipment Checkout System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimeEmp;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox EmployeeIDText;
        private System.Windows.Forms.Button FindMyRecButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

