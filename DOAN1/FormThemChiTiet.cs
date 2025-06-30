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
       
        private string connectionString = "server=localhost;user id=root;password=;database=qlbanhang;charset=utf8";
        private string maHoaDon, maSanPham;

        public FormThemChiTiet(string maHD)  // Thêm mới
        {
            InitializeComponent();
            maHoaDon = maHD;
            txtmaHoaDon.Text = maHD;
            txtmaHoaDon.ReadOnly = true;
        }

        public FormThemChiTiet(string maHD, string maSP)  // Sửa
        {
            InitializeComponent();
            maHoaDon = maHD;
            maSanPham = maSP;

            txtmaHoaDon.Text = maHD;
            txtmaSanPham.Text = maSP;
            txtmaHoaDon.ReadOnly = true;
            txtmaSanPham.ReadOnly = true;

            LoadChiTietCu(maHD, maSP); // bạn cần viết hàm này
        }


        private void LoadChiTietCu(string maHD, string maSP)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT soLuong, donGiaBan, thanhTien 
                             FROM tt_chitiet_hoadon 
                             WHERE maHoaDon = @maHD AND maSanPham = @maSP";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@maSP", maSP);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ndsoLuong.Value = Convert.ToInt32(reader["soLuong"]);
                            txtdonGiaBan.Text = reader["donGiaBan"].ToString();
                            txtthanhTien.Text = reader["thanhTien"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết hóa đơn: " + ex.Message);
            }
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

                    string query;

                    if (maSanPham == null)
                    {
                        // === THÊM ===
                        query = @"INSERT INTO tt_chitiet_hoadon 
                          (maHoaDon, maSanPham, soLuong, donGiaBan, thanhTien) 
                          VALUES (@maHD, @maSP, @sl, @gia, @tt)";
                    }
                    else
                    {
                        // === SỬA ===
                        query = @"UPDATE tt_chitiet_hoadon 
                          SET soLuong = @sl, donGiaBan = @gia, thanhTien = @tt 
                          WHERE maHoaDon = @maHD AND maSanPham = @maSP";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHoaDon);
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.Parameters.AddWithValue("@sl", soLuong);
                    cmd.Parameters.AddWithValue("@gia", donGia);
                    cmd.Parameters.AddWithValue("@tt", thanhTien);

                    cmd.ExecuteNonQuery();

                    string msg = (maSanPham == null) ? "Thêm chi tiết hóa đơn thành công!" : "Cập nhật chi tiết hóa đơn thành công!";
                    MessageBox.Show(msg);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
