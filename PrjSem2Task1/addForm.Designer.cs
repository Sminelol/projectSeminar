namespace PrjSem2Task1
{
    partial class addForm
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
            this.components = new System.ComponentModel.Container();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addStudentGUI = new System.Windows.Forms.GroupBox();
            this.addStudentSurnameTextBox = new System.Windows.Forms.TextBox();
            this.addStudentNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addSubjectGUI = new System.Windows.Forms.GroupBox();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addSubjectTextBox = new System.Windows.Forms.TextBox();
            this.addMarkGUI = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addMarkTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addMarkStudentSelectionCB = new System.Windows.Forms.ComboBox();
            this.addMarkSubjectSelectionCB = new System.Windows.Forms.ComboBox();
            this.addMarkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addObjectTypeSelectionCombo = new System.Windows.Forms.ComboBox();
            this.firstTaskPrSemDataSet = new PrjSem2Task1.firstTaskPrSemDataSet();
            this.firstTaskPrSemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addStudentGUI.SuspendLayout();
            this.addSubjectGUI.SuspendLayout();
            this.addMarkGUI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstTaskPrSemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTaskPrSemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(0, 184);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(284, 23);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.TabStop = false;
            this.addStudentButton.Text = "Add the student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addStudentGUI
            // 
            this.addStudentGUI.Controls.Add(this.addStudentSurnameTextBox);
            this.addStudentGUI.Controls.Add(this.addStudentNameTextBox);
            this.addStudentGUI.Controls.Add(this.addStudentButton);
            this.addStudentGUI.Controls.Add(this.label2);
            this.addStudentGUI.Controls.Add(this.label1);
            this.addStudentGUI.Location = new System.Drawing.Point(12, 33);
            this.addStudentGUI.Name = "addStudentGUI";
            this.addStudentGUI.Size = new System.Drawing.Size(284, 215);
            this.addStudentGUI.TabIndex = 5;
            this.addStudentGUI.TabStop = false;
            // 
            // addStudentSurnameTextBox
            // 
            this.addStudentSurnameTextBox.Location = new System.Drawing.Point(12, 68);
            this.addStudentSurnameTextBox.Name = "addStudentSurnameTextBox";
            this.addStudentSurnameTextBox.Size = new System.Drawing.Size(260, 20);
            this.addStudentSurnameTextBox.TabIndex = 8;
            this.addStudentSurnameTextBox.TabStop = false;
            // 
            // addStudentNameTextBox
            // 
            this.addStudentNameTextBox.Location = new System.Drawing.Point(12, 29);
            this.addStudentNameTextBox.Name = "addStudentNameTextBox";
            this.addStudentNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.addStudentNameTextBox.TabIndex = 7;
            this.addStudentNameTextBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // addSubjectGUI
            // 
            this.addSubjectGUI.Controls.Add(this.addSubjectButton);
            this.addSubjectGUI.Controls.Add(this.label4);
            this.addSubjectGUI.Controls.Add(this.addSubjectTextBox);
            this.addSubjectGUI.Location = new System.Drawing.Point(12, 33);
            this.addSubjectGUI.Name = "addSubjectGUI";
            this.addSubjectGUI.Size = new System.Drawing.Size(284, 215);
            this.addSubjectGUI.TabIndex = 6;
            this.addSubjectGUI.TabStop = false;
            this.addSubjectGUI.Enter += new System.EventHandler(this.addSubjectGUI_Enter);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(6, 184);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(272, 23);
            this.addSubjectButton.TabIndex = 12;
            this.addSubjectButton.TabStop = false;
            this.addSubjectButton.Text = "Add the subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Subject";
            // 
            // addSubjectTextBox
            // 
            this.addSubjectTextBox.Location = new System.Drawing.Point(6, 29);
            this.addSubjectTextBox.Name = "addSubjectTextBox";
            this.addSubjectTextBox.Size = new System.Drawing.Size(263, 20);
            this.addSubjectTextBox.TabIndex = 9;
            this.addSubjectTextBox.TabStop = false;
            // 
            // addMarkGUI
            // 
            this.addMarkGUI.Controls.Add(this.label6);
            this.addMarkGUI.Controls.Add(this.addMarkTextBox);
            this.addMarkGUI.Controls.Add(this.label5);
            this.addMarkGUI.Controls.Add(this.addMarkStudentSelectionCB);
            this.addMarkGUI.Controls.Add(this.addMarkSubjectSelectionCB);
            this.addMarkGUI.Controls.Add(this.addMarkButton);
            this.addMarkGUI.Controls.Add(this.label3);
            this.addMarkGUI.Location = new System.Drawing.Point(12, 33);
            this.addMarkGUI.Name = "addMarkGUI";
            this.addMarkGUI.Size = new System.Drawing.Size(284, 215);
            this.addMarkGUI.TabIndex = 7;
            this.addMarkGUI.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mark";
            // 
            // addMarkTextBox
            // 
            this.addMarkTextBox.Location = new System.Drawing.Point(6, 110);
            this.addMarkTextBox.Name = "addMarkTextBox";
            this.addMarkTextBox.Size = new System.Drawing.Size(272, 20);
            this.addMarkTextBox.TabIndex = 16;
            this.addMarkTextBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Student";
            // 
            // addMarkStudentSelectionCB
            // 
            this.addMarkStudentSelectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMarkStudentSelectionCB.FormattingEnabled = true;
            this.addMarkStudentSelectionCB.Location = new System.Drawing.Point(6, 67);
            this.addMarkStudentSelectionCB.Name = "addMarkStudentSelectionCB";
            this.addMarkStudentSelectionCB.Size = new System.Drawing.Size(272, 21);
            this.addMarkStudentSelectionCB.TabIndex = 14;
            this.addMarkStudentSelectionCB.TabStop = false;
            // 
            // addMarkSubjectSelectionCB
            // 
            this.addMarkSubjectSelectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMarkSubjectSelectionCB.FormattingEnabled = true;
            this.addMarkSubjectSelectionCB.Location = new System.Drawing.Point(6, 27);
            this.addMarkSubjectSelectionCB.Name = "addMarkSubjectSelectionCB";
            this.addMarkSubjectSelectionCB.Size = new System.Drawing.Size(272, 21);
            this.addMarkSubjectSelectionCB.TabIndex = 13;
            this.addMarkSubjectSelectionCB.TabStop = false;
            // 
            // addMarkButton
            // 
            this.addMarkButton.Location = new System.Drawing.Point(6, 184);
            this.addMarkButton.Name = "addMarkButton";
            this.addMarkButton.Size = new System.Drawing.Size(272, 23);
            this.addMarkButton.TabIndex = 12;
            this.addMarkButton.TabStop = false;
            this.addMarkButton.Text = "Add the mark";
            this.addMarkButton.UseVisualStyleBackColor = true;
            this.addMarkButton.Click += new System.EventHandler(this.addMarkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subject";
            // 
            // addObjectTypeSelectionCombo
            // 
            this.addObjectTypeSelectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addObjectTypeSelectionCombo.FormattingEnabled = true;
            this.addObjectTypeSelectionCombo.Items.AddRange(new object[] {
            "Student",
            "Subject",
            "Mark"});
            this.addObjectTypeSelectionCombo.Location = new System.Drawing.Point(12, 6);
            this.addObjectTypeSelectionCombo.Name = "addObjectTypeSelectionCombo";
            this.addObjectTypeSelectionCombo.Size = new System.Drawing.Size(284, 21);
            this.addObjectTypeSelectionCombo.TabIndex = 6;
            this.addObjectTypeSelectionCombo.TabStop = false;
            this.addObjectTypeSelectionCombo.SelectedIndexChanged += new System.EventHandler(this.addObjectTypeSelectionCombo_SelectedIndexChanged);
            // 
            // firstTaskPrSemDataSet
            // 
            this.firstTaskPrSemDataSet.DataSetName = "firstTaskPrSemDataSet";
            this.firstTaskPrSemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstTaskPrSemDataSetBindingSource
            // 
            this.firstTaskPrSemDataSetBindingSource.DataSource = this.firstTaskPrSemDataSet;
            this.firstTaskPrSemDataSetBindingSource.Position = 0;
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.addSubjectGUI);
            this.Controls.Add(this.addMarkGUI);
            this.Controls.Add(this.addObjectTypeSelectionCombo);
            this.Controls.Add(this.addStudentGUI);
            this.Name = "addForm";
            this.Text = "Add:";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.addStudentGUI.ResumeLayout(false);
            this.addStudentGUI.PerformLayout();
            this.addSubjectGUI.ResumeLayout(false);
            this.addSubjectGUI.PerformLayout();
            this.addMarkGUI.ResumeLayout(false);
            this.addMarkGUI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstTaskPrSemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTaskPrSemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox addStudentGUI;
        private System.Windows.Forms.TextBox addStudentSurnameTextBox;
        private System.Windows.Forms.TextBox addStudentNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox addSubjectGUI;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addSubjectTextBox;
        private System.Windows.Forms.ComboBox addObjectTypeSelectionCombo;
        private System.Windows.Forms.GroupBox addMarkGUI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addMarkTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addMarkStudentSelectionCB;
        private System.Windows.Forms.ComboBox addMarkSubjectSelectionCB;
        private System.Windows.Forms.Button addMarkButton;
        private System.Windows.Forms.Label label3;
        private firstTaskPrSemDataSet firstTaskPrSemDataSet;
        private System.Windows.Forms.BindingSource firstTaskPrSemDataSetBindingSource;
    }
}