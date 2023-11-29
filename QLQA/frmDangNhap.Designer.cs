namespace QLQA
{
    partial class frmDangNhap
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnThoat = new Button();
            btnDangNhap = new Button();
            label2 = new Label();
            label1 = new Label();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Location = new Point(412, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 431);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(91, 55);
            label3.Name = "label3";
            label3.Size = new Size(181, 37);
            label3.TabIndex = 4;
            label3.Text = "ĐĂNG NHẬP";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(216, 249);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(91, 35);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(53, 248);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(98, 36);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 184);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 124);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(169, 181);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(172, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(169, 124);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(172, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Location = new Point(15, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 427);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTenDangNhap;
        private Label label2;
        private TextBox txtMatKhau;
        private Button btnThoat;
        private Button btnDangNhap;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private Label label3;
    }
}