using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLNVIEN.Model;

namespace QLNVIEN.Connect
{
    public class NHANVIEN_CONNECT
    {
        chuoiKetNoi cn = new chuoiKetNoi();
        public DataTable DanhSachNhanVien()
        {
            return cn.LoadData("select * from NHANVIEN");

        }

        public int ThemNhanVien(NHANVIEN nv)
        {
            int Nparemeter = 7;
            string[] name = new string[Nparemeter];
            object[] value = new object[Nparemeter];
            name[0] = "@HoTen"; value[0] = nv.HoTen;
            name[1] = "@Khoa_PhongBan"; value[1] = nv.Khoa_PhongBan;
            name[2] = "@TrinhDo_ChucVu"; value[2] = nv.TrinhDo_ChucVu;
            name[3] = "@PhuCap"; value[3] = nv.PhuCap;
            name[4] = "@SoTietDay_SoNgayCong"; value[4] = nv.SoTietDay_SoNgayCong;
            name[5] = "@HeSoLuong"; value[5] = nv.HeSoLuong;
            name[6] = "@LoaiNhanVien"; value[6] = nv.LoaiNhanVien;
            return cn.update("insert into NHANVIEN(HoTen,Khoa_PhongBan,TrinhDo_ChucVu,PhuCap,SoTietDay_SoNgayCong,HeSoLuong,LoaiNhanVien) VALUES(@HoTen,@Khoa_PhongBan,@TrinhDo_ChucVu,@PhuCap,@SoTietDay_SoNgayCong,@HeSoLuong,@LoaiNhanVien)", name, value, Nparemeter);


        }
    }
}
