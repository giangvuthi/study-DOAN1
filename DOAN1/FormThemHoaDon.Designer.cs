namespace DOAN1
{
    partial class FormThemHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLuu = new Button();
            btnHuy = new Button();
            lblMaHoaDon = new Label();
            txtMaHoaDon = new TextBox();
            dateNgayLap = new DateTimePicker();
            lblMaNhanVien = new Label();
            txtMaNhanVien = new TextBox();
            lblNgayLap = new Label();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(530, 536);
            btnLuu.Margin = new Padding(5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 46);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(778, 536);
            btnHuy.Margin = new Padding(5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(153, 46);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblMaHoaDon.Location = new Point(252, 120);
            lblMaHoaDon.Margin = new Padding(5, 0, 5, 0);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(182, 40);
            lblMaHoaDon.TabIndex = 11;
            lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(530, 117);
            txtMaHoaDon.Margin = new Padding(5);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(399, 39);
            txtMaHoaDon.TabIndex = 12;
            // 
            // dateNgayLap
            // 
            dateNgayLap.Location = new Point(530, 290);
            dateNgayLap.Margin = new Padding(5);
            dateNgayLap.Name = "dateNgayLap";
            dateNgayLap.Size = new Size(399, 39);
            dateNgayLap.TabIndex = 19;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblMaNhanVien.Location = new Point(252, 206);
            lblMaNhanVien.Margin = new Padding(5, 0, 5, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(204, 40);
            lblMaNhanVien.TabIndex = 14;
            lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(530, 203);
            txtMaNhanVien.Margin = new Padding(5);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(399, 39);
            txtMaNhanVien.TabIndex = 15;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNgayLap.Location = new Point(252, 290);
            lblNgayLap.Margin = new Padding(5, 0, 5, 0);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(140, 40);
            lblNgayLap.TabIndex = 16;
            lblNgayLap.Text = "Ngày lập";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTongTien.Location = new Point(252, 376);
            lblTongTien.Margin = new Padding(5, 0, 5, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(236, 40);
            lblTongTien.TabIndex = 17;
            lblTongTien.Text = "Tổng thành tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(530, 373);
            txtTongTien.Margin = new Padding(5);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(399, 39);
            txtTongTien.TabIndex = 18;
            // 
            // FormThemHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(dateNgayLap);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(lblNgayLap);
            Controls.Add(txtMaNhanVien);
            Controls.Add(lblMaNhanVien);
            Controls.Add(txtMaHoaDon);
            Controls.Add(lblMaHoaDon);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Margin = new Padding(5);
            Name = "FormThemHoaDon";
            Text = "Thêm Hóa Đơn";
            Load += FormThemHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuu;
        private Button btnHuy;
        private Label lblMaHoaDon;
        private TextBox txtMaHoaDon;
        private DateTimePicker dateNgayLap;
        private Label lblMaNhanVien;
        private TextBox txtMaNhanVien;
        private Label lblNgayLap;
        private Label lblTongTien;
        private TextBox txtTongTien;
    }
}
