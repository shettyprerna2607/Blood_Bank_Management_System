using Blood_Bank_Management_System.BLL;
using Blood_Bank_Management_System.DAL;
using System;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();  
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        public static string loggedInUser;

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = textUsername.Text;
            l.password = txtPassword.Text;

            bool isSuccess = dal.loginCheck(l);
            if (isSuccess == true)
            {
                MessageBox.Show("Login Successful");
                loggedInUser = l.username;
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Try Again");
            }

        }
    }
}
