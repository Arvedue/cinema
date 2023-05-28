using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_project
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            welcomeLbl.Parent = pictureBox1;
            welcomeLbl.BackColor = Color.Transparent;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            List<User> users = UserCRUD.GetUsers();
            int id = users.Count + 1;
            User user = new User(id, name, username, password, "customer");

            UserCRUD.AddNewUser(user);

            Close();
            MoviesForm customerMainForm = new MoviesForm();
            customerMainForm.setUserId(user.UserId);
            customerMainForm.Show();
        }
    }
}
