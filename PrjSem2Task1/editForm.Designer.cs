namespace PrjSem2Task1
{
    partial class editForm
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
            this.applyStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adadsd = new System.Windows.Forms.Label();
            this.studentGB = new System.Windows.Forms.GroupBox();
            this.studentSurnameTB = new System.Windows.Forms.TextBox();
            this.studentNameTB = new System.Windows.Forms.TextBox();
            this.subjectGB = new System.Windows.Forms.GroupBox();
            this.subjectNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applySubjectButton = new System.Windows.Forms.Button();
            this.markGB = new System.Windows.Forms.GroupBox();
            this.markTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyMarkButton = new System.Windows.Forms.Button();
            this.studentGB.SuspendLayout();
            this.subjectGB.SuspendLayout();
            this.markGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyStudentButton
            // 
            this.applyStudentButton.Location = new System.Drawing.Point(6, 97);
            this.applyStudentButton.Name = "applyStudentButton";
            this.applyStudentButton.Size = new System.Drawing.Size(248, 23);
            this.applyStudentButton.TabIndex = 0;
            this.applyStudentButton.TabStop = false;
            this.applyStudentButton.Text = "Apply";
            this.applyStudentButton.UseVisualStyleBackColor = true;
            this.applyStudentButton.Click += new System.EventHandler(this.applyStudentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // adadsd
            // 
            this.adadsd.AutoSize = true;
            this.adadsd.Location = new System.Drawing.Point(6, 16);
            this.adadsd.Name = "adadsd";
            this.adadsd.Size = new System.Drawing.Size(35, 13);
            this.adadsd.TabIndex = 2;
            this.adadsd.Text = "Name";
            // 
            // studentGB
            // 
            this.studentGB.Controls.Add(this.studentSurnameTB);
            this.studentGB.Controls.Add(this.studentNameTB);
            this.studentGB.Controls.Add(this.adadsd);
            this.studentGB.Controls.Add(this.applyStudentButton);
            this.studentGB.Controls.Add(this.label1);
            this.studentGB.Location = new System.Drawing.Point(12, 12);
            this.studentGB.Name = "studentGB";
            this.studentGB.Size = new System.Drawing.Size(260, 128);
            this.studentGB.TabIndex = 3;
            this.studentGB.TabStop = false;
            // 
            // studentSurnameTB
            // 
            this.studentSurnameTB.Location = new System.Drawing.Point(6, 71);
            this.studentSurnameTB.Name = "studentSurnameTB";
            this.studentSurnameTB.Size = new System.Drawing.Size(248, 20);
            this.studentSurnameTB.TabIndex = 4;
            this.studentSurnameTB.TabStop = false;
            // 
            // studentNameTB
            // 
            this.studentNameTB.Location = new System.Drawing.Point(6, 32);
            this.studentNameTB.Name = "studentNameTB";
            this.studentNameTB.Size = new System.Drawing.Size(248, 20);
            this.studentNameTB.TabIndex = 3;
            this.studentNameTB.TabStop = false;
            // 
            // subjectGB
            // 
            this.subjectGB.Controls.Add(this.subjectNameTB);
            this.subjectGB.Controls.Add(this.label2);
            this.subjectGB.Controls.Add(this.applySubjectButton);
            this.subjectGB.Location = new System.Drawing.Point(12, 12);
            this.subjectGB.Name = "subjectGB";
            this.subjectGB.Size = new System.Drawing.Size(260, 128);
            this.subjectGB.TabIndex = 4;
            this.subjectGB.TabStop = false;
            // 
            // subjectNameTB
            // 
            this.subjectNameTB.Location = new System.Drawing.Point(6, 32);
            this.subjectNameTB.Name = "subjectNameTB";
            this.subjectNameTB.Size = new System.Drawing.Size(248, 20);
            this.subjectNameTB.TabIndex = 3;
            this.subjectNameTB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // applySubjectButton
            // 
            this.applySubjectButton.Location = new System.Drawing.Point(6, 97);
            this.applySubjectButton.Name = "applySubjectButton";
            this.applySubjectButton.Size = new System.Drawing.Size(248, 23);
            this.applySubjectButton.TabIndex = 0;
            this.applySubjectButton.TabStop = false;
            this.applySubjectButton.Text = "Apply";
            this.applySubjectButton.UseVisualStyleBackColor = true;
            this.applySubjectButton.Click += new System.EventHandler(this.applySubjectButton_Click);
            // 
            // markGB
            // 
            this.markGB.Controls.Add(this.markTB);
            this.markGB.Controls.Add(this.label3);
            this.markGB.Controls.Add(this.applyMarkButton);
            this.markGB.Location = new System.Drawing.Point(12, 12);
            this.markGB.Name = "markGB";
            this.markGB.Size = new System.Drawing.Size(260, 128);
            this.markGB.TabIndex = 5;
            this.markGB.TabStop = false;
            // 
            // markTB
            // 
            this.markTB.Location = new System.Drawing.Point(6, 32);
            this.markTB.Name = "markTB";
            this.markTB.Size = new System.Drawing.Size(248, 20);
            this.markTB.TabIndex = 3;
            this.markTB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mark";
            // 
            // applyMarkButton
            // 
            this.applyMarkButton.Location = new System.Drawing.Point(6, 97);
            this.applyMarkButton.Name = "applyMarkButton";
            this.applyMarkButton.Size = new System.Drawing.Size(248, 23);
            this.applyMarkButton.TabIndex = 0;
            this.applyMarkButton.TabStop = false;
            this.applyMarkButton.Text = "Apply";
            this.applyMarkButton.UseVisualStyleBackColor = true;
            this.applyMarkButton.Click += new System.EventHandler(this.applyMarkButton_Click);
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.markGB);
            this.Controls.Add(this.subjectGB);
            this.Controls.Add(this.studentGB);
            this.Name = "editForm";
            this.studentGB.ResumeLayout(false);
            this.studentGB.PerformLayout();
            this.subjectGB.ResumeLayout(false);
            this.subjectGB.PerformLayout();
            this.markGB.ResumeLayout(false);
            this.markGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adadsd;
        private System.Windows.Forms.GroupBox studentGB;
        private System.Windows.Forms.TextBox studentSurnameTB;
        private System.Windows.Forms.TextBox studentNameTB;
        private System.Windows.Forms.GroupBox subjectGB;
        private System.Windows.Forms.TextBox subjectNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applySubjectButton;
        private System.Windows.Forms.GroupBox markGB;
        private System.Windows.Forms.TextBox markTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyMarkButton;
    }
}