using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class FilmRoom
    {
        private int filmRoomId;
        private string type;
        private int numberOfSeats;

        public FilmRoom(int filmRoodId, string type, int numberOfSeats)
        {
            this.FilmRoomId = filmRoodId;
            this.Type = type;
            this.NumberOfSeats = numberOfSeats;
        }

        public int FilmRoomId { get => filmRoomId; set => filmRoomId = value; }
        public string Type { get => type; set => type = value; }
        public int NumberOfSeats { get => numberOfSeats; set => numberOfSeats = value; }
    }
}
