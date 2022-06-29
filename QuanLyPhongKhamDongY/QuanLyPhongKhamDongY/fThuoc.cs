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
    public partial class fThuoc : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public int madt = 0;
        public fThuoc()
        {
            InitializeComponent();
        }

        private void fThuoc_Load(object sender, EventArgs e)
        {
            Thuoc();
            if (madt != 0)
            {
                lbSL.Visible = true;
                txtSoLuong.Visible = true;
                btnChonThuoc.Visible = true;
            }
        }
        public void Thuoc()
        {
            var data = from q in db.Thuocs
                       select q;
            dgvT.DataSource = data;
            if (dgvT.Rows.Count > 0)
            {
                dgvT.CurrentRow.Selected = true;
            }
        }

        private void dgvT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvT.Rows.Count > 0)
            {
                dgvT.CurrentRow.Selected = true;
                lbMaThuoc.Text = dgvT.CurrentRow.Cells["MaThuoc"].Value.ToString();
                txtTenThuoc.Text = dgvT.CurrentRow.Cells["TenThuoc"].Value.ToString();
                listQuyCach.SelectedItem = dgvT.CurrentRow.Cells["QuyCach"].Value.ToString();
                txtCongDung.Text = dgvT.CurrentRow.Cells["CongDung"].Value.ToString();
                txtCachDung.Text = dgvT.CurrentRow.Cells["CachDung"].Value.ToString();
                dateNSX.Value = DateTime.Parse(dgvT.CurrentRow.Cells["NSX"].Value.ToString());
                dateHSD.Value = DateTime.Parse(dgvT.CurrentRow.Cells["HSD"].Value.ToString());
                txtGia.Text = dgvT.CurrentRow.Cells["Gia"].Value.ToString();
            }
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }
        public bool KiemTra()
        {
            if (txtTenThuoc.Text == "")
            {
                MessageBox.Show("Tên thuốc không được để trống");
                return false;
            }
            if (listQuyCach.SelectedItem == null)
            {
                MessageBox.Show("Quy cách không được để trống");
                return false;
            }
            if (txtCongDung.Text == "")
            {
                MessageBox.Show("Công dụng không được để trống");
                return false;
            }
            if (txtCachDung.Text == "")
            {
                MessageBox.Show("Cách dùng không được để trống");
                return false;
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Giá không được để trống");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                Thuoc t = new Thuoc();
                t.TenThuoc = txtTenThuoc.Text.Trim();
                t.QuyCach = listQuyCach.SelectedItem.ToString();
                t.CongDung = txtCongDung.Text.Trim();
                t.CachDung = txtCachDung.Text.Trim();
                t.NSX = dateNSX.Value;
                t.HSD = dateHSD.Value;
                t.Gia = Int64.Parse(txtGia.Text.Trim());
                db.Thuocs.InsertOnSubmit(t);
                db.SubmitChanges();
                MessageBox.Show("Thêm thành công");
                Thuoc();
                BoQua();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                var data = from q in db.Thuocs
                           where q.MaThuoc == Int32.Parse(lbMaThuoc.Text.Trim())
                           select q;
                Thuoc t = data.Single();
                t.TenThuoc = txtTenThuoc.Text.Trim();
                t.QuyCach = listQuyCach.SelectedItem.ToString();
                t.CongDung = txtCongDung.Text.Trim();
                t.CachDung = txtCachDung.Text.Trim();
                t.NSX = dateNSX.Value;
                t.HSD = dateHSD.Value;
                t.Gia = Int64.Parse(txtGia.Text.Trim());
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công");
                Thuoc();
                BoQua();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa thuốc này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var data = from q in db.Thuocs
                           where q.MaThuoc == Int32.Parse(lbMaThuoc.Text.Trim())
                           select q;
                Thuoc t = data.Single();
                db.Thuocs.DeleteOnSubmit(t);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công");
                Thuoc();
                BoQua();
            }
        }
        public void BoQua()
        {
            lbMaThuoc.Text = "";
            txtTenThuoc.Text = "";
            listQuyCach.SelectedItem = null;
            txtCongDung.Text = "";
            txtCachDung.Text = "";
            txtGia.Text = "";
        }
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            BoQua();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            if (tukhoa == "")
            {
                Thuoc();
            }
            else
            {
                var data = from q in db.Thuocs
                           where q.TenThuoc.Contains(tukhoa) || q.QuyCach.Contains(tukhoa) || q.CongDung.Contains(tukhoa) || q.CachDung.Contains(tukhoa) || q.NSX.ToString().Contains(tukhoa) || q.HSD.ToString().Contains(tukhoa) || q.Gia.ToString().Contains(tukhoa)
                           select q;
                dgvT.DataSource = data;
                if (dgvT.Rows.Count > 0)
                {
                    dgvT.CurrentRow.Selected = true;
                }
            }
        }

        private void lbMaThuoc_TextChanged(object sender, EventArgs e)
        {
            if (lbMaThuoc.Text != "")
            {
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnChonThuoc.Enabled = true;
            }
            else
            {
                btnThem.Enabled = true;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
                btnChonThuoc.Enabled = false;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnChonThuoc_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }
            else
            {
                ChiTietDonThuoc ctdt = new ChiTietDonThuoc();
                ctdt.MaDT = madt;
                ctdt.MaThuoc = Int32.Parse(lbMaThuoc.Text.Trim());
                ctdt.SL = Int32.Parse(txtSoLuong.Value.ToString());
                ctdt.ThanhTien = ctdt.SL * Int64.Parse(txtGia.Text.Trim());
                db.ChiTietDonThuocs.InsertOnSubmit(ctdt);
                db.SubmitChanges();
                var data = from q in db.DonThuocs
                           where q.MaDT == madt
                           select q;
                DonThuoc dt = data.Single();
                dt.TongTien += ctdt.ThanhTien;
                db.SubmitChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
