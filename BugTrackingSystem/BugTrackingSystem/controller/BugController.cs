using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackingSystem.model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using BugTrackingSystem.view;
using System.Data;
using BugTrackingSystem.view;



namespace BugTrackingSystem.controller
{
    class BugController
    {
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;
        FileStream fileStream;
        BinaryReader binaryReader;

        public BugController()
        {
            //getting database connection
            if (databaseConnection == null)
            {
                databaseConnection = DbConnection.GetConnection();
            }
        }

        public Boolean ReportBug(Bugs bug)
        {
            Boolean isReported = false;
      
            //fileStream = new FileStream(bug.ProjectName, FileMode.Open, FileAccess.Read);
           // binaryReader = new BinaryReader(fileStream);
            //binaryReader.Close();
           // fileStream.Close();
            string query = "insert into bugs (userName, projectName, issue, fileName, " +
                "lineNo, createdDate, status)" +
                "values ('" + bug.Username + "','" + bug.ProjectName + "','" + bug.Issue + "','" + bug.FileName + "','" + bug.LineNo + "','" + bug.CreatedDate + "','" + bug.Status + "');";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    isReported = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return isReported;
        }

        



        public DataTable LoadMyBugs()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from bugs;";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = commandDatabase;
                dataAdapter.Fill(dataTable);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return dataTable;
        }



       

        public Boolean UpdateBug(Bugs bug)
        {
            Boolean isUpdated = false;
            string query = "update bugs set projectName='" + bug.ProjectName + "', " +
                "issue='" + bug.Issue + "'," +
                "fileName='" + bug.FileName + "', lineNo='" + bug.LineNo + "', " +
                "createdDate='" + bug.CreatedDate + "', status='" + bug.Status + "', fixby='" + bug.FixBy + "' where bugId ='" + bug.BugId + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int updatedRow = commandDatabase.ExecuteNonQuery();
                if (updatedRow > 0)
                {
                    isUpdated = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return isUpdated;
        }


        public DataTable LoadActiveBugs()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from bugs where status=@status;";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.Parameters.AddWithValue("status", "Active");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = commandDatabase;
                dataAdapter.Fill(dataTable);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return dataTable;
        }


        public string RetrieveReporter(Bugs bug)
        {
            string reporter = "";
            string query = "select name from members where email='" + bug.Username + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    reporter = reader["full_name"].ToString();
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return reporter;
        }


        public Boolean DeleteBug(Bugs bug)
        {
            Boolean userDeleted = false;
            string query = "delete from bugs where bugId='" + bug.BugId + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    userDeleted = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return userDeleted;
        }


        public Boolean UpdateBugStatusFixing(Bugs bug)
        {
            Boolean isUpdated = false;
            string query = "update bugs set status='" + bug.Status + "', userName='" + bug.Username + "' " +
                "where bugId='" + bug.BugId + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int updatedRow = commandDatabase.ExecuteNonQuery();
                if (updatedRow > 0)
                {
                    isUpdated = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return isUpdated;
        }

        public Boolean UpdateBugStatusFixed(Bugs bug)
        {
            Boolean isUpdated = false;
            string query = "update bug set status='" + bug.Status + "', fixDate='" + bug.FixDate + "', " +
                "userName='" + bug.Username + "' " + "where bugId='" + bug.BugId + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int updatedRow = commandDatabase.ExecuteNonQuery();
                if (updatedRow > 0)
                {
                    isUpdated = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return isUpdated;
        }

        public DataTable LoadToFixBugs(Bugs bug)
        {
            DataTable dataTable = new DataTable();
            string query = "select * from bug where status=@status and userName='" + bug.Username + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.Parameters.AddWithValue("status", "Fixing");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = commandDatabase;
                dataAdapter.Fill(dataTable);
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return dataTable;
        }

    }
}
