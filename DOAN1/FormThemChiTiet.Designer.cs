namespace DOAN1
{
    partial class FormThemChiTiet
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
            label1 = new Label();
            txtmaHoaDon = new MaskedTextBox();
            ndsoLuong = new NumericUpDown();
            btnLuu = new Button();
            btnHuy = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtmaSanPham = new MaskedTextBox();
            txtdonGiaBan = new MaskedTextBox();
            txtthanhTien = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)ndsoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 127);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn ";
            // 
            // txtmaHoaDon
            // 
            txtmaHoaDon.Location = new Point(490, 116);
            txtmaHoaDon.Margin = new Padding(5);
            txtmaHoaDon.Name = "txtmaHoaDon";
            txtmaHoaDon.ReadOnly = true;
            txtmaHoaDon.Size = new Size(414, 39);
            txtmaHoaDon.TabIndex = 1;
            // 
            // ndsoLuong
            // 
            ndsoLuong.Location = new Point(488, 278);
            ndsoLuong.Margin = new Padding(5);
            ndsoLuong.Name = "ndsoLuong";
            ndsoLuong.Size = new Size(416, 39);
            ndsoLuong.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(490, 536);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 46);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(753, 536);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 46);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Huy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 204);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 357);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 7;
            label3.Text = "Don Gia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 280);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 6;
            label4.Text = "So luong";
            // 
            // txtmaSanPham
            // 
            txtmaSanPham.Location = new Point(488, 192);
            txtmaSanPham.Margin = new Padding(5);
            txtmaSanPham.Name = "txtmaSanPham";
            txtmaSanPham.Size = new Size(414, 39);
            txtmaSanPham.TabIndex = 8;
            // 
            // txtdonGiaBan
            // 
            txtdonGiaBan.Location = new Point(490, 357);
            txtdonGiaBan.Margin = new Padding(5);
            txtdonGiaBan.Name = "txtdonGiaBan";
            txtdonGiaBan.Size = new Size(414, 39);
            txtdonGiaBan.TabIndex = 9;
            // 
            // txtthanhTien
            // 
            txtthanhTien.Location = new Point(490, 442);
            txtthanhTien.Margin = new Padding(5);
            txtthanhTien.Name = "txtthanhTien";
            txtthanhTien.ReadOnly = true;
            txtthanhTien.Size = new Size(414, 39);
            txtthanhTien.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 442);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 32);
            label5.TabIndex = 10;
            label5.Text = "Thanh tien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 192);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 12;
            label6.Text = "Ma san pham ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(595, 46);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 32);
            label7.TabIndex = 13;
            label7.Text = "Chi tiet hoa don ";
            // 
            // FormThemChiTiet
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtthanhTien);
            Controls.Add(label5);
            Controls.Add(txtdonGiaBan);
            Controls.Add(txtmaSanPham);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(ndsoLuong);
            Controls.Add(txtmaHoaDon);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "FormThemChiTiet";
            Text = "FormThemChiTiet";
            Load += FormThemChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)ndsoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox txtmaHoaDon;
        private NumericUpDown ndsoLuong;
        private Button btnLuu;
        private Button btnHuy;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox txtmaSanPham;
        private MaskedTextBox txtdonGiaBan;
        private MaskedTextBox txtthanhTien;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}