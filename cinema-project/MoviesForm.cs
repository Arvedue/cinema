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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private bool isUserAdmin = false;
        private int userId;

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {
            if (!isUserAdmin) buttonAdd.Visible = false;
            populate();
        }

        public void setUserId(int id)
        {
            this.userId = id;
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

            List<Movie> movies = MovieCRUD.GetMovies();
            MovieListItem[] movieListItems = new MovieListItem[movies.Count];

            for (int i = 0; i < movieListItems.Length; i++)
            {
                Movie movie = movies.ElementAt(i);
                movieListItems[i] = new MovieListItem();
                movieListItems[i].MovieId = movie.MovieId;
                movieListItems[i].Name = movie.Name;
                movieListItems[i].Year = movie.Year;
                movieListItems[i].Producer = movie.Producer;
                movieListItems[i].Genre = movie.Genre;
                movieListItems[i].Country = movie.Country;
                movieListItems[i].Description = movie.Description;
                movieListItems[i].IsUserAdmin = this.isUserAdmin;
                if (i < images.Count) movieListItems[i].Banner = images.ElementAt(i);

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else flowLayoutPanel1.Controls.Add(movieListItems[i]);
            }

        }
        
        public void checkRole(String role)
        {
            if (role.Equals("admin"))
            {
                this.isUserAdmin = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            SessionForm form = new SessionForm();
            form.setUserId(this.userId);
            if (isUserAdmin) form.setAsAdmin();
            form.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddMovieForm addForm = new AddMovieForm();
            addForm.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            SignInForm form = new SignInForm();
            form.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            PurchaseForm form = new PurchaseForm();
            form.setUser(this.userId);
            form.ShowDialog();
        }
    }
}
