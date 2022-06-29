using Microsoft.Reporting.WinForms;
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
    public partial class fXuatHoaDon : Form
    {
        QLPKDYDataClassesDataContext db = new QLPKDYDataClassesDataContext();
        public int madt;
        public fXuatHoaDon()
        {
            InitializeComponent();
        }

        private void fXuatHoaDon_Load(object sender, EventArgs e)
        {
            var data = from q in db.DonThuocs
                       join q1 in db.ChiTietDonThuocs on q.MaDT equals q1.MaDT
                       join q2 in db.BenhNhans on q.MaBN equals q2.MaBN
                       join q3 in db.Thuocs on q1.MaThuoc equals q3.MaThuoc
                       where q.MaDT == madt
                       group new { q, q1, q2, q3 } by new { q2.TenBN, q.MaDT, q3.TenThuoc, q.TongTien, q3.Gia, q.NgayLap } into g
                       select new { TenBN = g.Key.TenBN, SL = g.Sum(x => x.q1.SL), ThanhTien = g.Sum(x1 => x1.q1.ThanhTien), TenThuoc = g.Key.TenThuoc, MaDT = g.Key.MaDT, NgayLap = g.Key.NgayLap, TongTien = g.Key.TongTien, Gia = g.Key.Gia };
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 150;
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongKhamDongY.rpXuatHoaDon.rdlc";
            if (data.Count() > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "XuatHoaDon";
                rds.Value = data;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
        }
    }
}
