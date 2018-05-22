using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTrackingSystem.model;
using BugTrackingSystem.controller;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace BugTrackingSystem.controller
{
    class ProjectController
    {
        public string name, role, email, address, dob, username, password;
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;

        public ProjectController()
        {
            if (databaseConnection == null)
            {
                databaseConnection = DbConnection.GetConnection();
            }

        }


        public Boolean AddProject(projectModel project)
        {
            Boolean userAdded = false;
            string query = "insert into project (projectName, createdDate, EndDate,userName)" +
                "values ('" + project.ProjectName + "', '" + project.CreatedDate + "', '" + project.EndDate + "','"+project.Username +"' );";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                int affectedRows = commandDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    userAdded = true;
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query Error : " + ex.Message);
            }
            return userAdded;
        }
        public DataTable LoadAllProject()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from project;";
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


        public Boolean UpdateProject(projectModel project)
        {
            Boolean isUpdated = false;
            string query = "update project set userName ='" + project.Username + "',  projectName='" + project.ProjectName + "', createdDate= '" + project.CreatedDate + "', EndDate='" + project.EndDate + "' where projectId ='" + project.ProjectId + "';";
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
        public Boolean DeleteBug(projectModel project)
        {
            Boolean userDeleted = false;
            string query = "delete from project where bugId='" + project.ProjectId + "';";
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


    }
}
