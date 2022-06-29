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
    public partial class fBenhNhan : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public int madt=0;
        public fBenhNhan()
        {
            InitializeComponent();
        }

        private void fBenhNhan_Load(object sender, EventArgs e)
        {
            BenhNhan();
            if (madt != 0)
            {
                btnChonBN.Visible = true;
            }
        }
        public void BenhNhan()
        {
            var data = from q in db.BenhNhans
                       select q;
            dgvBN.DataSource = data;
            if (dgvBN.Rows.Count > 0)
            {
                dgvBN.CurrentRow.Selected = true;
            }
        }
        public bool KiemTra()
        {
            if (txtTenBN.Text == "")
            {
                MessageBox.Show("Tên bệnh nhân không được để trống");
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại bệnh nhân không được để trống");
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ bệnh nhân không được để trống");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                
                    BenhNhan bn = new BenhNhan();
                    bn.TenBN = txtTenBN.Text.Trim();
                    bn.SDT = txtSDT.Text.Trim();
                    bn.DiaChi = txtDiaChi.Text.Trim();
                    db.BenhNhans.InsertOnSubmit(bn);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    BenhNhan();
                    BoQua();
                
                
            }
        }
        public bool KiemTraBN(int mabn)
        {
            var data = from q in db.BenhNhans
                       where q.MaBN == mabn
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try{
                if (KiemTraBN(Int32.Parse(lbMaBN.Text.Trim())))
                {
                    var data = from q in db.BenhNhans
                               where q.MaBN == Int32.Parse(lbMaBN.Text.Trim())
                               select q;
                    BenhNhan bn = data.Single();
                    bn.TenBN = txtTenBN.Text.Trim();
                    bn.SDT = txtSDT.Text.Trim();
                    bn.DiaChi = txtDiaChi.Text.Trim();
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công");
                    BenhNhan();
                    BoQua();
                }
                }
            catch
            {
                MessageBox.Show("Không tìm thấy mã bệnh nhân");
            }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraBN(Int32.Parse(lbMaBN.Text.Trim())))
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa thông tin bệnh nhân này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var data = from q in db.BenhNhans
                                   where q.MaBN == Int32.Parse(lbMaBN.Text.Trim())
                                   select q;
                        BenhNhan bn = data.Single();
                        db.BenhNhans.DeleteOnSubmit(bn);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                        BenhNhan();
                        BoQua();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy mã bệnh nhân");
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            BoQua();
        }
        public void BoQua()
        {
            lbMaBN.Text = "";
            txtTenBN.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void dgvBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBN.Rows.Count > 0)
            {
                dgvBN.CurrentRow.Selected = true;
                lbMaBN.Text = dgvBN.CurrentRow.Cells["MaBN"].Value.ToString();
                txtTenBN.Text = dgvBN.CurrentRow.Cells["TenBN"].Value.ToString();
                txtSDT.Text = dgvBN.CurrentRow.Cells["SDT"].Value.ToString().Trim();
                txtDiaChi.Text = dgvBN.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            if (tukhoa == "")
            {
                BenhNhan();
            }
            else
            {
                var data = from q in db.BenhNhans
                           where q.TenBN.Contains(tukhoa) || q.SDT.Contains(tukhoa) || q.DiaChi.Contains(tukhoa)
                           select q;
                dgvBN.DataSource = data;
                if (dgvBN.Rows.Count > 0)
                {
                    dgvBN.CurrentRow.Selected = true;
                }
            }
        }

        private void txtTenBN_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbMaBN_TextChanged(object sender, EventArgs e)
        {
            if (lbMaBN.Text != "")
            {
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
                btnChonBN.Enabled = true;
            }
            else
            {
                btnThem.Enabled = true;
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
                btnChonBN.Enabled = false;
            }
        }

        private void btnChonBN_Click(object sender, EventArgs e)
        {
            var data = from q in db.DonThuocs
                       where q.MaDT == madt
                       select q;
            DonThuoc dt = data.Single();
            dt.MaBN = Int32.Parse(lbMaBN.Text.Trim());
            db.SubmitChanges();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
