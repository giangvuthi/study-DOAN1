namespace DOAN1
{
    partial class FormThongKe
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(113, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(464, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(158, 127);
            button2.Name = "button2";
            button2.Size = new Size(205, 42);
            button2.TabIndex = 3;
            button2.Text = "Thống kê";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(48, 68);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 6;
            label1.Text = "Từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(389, 68);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 7;
            label2.Text = "đến";
            // 
            // button1
            // 
            button1.Location = new Point(464, 127);
            button1.Name = "button1";
            button1.Size = new Size(205, 42);
            button1.TabIndex = 9;
            button1.Text = "Xuất PDF";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 205);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 10;
            label3.Text = "Tổng sản phẩm bán: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 205);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 11;
            label4.Text = "Tổng sản phẩm bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 250);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 13;
            label5.Text = "Tổng doanh thu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 250);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 12;
            label6.Text = "Tổng doanh thu: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 288);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 15;
            label7.Text = "Tổng tiền nhập ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 288);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 14;
            label8.Text = "Tổng tiền nhập: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 327);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 17;
            label9.Text = "Lợi nhuận";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 327);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 16;
            label10.Text = "Lợi nhuận ";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 575);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}