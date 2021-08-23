using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLNVIEN.Model;
using QLNVIEN.BLL;

namespace QLNVIEN
{
    public partial class frmThemMoiNV : Form
    {
        public frmThemMoiNV()
        {
            InitializeComponent();
        }

        private void btnThemnv_Click(object sender, EventArgs e)
        {
            NHANVIEN_BLL cls = new NHANVIEN_BLL();
            NHANVIEN nv = new NHANVIEN();
            nv.HoTen = txtHoten.Text;
            nv.Khoa_PhongBan = txtkhoa.Text;
            nv.TrinhDo_ChucVu = int.Parse(cbTrinhdo.Text);
            nv.PhuCap = int.Parse(txtPhucap.Text);
            nv.SoTietDay_SoNgayCong = int.Parse(txtSotiet.Text);
            nv.HeSoLuong = float.Parse(txtHesoluong.Text);
            nv.LoaiNhanVien = int.Parse(cbLoainv.Text);
            cls.ThemNhanVien(nv);
            MessageBox.Show("Them thanh cong!Load lai du lieu");
            this.Close();
            
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemMoiNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHANVIENDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLNHANVIENDataSet.NHANVIEN);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbTrinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
