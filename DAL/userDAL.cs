using Blood_Bank_Management_System.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.DAL
{
    class userDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        // Select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_users";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // Insert new user
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);
            try
            {
                string sql = "INSERT INTO tbl_users (username, email, password, full_name, contact, address, added_date, image_name) " +
                             "VALUES (@username, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        // Update existing user
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "UPDATE tbl_users SET username=@username, email=@email, password=@password, full_name=@full_name, " +
                             "contact=@contact, address=@address, added_date=@added_date, image_name=@image_name WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                conn.Open(); 
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // Delete user
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                string sql = "DELETE FROM tbl_users WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                conn.Open(); 
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstr);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_users WHERE user_id LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%' OR email LIKE '%" + keywords + "%' OR full_name LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt; 
        }

        public userBLL GetUserIDFromUsername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstr);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT user_id FROM tbl_users WHERE username='"+ username +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }
    }
}
