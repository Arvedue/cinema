using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Purchase
    {
        private int purchaseId;
        private int userId;
        private int sessionId;
        private int seatId;
        private DateTime date;

        public Purchase(int purchaseId, int userId, int sessionId, int seatId, DateTime date)
        {
            this.PurchaseId = purchaseId;
            this.UserId = userId;
            this.SessionId = sessionId;
            this.SeatId = seatId;
            this.date = date;
        }

        public int PurchaseId { get => purchaseId; set => purchaseId = value; }
        public DateTime Date { get => date; set => date = value; }
        public int UserId { get => userId; set => userId = value; }
        public int SessionId { get => sessionId; set => sessionId = value; }
        public int SeatId { get => seatId; set => seatId = value; }
    }
}
