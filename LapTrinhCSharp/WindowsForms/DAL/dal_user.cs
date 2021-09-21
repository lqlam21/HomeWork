using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsForms.DAL
{
    class dal_user : KetNoiCSDL
    {
        // - Lấy tất cả (Get All: SELECT * FORM...)
        public object LayNguoiDung()
        {
            string query = "SELECT [id] ";
            query += ",[username] ";
            query += ",[password] ";
            query += ",[ten] ";
            query += ",[hodem] ";
            query += ",[birth] ";
            query += ",[email] ";
            query += ",[phone] ";
            query += ",[active] ";
            query += "FROM[dbo].[tb_user]";

            return LayDuLieu(query);
        }


        // - Lấy có điều kiện (Get by conditions: SELECT * FROM ... WHERE...)
        public object LayNguoiDung(int id)
        {
            string query = "SELECT [id] ";
            query += ",[username] ";
            query += ",[password] ";
            query += ",[ten] ";
            query += ",[hodem] ";
            query += ",[birth] ";
            query += ",[email] ";
            query += ",[phone] ";
            query += ",[active] ";
            query += "FROM[dbo].[tb_user] WHERE id =" + id;

            return LayDuLieu(query);
        }

        // - Thêm mới (INSERT)
        public object ThemNguoiDung()
        {
            DTO.dto_user obj = new DTO.dto_user();
            obj.Username = "linh";
            obj.Password = "linh123";
            obj.Ten = "Linh    ";
            obj.Hodem = "Trần Mỹ     ";

            string query = "INSERT INTO [dbo].[tb_user] ";
            query += "([username] ";
            query += ",[password] ";
            query += ",[ten] ";
            query += ",[hodem] )";
            query += "VALUES ('" + obj.Username + "', '" + obj.Password + "', '" + obj.Ten + "', '" + obj.Hodem + "')";

            return GhiDuLieu(query);
        }


        // - Cập nhật (UPDATE)
        public object UpdateNguoiDung(string name, string new_username)
        {
            DTO.dto_user obj = new DTO.dto_user();
            string query = " UPDATE SINHVIEN SET username = '" + new_username + "' WHERE ten = '" + name + "'";
            return GhiDuLieu(query);
        }

        // - Xóa bản ghi (DELETE)
        public object XoaNguoiDung(string name)
        {
            DTO.dto_user obj = new DTO.dto_user();
            string query = " DELETE SINHVIEN WHERE ten = '" + name + "'";
            return GhiDuLieu(query);
        }
    }
}
