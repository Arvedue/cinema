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
    public partial class PurchaseListItem : UserControl
    {
        public PurchaseListItem()
        {
            InitializeComponent();
        }

        private void PurchaseListItem_Load(object sender, EventArgs e)
        {

        }

        #region Properties

        private int _purchaseId;
        private DateTime _date;
        private int _sessionId;
        private string _sessionTime;
        private string _movieName;
        private int _filmRoomId;
        private string _filmRoomType;
        private int _price;

        [Category("Custom Props")]
        public int PurchaseId { get => _purchaseId; set => labelPurchaseId.Text = "Билет #" + value.ToString(); }
        [Category("Custom Props")]
        public DateTime Date { get => _date; set => labelDate.Text = "Дата: " + value.ToString(); }
        [Category("Custom Props")]
        public int SessionId { get => _sessionId; set => labelSessionId.Text = "Сеанс #" + value.ToString(); }
        [Category("Custom Props")]
        public string SessionTime { get => _sessionTime; set => labelSessionTime.Text = "Время сеанса: " + value.ToString(); }
        [Category("Custom Props")]
        public string MovieName { get => _movieName; set => labelMovie.Text = value.ToString(); }
        [Category("Custom Props")]
        public int FilmRoomId { get => _filmRoomId; set => labelFilmRoomId.Text = "Зал #" + value.ToString(); }
        [Category("Custom Props")]
        public string FilmRoomType { get => _filmRoomType; set => labelFilmRoomType.Text = "Тип зала: " + value.ToString(); }
        [Category("Custom Props")]
        public int Price { get => _price; set => labelPrice.Text = "Цена за билет: " + value.ToString(); }

        #endregion
    }
}
