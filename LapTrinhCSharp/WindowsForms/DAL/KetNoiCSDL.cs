using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // Đọc thông tin chuỗi kết nối CSDL từ file App.config
using System.Windows.Forms;

namespace WindowsForms.DAL
{
    class KetNoiCSDL
    {
        // Định nghĩa chuỗi kết nối với CSDL
        string chuoiketnoi = ConfigurationManager.ConnectionStrings["ketnoi_quanlydongvat"].ToString();

        SqlConnection sql_conn;

        public bool KiemTraKetNoi()
        {
            bool is_valid = false;
            try
            {
                sql_conn = new SqlConnection(chuoiketnoi);
                // Kiểm tra trạng thái
                if (sql_conn.State == ConnectionState.Open)
                    is_valid = true;
                else
                    is_valid = false;
            }
            catch
            {
                is_valid = false;
                //throw ex;
                MessageBox.Show("Chuỗi kết nối không tồn tại/sai. Vui lòng kiểm tra lại.");
            }
            return is_valid;
        }

        public void MoKetNoi()
        {
            if (!KiemTraKetNoi())
                sql_conn.Open();
        }


        public void DongKetNoi()
        {
            if (KiemTraKetNoi())
                sql_conn.Close();
        }


        /// <summary>
        /// Lấy dữ liệu: SELECT
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public object LayDuLieu(string query)
        {
            MoKetNoi();

            //SqlCommand sql_cmd = new SqlCommand();
            //sql_cmd.Connection = sql_conn;
            //sql_cmd.CommandType = CommandType.Text; // Định kiểu command thực thi là chuỗi truy vấn dạng text
            //sql_cmd.CommandText = query;

            SqlCommand sql_cmd = new SqlCommand(query, sql_conn);
            SqlDataAdapter da = new SqlDataAdapter(sql_cmd);

            // Khởi tạo đối tượng lưu kết quả trả về từ DataAdapter
            DataSet ds = new DataSet();
            da.Fill(ds);
            DongKetNoi();

            var count_bang = ds.Tables.Count; // Đếm số bảng trả về trong Dataset
            var count_dong = ds.Tables[0].Rows.Count; // Đếm số dòng trong Table đầu tiền của Dataset
            MessageBox.Show("Lấy dữ liệu thành công: " + count_dong.ToString());
            return ds;
        }

        /// <summary>
        /// Ghi dữ liệu: INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int GhiDuLieu(string query)
        {
            MoKetNoi();
            SqlCommand sql_cmd = new SqlCommand(query, sql_conn);
            int ketqua = sql_cmd.ExecuteNonQuery();
            DongKetNoi();
            return ketqua;
        }


    }
}
