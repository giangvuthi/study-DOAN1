namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    partial class FormLoiNhuan
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
            lblTongLoiNhuan = new Label();
            dgvNhapXuat = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).BeginInit();
            SuspendLayout();
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(838, 386);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(94, 40);
            btnQuayLai.TabIndex = 29;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(14, 386);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 28;
            label4.Text = "Tổng lợi nhuận: ";
            // 
            // lblTongLoiNhuan
            // 
            lblTongLoiNhuan.AutoSize = true;
            lblTongLoiNhuan.Location = new Point(180, 386);
            lblTongLoiNhuan.Name = "lblTongLoiNhuan";
            lblTongLoiNhuan.Size = new Size(122, 20);
            lblTongLoiNhuan.TabIndex = 27;
            lblTongLoiNhuan.Text = "lblTongLoiNhuan";
            // 
            // dgvNhapXuat
            // 
            dgvNhapXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhapXuat.Location = new Point(12, 120);
            dgvNhapXuat.Name = "dgvNhapXuat";
            dgvNhapXuat.RowHeadersWidth = 51;
            dgvNhapXuat.Size = new Size(920, 239);
            dgvNhapXuat.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 46);
            label1.Name = "label1";
            label1.Size = new Size(273, 31);
            label1.TabIndex = 24;
            label1.Text = "LỢI NHUẬN SẢN PHẨM";
            // 
            // FormLoiNhuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 514);
            Controls.Add(btnQuayLai);
            Controls.Add(label4);
            Controls.Add(lblTongLoiNhuan);
            Controls.Add(dgvNhapXuat);
            Controls.Add(label1);
            Name = "FormLoiNhuan";
            Text = "FormLoiNhuan";
            ((System.ComponentModel.ISupportInitialize)dgvNhapXuat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Label label4;
        private Label lblTongLoiNhuan;
        private DataGridView dgvNhapXuat;
        private Label label1;
    }
}