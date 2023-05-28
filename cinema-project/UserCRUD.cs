using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    internal class UserCRUD
    {
        private static MySqlConnection connection;

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            connection = DatabaseConnection.getConnection();
            string sql = "select * from user";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                User user = new User(
                        Convert.ToInt32(dataReader["userId"]),
                        dataReader["name"].ToString(),
                        dataReader["username"].ToString(),
                        dataReader["password"].ToString(),
                        dataReader["role"].ToString());

                users.Add(user);
            }

            connection.Close();
            return users;
        }

        public static User GetUser(int userId)
        {
            connection = DatabaseConnection.getConnection();
            string sql = "select * from user WHERE userId = @UserId";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.Add("@UserId", MySqlDbType.Int32).Value = userId;
            MySqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            User user = new User(
                        Convert.ToInt32(dataReader["userId"]),
                        dataReader["name"].ToString(),
                        dataReader["username"].ToString(),
                        dataReader["password"].ToString(),
                        dataReader["role"].ToString());

            connection.Close();
            return user;
        }

        public static void AddNewUser(User user)
        {
            string sql = "INSERT INTO user VALUES (@UserId, @Name, @Username, @Password, @Role)";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@UserId", MySqlDbType.Int32).Value = user.UserId;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = user.Name;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = user.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = user.Password;
            cmd.Parameters.Add("@Role", MySqlDbType.VarChar).Value = user.Role;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("User not added.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }
    }
}
