using Blood_Bank_Management_System.BLL;
using Blood_Bank_Management_System.DAL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        string imageName = "no-image.jpg";
        string rowHeaderImage;
        private static readonly Random random = new Random();

        private string GetImagesFolder()
        {
            return Path.Combine(Application.StartupPath, "images");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // ---------------- ADD USER ----------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool success = dal.Insert(u);

            if (success)
            {
                MessageBox.Show("New user added successfully...");
                dgvUsers.DataSource = dal.Select();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user...");
            }
        }

        // ---------------- CLEAR FIELDS ----------------
        public void Clear()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtUserID.Clear();
            imageName = "no-image.jpg";

            string imagePath = Path.Combine(GetImagesFolder(), "no-image.jpg");
            SetProfilePicture(imagePath);
        }

        // ---------------- SET PROFILE PICTURE ----------------
        private void SetProfilePicture(string imagePath)
        {
            try
            {
                if (pictureBoxProfilePicture.Image != null)
                {
                    pictureBoxProfilePicture.Image.Dispose();
                    pictureBoxProfilePicture.Image = null;
                }

                if (File.Exists(imagePath))
                {
                    using (var img = Image.FromFile(imagePath))
                    {
                        pictureBoxProfilePicture.Image = new Bitmap(img);
                    }
                }
                else
                {
                    pictureBoxProfilePicture.Image = null;
                }
            }
            catch
            {
                pictureBoxProfilePicture.Image = null;
            }
        }

        // ---------------- LOAD DATA WHEN FORM OPENS ----------------
        private void frmUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = dal.Select();
        }

        // ---------------- GRID ROW CLICK TO POPULATE FIELDS ----------------
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;

            txtUserID.Text = dgvUsers.Rows[RowIndex].Cells[0].Value?.ToString();
            txtUsername.Text = dgvUsers.Rows[RowIndex].Cells[1].Value?.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value?.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value?.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value?.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value?.ToString();
            txtAddress.Text = dgvUsers.Rows[RowIndex].Cells[6].Value?.ToString();

            imageName = dgvUsers.Rows[RowIndex].Cells[8].Value?.ToString() ?? "no-image.jpg";
            rowHeaderImage = imageName;

            string imagePath = Path.Combine(GetImagesFolder(), imageName);
            if (!File.Exists(imagePath))
                imagePath = Path.Combine(GetImagesFolder(), "no-image.jpg");

            SetProfilePicture(imagePath);
        }

        // ---------------- UPDATE USER ----------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserID.Text, out int userId))
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            u.user_id = userId;
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            bool success = dal.Update(u);

            if (success)
            {
                MessageBox.Show("User updated successfully...");
                dgvUsers.DataSource = dal.Select();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update user...");
            }
        }

        // ---------------- DELETE USER ----------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserID.Text, out int userId))
            {
                MessageBox.Show("Please select a valid user to delete.");
                return;
            }

            u.user_id = userId;

            // Delete image from folder if not default
            if (rowHeaderImage != "no-image.jpg")
            {
                string imagePath = Path.Combine(GetImagesFolder(), rowHeaderImage);
                if (File.Exists(imagePath))
                {
                    try
                    {
                        File.Delete(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting image: " + ex.Message);
                    }
                }
            }

            bool success = dal.Delete(u);

            if (success)
            {
                MessageBox.Show("User deleted successfully...");
                dgvUsers.DataSource = dal.Select();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete user...");
            }
        }

        // ---------------- SELECT IMAGE ----------------
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(open.FileName);
                int RandInt = random.Next(0, 999999);

                imageName = "User_" + RandInt + ext;

                string imagesDir = GetImagesFolder();
                if (!Directory.Exists(imagesDir))
                    Directory.CreateDirectory(imagesDir);

                string destPath = Path.Combine(imagesDir, imageName);
                File.Copy(open.FileName, destPath, true);

                SetProfilePicture(destPath);
                MessageBox.Show("Image Uploaded Successfully");
            }
        }

        // ---------------- SEARCH USER ----------------
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(keywords))
                dgvUsers.DataSource = dal.Search(keywords);
            else
                dgvUsers.DataSource = dal.Select();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
