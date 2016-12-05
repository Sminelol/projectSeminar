using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjSem2Task1
{
    public partial class editForm : Form
    {
        public SqlConnection sqlC = new SqlConnection("Data Source=DESKTOP-J4P172J\\SMNDB;Initial Catalog=DBSem23.11;Integrated Security=True;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\"");
        public Guid editedItemKey;
        public editForm(string type, DataGridViewRow _dataGridRow)
        {
            InitializeComponent();
            studentGB.Hide();
            subjectGB.Hide();
            markGB.Hide();
            editedItemKey = new Guid(_dataGridRow.Cells[0].Value.ToString()) ;
            switch (type)
            {
                case "student":
                    studentGB.Show();
                    Text = "student";
                    studentNameTB.Text = _dataGridRow.Cells[1].Value.ToString();
                    studentSurnameTB.Text = _dataGridRow.Cells[2].Value.ToString();
                    break;
                case "subject":
                    subjectGB.Show();
                    Text = "subject";
                    subjectNameTB.Text = _dataGridRow.Cells[1].Value.ToString();
                    break;
                case "mark":
                    markGB.Show();
                    Text = "mark";
                    markTB.Text = _dataGridRow.Cells[3].Value.ToString();
                    break;
            }
        }

        private void applyStudentButton_Click(object sender, EventArgs e)
        {
            if (studentNameTB.Text.Length > 0 && studentSurnameTB.Text.Length > 0)
            {
                databaseQueries.updateStudent(editedItemKey, studentNameTB.Text, studentSurnameTB.Text, sqlC);
                Close();
            }
            else MessageBox.Show("Fill in both name and surname textboxes");
        }

        private void applySubjectButton_Click(object sender, EventArgs e)
        {
            if (subjectNameTB.Text.Length > 0)
            {
                databaseQueries.updateSubject(editedItemKey, subjectNameTB.Text, sqlC);
                Close();
            }
            else MessageBox.Show("Fill in the textbox");
        }

        private void applyMarkButton_Click(object sender, EventArgs e)
        {
            int x;
            if (Int32.TryParse(markTB.Text, out x) && x >= 0 && x <= 10)
            {
                databaseQueries.updateMark(editedItemKey, x, sqlC);
                Close();
            }
            else MessageBox.Show("Mark should be an integer from 0 to 10");
        }
    }
}
