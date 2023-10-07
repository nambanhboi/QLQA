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
            btnQlba = new Button();
            btnQltt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnQlba
            // 
            btnQlba.Location = new Point(288, 255);
            btnQlba.Name = "btnQlba";
            btnQlba.Size = new Size(139, 50);
            btnQlba.TabIndex = 0;
            btnQlba.Text = "Quản lý bàn ăn";
            btnQlba.UseVisualStyleBackColor = true;
            btnQlba.Click += btnQlba_Click;
            // 
            // btnQltt
            // 
            btnQltt.Location = new Point(288, 174);
            btnQltt.Name = "btnQltt";
            btnQltt.Size = new Size(139, 50);
            btnQltt.TabIndex = 0;
            btnQltt.Text = "Quản lý thông tin";
            btnQltt.UseVisualStyleBackColor = true;
            btnQltt.Click += btnQltt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 95);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // frmHeThong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnQltt);
            Controls.Add(btnQlba);
            Name = "frmHeThong";
            Text = "frmHeThong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQlba;
        private Button btnQltt;
        private Label label1;
    }
}