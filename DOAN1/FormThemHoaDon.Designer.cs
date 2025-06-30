namespace DOAN1
{
    partial class FormThemHoaDon
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
            this.btnLuu = new Button();
            btnHuy = new Button();
            label = new Label();
            txtmaHoaDon = new TextBox();
            dateTimengayLap = new DateTimePicker();
            txt = new Label();
            txtmaNhanVien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txttongThanhTien = new TextBox();
            SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new Point(326, 335);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new Size(94, 29);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(479, 335);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label.Location = new Point(155, 75);
            label.Name = "label";
            label.Size = new Size(114, 25);
            label.TabIndex = 11;
            label.Text = "Mã hóa đơn";
            // 
            // txtmaHoaDon
            // 
            txtmaHoaDon.Location = new Point(326, 73);
            txtmaHoaDon.Name = "txtmaHoaDon";
            txtmaHoaDon.Size = new Size(247, 27);
            txtmaHoaDon.TabIndex = 12;
            // 
            // dateTimengayLap
            // 
            dateTimengayLap.Location = new Point(326, 181);
            dateTimengayLap.Name = "dateTimengayLap";
            dateTimengayLap.Size = new Size(247, 27);
            dateTimengayLap.TabIndex = 19;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            txt.Location = new Point(155, 129);
            txt.Name = "txt";
            txt.Size = new Size(133, 25);
            txt.TabIndex = 14;
            txt.Text = "Mã nhân viên ";
            // 
            // txtmaNhanVien
            // 
            txtmaNhanVien.Location = new Point(326, 127);
            txtmaNhanVien.Name = "txtmaNhanVien";
            txtmaNhanVien.Size = new Size(247, 27);
            txtmaNhanVien.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(155, 181);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 16;
            label4.Text = "Ngày lập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(155, 235);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 17;
            label3.Text = "Tổng thành tiền";
            // 
            // txttongThanhTien
            // 
            txttongThanhTien.Location = new Point(326, 233);
            txttongThanhTien.Name = "txttongThanhTien";
            txttongThanhTien.Size = new Size(247, 27);
            txttongThanhTien.TabIndex = 18;
            // 
            // FormThemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimengayLap);
            Controls.Add(txttongThanhTien);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtmaNhanVien);
            Controls.Add(txt);
            Controls.Add(txtmaHoaDon);
            Controls.Add(label);
            Controls.Add(btnHuy);
            Controls.Add(this.btnLuu);
            Name = "FormThemHoaDon";
            Text = "FormThemHoaDon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button1;
        private Button btnHuy;
        private Label label;
        private TextBox txtmaHoaDon;
        private DateTimePicker dateTimengayLap;
        private Label txt;
        private TextBox txtmaNhanVien;
        private Label label4;
        private Label label3;
        private TextBox txttongThanhTien;
    }
}