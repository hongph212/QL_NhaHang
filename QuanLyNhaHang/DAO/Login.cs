using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class Login
    {
        private static string user = "";

        public static string User
        {
            get { return user; }
            set { user = value; }
        }
    }
}
