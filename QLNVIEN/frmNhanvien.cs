using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLNVIEN.BLL;
using QLNVIEN.Model;
using QLNVIEN.Connect;


namespace QLNVIEN
{
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void txtLoadData_Click(object sender, EventArgs e)
        {
            NHANVIEN_BLL nvcls = new NHANVIEN_BLL();


            dgrNhanVien.DataSource = nvcls.DanhSachNhanVien();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {

            NHANVIEN_BLL nvcls = new NHANVIEN_BLL();


            dgrNhanVien.DataSource = nvcls.DanhSachNhanVien();
        }

        private void txtThemmoinv_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmThemMoiNV tmnv = new frmThemMoiNV();
            tmnv.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-VNN522RG;Initial Catalog=QLNHANVIEN;Integrated Security=True");
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
          /*if (txtHoTen.Text.Length > 0)
            {

                BindingSource bs = new BindingSource();
                bs.Filter = string.Format("HoTen like '%" + txtHoTen.Text + "%'");
                dgrNhanVien.DataSource = bs;
            
               

                
                

            } */
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from NHANVIEN where HoTen like('"+txtHoTen.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgrNhanVien.DataSource = dt;
            con.Close();
          
           
       }

        private void txtHoTen_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgrNhanVien_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }
    }
    }

