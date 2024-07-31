using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSB
{
    public class ConnectionStringManager
    {
        public static string GetConnectionString()
        {
            // Thay thế dòng sau bằng chuỗi kết nối thực tế của bạn
            string connectionString = "Data Source=TRANAN3110\\SQLEXPRESS;Initial Catalog=QL_SANBONG_TEST1;User ID=sa;Password=123";
            return connectionString;
        }
    }
}
