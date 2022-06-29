namespace QuanLyPhongKhamDongY
{
    partial class fDonThuoc
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDT = new System.Windows.Forms.DataGridView();
            this.btnXoaDonThuoc = new System.Windows.Forms.Button();
            this.btnTaoDonThuoc = new System.Windows.Forms.Button();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInDonThuoc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTimKiem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnXoaDonThuoc, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTaoDonThuoc, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnInDonThuoc, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTimKiem, 4);
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(123, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(862, 37);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvDT
            // 
            this.dgvDT.AllowUserToAddRows = false;
            this.dgvDT.AllowUserToDeleteRows = false;
            this.dgvDT.AllowUserToResizeColumns = false;
            this.dgvDT.AllowUserToResizeRows = false;
            this.dgvDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDT,
            this.TenBN,
            this.NgayLap,
            this.TongTien});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDT, 5);
            this.dgvDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDT.Location = new System.Drawing.Point(3, 46);
            this.dgvDT.MultiSelect = false;
            this.dgvDT.Name = "dgvDT";
            this.dgvDT.ReadOnly = true;
            this.dgvDT.RowHeadersVisible = false;
            this.dgvDT.RowTemplate.Height = 30;
            this.dgvDT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDT.Size = new System.Drawing.Size(982, 494);
            this.dgvDT.TabIndex = 2;
            this.dgvDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDT_CellClick);
            // 
            // btnXoaDonThuoc
            // 
            this.btnXoaDonThuoc.Location = new System.Drawing.Point(579, 546);
            this.btnXoaDonThuoc.Name = "btnXoaDonThuoc";
            this.btnXoaDonThuoc.Size = new System.Drawing.Size(200, 50);
            this.btnXoaDonThuoc.TabIndex = 3;
            this.btnXoaDonThuoc.Text = "Xóa đơn thuốc";
            this.btnXoaDonThuoc.UseVisualStyleBackColor = true;
            this.btnXoaDonThuoc.Click += new System.EventHandler(this.btnXoaDonThuoc_Click);
            // 
            // btnTaoDonThuoc
            // 
            this.btnTaoDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaoDonThuoc.Location = new System.Drawing.Point(785, 546);
            this.btnTaoDonThuoc.Name = "btnTaoDonThuoc";
            this.btnTaoDonThuoc.Size = new System.Drawing.Size(200, 50);
            this.btnTaoDonThuoc.TabIndex = 3;
            this.btnTaoDonThuoc.Text = "Tạo đơn thuốc";
            this.btnTaoDonThuoc.UseVisualStyleBackColor = true;
            this.btnTaoDonThuoc.Click += new System.EventHandler(this.btnTaoDonThuoc_Click);
            // 
            // MaDT
            // 
            this.MaDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.HeaderText = "Mã";
            this.MaDT.Name = "MaDT";
            this.MaDT.ReadOnly = true;
            this.MaDT.Width = 84;
            // 
            // TenBN
            // 
            this.TenBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenBN.DataPropertyName = "TenBN";
            this.TenBN.HeaderText = "Tên bệnh nhân";
            this.TenBN.Name = "TenBN";
            this.TenBN.ReadOnly = true;
            this.TenBN.Width = 206;
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle3.Format = "C0";
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 148;
            // 
            // btnInDonThuoc
            // 
            this.btnInDonThuoc.Location = new System.Drawing.Point(373, 546);
            this.btnInDonThuoc.Name = "btnInDonThuoc";
            this.btnInDonThuoc.Size = new System.Drawing.Size(200, 50);
            this.btnInDonThuoc.TabIndex = 3;
            this.btnInDonThuoc.Text = "In đơn thuốc";
            this.btnInDonThuoc.UseVisualStyleBackColor = true;
            this.btnInDonThuoc.Click += new System.EventHandler(this.btnInDonThuoc_Click);
            // 
            // fDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(988, 599);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn thuốc";
            this.Load += new System.EventHandler(this.fDonThuoc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDT;
        private System.Windows.Forms.Button btnXoaDonThuoc;
        private System.Windows.Forms.Button btnTaoDonThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnInDonThuoc;
    }
}