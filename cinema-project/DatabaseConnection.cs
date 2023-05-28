using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    internal class DatabaseConnection
    {

        public static MySqlConnection getConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=root;database=cinema";
            MySqlConnection connection = new MySqlConnection(sql);

            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("MySqlConnection.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return connection;
        }
    }
}
