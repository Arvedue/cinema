using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    internal class PurchaseCRUD
    {
        private static MySqlConnection connection;

        public static List<Purchase> GetPurchasesOfUser(int userId)
        {
            List<Purchase> purchases = new List<Purchase>();
            connection = DatabaseConnection.getConnection();
            string sql = "select * from purchase WHERE userId = @UserId";
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.Add("@UserId", MySqlDbType.Int32).Value = userId;

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Purchase purchase = new Purchase(
                        Convert.ToInt32(dataReader["purchaseId"]),
                        Convert.ToInt32(dataReader["userId"]),
                        Convert.ToInt32(dataReader["sessionId"]),
                        Convert.ToInt32(dataReader["seat"]),
                        DateTime.Parse(dataReader["date"].ToString()));

                purchases.Add(purchase);
            }

            connection.Close();
            return purchases;
        }

        public static List<Purchase> GetPurchases()
        {
            List<Purchase> purchases = new List<Purchase>();
            connection = DatabaseConnection.getConnection();
            string sql = "select * from purchase";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Purchase purchase = new Purchase(
                        Convert.ToInt32(dataReader["purchaseId"]),
                        Convert.ToInt32(dataReader["userId"]),
                        Convert.ToInt32(dataReader["sessionId"]),
                        Convert.ToInt32(dataReader["seat"]),
                        DateTime.Parse(dataReader["date"].ToString()));

                purchases.Add(purchase);
            }

            connection.Close();
            return purchases;
        }

        public static void AddNewPurchase(Purchase purchase)
        {
            string sql = "INSERT INTO purchase VALUES (@PurchaseId, @UserId, @SessionId, @Seat, @Date)";
            connection = DatabaseConnection.getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.Add("@PurchaseId", MySqlDbType.Int32).Value = purchase.PurchaseId;
            cmd.Parameters.Add("@UserId", MySqlDbType.Int32).Value = purchase.UserId;
            cmd.Parameters.Add("@SessionId", MySqlDbType.Int32).Value = purchase.SessionId;
            cmd.Parameters.Add("@Seat", MySqlDbType.Int32).Value = purchase.SeatId;
            cmd.Parameters.Add("@Date", MySqlDbType.DateTime).Value = purchase.Date.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.", "Ticket was bought.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Purchase not added.\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            connection.Close();
        }
    }
}
