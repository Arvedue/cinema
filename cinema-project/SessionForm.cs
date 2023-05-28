using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    public partial class SessionForm : Form
    {
        private bool isUserAdmin = false;
        private int userId;
        public SessionForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if (!isUserAdmin) buttonAdd.Visible = false;
            populate();
        }

        public void setUserId(int id)
        {
            this.userId = id;
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            Close();
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.setUserId(this.userId);
            if (isUserAdmin)
            {
                moviesForm.checkRole("admin");
            }
            moviesForm.Show();
        }

        private void populate()
        {
            List<Image> images = new List<Image>();

            String[] paths = Directory.GetFiles("C:\\Users\\User\\SystemProgrammingProjects\\cinema-project\\cinema-project\\movie_images\\");

            try
            {
                foreach (String path in paths)
                {
                    images.Add(Image.FromFile(path));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<Session> sessions = SessionCRUD.GetSessions();
            SessionListItem[] sessionListItems = new SessionListItem[sessions.Count];

            for (int i = 0; i < sessionListItems.Length; i++)
            {
                Session session = sessions.ElementAt(i);

                Movie movie = MovieCRUD.getMovie(session.MovieId);
                FilmRoom filmRoom = FilmRoomCRUD.GetFilmRoom(session.FilmRoomId);

                sessionListItems[i] = new SessionListItem();
                sessionListItems[i].SessionId = session.SessionId;
                sessionListItems[i].MovieId = session.MovieId;
                sessionListItems[i].Name = movie.Name;
                sessionListItems[i].FilmRoomId = filmRoom.FilmRoomId;
                sessionListItems[i].FilmRoomType = filmRoom.Type;
                sessionListItems[i].NumberOfSeats = filmRoom.NumberOfSeats;
                sessionListItems[i].Time = session.Time;
                sessionListItems[i].Price = session.Price;
                sessionListItems[i].IsUserAdmin = this.isUserAdmin;
                sessionListItems[i].setUserId(this.userId);

                if (i < images.Count) sessionListItems[i].Banner = images.ElementAt(session.MovieId - 1);

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else flowLayoutPanel1.Controls.Add(sessionListItems[i]);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            SignInForm form = new SignInForm();
            form.ShowDialog();
        }

        public void setAsAdmin()
        {
            this.isUserAdmin = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddSessionForm form = new AddSessionForm();
            form.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populate();
        }
    }
}
