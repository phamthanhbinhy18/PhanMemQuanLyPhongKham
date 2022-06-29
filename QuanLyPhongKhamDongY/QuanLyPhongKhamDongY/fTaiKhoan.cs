using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKhamDongY
{
    public partial class fTaiKhoan : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public fTaiKhoan()
        {
            InitializeComponent();
        }
        public bool KiemTra()
        {
            if (txtMKC.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được để trống");
                return false;
            }
            if (txtMKM.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống");
                return false;
            }
            return true;
        }
        private void btnDMK_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (KiemTraMKC())
                {
                    string mkm = txtMKM.Text.Trim();
                    var data = from q in db.TaiKhoans
                               where q.TDN == "admin"
                               select q;
                    TaiKhoan tk = data.Single();
                    tk.MK = mkm;
                    db.SubmitChanges();
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
        }
        public bool KiemTraMKC()
        {
            string tdn = "admin";
            string mkc = txtMKC.Text.Trim();
            var data = from q in db.TaiKhoans
                       where q.TDN == tdn && q.MK == mkc
                       select q;
            if (data.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
