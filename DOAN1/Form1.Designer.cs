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
            label = new Label();
            txtmaHoaDon = new TextBox();
            btnChiTietHoaDon = new Button();
            txtmaNhanVien = new TextBox();
            txt = new Label();
            txttongThanhTien = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimengayLap = new DateTimePicker();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            toolStrip1 = new ToolStrip();
            tsThem = new ToolStripButton();
            tsSua = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsXoa = new ToolStripButton();
            tsChitiet = new ToolStripButton();
            tslammoi = new ToolStripButton();
            panelChiTiet = new Panel();
            dgvChiTietHoaDon = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            toolStrip1.SuspendLayout();
            panelChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label.Location = new Point(837, 75);
            label.Name = "label";
            label.Size = new Size(114, 25);
            label.TabIndex = 0;
            label.Text = "Mã hóa đơn";
            // 
            // txtmaHoaDon
            // 
            txtmaHoaDon.Location = new Point(1008, 73);
            txtmaHoaDon.Name = "txtmaHoaDon";
            txtmaHoaDon.Size = new Size(247, 27);
            txtmaHoaDon.TabIndex = 1;
            // 
            // btnChiTietHoaDon
            // 
            btnChiTietHoaDon.Location = new Point(1091, 300);
            btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            btnChiTietHoaDon.Size = new Size(94, 29);
            btnChiTietHoaDon.TabIndex = 2;
            btnChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            btnChiTietHoaDon.UseVisualStyleBackColor = true;
            btnChiTietHoaDon.Click += btnChiTietHoaDon_Click;
            // 
            // txtmaNhanVien
            // 
            txtmaNhanVien.Location = new Point(1008, 127);
            txtmaNhanVien.Name = "txtmaNhanVien";
            txtmaNhanVien.Size = new Size(247, 27);
            txtmaNhanVien.TabIndex = 4;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt.Location = new Point(837, 129);
            txt.Name = "txt";
            txt.Size = new Size(133, 25);
            txt.TabIndex = 3;
            txt.Text = "Mã nhân viên ";
            // 
            // txttongThanhTien
            // 
            txttongThanhTien.Location = new Point(1008, 233);
            txttongThanhTien.Name = "txttongThanhTien";
            txttongThanhTien.Size = new Size(247, 27);
            txttongThanhTien.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(837, 235);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 7;
            label3.Text = "Tổng thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(837, 181);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 5;
            label4.Text = "Ngày lập";
            // 
            // dateTimengayLap
            // 
            dateTimengayLap.Location = new Point(1008, 181);
            dateTimengayLap.Name = "dateTimengayLap";
            dateTimengayLap.Size = new Size(247, 27);
            dateTimengayLap.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(690, 27);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 10;
            label1.Text = "HÓA ĐƠN ";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(80, 75);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(609, 254);
            dgvHoaDon.TabIndex = 11;
            dgvHoaDon.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsThem, tsSua, toolStripSeparator1, tsXoa, tsChitiet, tslammoi });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1384, 27);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsThem
            // 
            tsThem.Image = Properties.Resources.icons8_add_48;
            tsThem.ImageTransparentColor = Color.Magenta;
            tsThem.Name = "tsThem";
            tsThem.Size = new Size(70, 24);
            tsThem.Text = "Thêm";
            // 
            // tsSua
            // 
            tsSua.Image = Properties.Resources.icons8_update_48;
            tsSua.ImageTransparentColor = Color.Magenta;
            tsSua.Name = "tsSua";
            tsSua.Size = new Size(58, 24);
            tsSua.Text = "Sửa";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // tsXoa
            // 
            tsXoa.Image = Properties.Resources.icons8_delete_48;
            tsXoa.ImageTransparentColor = Color.Magenta;
            tsXoa.Name = "tsXoa";
            tsXoa.Size = new Size(59, 24);
            tsXoa.Text = "Xóa";
            // 
            // tsChitiet
            // 
            tsChitiet.Image = Properties.Resources.icons8_detail_48;
            tsChitiet.ImageTransparentColor = Color.Magenta;
            tsChitiet.Name = "tsChitiet";
            tsChitiet.Size = new Size(112, 24);
            tsChitiet.Text = "Xem chi tiết";
            // 
            // tslammoi
            // 
            tslammoi.Image = Properties.Resources.icons8_refresh;
            tslammoi.ImageTransparentColor = Color.Magenta;
            tslammoi.Name = "tslammoi";
            tslammoi.Size = new Size(91, 24);
            tslammoi.Text = "Làm mới";
            // 
            // panelChiTiet
            // 
            panelChiTiet.Controls.Add(dgvChiTietHoaDon);
            panelChiTiet.Controls.Add(label2);
            panelChiTiet.Location = new Point(43, 416);
            panelChiTiet.Name = "panelChiTiet";
            panelChiTiet.Size = new Size(1224, 443);
            panelChiTiet.TabIndex = 13;
            panelChiTiet.Visible = false;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToResizeRows = false;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Location = new Point(37, 119);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.Size = new Size(609, 270);
            dgvChiTietHoaDon.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(608, 20);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 11;
            label2.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 877);
            Controls.Add(panelChiTiet);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(dateTimengayLap);
            Controls.Add(txttongThanhTien);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtmaNhanVien);
            Controls.Add(txt);
            Controls.Add(btnChiTietHoaDon);
            Controls.Add(txtmaHoaDon);
            Controls.Add(label);
            Controls.Add(dgvHoaDon);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelChiTiet.ResumeLayout(false);
            panelChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox txtmaHoaDon;
        private Button btnChiTietHoaDon;
        private TextBox txtmaNhanVien;
        private Label txt;
        private TextBox txttongThanhTien;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimengayLap;
        private Label label1;
        private DataGridView dgvHoaDon;
        private ToolStrip toolStrip1;
        private ToolStripButton tsThem;
        private ToolStripButton tsSua;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsXoa;
        private ToolStripButton tsChitiet;
        private ToolStripButton tslammoi;
        private Panel panelChiTiet;
        private Label label2;
        private DataGridView dgvChiTietHoaDon;
    }
}
