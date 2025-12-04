using Blood_Bank_Management_System.BLL;
using Blood_Bank_Management_System.DAL;
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

namespace Blood_Bank_Management_System.UI
{
    public partial class frmDoners : Form
    {
        public frmDoners()
        {
            InitializeComponent();
        }
        donerBLL d = new donerBLL();
        donerDAL dal = new donerDAL();
        userDAL udal = new userDAL();
        string imageName = "no-image.jpg";

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;

            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetUserIDFromUsername(loggedInUser);
            d.added_by = usr.user_id;
            d.image_name = imageName;

            bool success = dal.Insert(d);
            if (success == true)
            {
                MessageBox.Show("New Doner Added Successfully");
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New Doner. Try Again.");
            }

        }
        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbBloodGroup.Text = "";
            cmbGender.Text = "";
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = path + "\\images\\no-image.jpg";
            pictureBoxProfilePicture.Image = new Bitmap(imagePath);
        }

        private void frmDoners_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvDoners.DataSource = dt;
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = path + "\\images\\no-image.jpg";
            pictureBoxProfilePicture.Image = new Bitmap(imagePath);
        }

        private void dgvDoners_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtDonerID.Text = dgvDoners.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDoners.Rows[RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvDoners.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDoners.Rows[RowIndex].Cells[3].Value.ToString();
            cmbGender.Text = dgvDoners.Rows[RowIndex].Cells[4].Value.ToString();
            cmbBloodGroup.Text = dgvDoners.Rows[RowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvDoners.Rows[RowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvDoners.Rows[RowIndex].Cells[7].Value.ToString();
            imageName = dgvDoners.Rows[RowIndex].Cells[9].Value.ToString();
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = path + "\\images\\" + imageName;
            pictureBoxProfilePicture.Image = new Bitmap(imagePath);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.doner_id = int.Parse(txtDonerID.Text);
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetUserIDFromUsername(loggedInUser);
            d.added_by = usr.user_id;
            d.image_name = imageName;

            bool success = dal.Update(d);
            if (success == true)
            {
                MessageBox.Show("Doner Updated Successfully");
                Clear();
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Update Doner. Try Again.");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.doner_id = int.Parse(txtDonerID.Text);
            bool isSuccess = dal.Delete(d);
            if (isSuccess == true)
            {
                MessageBox.Show("Doner Deleted Successfully");
                Clear();
                DataTable dt = dal.Select();
                dgvDoners.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Delete Doner. Try Again.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files Only (*.jpg;*.jpeg;*.png;*.gif;|*.jpg;*.jpeg;*.png;*.gif;)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);
                    string ext = Path.GetExtension(open.FileName);
                    string name = Path.GetFileNameWithoutExtension(open.FileName);
                    Guid g = new Guid();
                    g = Guid.NewGuid();
                    imageName = "BBMS" + name + g + ext;
                    string sourcePath = open.FileName;
                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
                    string destinationPath = paths + "\\images\\" + imageName;
                    File.Copy(sourcePath, destinationPath);
                    MessageBox.Show("Image Uploaded Successfully!");

                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox1.Text;

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
