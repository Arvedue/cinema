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
    public partial class BookTicketForm : Form
    {
        public BookTicketForm()
        {
            InitializeComponent();
        }

        private int filmRoomId;
        private int userId;
        private int sessionId;
        private FilmRoom filmRoom;

        public void setFilmRoomId(int id)
        {
            this.filmRoomId = id;
        }

        public void setUserId(int id) 
        {
            this.userId = id;
        }

        public void setSessionId(int id)
        {
            this.sessionId = id;    
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            int seat = Convert.ToInt32(cbSeats.Text);   
            List<Purchase> purchases = PurchaseCRUD.GetPurchases();

            if (purchases.Count == 0)
            {
                PurchaseCRUD.AddNewPurchase(new Purchase(1, userId, sessionId, seat, DateTime.Now));
                Close();
                return;
            }

            foreach(Purchase p in purchases)
            {
                if (p.SessionId == sessionId && p.SeatId == seat)
                {
                    MessageBox.Show("Ticket was not bought.", "Seat is already ordered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }
            }

            int id = purchases.Count + 1;
            PurchaseCRUD.AddNewPurchase(new Purchase(id, userId, sessionId, seat, DateTime.Now));

            Close();
        }

        private void BookTicketForm_Load(object sender, EventArgs e)
        {
            filmRoom = FilmRoomCRUD.GetFilmRoom(this.filmRoomId);

            string[] seatsArr = new string[filmRoom.NumberOfSeats];
            for (int i = 0; i < seatsArr.Length; i++)
                seatsArr[i] = (i + 1).ToString();

            cbSeats.Items.AddRange(seatsArr);

            if (filmRoom.Type.Equals("standart"))
                pbFilmRoom.Image = Image.FromFile("C:\\Users\\User\\SystemProgrammingProjects\\cinema-project\\cinema-project\\room_images\\standart.png");
            else if (filmRoom.Type.Equals("vip"))
                pbFilmRoom.Image = Image.FromFile("C:\\Users\\User\\SystemProgrammingProjects\\cinema-project\\cinema-project\\room_images\\vip.png");
        }
    }
}
