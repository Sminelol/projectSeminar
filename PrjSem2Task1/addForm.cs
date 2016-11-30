using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrjSem2Task1
{
    public partial class addForm : Form
    {
        public SqlConnection sqlC = new SqlConnection("Data Source=DESKTOP-2AJTSGQ\\SMNDB;Initial Catalog=firstTaskPrSem;Integrated Security=True");
        DataTable originalStudentsDT = new DataTable();
        DataTable originalSubjectsDT = new DataTable();
        public addForm()
        {
            InitializeComponent();
            originalStudentsDT = databaseQueries.GetDataTable("Students", sqlC);
            addMarkStudentSelectionCB.DataSource = originalStudentsDT;
            addMarkStudentSelectionCB.DisplayMember = originalStudentsDT.Columns[2].ToString();

            originalSubjectsDT = databaseQueries.GetDataTable("Subjects", sqlC);
            addMarkSubjectSelectionCB.DataSource = originalSubjectsDT;
            addMarkSubjectSelectionCB.DisplayMember = originalSubjectsDT.Columns[1].ToString();
        }

        private void addSubjectGUI_Enter(object sender, EventArgs e)
        {

        }

        private void addForm_Load(object sender, EventArgs e)
        {
            addObjectTypeSelectionCombo.SelectedIndex = 0;
        }

        private void addObjectTypeSelectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (addObjectTypeSelectionCombo.SelectedIndex)
            {
                case 0:
                    addStudentGUI.Visible = true;
                    addSubjectGUI.Visible = false;
                    addMarkGUI.Visible = false;
                    break;
                case 1:
                    addSubjectGUI.Visible = true;
                    addStudentGUI.Visible = false;          
                    addMarkGUI.Visible = false;
                    break;
                case 2:
                    addMarkGUI.Visible = true;
                    addStudentGUI.Visible = false;
                    addSubjectGUI.Visible = false;
                    break;
            }
        }

        private void addMarkButton_Click(object sender, EventArgs e)
        {

        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (addSubjectTextBox.Text.Length > 0)
            {
                databaseQueries.insertSubject(addSubjectTextBox.Text, sqlC);
                Close();
            }
            else MessageBox.Show("Fill in the subject textbox");
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (addNameTextBox.Text.Length > 0 && addSurnameTextBox.Text.Length > 0)
            {
                databaseQueries.insertStudent(addNameTextBox.Text, addSurnameTextBox.Text, sqlC);
                Close();
            }
            else MessageBox.Show("Fill in both name and surname textboxes");
        }
    }
}
