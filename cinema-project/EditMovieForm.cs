using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cinema_project
{
    public partial class EditMovieForm : Form
    {
        public EditMovieForm()
        {
            InitializeComponent();
        }

        private int movieId;

        public void SetMovie(int movieId, string name, int year, string producer, string genre, string country, string description)
        {
            this.movieId = movieId;
            textBoxName.Text = name;
            textBoxYear.Text = year.ToString();
            textBoxProducer.Text = producer;
            textBoxGenre.Text = genre;
            textBoxCountry.Text = country;
            textBoxDescription.Text = description;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int year = Convert.ToInt32(textBoxYear.Text);
            string producer = textBoxProducer.Text;
            string genre = textBoxGenre.Text;
            string country = textBoxCountry.Text;
            string description = textBoxDescription.Text;

            Movie newMovie = new Movie(this.movieId, name, year, producer, genre, country, description);
            MovieCRUD.UpdateMovie(newMovie);

            Close();
        }
    }
}
