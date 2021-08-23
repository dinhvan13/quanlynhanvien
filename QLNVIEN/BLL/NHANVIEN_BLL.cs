using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLNVIEN.Model;
using QLNVIEN.Connect;

namespace QLNVIEN.BLL
{
    public class NHANVIEN_BLL
    {
        NHANVIEN_CONNECT nvc = new NHANVIEN_CONNECT();

        public DataTable DanhSachNhanVien()
        {
            return nvc.DanhSachNhanVien();
        }
        public int ThemNhanVien(NHANVIEN nv)
        {
            return nvc.ThemNhanVien(nv);
        }

    }
}
