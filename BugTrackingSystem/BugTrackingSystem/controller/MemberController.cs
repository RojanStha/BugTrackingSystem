using System;
using BugTrackingSystem.model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;



namespace BugTrackingSystem.controller
{
    class MemberController
    {
        public string name, role, email, address, dob, password;
        private MySqlConnection databaseConnection = null;
        private MySqlCommand commandDatabase;


        public MemberController()
        {
            if (databaseConnection == null)
            {
                databaseConnection = DbConnection.GetConnection();
            }

        }

        public Boolean Authenticate(MemberModel member)
        {
            Boolean isValid = false;
            string query = "select * from members where email='" + member.Email + "' " +
                "and password='" + member.Password + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    isValid = true;
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return isValid;
        }



        public Boolean CheckUsername(MemberModel member)
        {
            Boolean userFound = false;
            string query = "select * from members where email='" + member.Email + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    userFound = true;
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return userFound;
        }

        public Boolean CheckEmail(MemberModel member)
        {
            Boolean emailFound = false;
            string query = "select * from members where email='" + member.Email + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    emailFound = true;
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return emailFound;
        }




        public Boolean AddUser(MemberModel member)
        {
            Boolean userAdded = false;
            string query = "insert into members (name, role, email, password, dob, address)" +
                "values ('" + member.MemberName + "', '" + member.Role + "', '" + member.Email + "', '" + member.Password + "', '" + member.Dob + "'," +
                "'" + member.Address + "');";
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
        public DataTable LoadAllUsers()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from members;";
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

        public Boolean DeleteUser(MemberModel member)
        {
            Boolean userDeleted = false;
            string query = "delete from members where id='" + member.MemberId + "' and email='" + member.Email + "';";
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

        public Boolean UpdateUser(MemberModel user)
        {
            Boolean isUpdated = false;
            string query = "UPDATE members SET name='" + user.MemberName + "', " +
                "role='" + user.Role + "'," + "email='" + user.Email + "', password='" + user.Password + "', " +
                "dob='" + user.Dob + "', address='" + user.Address + "' where email ='" + user.Email +"'; ";
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

        public string RetrieveRole(MemberModel user)
        {
            string role = "";
            string query = "select role from members where email='" + user.Email + "' and password='" + user.Password + "';";
            try
            {
                databaseConnection.Open();
                commandDatabase = new MySqlCommand(query, databaseConnection);
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    role = reader["role"].ToString();
                }
                databaseConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            return role;
        }





    }
}
