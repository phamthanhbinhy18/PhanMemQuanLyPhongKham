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
    public partial class fDonThuoc : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public fDonThuoc()
        {
            InitializeComponent();
        }

        private void btnTaoDonThuoc_Click(object sender, EventArgs e)
        {
            DonThuoc dt = new DonThuoc();
            dt.NgayLap = DateTime.Now;
            dt.TongTien = 0;
            db.DonThuocs.InsertOnSubmit(dt);
            db.SubmitChanges();
            fTaoDonThuoc fTDT = new fTaoDonThuoc();
            fTDT.madt = LayMaDT();
            if (fTDT.ShowDialog() == DialogResult.OK)
            {
                DonThuoc();
            }
        }
        public int LayMaDT()
        {
            var data = from q in db.DonThuocs
                       orderby q.MaDT descending
                       select q;
            DonThuoc dt = data.First();
            return Int32.Parse(dt.MaDT.ToString());
        }
        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDT.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa đơn thuốc?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var data = from q in db.DonThuocs
                               where q.MaDT == Int32.Parse(dgvDT.CurrentRow.Cells["MaDT"].Value.ToString())
                               select q;
                    DonThuoc dt = data.Single();
                    db.DonThuocs.DeleteOnSubmit(dt);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa đơn thuốc thành công");
                    DonThuoc();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn thuốc");
            }
        }

        private void fDonThuoc_Load(object sender, EventArgs e)
        {
            DonThuoc();
        }
        public void DonThuoc()
        {
            var data = from q in db.DonThuocs
                       join q1 in db.BenhNhans on q.MaBN equals q1.MaBN
                       where q.MaBN != null && q.TongTien != 0
                       orderby q.MaDT descending
                       select new { q.MaDT, q1.TenBN, q.NgayLap, q.TongTien };
            dgvDT.DataSource = data;
            if (dgvDT.Rows.Count > 0)
            {
                dgvDT.CurrentRow.Selected = true;
            }
        }

        private void dgvDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDT.Rows.Count > 0)
            {
                dgvDT.CurrentRow.Selected = true;
            }
        }

        private void btnInDonThuoc_Click(object sender, EventArgs e)
        {
            if (dgvDT.Rows.Count > 0)
            {
                int madt = Int32.Parse(dgvDT.CurrentRow.Cells["MaDT"].Value.ToString());
                fXuatHoaDon fXHD = new fXuatHoaDon();
                fXHD.madt = madt;
                fXHD.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            if (tukhoa == "")
            {
                DonThuoc();
            }
            else
            {
                var data = from q in db.DonThuocs
                           join q1 in db.BenhNhans on q.MaBN equals q1.MaBN
                           where q.MaBN != null && q.TongTien != 0 && (q1.TenBN.Contains(tukhoa) || q1.SDT.Contains(tukhoa) || q.TongTien.ToString().Contains(tukhoa) || q.NgayLap.ToString().Contains(tukhoa))
                           orderby q.MaDT descending
                           select new { q.MaDT, q1.TenBN, q.NgayLap, q.TongTien };
                dgvDT.DataSource = data;
                if (dgvDT.Rows.Count > 0)
                {
                    dgvDT.CurrentRow.Selected = true;
                }
            }
        }
    }
}
