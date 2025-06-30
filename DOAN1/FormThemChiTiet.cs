using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN1
{
    public partial class FormThemChiTiet : Form
    {
        private string maHoaDon;
        private string connectionString = "server=localhost;user id=root;password=;database=qlbanhang;charset=utf8";
        public FormThemChiTiet(string maHD)
        {
            InitializeComponent();
            this.maHoaDon = maHD;
            txtmaHoaDon.Text = maHD;
            txtmaHoaDon.ReadOnly = true;

            // Gắn sự kiện tự tính thành tiền
            ndsoLuong.ValueChanged += TinhThanhTien;
            txtdonGiaBan.TextChanged += TinhThanhTien;
            txtthanhTien.ReadOnly = true;
        }

        private void TinhThanhTien(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdonGiaBan.Text, out decimal donGia))
            {
                int soLuong = (int)ndsoLuong.Value;
                decimal thanhTien = donGia * soLuong;
                txtthanhTien.Text = thanhTien.ToString("0.##");
            }
            else
            {
                txtthanhTien.Text = "";
            }
        }
        private void FormThemChiTiet_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSP = txtmaSanPham.Text.Trim();
            decimal donGia;
            int soLuong = (int)ndsoLuong.Value;

            if (maSP == "" || !decimal.TryParse(txtdonGiaBan.Text.Trim(), out donGia))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm và đơn giá hợp lệ.");
                return;
            }

            decimal thanhTien = soLuong * donGia;
            txtthanhTien.Text = thanhTien.ToString("0.##");

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO tt_chitiet_hoadon 
                             (maHoaDon, maSanPham, soLuong, donGiaBan, thanhTien) 
                             VALUES (@maHD, @maSP, @sl, @gia, @tt)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHoaDon);
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.Parameters.AddWithValue("@sl", soLuong);
                    cmd.Parameters.AddWithValue("@gia", donGia);
                    cmd.Parameters.AddWithValue("@tt", thanhTien);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm chi tiết hóa đơn thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
