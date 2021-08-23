using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QLNVIEN.Connect
{
    public class chuoiKetNoi
    {
        SqlConnection conn = new SqlConnection();
        public chuoiKetNoi()
        {
            try
            {
                conn.ConnectionString = @"Data Source=LAPTOP-VNN522RG;Initial Catalog=QLNHANVIEN;Integrated Security=True";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public DataTable LoadData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int update(string sql, string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
