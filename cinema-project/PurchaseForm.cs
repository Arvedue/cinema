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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            populate();
            User user = UserCRUD.GetUser(userId);
            labelName.Text = user.Name;
        }

        private int userId;

        public void setUser(int id)
        {
            this.userId = id;
        }

        private void populate()
        {
            List<Purchase> purchases = PurchaseCRUD.GetPurchasesOfUser(userId);
            PurchaseListItem[] purchaseListItems = new PurchaseListItem[purchases.Count];

            for (int i = 0; i < purchaseListItems.Length; i++)
            {
                Purchase purchase = purchases.ElementAt(i);

                Session session = SessionCRUD.GetSession(purchase.SessionId);
                FilmRoom filmRoom = FilmRoomCRUD.GetFilmRoom(session.FilmRoomId);
                Movie movie = MovieCRUD.getMovie(session.MovieId);

                purchaseListItems[i] = new PurchaseListItem();
                purchaseListItems[i].PurchaseId = purchase.PurchaseId;
                purchaseListItems[i].Date = purchase.Date;
                purchaseListItems[i].SessionId = session.SessionId;
                purchaseListItems[i].SessionTime = session.Time;
                purchaseListItems[i].MovieName = movie.Name;
                purchaseListItems[i].FilmRoomId = filmRoom.FilmRoomId;
                purchaseListItems[i].FilmRoomType = filmRoom.Type;
                purchaseListItems[i].Price = session.Price;

                if (flowLayoutPanel1.Controls.Count < 0)
                    flowLayoutPanel1.Controls.Clear();
                else flowLayoutPanel1.Controls.Add(purchaseListItems[i]);
            }

        }
    }
}
