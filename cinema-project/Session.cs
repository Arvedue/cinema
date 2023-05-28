using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Session
    {
        private int sessionId;
        private int movieId;
        private int filmRoomId;
        private string time;
        private int price;

        public Session(int sessionId, int movieId, int filmRoomId, string time, int price)
        {
            this.SessionId = sessionId;
            this.MovieId = movieId;
            this.FilmRoomId = filmRoomId;
            this.Time = time;
            this.Price = price;
        }

        public int SessionId { get => sessionId; set => sessionId = value; }
        public string Time { get => time; set => time = value; }
        public int Price { get => price; set => price = value; }
        public int MovieId { get => movieId; set => movieId = value; }
        public int FilmRoomId { get => filmRoomId; set => filmRoomId = value; }
    }
}
