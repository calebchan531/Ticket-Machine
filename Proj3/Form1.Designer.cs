namespace Proj3
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
            this.uxStudent = new System.Windows.Forms.RadioButton();
            this.uxAlumni = new System.Windows.Forms.RadioButton();
            this.uxMilitary = new System.Windows.Forms.RadioButton();
            this.uxFacultyorStaff = new System.Windows.Forms.RadioButton();
            this.uxGeneralPublic = new System.Windows.Forms.RadioButton();
            this.uxControlPanel = new System.Windows.Forms.Panel();
            this.uxTextBox = new System.Windows.Forms.TextBox();
            this.uxTextBox1 = new System.Windows.Forms.TextBox();
            this.uxOK = new System.Windows.Forms.Button();
            this.uxParkingPass = new System.Windows.Forms.CheckBox();
            this.uxControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxStudent
            // 
            this.uxStudent.AutoSize = true;
            this.uxStudent.Location = new System.Drawing.Point(33, 81);
            this.uxStudent.Name = "uxStudent";
            this.uxStudent.Size = new System.Drawing.Size(117, 29);
            this.uxStudent.TabIndex = 0;
            this.uxStudent.TabStop = true;
            this.uxStudent.Text = "Student";
            this.uxStudent.UseVisualStyleBackColor = true;
            // 
            // uxAlumni
            // 
            this.uxAlumni.AutoSize = true;
            this.uxAlumni.Location = new System.Drawing.Point(33, 117);
            this.uxAlumni.Name = "uxAlumni";
            this.uxAlumni.Size = new System.Drawing.Size(108, 29);
            this.uxAlumni.TabIndex = 1;
            this.uxAlumni.TabStop = true;
            this.uxAlumni.Text = "Alumni";
            this.uxAlumni.UseVisualStyleBackColor = true;
            // 
            // uxMilitary
            // 
            this.uxMilitary.AutoSize = true;
            this.uxMilitary.Location = new System.Drawing.Point(33, 153);
            this.uxMilitary.Name = "uxMilitary";
            this.uxMilitary.Size = new System.Drawing.Size(112, 29);
            this.uxMilitary.TabIndex = 2;
            this.uxMilitary.TabStop = true;
            this.uxMilitary.Text = "Military";
            this.uxMilitary.UseVisualStyleBackColor = true;
            // 
            // uxFacultyorStaff
            // 
            this.uxFacultyorStaff.AutoSize = true;
            this.uxFacultyorStaff.Location = new System.Drawing.Point(33, 189);
            this.uxFacultyorStaff.Name = "uxFacultyorStaff";
            this.uxFacultyorStaff.Size = new System.Drawing.Size(188, 29);
            this.uxFacultyorStaff.TabIndex = 3;
            this.uxFacultyorStaff.TabStop = true;
            this.uxFacultyorStaff.Text = "Faculty or Staff";
            this.uxFacultyorStaff.UseVisualStyleBackColor = true;
            // 
            // uxGeneralPublic
            // 
            this.uxGeneralPublic.AutoSize = true;
            this.uxGeneralPublic.Location = new System.Drawing.Point(33, 225);
            this.uxGeneralPublic.Name = "uxGeneralPublic";
            this.uxGeneralPublic.Size = new System.Drawing.Size(184, 29);
            this.uxGeneralPublic.TabIndex = 4;
            this.uxGeneralPublic.TabStop = true;
            this.uxGeneralPublic.Text = "General Public";
            this.uxGeneralPublic.UseVisualStyleBackColor = true;
            // 
            // uxControlPanel
            // 
            this.uxControlPanel.Controls.Add(this.uxTextBox);
            this.uxControlPanel.Controls.Add(this.uxStudent);
            this.uxControlPanel.Controls.Add(this.uxGeneralPublic);
            this.uxControlPanel.Controls.Add(this.uxAlumni);
            this.uxControlPanel.Controls.Add(this.uxFacultyorStaff);
            this.uxControlPanel.Controls.Add(this.uxMilitary);
            this.uxControlPanel.Location = new System.Drawing.Point(41, 39);
            this.uxControlPanel.Name = "uxControlPanel";
            this.uxControlPanel.Size = new System.Drawing.Size(272, 274);
            this.uxControlPanel.TabIndex = 5;
            // 
            // uxTextBox
            // 
            this.uxTextBox.Location = new System.Drawing.Point(3, 0);
            this.uxTextBox.MaxLength = 60000;
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(200, 31);
            this.uxTextBox.TabIndex = 5;
            this.uxTextBox.Text = "Seating Category";
            // 
            // uxTextBox1
            // 
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
            this.uxOK.Size = new System.Drawing.Size(107, 32);
            this.uxOK.TabIndex = 7;
            this.uxOK.Text = "OK";
            this.uxOK.UseVisualStyleBackColor = true;
            this.uxOK.Click += new System.EventHandler(this.uxOK_Click);
            // 
            // uxParkingPass
            // 
            this.uxParkingPass.AutoSize = true;
            this.uxParkingPass.Location = new System.Drawing.Point(41, 495);
            this.uxParkingPass.Name = "uxParkingPass";
            this.uxParkingPass.Size = new System.Drawing.Size(171, 29);
            this.uxParkingPass.TabIndex = 8;
            this.uxParkingPass.Text = "Parking Pass";
            this.uxParkingPass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 756);
            this.Controls.Add(this.uxParkingPass);
            this.Controls.Add(this.uxOK);
            this.Controls.Add(this.uxTextBox1);
            this.Controls.Add(this.uxControlPanel);
            this.Name = "Form1";
            this.Text = "K-State Athletic Department";
            this.uxControlPanel.ResumeLayout(false);
            this.uxControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton uxStudent;
        private System.Windows.Forms.RadioButton uxAlumni;
        private System.Windows.Forms.RadioButton uxMilitary;
        private System.Windows.Forms.RadioButton uxFacultyorStaff;
        private System.Windows.Forms.RadioButton uxGeneralPublic;
        private System.Windows.Forms.Panel uxControlPanel;
        private System.Windows.Forms.TextBox uxTextBox;
        private System.Windows.Forms.TextBox uxTextBox1;
        private System.Windows.Forms.Button uxOK;
        private System.Windows.Forms.CheckBox uxParkingPass;
    }
}

