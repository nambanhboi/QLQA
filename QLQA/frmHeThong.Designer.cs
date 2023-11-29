namespace QLQA
{
    partial class frmHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeThong));
            btnQlba = new Button();
            btnQltt = new Button();
            label1 = new Label();
            btnThongKe = new Button();
            btnPn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnQlba
            // 
            btnQlba.Location = new Point(207, 410);
            btnQlba.Name = "btnQlba";
            btnQlba.Size = new Size(139, 50);
            btnQlba.TabIndex = 1;
            btnQlba.Text = "Quản lý bàn ăn";
            btnQlba.UseVisualStyleBackColor = true;
            btnQlba.Click += btnQlba_Click;
            // 
            // btnQltt
            // 
            btnQltt.Location = new Point(693, 242);
            btnQltt.Name = "btnQltt";
            btnQltt.Size = new Size(151, 50);
            btnQltt.TabIndex = 0;
            btnQltt.Text = "Quản lý thông tin";
            btnQltt.UseVisualStyleBackColor = true;
            btnQltt.Click += btnQltt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(693, 73);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 1;
            label1.Text = "Trang chủ";
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(693, 415);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(151, 46);
            btnThongKe.TabIndex = 2;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnPn
            // 
            btnPn.Location = new Point(1123, 415);
            btnPn.Name = "btnPn";
            btnPn.Size = new Size(139, 48);
            btnPn.TabIndex = 3;
            btnPn.Text = "Phiếu nhập";
            btnPn.UseVisualStyleBackColor = true;
            btnPn.Click += btnPn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1285, 12);
            button2.Name = "button2";
            button2.Size = new Size(151, 46);
            button2.TabIndex = 4;
            button2.Text = "Đăng xuất";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1467, 738);
            Controls.Add(button2);
            Controls.Add(btnThongKe);
            Controls.Add(label1);
            Controls.Add(btnPn);
            Controls.Add(btnQltt);
            Controls.Add(btnQlba);
            Name = "frmHeThong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHeThong";
            Load += frmHeThong_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQlba;
        private Button btnQltt;
        private Label label1;
        private Button btnThongKe;
        private Button btnPn;
        private Button button2;
    }
}