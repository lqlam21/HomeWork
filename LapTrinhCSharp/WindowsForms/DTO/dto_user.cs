using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.DTO
{
    class dto_user
    {
        string id;
        string username;
        string password;
        string ten;
        string hodem;
        DateTime birth;
        string email;
        string phone;
        Boolean active;

        public string Id { get => id; set => id = value; }
        public string Username { 
            get => username; 
            set => username = value; 
        }
        public string Password { 
            get => password; 
            set => password = lib_hash.HashStringSHA256(value); }
        public string Ten { get => ten; set => ten = value; }
        public string Hodem { get => hodem; set => hodem = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Active { get => active; set => active = value; }

        // Viết các hàm xử lý chuỗi cho họ và tên
        // Hàm tính tuổi (thâm niên)
        // Hàm kiểm tra username
        // Hàm kiểm tra email, điện thoại
    }
}
