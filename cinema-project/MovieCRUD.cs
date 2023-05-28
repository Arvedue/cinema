    using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    internal class MovieCRUD
    {
        private static MySqlConnection connection;

        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            connection = DatabaseConnection.getConnection();
            string sql = "select * from movie";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Movie movie = new Movie(
                        Convert.ToInt32(dataReader["movieId"]),
                        dataReader["name"].ToString(),
                        Convert.ToInt32(dataReader["year"]),
                        dataReader["producer"].ToString(),
                        dataReader["genre"].ToString(),
                        dataReader["country"].ToString(),
                        dataReader["description"].ToString());

                movies.Add(movie);
            }

            connection.Close();
            return movies;
        }

        public static Movie getMovie(int movieId)
        {
            connection = DatabaseConnection.getConnection();
            string sql = "select * from movie WHERE movieId = @MovieId";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.Add("@MovieId", MySqlDbType.Int32).Value = movieId;

            MySqlDataReader dataReader = cmd.ExecuteReader();

            dataReader.Read();
            Movie movie = new Movie(
                        Convert.ToInt32(dataReader["movieId"]),
                        dataReader["name"].ToString(),
                        Convert.ToInt32(dataReader["year"]),
                        dataReader["producer"].ToString(),
                        dataReader["genre"].ToString(),
                        dataReader["country"].ToString(),
                        dataReader["description"].ToString());

            connection.Close();
            return movie;
        }

        public static void AddNewMovie(Movie movie)
        {
            string sql = "INSERT INTO movie VALUES (@MovieId, @Name, @Year, @Producer, @Genre, @Country, @Description)";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@MovieId", MySqlDbType.Int32).Value = movie.MovieId;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = movie.Name;
            cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = movie.Year;
            cmd.Parameters.Add("@Producer", MySqlDbType.VarChar).Value = movie.Producer;
            cmd.Parameters.Add("@Genre", MySqlDbType.VarChar).Value = movie.Genre;
            cmd.Parameters.Add("@Country", MySqlDbType.VarChar).Value = movie.Country;
            cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = movie.Description;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Movie not added.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }

        public static void UpdateMovie(Movie movie)
        {
            string sql = "UPDATE movie SET name = @Name, year = @Year, producer = @Producer, genre = @Genre, " +
                "country = @Country, description = @Description WHERE movieId = @MovieId";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@MovieId", MySqlDbType.Int32).Value = movie.MovieId;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = movie.Name;
            cmd.Parameters.Add("@Year", MySqlDbType.Int32).Value = movie.Year;
            cmd.Parameters.Add("@Producer", MySqlDbType.VarChar).Value = movie.Producer;
            cmd.Parameters.Add("@Genre", MySqlDbType.VarChar).Value = movie.Genre;
            cmd.Parameters.Add("@Country", MySqlDbType.VarChar).Value = movie.Country;
            cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = movie.Description;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Movie not updated.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }   

        public static void deleteMovie(Movie movie)
        {
            string sql = "DELETE FROM movie WHERE movieId = @MovieId";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@MovieId", MySqlDbType.Int32).Value = movie.MovieId;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Movie not deleted.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }

    }
}
