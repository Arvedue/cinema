using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    internal class SessionCRUD
    {

        private static MySqlConnection connection;

        public static List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();
            connection = DatabaseConnection.getConnection();
            string sql = "select * from session";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                int sessionId = Convert.ToInt32(dataReader["sessionId"]);
                int movieId = Convert.ToInt32(dataReader["movieId"]);
                int filmRoomId = Convert.ToInt32(dataReader["filmRoomId"]);
                string time = dataReader["time"].ToString();
                int price = Convert.ToInt32(dataReader["price"]);

                Session session = new Session(sessionId, movieId, filmRoomId, time, price);

                sessions.Add(session);
            }

            connection.Close();
            return sessions;
        }

        public static Session GetSession(int sessionId)
        {
            connection = DatabaseConnection.getConnection();
            string sql = "select * from session WHERE sessionId = @SessionId";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.Add("@SessionId", MySqlDbType.Int32).Value = sessionId;
            MySqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            int movieId = Convert.ToInt32(dataReader["movieId"]);
            int filmRoomId = Convert.ToInt32(dataReader["filmRoomId"]);
            string time = dataReader["time"].ToString();
            int price = Convert.ToInt32(dataReader["price"]);

            Session session = new Session(sessionId, movieId, filmRoomId, time, price);

            connection.Close();
            return session;
        }

        public static void AddNewSession(Session session)
        {
            string sql = "INSERT INTO session VALUES (@SessionId, @MovieId, @FilmRoomId, @Time, @Price)";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@SessionId", MySqlDbType.Int32).Value = session.SessionId;
            cmd.Parameters.Add("@MovieId", MySqlDbType.Int32).Value = session.MovieId;
            cmd.Parameters.Add("@FilmRoomId", MySqlDbType.Int32).Value = session.FilmRoomId;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = session.Time;
            cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = session.Price;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Session not added.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }

        public static void UpdateSession(Session session)
        {
            string sql = "UPDATE session SET movieId = @MovieId, filmRoomId = @FilmRoomId, " +
                "time = @Time, price = @Price WHERE sessionId = @SessionId";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@SessionId", MySqlDbType.Int32).Value = session.SessionId;
            cmd.Parameters.Add("@MovieId", MySqlDbType.Int32).Value = session.MovieId;
            cmd.Parameters.Add("@FilmRoomId", MySqlDbType.Int32).Value = session.FilmRoomId;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = session.Time;
            cmd.Parameters.Add("@Price", MySqlDbType.Int32).Value = session.Price;
           
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Session not updated.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }

        public static void deleteSession(Session session)
        {
            string sql = "DELETE FROM session WHERE sessionId = @SessionId";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@SessionId", MySqlDbType.Int32).Value = session.SessionId;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Session not deleted.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }
    }

}
