using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PrjSem2Task1
{
    class databaseQueries
    {
        public SqlConnection sqlC = new SqlConnection("Data Source=DESKTOP-J4P172J\\SMNDB;Initial Catalog=DBSem23.11;Integrated Security=True;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\"");
        #region displayForm
        public static DataTable GetDataTable(string tbName, SqlConnection sqlC)
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
        public static DataTable GetDataMarksTable(SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "select marks.markID,Students.surname Фамилия, Subjects.name Предмет, Marks.mark Оценка from" +
                "(Marks join Students on marks.StudentID=Students.StudentID) join Subjects on Marks.SubjectID=Subjects.SubjectID;";
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
        #endregion
        #region addForm
        public static void insertStudent(string _name, string _surname, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            var newguid = Guid.NewGuid();
            com.CommandText = "insert into students (studentID, name, surname) values (@key,@name, @surname)";
            com.Parameters.Add("key", SqlDbType.UniqueIdentifier).Value = newguid;
            com.Parameters.Add("name", SqlDbType.NVarChar).Value = _name;
            com.Parameters.Add("surname", SqlDbType.NVarChar).Value = _surname;
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

         }
        public static void insertSubject(string _name, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            var newguid = Guid.NewGuid();
            com.CommandText = "insert into subjects (subjectID, name) values (@key, @name)";
            com.Parameters.Add("key", SqlDbType.UniqueIdentifier).Value = newguid;
            com.Parameters.Add("name", SqlDbType.NVarChar).Value = _name;
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        public static void insertMark(Guid _studentID, Guid _subjectID, int mark, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            var newguid = Guid.NewGuid();
            com.CommandText = "insert into marks (markID, studentID, subjectID, mark) values (@key, @studentkey, @subjectkey, @mark)";
            com.Parameters.Add("key", SqlDbType.UniqueIdentifier).Value = newguid;
            com.Parameters.Add("studentkey", SqlDbType.UniqueIdentifier).Value = _studentID;
            com.Parameters.Add("subjectkey", SqlDbType.UniqueIdentifier).Value = _subjectID;
            com.Parameters.Add("mark", SqlDbType.SmallInt).Value = mark;
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }

        #endregion
        #region delete queries
        public static void deleteStudent(Guid _studentID, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "delete from students where StudentID='"+_studentID+"'";        
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        public static void deleteSubject(Guid _subjectID, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "delete from subjects where SubjectID='"+_subjectID+"'";
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        public static void deleteMark(Guid _markID, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "delete from marks where markID='"+_markID+"'";
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        #endregion
        #region edit queries
        public static void updateStudent(Guid _studentID, string _name, string _surname, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "update students set name= '"+_name+"', surname='"+_surname+"' where studentID='"+_studentID+"'";
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        public static void updateMark(Guid _markID, int _mark, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "update marks set mark=" + _mark + " where markID='" + _markID+"'";
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        public static void updateSubject(Guid _subjectID, string _name, SqlConnection sqlC)
        {
            SqlCommand com = sqlC.CreateCommand();
            com.CommandText = "update subjects set name='" + _name + "' where subjectID='" + _subjectID+"'";
            sqlC.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Err");
            }
            finally
            {
                sqlC.Close();
            }

        }
        #endregion
    }
}
