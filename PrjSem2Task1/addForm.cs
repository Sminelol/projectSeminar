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
        public SqlConnection sqlC = new SqlConnection("Data Source=DESKTOP-J4P172J\\SMNDB;Initial Catalog=DBSem23.11;Integrated Security=True;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\""); DataTable originalStudentsDT = new DataTable();
        DataTable originalSubjectsDT = new DataTable();
        public addForm()
        {
            InitializeComponent();
            refreshComboboxes();
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
            int x;
            if (Int32.TryParse(addMarkTextBox.Text, out x) && x >= 0 && x <= 10)
            {
                DataRowView drSubject = (DataRowView)addMarkSubjectSelectionCB.SelectedItem;
                DataRowView drStudent = (DataRowView)addMarkStudentSelectionCB.SelectedItem;

                databaseQueries.insertMark(new Guid(drStudent[0].ToString()), new Guid(drSubject[0].ToString()), x, sqlC);
            }
            else MessageBox.Show("Mark should be an integer from 0 to 10");
            addMarkTextBox.Clear();
        }

        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (addSubjectTextBox.Text.Length > 0)
            {
                databaseQueries.insertSubject(addSubjectTextBox.Text, sqlC);
                refreshComboboxes();
                addSubjectTextBox.Clear();
            }
            else MessageBox.Show("Fill in the subject textbox");
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            if (addStudentNameTextBox.Text.Length > 0 && addStudentSurnameTextBox.Text.Length > 0)
            {
                databaseQueries.insertStudent(addStudentNameTextBox.Text, addStudentSurnameTextBox.Text, sqlC);
                refreshComboboxes();
                addStudentNameTextBox.Clear();
                addStudentSurnameTextBox.Clear();
            }
            else MessageBox.Show("Fill in both name and surname textboxes");
        }
        private void refreshComboboxes()
        {
            originalStudentsDT = databaseQueries.GetDataTable("Students", sqlC);
            addMarkStudentSelectionCB.DataSource = originalStudentsDT;
            addMarkStudentSelectionCB.DisplayMember = originalStudentsDT.Columns[2].ToString();

            originalSubjectsDT = databaseQueries.GetDataTable("Subjects", sqlC);
            addMarkSubjectSelectionCB.DataSource = originalSubjectsDT;
            addMarkSubjectSelectionCB.DisplayMember = originalSubjectsDT.Columns[1].ToString();
            addMarkStudentSelectionCB.SelectedIndex = 0;
            addMarkSubjectSelectionCB.SelectedIndex = 0;
        }
    }
}
