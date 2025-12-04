using Blood_Bank_Management_System.DAL;
using Blood_Bank_Management_System.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        donerDAL dal = new donerDAL();

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }
        private void donerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoners doners = new frmDoners();
            doners.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            allDonerCount();
            DataTable dt = dal.Select();
            dgvDoners.DataSource = dt;

            lblUser.Text = frmLogin.loggedInUser;   

        }

        public void allDonerCount()
        {
            lblOPositiveCount.Text = dal.countDoners("O+");
            lblOnegativeCount.Text = dal.countDoners("O-");
            lblApositiveCount.Text = dal.countDoners("A+");
            lblAnegativeCount.Text = dal.countDoners("A-");
            lblBPostiveCount.Text = dal.countDoners("B+");
            lblBNegativeCount.Text = dal.countDoners("B-");
            lblABPositiveCount.Text = dal.countDoners("AB+");
            lblABNegativeCount.Text = dal.countDoners("AB-");


        }

        private void Home_Activated(object sender, EventArgs e)
        {
            allDonerCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (!string.IsNullOrWhiteSpace(keywords))
            {
                DataTable dt = dal.Search(keywords);
                dgvDoners.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
            }
        }

    }
}
