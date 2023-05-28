using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    public partial class MovieListItem : UserControl
    {
        public MovieListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private int _movieId;

        [Category("Custom Props")]
        public int MovieId
        {
            get { return _movieId; }
            set { this._movieId = value; }
        }

        private string _name;

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set 
            {
                this._name = value;
                labelName.Text = value; 
            }
        }

        private int _year;

        [Category("Custom Props")]
        public int Year
        {
            get { return _year; }
            set 
            { 
                labelYear.Text = "Год: " + value.ToString(); 
                this._year = value;
            }
        }

        private string _producer;

        [Category("Custom Props")]
        public string Producer
        {
            get { return _producer; }
            set 
            { 
                labelProducer.Text = "Режиссер: " + value;
                this._producer = value;
            }
        }

        private string _genre;

        [Category("Custom Props")]
        public string Genre
        {
            get { return _genre; }
            set 
            { 
                labelGenre.Text = "Жанр: " + value; 
                this._genre = value;
            }
        }

        private string _country;

        [Category("Custom Props")]
        public string Country
        {
            get { return _country; }
            set 
            { 
                labelCountry.Text = "Страна: " + value;
                this._country = value;
            }
        }

        private string _description;

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set 
            { 
                labelDescription.Text = "Описание: " + value; 
                this._description = value;
            }
        }

        private Image _banner;

        [Category("Custom Props")]
        public Image Banner
        {
            get { return _banner; }
            set { movieBanner.Image =  value; }
        }

        private bool isUserAdmin = false;
        public bool IsUserAdmin { get => isUserAdmin; set => isUserAdmin = value; }


        #endregion

        private void MovieListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MintCream;
        }

        private void MovieListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void MovieListItem_Load(object sender, EventArgs e)
        {
            if (!IsUserAdmin)
            {
                buttonDelete.Visible = false;
                buttonEdit.Visible = false;
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(_movieId, _name, _year, _producer, _genre, _country, _description);
            MovieCRUD.deleteMovie(movie);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditMovieForm editMovie = new EditMovieForm();
            editMovie.SetMovie(_movieId, _name, _year, _producer, _genre, _country, _description);
            editMovie.ShowDialog();
        }
    }
}
