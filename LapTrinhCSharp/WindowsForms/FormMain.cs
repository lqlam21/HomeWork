using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.DAL;

namespace WindowsForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Test Load dữ liệu (xem thành công không)
            dal_user all_user = new dal_user();

            all_user.ThemNguoiDung();
            all_user.LayNguoiDung();
            all_user.UpdateNguoiDung("a", "b");
            all_user.XoaNguoiDung("a");
            
        }
    }
}
