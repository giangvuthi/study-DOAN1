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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(326, 335);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(479, 335);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.AutoSize = true;
            lblMaHoaDon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblMaHoaDon.Location = new Point(155, 75);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(114, 25);
            lblMaHoaDon.TabIndex = 11;
            lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(326, 73);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(247, 27);
            txtMaHoaDon.TabIndex = 12;
            // 
            // dateNgayLap
            // 
            dateNgayLap.Location = new Point(326, 181);
            dateNgayLap.Name = "dateNgayLap";
            dateNgayLap.Size = new Size(247, 27);
            dateNgayLap.TabIndex = 19;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblMaNhanVien.Location = new Point(155, 129);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(128, 25);
            lblMaNhanVien.TabIndex = 14;
            lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(326, 127);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(247, 27);
            txtMaNhanVien.TabIndex = 15;
            // 
            // lblNgayLap
            // 
            lblNgayLap.AutoSize = true;
            lblNgayLap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNgayLap.Location = new Point(155, 181);
            lblNgayLap.Name = "lblNgayLap";
            lblNgayLap.Size = new Size(88, 25);
            lblNgayLap.TabIndex = 16;
            lblNgayLap.Text = "Ngày lập";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTongTien.Location = new Point(155, 235);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(149, 25);
            lblTongTien.TabIndex = 17;
            lblTongTien.Text = "Tổng thành tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(326, 233);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(247, 27);
            txtTongTien.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 22);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 20;
            label1.Text = "Hóa đơn ";
            // 
            // FormThemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
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
        private Label label1;
    }
}
