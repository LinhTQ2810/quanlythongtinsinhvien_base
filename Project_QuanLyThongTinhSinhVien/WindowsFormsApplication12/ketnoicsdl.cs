using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication12
{
    class ketnoicsdl
    {
            static string string_sql_con = "";//@"Data Source=DESKTOP-F4E2ODN\SQLEXPRESS;Initial Catalog=quanlythongtinsinhvien;Integrated Security=True";
            static SqlConnection con;

            public void set_stringsql(string strconn)
            {
                string_sql_con = strconn;
            }

            public string get_stringsql()
            {
                return string_sql_con;
            }

            private void openconnect()
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }

            private void closeconnect()
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            
            // Hàm thực thi dữ liệu là lệnh thêm,sửa,xóa dữ liệu
            public Boolean exedata(string cmd)
            {
                openconnect();
                Boolean check = false;
                try
                {
                    SqlCommand sc = new SqlCommand(cmd, con);
                    sc.ExecuteNonQuery();
                    check = true;
                }
                catch (Exception)
                {
                    check = false;
                }
                closeconnect();
                return check;
            }
            

               // Hàm truy vấn trả về dữ liệu
            public DataTable readdata(string cmd)
            {
                openconnect();
                DataTable da = new DataTable();
                try
                {
                    SqlCommand sc = new SqlCommand(cmd, con);
                    SqlDataAdapter sda = new SqlDataAdapter(sc);
                    sda.Fill(da);
                }
                catch (Exception)
                {
                    da = null;
                }
                closeconnect();
                return da;
            }
        
            //Hàm đọc dữ liệu dùng SqldataReader
            public SqlDataReader Reader(string chuoisql)
            {

                openconnect();
                SqlCommand lenh = new SqlCommand(chuoisql, con);
                SqlDataReader docdl1 = lenh.ExecuteReader();
                closeconnect();
                return docdl1;
            }

            // ExecuteScalar sql dùng để đếm
            public int dembanghi(string chuoisql)
            {
                openconnect();
                SqlCommand bo_lenh = new SqlCommand(chuoisql, con);
                int kq = (int)bo_lenh.ExecuteScalar();
                closeconnect();
                return kq;

            }
            public string testconnect()
            {
                try
                {
                    con = new SqlConnection(string_sql_con);
                    return "True";
                }
                catch (Exception)
                {                    
                    return "False";
                }
               
            }
        
    }
}
