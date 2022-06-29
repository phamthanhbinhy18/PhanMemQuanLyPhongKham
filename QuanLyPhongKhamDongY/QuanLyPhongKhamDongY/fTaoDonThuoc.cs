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
    public partial class fTaoDonThuoc : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public int madt;
        public fTaoDonThuoc()
        {
            InitializeComponent();
        }

        private void fTaoDonThuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnChonThuoc_Click(object sender, EventArgs e)
        {
            fThuoc fT = new fThuoc();
            fT.madt = madt;
            if (fT.ShowDialog() == DialogResult.OK)
            {
                ChiTietDonThuoc();
                TongTien();
            }
        }
        public void ChiTietDonThuoc()
        {
            var data = from q in db.ChiTietDonThuocs
                       join q1 in db.Thuocs on q.MaThuoc equals q1.MaThuoc
                       where q.MaDT == madt
                       group new { q, q1 } by new { q.MaThuoc, q1.TenThuoc, q1.Gia } into g
                       select new { MaThuoc = g.Key.MaThuoc, TenThuoc = g.Key.TenThuoc, Gia = g.Key.Gia, SL = g.Sum(x => x.q.SL), ThanhTien = g.Sum(x1 => x1.q.ThanhTien) };
            dgvCTDT.DataSource = data;
            if (dgvCTDT.Rows.Count > 0)
            {
                dgvCTDT.CurrentRow.Selected = true;
            }
        }
        public void TongTien()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.DonThuocs);
            var data = from q in db.DonThuocs
                       where q.MaDT == madt
                       select q;
            DonThuoc dt = data.Single();
            lbTongTien.Text = String.Format("{0:C0}", Int64.Parse(dt.TongTien.ToString()));
        }

        private void btnChonBN_Click(object sender, EventArgs e)
        {
            fBenhNhan fBN = new fBenhNhan();
            fBN.madt = madt;
            if (fBN.ShowDialog() == DialogResult.OK)
            {
                ThongTinBenhNhan();
            }
        }
        public void ThongTinBenhNhan()
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.DonThuocs);
            var data = (from q in db.DonThuocs
                        join q1 in db.BenhNhans on q.MaBN equals q1.MaBN
                        where q.MaDT == madt
                        select new { q.MaBN, q1.TenBN }).Single();
            lbBenhNhan.Text = data.TenBN;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvCTDT.Rows.Count > 0)
            {
                if (lbBenhNhan.Text != "")
                {
                    fXuatHoaDon fXHD = new fXuatHoaDon();
                    fXHD.madt = madt;
                    if (fXHD.ShowDialog() == DialogResult.Cancel)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn bệnh nhân");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn thuốc");
            }
        }
    }
}
