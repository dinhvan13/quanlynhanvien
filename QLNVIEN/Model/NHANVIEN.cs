using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLNVIEN.Model
{
   public class NHANVIEN
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _Khoa_PhongBan;

        public string Khoa_PhongBan
        {
            get { return _Khoa_PhongBan; }
            set { _Khoa_PhongBan = value; }
        }
        private int _TrinhDo_ChucVu;

        public int TrinhDo_ChucVu
        {
            get { return _TrinhDo_ChucVu; }
            set { _TrinhDo_ChucVu = value; }
        }
        private int _PhuCap;

        public int PhuCap
        {
            get { return _PhuCap; }
            set { _PhuCap = value; }
        }
        private int _SoTietDay_SoNgayCong;

        public int SoTietDay_SoNgayCong
        {
            get { return _SoTietDay_SoNgayCong; }
            set { _SoTietDay_SoNgayCong = value; }
        }
        private float _HeSoLuong;

        public float HeSoLuong
        {
            get { return _HeSoLuong; }
            set { _HeSoLuong = value; }
        }
        private float _TongLuong;

        public float TongLuong
        {
            get { return _TongLuong; }
            set { _TongLuong = value; }
        }
        private int _LoaiNhanVien;

        public int LoaiNhanVien
        {
            get { return _LoaiNhanVien; }
            set { _LoaiNhanVien = value; }
        }

        public enum TrinhDo
        {
            CuNhan = 1, ThacSi = 2, TienSy = 3, TruongPhong = 4, PhoPhong = 5, NhanVien = 6
        }
        public static string KiemTraTrinhDo(int trinhDo)
        {
            if (trinhDo == 1)
            {
                return TrinhDo.CuNhan.ToString();

            }
            else if (trinhDo == 2)
            {
                return TrinhDo.ThacSi.ToString();
            }
            else if (trinhDo == 3)
            {
                return TrinhDo.TienSy.ToString();
            }
            else if (trinhDo == 4)
            {
                return TrinhDo.TruongPhong.ToString();
            }
            else if (trinhDo == 5)
            {
                return TrinhDo.PhoPhong.ToString();
            }
            else return TrinhDo.NhanVien.ToString();
        }
        public static int KiemTraPhuCap(int trinhDo)
        {
            if (trinhDo == 1)
            {
                return 300;
            }
            else if (trinhDo == 2 || trinhDo == 6)
            {
                return 500;
            }
            else if (trinhDo == 3 || trinhDo == 5)
            {
                return 1000;
            }
            else
                return 2000;
        }

    }
}
