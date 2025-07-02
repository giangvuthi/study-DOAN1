namespace DOAN1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            tsThem = new ToolStripButton();
            tsSua = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsXoa = new ToolStripButton();
            tsChitiet = new ToolStripButton();
            tslammoi = new ToolStripButton();
            txtMahd = new TextBox();
            cbMakh = new ComboBox();
            dtpNgaylap = new DateTimePicker();
            txtManv = new TextBox();
            lblTongThanhTien = new Label();
            grbThongtinchung = new GroupBox();
            groupBox1 = new GroupBox();
            btnThemsp = new Button();
            nudSoluong = new NumericUpDown();
            txtTonkho = new TextBox();
            txtDongiaban = new TextBox();
            this.txtTensp = new TextBox();
            cbSanpham = new ComboBox();
            dgvChitiethoadon = new DataGridView();
            btnTaohoadon = new Button();
            toolStrip1.SuspendLayout();
            grbThongtinchung.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChitiethoadon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(831, 89);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 40);
            label1.TabIndex = 10;
            label1.Text = "THÔNG TIN HOA DON ";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsThem, tsSua, toolStripSeparator1, tsXoa, tsChitiet, tslammoi });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(2040, 42);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsThem
            // 
            tsThem.Image = Properties.Resources.icons8_add_48;
            tsThem.ImageTransparentColor = Color.Magenta;
            tsThem.Name = "tsThem";
            tsThem.Size = new Size(99, 36);
            tsThem.Text = "Thêm";
            tsThem.Click += tsThem_Click;
            // 
            // tsSua
            // 
            tsSua.Image = Properties.Resources.icons8_update_48;
            tsSua.ImageTransparentColor = Color.Magenta;
            tsSua.Name = "tsSua";
            tsSua.Size = new Size(77, 36);
            tsSua.Text = "Sửa";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 42);
            // 
            // tsXoa
            // 
            tsXoa.Image = Properties.Resources.icons8_delete_48;
            tsXoa.ImageTransparentColor = Color.Magenta;
            tsXoa.Name = "tsXoa";
            tsXoa.Size = new Size(78, 36);
            tsXoa.Text = "Xóa";
            // 
            // tsChitiet
            // 
            tsChitiet.Image = Properties.Resources.icons8_detail_48;
            tsChitiet.ImageTransparentColor = Color.Magenta;
            tsChitiet.Name = "tsChitiet";
            tsChitiet.Size = new Size(166, 36);
            tsChitiet.Text = "Xem chi tiết";
            tsChitiet.Click += tsChitiet_Click;
            // 
            // tslammoi
            // 
            tslammoi.Image = Properties.Resources.icons8_refresh;
            tslammoi.ImageTransparentColor = Color.Magenta;
            tslammoi.Name = "tslammoi";
            tslammoi.Size = new Size(130, 36);
            tslammoi.Text = "Làm mới";
            // 
            // txtMahd
            // 
            txtMahd.Location = new Point(24, 56);
            txtMahd.Name = "txtMahd";
            txtMahd.PlaceholderText = "Ma hoa don ";
            txtMahd.ReadOnly = true;
            txtMahd.Size = new Size(170, 39);
            txtMahd.TabIndex = 13;
            txtMahd.TextChanged += textBox1_TextChanged;
            // 
            // cbMakh
            // 
            cbMakh.FormattingEnabled = true;
            cbMakh.Location = new Point(532, 56);
            cbMakh.Name = "cbMakh";
            cbMakh.Size = new Size(170, 40);
            cbMakh.TabIndex = 14;
            // 
            // dtpNgaylap
            // 
            dtpNgaylap.Location = new Point(800, 57);
            dtpNgaylap.Name = "dtpNgaylap";
            dtpNgaylap.Size = new Size(370, 39);
            dtpNgaylap.TabIndex = 15;
            // 
            // txtManv
            // 
            txtManv.Location = new Point(286, 56);
            txtManv.Name = "txtManv";
            txtManv.PlaceholderText = "Ma nhan vien";
            txtManv.Size = new Size(170, 39);
            txtManv.TabIndex = 16;
            // 
            // lblTongThanhTien
            // 
            lblTongThanhTien.Location = new Point(1264, 56);
            lblTongThanhTien.Name = "lblTongThanhTien";
            lblTongThanhTien.Size = new Size(378, 40);
            lblTongThanhTien.TabIndex = 17;
            lblTongThanhTien.Text = "l";
            // 
            // grbThongtinchung
            // 
            grbThongtinchung.Controls.Add(dtpNgaylap);
            grbThongtinchung.Controls.Add(lblTongThanhTien);
            grbThongtinchung.Controls.Add(txtMahd);
            grbThongtinchung.Controls.Add(txtManv);
            grbThongtinchung.Controls.Add(cbMakh);
            grbThongtinchung.Location = new Point(115, 146);
            grbThongtinchung.Name = "grbThongtinchung";
            grbThongtinchung.Size = new Size(1720, 122);
            grbThongtinchung.TabIndex = 18;
            grbThongtinchung.TabStop = false;
            grbThongtinchung.Text = "groupBox1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThemsp);
            groupBox1.Controls.Add(nudSoluong);
            groupBox1.Controls.Add(txtTonkho);
            groupBox1.Controls.Add(txtDongiaban);
            groupBox1.Controls.Add(this.txtTensp);
            groupBox1.Controls.Add(cbSanpham);
            groupBox1.Location = new Point(115, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1720, 122);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnThemsp
            // 
            btnThemsp.Location = new Point(1281, 38);
            btnThemsp.Name = "btnThemsp";
            btnThemsp.Size = new Size(150, 46);
            btnThemsp.TabIndex = 21;
            btnThemsp.Text = "Them san pham";
            btnThemsp.UseVisualStyleBackColor = true;
            // 
            // nudSoluong
            // 
            nudSoluong.Location = new Point(1037, 53);
            nudSoluong.Name = "nudSoluong";
            nudSoluong.Size = new Size(133, 39);
            nudSoluong.TabIndex = 20;
            // 
            // txtTonkho
            // 
            txtTonkho.Location = new Point(800, 53);
            txtTonkho.Name = "txtTonkho";
            txtTonkho.PlaceholderText = "So luong con trong kho ";
            txtTonkho.ReadOnly = true;
            txtTonkho.Size = new Size(170, 39);
            txtTonkho.TabIndex = 19;
            // 
            // txtDongiaban
            // 
            txtDongiaban.Location = new Point(532, 53);
            txtDongiaban.Name = "txtDongiaban";
            txtDongiaban.PlaceholderText = "Don gia";
            txtDongiaban.ReadOnly = true;
            txtDongiaban.Size = new Size(170, 39);
            txtDongiaban.TabIndex = 18;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new Point(286, 56);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.PlaceholderText = "Ten san pham";
            this.txtTensp.ReadOnly = true;
            this.txtTensp.Size = new Size(170, 39);
            this.txtTensp.TabIndex = 16;
            // 
            // cbSanpham
            // 
            cbSanpham.FormattingEnabled = true;
            cbSanpham.Location = new Point(24, 59);
            cbSanpham.Name = "cbSanpham";
            cbSanpham.Size = new Size(178, 40);
            cbSanpham.TabIndex = 14;
            // 
            // dgvChitiethoadon
            // 
            dgvChitiethoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChitiethoadon.Location = new Point(115, 439);
            dgvChitiethoadon.Name = "dgvChitiethoadon";
            dgvChitiethoadon.RowHeadersWidth = 82;
            dgvChitiethoadon.Size = new Size(1730, 152);
            dgvChitiethoadon.TabIndex = 22;
            // 
            // btnTaohoadon
            // 
            btnTaohoadon.Location = new Point(667, 698);
            btnTaohoadon.Name = "btnTaohoadon";
            btnTaohoadon.Size = new Size(150, 46);
            btnTaohoadon.TabIndex = 22;
            btnTaohoadon.Text = "Tao hoa don";
            btnTaohoadon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2040, 1025);
            Controls.Add(btnTaohoadon);
            Controls.Add(dgvChitiethoadon);
            Controls.Add(groupBox1);
            Controls.Add(grbThongtinchung);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "--";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            grbThongtinchung.ResumeLayout(false);
            grbThongtinchung.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChitiethoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsThem;
        private ToolStripButton tsSua;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsXoa;
        private ToolStripButton tsChitiet;
        private ToolStripButton tslammoi;
        private TextBox txtMahd;
        private ComboBox cbMakh;
        private DateTimePicker dtpNgaylap;
        private TextBox txtManv;
        private Label lblTongThanhTien;
        private GroupBox grbThongtinchung;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox cbSanpham;
        private Button btnThemsp;
        private NumericUpDown nudSoluong;
        private TextBox txtTonkho;
        private TextBox txtDongiaban;
        private DataGridView dgvChitiethoadon;
        private Button btnTaohoadon;
    }
}
