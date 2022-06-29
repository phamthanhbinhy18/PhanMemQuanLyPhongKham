namespace QuanLyPhongKhamDongY
{
    partial class fTaoDonThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChonThuoc = new System.Windows.Forms.Button();
            this.dgvCTDT = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonBN = new System.Windows.Forms.Button();
            this.lbBenhNhan = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDT)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnXuatHoaDon, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbTongTien, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 509);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 91);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.SetColumnSpan(this.btnXuatHoaDon, 2);
            this.btnXuatHoaDon.Location = new System.Drawing.Point(335, 33);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(222, 50);
            this.btnXuatHoaDon.TabIndex = 1;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(121, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(26, 30);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnChonThuoc, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCTDT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChonBN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbBenhNhan, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 509);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnChonThuoc
            // 
            this.btnChonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChonThuoc.Location = new System.Drawing.Point(3, 3);
            this.btnChonThuoc.Name = "btnChonThuoc";
            this.btnChonThuoc.Size = new System.Drawing.Size(222, 50);
            this.btnChonThuoc.TabIndex = 0;
            this.btnChonThuoc.Text = "Chọn thuốc";
            this.btnChonThuoc.UseVisualStyleBackColor = true;
            this.btnChonThuoc.Click += new System.EventHandler(this.btnChonThuoc_Click);
            // 
            // dgvCTDT
            // 
            this.dgvCTDT.AllowUserToAddRows = false;
            this.dgvCTDT.AllowUserToDeleteRows = false;
            this.dgvCTDT.AllowUserToResizeColumns = false;
            this.dgvCTDT.AllowUserToResizeRows = false;
            this.dgvCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.Gia,
            this.SL,
            this.ThanhTien});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvCTDT, 2);
            this.dgvCTDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDT.Location = new System.Drawing.Point(3, 59);
            this.dgvCTDT.MultiSelect = false;
            this.dgvCTDT.Name = "dgvCTDT";
            this.dgvCTDT.ReadOnly = true;
            this.dgvCTDT.RowHeadersVisible = false;
            this.dgvCTDT.RowTemplate.Height = 30;
            this.dgvCTDT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTDT.Size = new System.Drawing.Size(886, 391);
            this.dgvCTDT.TabIndex = 1;
            // 
            // MaThuoc
            // 
            this.MaThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Width = 84;
            // 
            // TenThuoc
            // 
            this.TenThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle3.Format = "C0";
            this.Gia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 84;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 78;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "C0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 161;
            // 
            // btnChonBN
            // 
            this.btnChonBN.Location = new System.Drawing.Point(3, 456);
            this.btnChonBN.Name = "btnChonBN";
            this.btnChonBN.Size = new System.Drawing.Size(222, 50);
            this.btnChonBN.TabIndex = 2;
            this.btnChonBN.Text = "Chọn bệnh nhân";
            this.btnChonBN.UseVisualStyleBackColor = true;
            this.btnChonBN.Click += new System.EventHandler(this.btnChonBN_Click);
            // 
            // lbBenhNhan
            // 
            this.lbBenhNhan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbBenhNhan.AutoSize = true;
            this.lbBenhNhan.Location = new System.Drawing.Point(231, 466);
            this.lbBenhNhan.Name = "lbBenhNhan";
            this.lbBenhNhan.Size = new System.Drawing.Size(0, 29);
            this.lbBenhNhan.TabIndex = 3;
            // 
            // fTaoDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(892, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fTaoDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đơn thuốc";
            this.Load += new System.EventHandler(this.fTaoDonThuoc_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnChonThuoc;
        private System.Windows.Forms.DataGridView dgvCTDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Button btnChonBN;
        private System.Windows.Forms.Label lbBenhNhan;

    }
}