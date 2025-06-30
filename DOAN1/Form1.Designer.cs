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
            btnChiTietHoaDon = new Button();
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
            // btnChiTietHoaDon
            // 
            btnChiTietHoaDon.Location = new Point(1232, 478);
            btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            btnChiTietHoaDon.Size = new Size(94, 29);
            btnChiTietHoaDon.TabIndex = 2;
            btnChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            btnChiTietHoaDon.UseVisualStyleBackColor = true;
            btnChiTietHoaDon.Click += btnChiTietHoaDon_Click;
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
            dgvHoaDon.Location = new Point(0, 67);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(1384, 400);
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
            tsThem.Click += tsThem_Click;
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
            tsChitiet.Click += tsChitiet_Click;
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
            panelChiTiet.Location = new Point(0, 513);
            panelChiTiet.Name = "panelChiTiet";
            panelChiTiet.Size = new Size(1372, 364);
            panelChiTiet.TabIndex = 13;
            panelChiTiet.Visible = false;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.AllowUserToResizeRows = false;
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Location = new Point(0, 68);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.Size = new Size(1384, 300);
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
            Controls.Add(btnChiTietHoaDon);
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
        private Button btnChiTietHoaDon;
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
