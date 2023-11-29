namespace QLQA
{
    partial class frmQuanLyBanAn
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
            groupBox2 = new GroupBox();
            dgvDanhSachMon = new DataGridView();
            nudSoLuongMon = new NumericUpDown();
            btnXoaMon = new Button();
            btnThemMon = new Button();
            cbMon = new ComboBox();
            groupBox3 = new GroupBox();
            nudSale = new NumericUpDown();
            label14 = new Label();
            txtTamTinh = new TextBox();
            txtTongTien = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            cbBan = new ComboBox();
            btnThanhToan = new Button();
            btnChuyenBan = new Button();
            groupBox4 = new GroupBox();
            flpBan = new FlowLayoutPanel();
            btnDong = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachMon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongMon).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSale).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachMon);
            groupBox2.Controls.Add(nudSoLuongMon);
            groupBox2.Controls.Add(btnXoaMon);
            groupBox2.Controls.Add(btnThemMon);
            groupBox2.Controls.Add(cbMon);
            groupBox2.Location = new Point(486, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 597);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgvDanhSachMon
            // 
            dgvDanhSachMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachMon.Location = new Point(9, 87);
            dgvDanhSachMon.Name = "dgvDanhSachMon";
            dgvDanhSachMon.RowHeadersWidth = 51;
            dgvDanhSachMon.RowTemplate.Height = 29;
            dgvDanhSachMon.Size = new Size(572, 483);
            dgvDanhSachMon.TabIndex = 3;
            dgvDanhSachMon.CellClick += dvgDanhSachMon_CellClick;
            // 
            // nudSoLuongMon
            // 
            nudSoLuongMon.Location = new Point(295, 32);
            nudSoLuongMon.Name = "nudSoLuongMon";
            nudSoLuongMon.Size = new Size(55, 27);
            nudSoLuongMon.TabIndex = 1;
            // 
            // btnXoaMon
            // 
            btnXoaMon.FlatStyle = FlatStyle.Popup;
            btnXoaMon.Location = new Point(489, 32);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(92, 29);
            btnXoaMon.TabIndex = 3;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.UseVisualStyleBackColor = true;
            btnXoaMon.Click += btnXoaMon_Click;
            // 
            // btnThemMon
            // 
            btnThemMon.FlatStyle = FlatStyle.Popup;
            btnThemMon.Location = new Point(374, 32);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(101, 29);
            btnThemMon.TabIndex = 2;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = true;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // cbMon
            // 
            cbMon.FormattingEnabled = true;
            cbMon.Location = new Point(25, 32);
            cbMon.Name = "cbMon";
            cbMon.Size = new Size(252, 28);
            cbMon.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nudSale);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtTamTinh);
            groupBox3.Controls.Add(txtTongTien);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cbBan);
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(btnChuyenBan);
            groupBox3.Location = new Point(1095, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(185, 597);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // nudSale
            // 
            nudSale.Location = new Point(20, 331);
            nudSale.Name = "nudSale";
            nudSale.Size = new Size(125, 27);
            nudSale.TabIndex = 7;
            nudSale.ValueChanged += nudSale_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 248);
            label14.Name = "label14";
            label14.Size = new Size(67, 20);
            label14.TabIndex = 9;
            label14.Text = "Tạm tính";
            // 
            // txtTamTinh
            // 
            txtTamTinh.Location = new Point(20, 271);
            txtTamTinh.Name = "txtTamTinh";
            txtTamTinh.Size = new Size(125, 27);
            txtTamTinh.TabIndex = 6;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(20, 416);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 379);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 6;
            label13.Text = "Tổng tiền";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 308);
            label12.Name = "label12";
            label12.Size = new Size(91, 20);
            label12.TabIndex = 6;
            label12.Text = "Giảm giá(%)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 207);
            label11.Name = "label11";
            label11.Size = new Size(83, 20);
            label11.TabIndex = 6;
            label11.Text = "Thanh toán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 36);
            label10.Name = "label10";
            label10.Size = new Size(86, 20);
            label10.TabIndex = 6;
            label10.Text = "Chuyển bàn";
            // 
            // cbBan
            // 
            cbBan.FormattingEnabled = true;
            cbBan.Location = new Point(20, 90);
            cbBan.Name = "cbBan";
            cbBan.Size = new Size(125, 28);
            cbBan.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(20, 506);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(125, 64);
            btnThanhToan.TabIndex = 9;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.Location = new Point(20, 128);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.Size = new Size(125, 64);
            btnChuyenBan.TabIndex = 5;
            btnChuyenBan.Text = "Chuyển bàn";
            btnChuyenBan.UseVisualStyleBackColor = true;
            btnChuyenBan.Click += btnChuyenBan_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flpBan);
            groupBox4.Location = new Point(8, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(472, 597);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // flpBan
            // 
            flpBan.Location = new Point(8, 30);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(445, 540);
            flpBan.TabIndex = 0;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(12, 629);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(1268, 34);
            btnDong.TabIndex = 10;
            btnDong.Text = "Thoát";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // frmQuanLyBanAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 675);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnDong);
            Controls.Add(groupBox2);
            Name = "frmQuanLyBanAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyBanAn";
            Load += frmQuanLyBanAn_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachMon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongMon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSale).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button ban1;
        private GroupBox groupBox3;
        private Label label1;
        private Label label9;
        private Label label6;
        private Label label3;
        private Label label8;
        private Label label5;
        private Label label2;
        private Label label7;
        private Label label4;
        private Button ban9;
        private Button ban6;
        private Button ban3;
        private Button ban8;
        private Button ban7;
        private Button ban5;
        private Button ban4;
        private Button ban2;
        private DataGridView dgvDanhSachMon;
        private Button btnThemMon;
        private ComboBox cbMon;
        private Label label11;
        private Label label10;
        private ComboBox cbBan;
        private Button btnChuyenBan;
        private TextBox txtTongTien;
        private Label label13;
        private Label label12;
        private Button btnThanhToan;
        private TextBox txtTamTinh;
        private Label label14;
        private GroupBox groupBox4;
        private FlowLayoutPanel flpBan;
        private NumericUpDown nudSoLuongMon;
        private NumericUpDown nudSale;
        private Button btnXoaMon;
        private Button btnDong;
    }
}