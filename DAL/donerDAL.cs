using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System.DAL
{
    class donerDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "SELECT * FROM tbl_doners";
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
        public bool Insert(BLL.donerBLL d)
        {
            bool isSuccess = false;

            using (SqlConnection conn = new SqlConnection(myconnstrng))
            {
                try
                {
                    string sql = @"INSERT INTO tbl_doners
                           (first_name, last_name, email, contact, gender, address, blood_group, added_date, image_name, added_by)
                           VALUES
                           (@first_name, @last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name, @added_by)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@first_name", d.first_name);
                    cmd.Parameters.AddWithValue("@last_name", d.last_name);
                    cmd.Parameters.AddWithValue("@email", d.email);
                    cmd.Parameters.AddWithValue("@contact", d.contact);
                    cmd.Parameters.AddWithValue("@gender", d.gender);
                    cmd.Parameters.AddWithValue("@address", d.address);
                    cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                    cmd.Parameters.AddWithValue("@added_date", d.added_date);
                    cmd.Parameters.AddWithValue("@image_name", d.image_name);
                    cmd.Parameters.AddWithValue("@added_by", d.added_by);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isSuccess;
        }
        public bool Update(BLL.donerBLL d)
        {
            bool isSuccess = false;

            using (SqlConnection conn = new SqlConnection(myconnstrng))
            {
                try
                {
                    string sql = @"UPDATE tbl_doners
                           SET first_name = @first_name,
                               last_name = @last_name,
                               email = @email,
                               contact = @contact,
                               gender = @gender,
                               address = @address,
                               blood_group = @blood_group,
                               added_date = @added_date,
                               image_name = @image_name,
                               added_by = @added_by
                           WHERE doner_id = @doner_id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@first_name", d.first_name);
                    cmd.Parameters.AddWithValue("@last_name", d.last_name);
                    cmd.Parameters.AddWithValue("@email", d.email);
                    cmd.Parameters.AddWithValue("@contact", d.contact);
                    cmd.Parameters.AddWithValue("@gender", d.gender);
                    cmd.Parameters.AddWithValue("@address", d.address);
                    cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                    cmd.Parameters.AddWithValue("@added_date", d.added_date);
                    cmd.Parameters.AddWithValue("@image_name", d.image_name);
                    cmd.Parameters.AddWithValue("@added_by", d.added_by);
                    cmd.Parameters.AddWithValue("@doner_id", d.doner_id);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        isSuccess = true;
                    } else
                    {
                        isSuccess = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return isSuccess;
        }
        public bool Delete(BLL.donerBLL d)
        {
            bool isSuccess = false;
            using (SqlConnection conn = new SqlConnection(myconnstrng))
            {
                try
                {
                    string sql = "DELETE FROM tbl_doners WHERE doner_id = @doner_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@doner_id", d.doner_id);
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        isSuccess = true;
                    }
                    else
                    {
                        isSuccess = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return isSuccess;
        }

        public string countDoners(string blood_group)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            string doners = "0";
            try
            {
                string sql = "SELECT * FROM tbl_doners WHERE blood_group = '"+ blood_group +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                doners = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                
            }
            return doners;

        }

        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM tbl_doners WHERE doner_id LIKE '%" + keywords + "%' " +
             "OR first_name LIKE '%" + keywords + "%' " +
             "OR last_name LIKE '%" + keywords + "%' " +
             "OR email LIKE '%" + keywords + "%' " +
             "OR blood_group LIKE '%" + keywords + "%'";

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


    }
}
