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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            fBenhNhan fBN = new fBenhNhan();
            fBN.ShowDialog();
        }

        private void btnThuoc_Click(object sender, EventArgs e)
        {
            fThuoc fT = new fThuoc();
            fT.ShowDialog();
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            fDonThuoc fDT = new fDonThuoc();
            fDT.ShowDialog();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            fTaiKhoan fTK = new fTaiKhoan();
            if (fTK.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
