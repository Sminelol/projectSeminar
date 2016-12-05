using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PrjSem2Task1
{
    public partial class main : Form
    {
        string typeOfCurrentDisplayedItems = ""; //тип последних отображенных данных в форме
        public SqlConnection sqlC = new SqlConnection("Data Source=DESKTOP-J4P172J\\SMNDB;Initial Catalog=DBSem23.11;Integrated Security=True;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\"");
        public main()
        {
            InitializeComponent();     
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDGV.DataSource = databaseQueries.GetDataTable("Students", sqlC);
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "Имя";
            mainDGV.Columns[2].HeaderText = "Фамилия";
            typeOfCurrentDisplayedItems = "student";

        }
        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDGV.DataSource = databaseQueries.GetDataTable("Subjects", sqlC);
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "Предмет";
            typeOfCurrentDisplayedItems = "subject";
        }
        private void marksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDGV.DataSource = databaseQueries.GetDataMarksTable(sqlC);
            mainDGV.Columns[0].Visible = false;
            mainDGV.Columns[1].HeaderText = "Фамилия";
            mainDGV.Columns[2].HeaderText = "Предмет";
            mainDGV.Columns[3].HeaderText = "Оценка";
            typeOfCurrentDisplayedItems = "mark";
        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm newAddForm = new addForm();
            newAddForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mainDGV.SelectedRows.Count>0)
            {
                editForm newEditForm = new editForm(typeOfCurrentDisplayedItems, mainDGV.SelectedRows[0]);
                newEditForm.ShowDialog();
                refreshTable();
            }
        }
        private void refreshTable()
        {
            switch(typeOfCurrentDisplayedItems)
            {
                case "student":
                    studentsToolStripMenuItem.PerformClick();
                    break;
                case "subject":
                    subjectsToolStripMenuItem.PerformClick();
                    break;
                case "mark":
                    marksToolStripMenuItem.PerformClick();
                    break;
            }
        }

        private void connString_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainDGV.SelectedRows.Count > 0)
            {

                switch (typeOfCurrentDisplayedItems)
                {
                    case "student":
                        databaseQueries.deleteStudent(new Guid(mainDGV.SelectedRows[0].Cells[0].Value.ToString()), sqlC);
                        break;
                    case "subject":
                        databaseQueries.deleteSubject(new Guid(mainDGV.SelectedRows[0].Cells[0].Value.ToString()), sqlC);
                        break;
                    case "mark":
                        databaseQueries.deleteMark(new Guid(mainDGV.SelectedRows[0].Cells[0].Value.ToString()), sqlC);
                        break;
                }
                refreshTable();
            }
        }
    }
}
