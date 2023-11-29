namespace QLQA
{
    partial class frmThongKe
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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnThongKe = new Button();
            nudNam = new NumericUpDown();
            nudThang = new NumericUpDown();
            groupBox2 = new GroupBox();
            label2 = new Label();
            dvgHoaDon = new DataGridView();
            txtDoanhThu = new TextBox();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThang).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgHoaDon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThongKe);
            groupBox1.Controls.Add(nudNam);
            groupBox1.Controls.Add(nudThang);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1188, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(500, 100);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 1;
            label4.Text = "Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 100);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "Tháng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(472, 23);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 3;
            label1.Text = "Thống kê";
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(818, 87);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(115, 47);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // nudNam
            // 
            nudNam.Location = new Point(578, 98);
            nudNam.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudNam.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudNam.Name = "nudNam";
            nudNam.Size = new Size(148, 27);
            nudNam.TabIndex = 1;
            nudNam.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // nudThang
            // 
            nudThang.Location = new Point(338, 98);
            nudThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudThang.Name = "nudThang";
            nudThang.Size = new Size(103, 27);
            nudThang.TabIndex = 0;
            nudThang.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dvgHoaDon);
            groupBox2.Controls.Add(txtDoanhThu);
            groupBox2.Location = new Point(12, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1188, 439);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 32);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Doanh thu";
            // 
            // dvgHoaDon
            // 
            dvgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgHoaDon.Location = new Point(13, 75);
            dvgHoaDon.Name = "dvgHoaDon";
            dvgHoaDon.RowHeadersWidth = 51;
            dvgHoaDon.RowTemplate.Height = 29;
            dvgHoaDon.Size = new Size(1164, 334);
            dvgHoaDon.TabIndex = 0;
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.Enabled = false;
            txtDoanhThu.Location = new Point(472, 29);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.Size = new Size(295, 27);
            txtDoanhThu.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(12, 671);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(1177, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 712);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKe";
            Load += frmThongKe_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNam).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThang).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnThongKe;
        private NumericUpDown nudThang;
        private Label label2;
        private DataGridView dvgHoaDon;
        private TextBox txtDoanhThu;
        private Label label4;
        private Label label3;
        private NumericUpDown nudNam;
        private Button btnThoat;
    }
}