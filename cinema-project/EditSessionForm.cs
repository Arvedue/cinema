using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    public partial class EditSessionForm : Form
    {
        public EditSessionForm()
        {
            InitializeComponent();
        }

        private int sessionId;
        public void setSession(int sessionId, int movieId, int filmRoomId, string time, int price)
        {
            this.sessionId = sessionId;
            cbMovieId.Text = movieId.ToString();
            cbFilmRoomId.Text = filmRoomId.ToString();
            cbTime.Text = time.ToString();
            tbPrice.Text = price.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(cbMovieId.Text);
            int filmRoomId = Convert.ToInt32(cbFilmRoomId.Text);
            string time = cbTime.Text;
            int price = Convert.ToInt32(tbPrice.Text);

            Session session = new Session(sessionId, movieId, filmRoomId, time, price);
            SessionCRUD.UpdateSession(session);

            Close();
        }

        private void EditSessionForm_Load(object sender, EventArgs e)
        {
            List<Movie> movies = MovieCRUD.GetMovies();
            List<FilmRoom> filmRooms = FilmRoomCRUD.GetFilmRooms();

            string[] moviesId = new string[movies.Count];
            for (int i = 0; i < movies.Count; i++)
                moviesId[i] = movies.ElementAt(i).MovieId.ToString();

            string[] filmRoomsId = new string[filmRooms.Count];
            for (int i = 0; i < filmRooms.Count; i++)
                filmRoomsId[i] = filmRooms.ElementAt(i).FilmRoomId.ToString();

            string[] time = {
                "8:00:00",
                "10:00:00",
                "12:00:00",
                "14:00:00",
                "16:00:00",
                "18:00:00",
                "20:00:00"
            };

            cbMovieId.Items.AddRange(moviesId);
            cbFilmRoomId.Items.AddRange(filmRoomsId);
            cbTime.Items.AddRange(time);
        }
    }
}
