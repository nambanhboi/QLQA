namespace QLQA
{
    partial class frmPhieuNhap
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
            btnHuy = new Button();
            btnLuu = new Button();
            cbNhanVienLap = new ComboBox();
            dgvDanhSachNguyenLieu = new DataGridView();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtNgayLap = new TextBox();
            txtTongTien = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguyenLieu).BeginInit();
            SuspendLayout();
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(287, 572);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(128, 39);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(530, 572);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 39);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // cbNhanVienLap
            // 
            cbNhanVienLap.FormattingEnabled = true;
            cbNhanVienLap.Location = new Point(247, 99);
            cbNhanVienLap.Name = "cbNhanVienLap";
            cbNhanVienLap.Size = new Size(220, 28);
            cbNhanVienLap.TabIndex = 0;
            // 
            // dgvDanhSachNguyenLieu
            // 
            dgvDanhSachNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNguyenLieu.Location = new Point(107, 160);
            dgvDanhSachNguyenLieu.Name = "dgvDanhSachNguyenLieu";
            dgvDanhSachNguyenLieu.RowHeadersWidth = 51;
            dgvDanhSachNguyenLieu.RowTemplate.Height = 29;
            dgvDanhSachNguyenLieu.Size = new Size(778, 295);
            dgvDanhSachNguyenLieu.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 106);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 17;
            label4.Text = "Ngày lập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(663, 485);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 15;
            label7.Text = "Tổng tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 106);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 14;
            label5.Text = "Nhân viên lập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(378, 29);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 12;
            label1.Text = "PHIẾU NHẬP";
            // 
            // txtNgayLap
            // 
            txtNgayLap.Enabled = false;
            txtNgayLap.Location = new Point(650, 99);
            txtNgayLap.Name = "txtNgayLap";
            txtNgayLap.Size = new Size(196, 27);
            txtNgayLap.TabIndex = 5;
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(760, 482);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(125, 27);
            txtTongTien.TabIndex = 11;
            // 
            // frmPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 659);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cbNhanVienLap);
            Controls.Add(dgvDanhSachNguyenLieu);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(txtNgayLap);
            Controls.Add(txtTongTien);
            Name = "frmPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhieuNhap";
            Load += frmPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNguyenLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHuy;
        private Button btnLuu;
        private ComboBox cbNhanVienLap;
        private DataGridView dgvDanhSachNguyenLieu;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label1;
        private TextBox txtNgayLap;
        private TextBox txtTongTien;
    }
}