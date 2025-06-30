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

        public FormThemHoaDon()
        {
            InitializeComponent();
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

                    string sql = "INSERT INTO hoadon (maHoaDon, maNhanVien, ngayLap, tongThanhTien) " +
                                 "VALUES (@maHD, @maNV, @ngayLap, @tongTien)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@ngayLap", ngayLap);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    this.DialogResult = DialogResult.OK; // Cho phép Form1 reload
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message);
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
