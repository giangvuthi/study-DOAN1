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
    public partial class FormThemHoaDon : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=qlbanhang;charset=utf8";

        private string maHoaDonSua = null;
        public FormThemHoaDon()  // Thêm mới
        {
            InitializeComponent();
        }

        public FormThemHoaDon(string maHD)  // Sửa
        {
            InitializeComponent();
            maHoaDonSua = maHD;
            txtMaHoaDon.Text = maHD;
            txtMaHoaDon.ReadOnly = true;
            LoadThongTinHoaDon(maHD); // bạn cần viết hàm này
        }

        private void LoadThongTinHoaDon(string maHD)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM hoadon WHERE maHoaDon = @maHD";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHD);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMaNhanVien.Text = reader["maNhanVien"].ToString();

                            DateTime ngayLap;
                            if (DateTime.TryParse(reader["ngayLap"].ToString(), out ngayLap))
                            {
                                dateNgayLap.Value = ngayLap;
                            }

                            txtTongTien.Text = reader["tongThanhTien"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin hóa đơn: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHoaDon.Text.Trim();
            string maNV = txtMaNhanVien.Text.Trim();
            string ngayLap = dateNgayLap.Value.ToString("yyyy-MM-dd");
            string tongTienStr = txtTongTien.Text.Trim();

            // Kiểm tra dữ liệu
            if (maHD == "" || maNV == "" || tongTienStr == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!double.TryParse(tongTienStr, out double tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql;
                    MySqlCommand cmd;

                    if (maHoaDonSua == null)
                    {
                        // === THÊM MỚI ===
                        sql = "INSERT INTO hoadon (maHoaDon, maNhanVien, ngayLap, tongThanhTien) " +
                              "VALUES (@maHD, @maNV, @ngayLap, @tongTien)";
                    }
                    else
                    {
                        // === CẬP NHẬT ===
                        sql = "UPDATE hoadon SET maNhanVien = @maNV, ngayLap = @ngayLap, tongThanhTien = @tongTien " +
                              "WHERE maHoaDon = @maHD";
                    }

                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);

                    cmd.ExecuteNonQuery();

                    string msg = (maHoaDonSua == null) ? "Thêm hóa đơn thành công!" : "Cập nhật hóa đơn thành công!";
                    MessageBox.Show(msg);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message);
            }
        }

        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThemHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
