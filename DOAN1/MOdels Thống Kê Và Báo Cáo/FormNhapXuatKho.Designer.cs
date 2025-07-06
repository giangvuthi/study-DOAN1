namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormNhapXuatKho
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
            btnQuayLai = new Button();
            label4 = new Label();
            lblTongSoLuong = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLocDuLieu = new Button();
            dgvNhapXuat = new DataGridView();
            label1 = new Label();
            cbLoaiNX = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).BeginInit();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(527, 145);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 40);
            btnQuayLai.TabIndex = 22;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(48, 482);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 21;
            label4.Text = "Tổng số lượng: ";
            // 
            // lblTongSoLuong
            // 
            lblTongSoLuong.AutoSize = true;
            lblTongSoLuong.Location = new Point(214, 482);
            lblTongSoLuong.Name = "lblTongSoLuong";
            lblTongSoLuong.Size = new Size(117, 20);
            lblTongSoLuong.TabIndex = 19;
            lblTongSoLuong.Text = "lblTongSoLuong";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(-60, 121);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 18;
            label3.Text = "Đến";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(-60, 67);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 16;
            label2.Text = "Từ";
            // 
            // btnLocDuLieu
            // 
            btnLocDuLieu.Location = new Point(402, 145);
            btnLocDuLieu.Name = "btnLocDuLieu";
            btnLocDuLieu.Size = new Size(94, 40);
            btnLocDuLieu.TabIndex = 15;
            btnLocDuLieu.Text = "Lọc dữ liệu";
            btnLocDuLieu.UseVisualStyleBackColor = true;
            // 
            // dgvNhapXuat
            // 
            dgvNhapXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapXuat.Location = new Point(46, 216);
            dgvNhapXuat.Name = "dgvNhapXuat";
            dgvNhapXuat.RowHeadersWidth = 51;
            dgvNhapXuat.Size = new Size(920, 239);
            dgvNhapXuat.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 33);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 13;
            label1.Text = "NHẬP / XUẤT KHO";
            // 
            // cbLoaiNX
            // 
            cbLoaiNX.FormattingEnabled = true;
            cbLoaiNX.Location = new Point(440, 97);
            cbLoaiNX.Name = "cbLoaiNX";
            cbLoaiNX.Size = new Size(151, 28);
            cbLoaiNX.TabIndex = 23;
            cbLoaiNX.Text = "Loại";
            // 
            // FormNhapXuatKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 603);
            Controls.Add(cbLoaiNX);
            Controls.Add(btnQuayLai);
            Controls.Add(label4);
            Controls.Add(lblTongSoLuong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLocDuLieu);
            Controls.Add(dgvNhapXuat);
            Controls.Add(label1);
            Name = "FormNhapXuatKho";
            Text = "FormNhapXuatKho";
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Label label4;
        private Label lblTongSoLuong;
        private Label label3;
        private Label label2;
        private Button btnLocDuLieu;
        private DataGridView dgvNhapXuat;
        private Label label1;
        private ComboBox cbLoaiNX;
    }
}