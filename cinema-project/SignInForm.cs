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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            welcomeLbl.Parent = pictureBox1;
            welcomeLbl.BackColor = Color.Transparent;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Close();
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            List<User> users = UserCRUD.GetUsers();
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            bool isFound = false;

            foreach(User user in users)
            {
                if (user.Username.Equals(login))
                {
                    isFound = true;
                    if (user.Password.Equals(password)) {
                        Close();
                        MoviesForm moviesForm = new MoviesForm();
                        moviesForm.setUserId(user.UserId);
                        moviesForm.checkRole(user.Role);
                        moviesForm.Show();
                    }
                    else MessageBox.Show("Autentication failed.\n", "Password is not correct!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!isFound)
                MessageBox.Show("Autentication failed.\n", "User is not found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
