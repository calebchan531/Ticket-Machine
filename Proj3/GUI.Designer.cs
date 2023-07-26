namespace Proj3
{
    partial class GUI
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
            this.uxStudentRB = new System.Windows.Forms.RadioButton();
            this.uxAlumniRB = new System.Windows.Forms.RadioButton();
            this.uxMilitaryRB = new System.Windows.Forms.RadioButton();
            this.uxFacultyorStaffRB = new System.Windows.Forms.RadioButton();
            this.uxGeneralPublicRB = new System.Windows.Forms.RadioButton();
            this.uxControlPanel = new System.Windows.Forms.Panel();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxTextBox1 = new System.Windows.Forms.TextBox();
            this.uxOK = new System.Windows.Forms.Button();
            this.uxParkingCheckbox = new System.Windows.Forms.CheckBox();
            this.uxTicketQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxTicketQuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxStudentRB
            // 
            this.uxStudentRB.AutoSize = true;
            this.uxStudentRB.Location = new System.Drawing.Point(33, 81);
            this.uxStudentRB.Name = "uxStudentRB";
            this.uxStudentRB.Size = new System.Drawing.Size(117, 29);
            this.uxStudentRB.TabIndex = 0;
            this.uxStudentRB.TabStop = true;
            this.uxStudentRB.Text = "Student";
            this.uxStudentRB.UseVisualStyleBackColor = true;
            // 
            // uxAlumniRB
            // 
            this.uxAlumniRB.AutoSize = true;
            this.uxAlumniRB.Location = new System.Drawing.Point(33, 117);
            this.uxAlumniRB.Name = "uxAlumniRB";
            this.uxAlumniRB.Size = new System.Drawing.Size(108, 29);
            this.uxAlumniRB.TabIndex = 1;
            this.uxAlumniRB.TabStop = true;
            this.uxAlumniRB.Text = "Alumni";
            this.uxAlumniRB.UseVisualStyleBackColor = true;
            // 
            // uxMilitaryRB
            // 
            this.uxMilitaryRB.AutoSize = true;
            this.uxMilitaryRB.Location = new System.Drawing.Point(33, 153);
            this.uxMilitaryRB.Name = "uxMilitaryRB";
            this.uxMilitaryRB.Size = new System.Drawing.Size(112, 29);
            this.uxMilitaryRB.TabIndex = 2;
            this.uxMilitaryRB.TabStop = true;
            this.uxMilitaryRB.Text = "Military";
            this.uxMilitaryRB.UseVisualStyleBackColor = true;
            // 
            // uxFacultyorStaffRB
            // 
            this.uxFacultyorStaffRB.AutoSize = true;
            this.uxFacultyorStaffRB.Location = new System.Drawing.Point(33, 189);
            this.uxFacultyorStaffRB.Name = "uxFacultyorStaffRB";
            this.uxFacultyorStaffRB.Size = new System.Drawing.Size(188, 29);
            this.uxFacultyorStaffRB.TabIndex = 3;
            this.uxFacultyorStaffRB.TabStop = true;
            this.uxFacultyorStaffRB.Text = "Faculty or Staff";
            this.uxFacultyorStaffRB.UseVisualStyleBackColor = true;
            // 
            // uxGeneralPublicRB
            // 
            this.uxGeneralPublicRB.AutoSize = true;
            this.uxGeneralPublicRB.Location = new System.Drawing.Point(33, 225);
            this.uxGeneralPublicRB.Name = "uxGeneralPublicRB";
            this.uxGeneralPublicRB.Size = new System.Drawing.Size(184, 29);
            this.uxGeneralPublicRB.TabIndex = 4;
            this.uxGeneralPublicRB.TabStop = true;
            this.uxGeneralPublicRB.Text = "General Public";
            this.uxGeneralPublicRB.UseVisualStyleBackColor = true;
            // 
            // uxControlPanel
            // 
            this.uxControlPanel.Controls.Add(this.uxTextBox);
            this.uxControlPanel.Controls.Add(this.uxStudentRB);
            this.uxControlPanel.Controls.Add(this.uxGeneralPublicRB);
            this.uxControlPanel.Controls.Add(this.uxAlumniRB);
            this.uxControlPanel.Controls.Add(this.uxFacultyorStaffRB);
            this.uxControlPanel.Controls.Add(this.uxMilitaryRB);
            this.uxControlPanel.Location = new System.Drawing.Point(41, 39);
            this.uxControlPanel.Name = "uxControlPanel";
            this.uxControlPanel.Size = new System.Drawing.Size(272, 274);
            this.uxControlPanel.TabIndex = 5;
            // 
            // uxTextBox
            // 
            this.uxTextBox.Enabled = false;
            this.uxTextBox.Location = new System.Drawing.Point(3, 0);
            this.uxTextBox.MaxLength = 60000;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(200, 31);
            this.uxTextBox.TabIndex = 5;
            this.uxTextBox.Text = "Seating Category";
            // 
            // uxTextBox1
            // 
            this.uxTextBox1.Enabled = false;
            this.uxTextBox1.Location = new System.Drawing.Point(41, 384);
            this.uxTextBox1.Name = "uxTextBox1";
            this.uxTextBox1.Size = new System.Drawing.Size(300, 31);
            this.uxTextBox1.TabIndex = 6;
            this.uxTextBox1.Text = "Number of Tickets?";
            // 
            // uxOK
            // 
            this.uxOK.Location = new System.Drawing.Point(93, 560);
            this.uxOK.Name = "uxOK";
            this.uxOK.Size = new System.Drawing.Size(107, 45);
            this.uxOK.TabIndex = 7;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            this.uxOK.Click += new System.EventHandler(this.uxOK_Click);
            // 
            // uxParkingCheckbox
            // 
            this.uxParkingCheckbox.AutoSize = true;
            this.uxParkingCheckbox.Location = new System.Drawing.Point(41, 495);
            this.uxParkingCheckbox.Name = "uxParkingCheckbox";
            this.uxParkingCheckbox.Size = new System.Drawing.Size(171, 29);
            this.uxParkingCheckbox.TabIndex = 8;
            this.uxParkingCheckbox.Text = "Parking Pass";
            this.uxParkingCheckbox.UseVisualStyleBackColor = true;
            // 
            // uxTicketQuantityNumericUpDown
            // 
            this.uxTicketQuantityNumericUpDown.Location = new System.Drawing.Point(41, 441);
            this.uxTicketQuantityNumericUpDown.Name = "uxTicketQuantityNumericUpDown";
            this.uxTicketQuantityNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.uxTicketQuantityNumericUpDown.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 756);
            this.Controls.Add(this.uxTicketQuantityNumericUpDown);
            this.Controls.Add(this.uxParkingCheckbox);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxTextBox1);
            this.Controls.Add(this.uxControlPanel);
            this.Name = "Form1";
            this.Text = "K-State Athletic Department";
            this.uxControlPanel.ResumeLayout(false);
            this.uxControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxTicketQuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton uxStudentRB;
        private System.Windows.Forms.RadioButton uxAlumniRB;
        private System.Windows.Forms.RadioButton uxMilitaryRB;
        private System.Windows.Forms.RadioButton uxFacultyorStaffRB;
        private System.Windows.Forms.RadioButton uxGeneralPublicRB;
        private System.Windows.Forms.Panel uxControlPanel;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.TextBox uxTextBox1;
        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.CheckBox uxParkingCheckbox;
        private System.Windows.Forms.NumericUpDown uxTicketQuantityNumericUpDown;
    }
}

