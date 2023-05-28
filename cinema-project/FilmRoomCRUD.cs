using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class FilmRoomCRUD
    {
        private static MySqlConnection connection;

        public static List<FilmRoom> GetFilmRooms()
        {
            List<FilmRoom> filmRooms = new List<FilmRoom>();
            connection = DatabaseConnection.getConnection();
            string sql = "select * from filmroom";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                FilmRoom filmRoom = new FilmRoom(
                        Convert.ToInt32(dataReader["filmRoomId"]),
                        dataReader["type"].ToString(),
                        Convert.ToInt32(dataReader["numberOfSeats"]));

                filmRooms.Add(filmRoom);
            }

            connection.Close();
            return filmRooms;
        }

        public static FilmRoom GetFilmRoom(int filmRoomId)
        {
            connection = DatabaseConnection.getConnection();
            string sql = "select * from filmroom WHERE filmRoomId = @FilmRoomId";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.Add("@FilmRoomId", MySqlDbType.Int32).Value = filmRoomId;

            MySqlDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();

            FilmRoom filmRoom = new FilmRoom(
                        Convert.ToInt32(dataReader["filmRoomId"]),
                        dataReader["type"].ToString(),
                        Convert.ToInt32(dataReader["numberOfSeats"]));

            connection.Close();
            return filmRoom;
        }
    }
}
