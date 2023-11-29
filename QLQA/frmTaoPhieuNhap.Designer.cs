namespace QLQA
{
    partial class frmTaoPhieuNhap
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            nudSoLuong = new NumericUpDown();
            cbNguyenLieu = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            groupBox2 = new GroupBox();
            dvgNguyenLieu = new DataGridView();
            btnLuu = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgNguyenLieu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nudSoLuong);
            groupBox1.Controls.Add(cbNguyenLieu);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Location = new Point(10, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1071, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(421, 23);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 11;
            label1.Text = "Tạo phiếu nhập";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(490, 90);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(55, 27);
            nudSoLuong.TabIndex = 10;
            // 
            // cbNguyenLieu
            // 
            cbNguyenLieu.FormattingEnabled = true;
            cbNguyenLieu.Location = new Point(220, 90);
            cbNguyenLieu.Name = "cbNguyenLieu";
            cbNguyenLieu.Size = new Size(252, 28);
            cbNguyenLieu.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Location = new Point(569, 90);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Location = new Point(684, 90);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dvgNguyenLieu);
            groupBox2.Location = new Point(10, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1071, 412);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dvgNguyenLieu
            // 
            dvgNguyenLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgNguyenLieu.Location = new Point(13, 26);
            dvgNguyenLieu.Name = "dvgNguyenLieu";
            dvgNguyenLieu.RowHeadersWidth = 51;
            dvgNguyenLieu.RowTemplate.Height = 29;
            dvgNguyenLieu.Size = new Size(1052, 368);
            dvgNguyenLieu.TabIndex = 0;
            dvgNguyenLieu.CellClick += dvgNguyenLieu_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(945, 606);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(113, 41);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(800, 606);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(104, 41);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTaoPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 680);
            Controls.Add(btnThoat);
            Controls.Add(btnLuu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmTaoPhieuNhap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmPhieuNhap";
            Load += frmPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgNguyenLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudSoLuong;
        private ComboBox cbNguyenLieu;
        private Button btnThem;
        private Button btnXoa;
        private GroupBox groupBox2;
        private DataGridView dvgNguyenLieu;
        private Button btnLuu;
        private Button btnThoat;
        private Label label1;
    }
}