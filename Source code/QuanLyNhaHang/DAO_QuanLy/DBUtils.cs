using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLy
{
    public class DBUtils
    {
        public static SqlConnection MakeConnection()
        {
            string strConnection = "server=SE130132;database=QuanLyNhaHang;uid=sa;pwd=123456";
            SqlConnection con = new SqlConnection(strConnection);
            return con;
        }
    }
}
