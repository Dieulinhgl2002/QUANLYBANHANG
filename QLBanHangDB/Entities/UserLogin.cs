﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHangDB.Entities
{
    class UserLogin
    {
        private static string _TenDangNhap;

        public static string TenDangNhap
        {
            get { return UserLogin._TenDangNhap; }
            set { UserLogin._TenDangNhap = value; }
        }

        private static string _MaNV = "";
        public static string MaNV
        {
            get { return UserLogin._MaNV; }
            set { UserLogin._MaNV = value; }
        }

        private static string _MaCV = "";

        public static string MaCV
        {
            get { return UserLogin._MaCV; }
            set { UserLogin._MaCV = value; }
        }


        private static string _MatKhau;

        public static string MatKhau
        {
            get { return UserLogin._MatKhau; }
            set { UserLogin._MatKhau = value; }
        }
    }
}
