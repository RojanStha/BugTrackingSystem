using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BugTrackingSystem.controller
{
    class DbConnection {

        private static MySqlConnection databaseConnection = null;

        public static MySqlConnection GetConnection()
        {
            
            if (databaseConnection == null)
            {
                //connection method calling 
                ConnectDB();
            }
            return databaseConnection;
        }

        private static void ConnectDB()
        {
            try
            {
                //connection string
                string ConnectionString = "datasource=localhost;username=root;password=;database=bugtrackingsystem;SSLmode=none; pooling = false; convert zero datetime=True";

                
                //getting connection
                databaseConnection = new MySqlConnection(ConnectionString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
