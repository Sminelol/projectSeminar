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
        public SqlConnection sqlC = new SqlConnection("Data Source=DESKTOP-2AJTSGQ\\SMNDB;Initial Catalog=firstTaskPrSem;Integrated Security=True");
        public main()
        {
            InitializeComponent();     
        }
        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDGV.DataSource = DisplayTable("Students", sqlC);
        }    
        public static DataTable DisplayTable(string tbName, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "select * from " + tbName;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(com);
            try
            {
                adp.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }
            return dt;
        }
        public static void insertStudent(string name, string surname, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "insert into students (studentID, name, surname) values (@name, @surname)";
            com.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
            com.Parameters.Add("surname", SqlDbType.NVarChar).Value = surname;
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
           finally
            {
                sqlC.Close();
            }
          
        }

    }
}
