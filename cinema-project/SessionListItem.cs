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
    public partial class SessionListItem : UserControl
    {
        public SessionListItem()
        {
            InitializeComponent();
        }

        private void SessionListItem_Load(object sender, EventArgs e)
        {
            if (!IsUserAdmin)
            {
                buttonDelete.Visible = false;
                buttonEdit.Visible = false;
            }
        }

        #region Properties
        private int _sessionId;

        [Category("Custom Props")]
        public int SessionId
        {
            get { return _sessionId; }
            set { this._sessionId = value; }
        }

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

        private int _filmRoomId;

        [Category("Custom Props")]
        public int FilmRoomId
        {
            get { return _filmRoomId; }
            set
            {
                labelFilmRoom.Text = "Номер зала: " + value.ToString();
                this._filmRoomId = value;
            }
        }

        private string _filmRoomType;

        [Category("Custom Props")]
        public string FilmRoomType
        {
            get { return _filmRoomType; }
            set
            {
                labelType.Text = "Тип зала: " + value;
                this._filmRoomType = value;
            }
        }

        private int _numberOfSeats;

        [Category("Custom Props")]
        public int NumberOfSeats
        {
            get { return _numberOfSeats; }
            set
            {
                labelNumberOfSeats.Text = "Количество мест: " + value.ToString();
                this._numberOfSeats = value;
            }
        }

        private string _time;

        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set
            {
                labelTime.Text = "Время: " + value;
                this._time = value;
            }
        }

        private int _price;

        [Category("Custom Props")]
        public int Price
        {
            get { return _price; }
            set
            {
                labelPrice.Text = "Цена за 1 билет: " + value.ToString();
                this._price = value;
            }
        }

        private Image _banner;

        [Category("Custom Props")]
        public Image Banner
        {
            get { return _banner; }
            set { movieBanner.Image = value; }
        }

        private bool isUserAdmin = false;
        public bool IsUserAdmin { get => isUserAdmin; set => isUserAdmin = value; }

        #endregion

        private int userId;
        public void setUserId(int id)
        {
            this.userId = id;
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditSessionForm form = new EditSessionForm();
            form.setSession(_sessionId, _movieId, _filmRoomId, _time, _price);
            form.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Session session = new Session(_sessionId, _movieId, _filmRoomId, _time, _price);
            SessionCRUD.deleteSession(session);
        }

        private void SessionListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MintCream;
        }

        private void SessionListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SessionListItem_MouseClick(object sender, MouseEventArgs e)
        {
            BookTicketForm form = new BookTicketForm();
            form.setUserId(this.userId);
            form.setSessionId(_sessionId);
            form.setFilmRoomId(_filmRoomId);
            form.ShowDialog();
        }
    }


}
