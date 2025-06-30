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
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)ndsoLuong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(177, 79);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn ";
            // 
            // txtmaHoaDon
            // 
            txtmaHoaDon.Location = new Point(302, 72);
            txtmaHoaDon.Name = "txtmaHoaDon";
            txtmaHoaDon.ReadOnly = true;
            txtmaHoaDon.Size = new Size(256, 27);
            txtmaHoaDon.TabIndex = 1;
            // 
            // ndsoLuong
            // 
            ndsoLuong.Location = new Point(300, 174);
            ndsoLuong.Name = "ndsoLuong";
            ndsoLuong.Size = new Size(256, 27);
            ndsoLuong.TabIndex = 2;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(302, 335);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(463, 335);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Huy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(177, 128);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(177, 223);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 7;
            label3.Text = "Don Gia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(177, 175);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 6;
            label4.Text = "So luong";
            // 
            // txtmaSanPham
            // 
            txtmaSanPham.Location = new Point(300, 120);
            txtmaSanPham.Name = "txtmaSanPham";
            txtmaSanPham.Size = new Size(256, 27);
            txtmaSanPham.TabIndex = 8;
            // 
            // txtdonGiaBan
            // 
            txtdonGiaBan.Location = new Point(302, 223);
            txtdonGiaBan.Name = "txtdonGiaBan";
            txtdonGiaBan.Size = new Size(256, 27);
            txtdonGiaBan.TabIndex = 9;
            // 
            // txtthanhTien
            // 
            txtthanhTien.Location = new Point(302, 276);
            txtthanhTien.Name = "txtthanhTien";
            txtthanhTien.ReadOnly = true;
            txtthanhTien.Size = new Size(256, 27);
            txtthanhTien.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(177, 276);
            label5.Name = "label5";
            label5.Size = new Size(95, 23);
            label5.TabIndex = 10;
            label5.Text = "Thanh tien";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(177, 120);
            label6.Name = "label6";
            label6.Size = new Size(122, 23);
            label6.TabIndex = 12;
            label6.Text = "Ma san pham ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(337, 19);
            label8.Name = "label8";
            label8.Size = new Size(230, 38);
            label8.TabIndex = 21;
            label8.Text = "Chi tiết hóa đơn";
            // 
            // FormThemChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
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
        private Label label8;
    }
}