using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cinema_project
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int movieId = Convert.ToInt32(textBoxId.Text);
            string name = textBoxName.Text;
            int year = Convert.ToInt32(textBoxYear.Text);
            string producer = textBoxProducer.Text;
            string genre = textBoxGenre.Text;
            string country = textBoxCountry.Text;
            string description = textBoxDescription.Text;

            Movie newMovie = new Movie(movieId, name, year, producer, genre, country, description);
            MovieCRUD.AddNewMovie(newMovie);

            Close();
        }
    }
}
