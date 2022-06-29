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
    public partial class fDangNhap : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public fDangNhap()
        {
            InitializeComponent();
        }
        public bool KiemTra()
        {
            if (txtTDN.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                return false;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return false;
            }
            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                string tdn = txtTDN.Text.Trim();
                string mk = txtMK.Text.Trim();
                var data = from q in db.TaiKhoans
                           where q.TDN == tdn && q.MK == mk
                           select q;
                if (data.Count() > 0)
                {
                    this.Hide();
                    fMain fM = new fMain();
                    if (fM.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Show();
                        db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.TaiKhoans);
                        txtMK.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
