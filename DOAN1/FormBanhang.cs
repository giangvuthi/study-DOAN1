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
    public partial class FormBanhang : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=qlbanhang;";

        public FormBanhang()
        {
            InitializeComponent();
        }

        private void FormBanhang_Load(object sender, EventArgs e)
        {
            txtMaHd.Text = TaoMaHoaDonTuDong();
            LoadKhachHang();
            LoadSanPham();
            LoadNhanVien();
            TaoCauTrucBang();
        }

        private void LoadKhachHang()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maKhachHang, tenKhachHang FROM tt_khachhang";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbmakhachhang.DataSource = dt;
                cbmakhachhang.DisplayMember = "maKhachHang";
                cbmakhachhang.ValueMember = "maKhachHang";
            }
        }

        private void LoadSanPham()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maSanPham FROM tt_sanpham";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMasanpham.DataSource = dt;
                cbMasanpham.DisplayMember = "maSanPham";
                cbMasanpham.ValueMember = "maSanPham";
            }
        }

        private void LoadNhanVien()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT maNhanVien FROM nhanvien";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbManv.DataSource = dt;
                cbManv.DisplayMember = "tenNhanVien";
                cbManv.ValueMember = "maNhanVien";
            }
        }


        private void cbMasanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMasanpham.SelectedValue == null)
                return;

            string maSP = cbMasanpham.SelectedValue.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT tenSanPham, donGiaBan, soLuongTon FROM tt_sanpham WHERE maSanPham = @maSP";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maSP", maSP);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenSanpham.Text = reader["tenSanPham"].ToString();
                        txtDonGia.Text = reader["donGiaBan"].ToString();
                        txtTonKho.Text = reader["soLuongTon"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load sản phẩm: " + ex.Message);
                }
            }
        }
        private string TaoMaHoaDonTuDong()
        {
            string maMoi = "HD001";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT maHoaDon FROM hoadon ORDER BY maHoaDon DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string maCu = result.ToString(); // Ví dụ: "HD012"
                        if (maCu.Length >= 3 && int.TryParse(maCu.Substring(2), out int so))
                        {
                            so++;
                            maMoi = "HD" + so.ToString("D3"); // format 3 chữ số
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã hóa đơn tự động: " + ex.Message);
            }

            return maMoi;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKhachHang f = new FormThemKhachHang();
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHang(); // Reload combobox
                cbmakhachhang.SelectedValue = f.GetMaKhachHangMoi();
            }
        }


        private void TaoCauTrucBang()
        {
            dgvThongTinSanPham.Columns.Clear();

            dgvThongTinSanPham.Columns.Add("MaSP", "Mã sản phẩm");
            dgvThongTinSanPham.Columns.Add("TenSP", "Tên sản phẩm");
            dgvThongTinSanPham.Columns.Add("DonGia", "Đơn giá");
            dgvThongTinSanPham.Columns.Add("SoLuong", "Số lượng");
            dgvThongTinSanPham.Columns.Add("ThanhTien", "Thành tiền");

            dgvThongTinSanPham.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvThongTinSanPham.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            dgvThongTinSanPham.AllowUserToAddRows = false;
            dgvThongTinSanPham.ReadOnly = false; // Cho phép sửa

            // Các cột bị khóa (chỉ cho phép sửa số lượng)
            dgvThongTinSanPham.Columns["MaSP"].ReadOnly = true;
            dgvThongTinSanPham.Columns["TenSP"].ReadOnly = true;
            dgvThongTinSanPham.Columns["DonGia"].ReadOnly = true;
            dgvThongTinSanPham.Columns["ThanhTien"].ReadOnly = true;
            dgvThongTinSanPham.Columns["SoLuong"].ReadOnly = false;
        }


        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            int soLuongThem = (int)nudsoluong.Value;

            if (soLuongThem < 1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            int tonKho = int.Parse(txtTonKho.Text);
            string maSP = cbMasanpham.SelectedValue.ToString();

            // Tính tổng số lượng của sản phẩm này đã có trong dgv
            int soLuongDaThem = 0;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSP)
                {
                    soLuongDaThem += Convert.ToInt32(row.Cells["SoLuong"].Value);
                }
            }

            if (soLuongThem + soLuongDaThem > tonKho)
            {
                MessageBox.Show("Số lượng vượt quá số lượng tồn kho hiện tại!");
                return;
            }

            string tenSP = txtTenSanpham.Text;
            decimal donGia = decimal.Parse(txtDonGia.Text);
            decimal thanhTien = donGia * soLuongThem;

            dgvThongTinSanPham.Rows.Add(maSP, tenSP, donGia, soLuongThem, thanhTien);

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tong += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }
            lblTongThanhTien.Text = tong.ToString("N0") + " VND";
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHd.Text.Trim();
            string maKH = cbmakhachhang.SelectedValue?.ToString();
            string maNV = cbManv.SelectedValue?.ToString();
            DateTime ngayLap = dtpNgayTao.Value;

            if (dgvThongTinSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm!");
                return;
            }

            // Tính tổng tiền
            decimal tongThanhTien = 0;
            foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    tongThanhTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 1. Thêm vào bảng hoadon
                    string sqlHD = @"INSERT INTO hoadon 
                (maHoaDon, ngayLap, maNhanVien, maKhachHang, tongThanhTien) 
                VALUES (@maHD, @ngayLap, @maNV, @maKH, @tongTien)";
                    MySqlCommand cmdHD = new MySqlCommand(sqlHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@maHD", maHD);
                    cmdHD.Parameters.AddWithValue("@ngayLap", ngayLap);
                    cmdHD.Parameters.AddWithValue("@maNV", maNV);
                    cmdHD.Parameters.AddWithValue("@maKH", maKH);
                    cmdHD.Parameters.AddWithValue("@tongTien", tongThanhTien);
                    cmdHD.ExecuteNonQuery();

                    // 2. Thêm từng dòng sản phẩm vào chi tiết hóa đơn và trừ tồn kho
                    foreach (DataGridViewRow row in dgvThongTinSanPham.Rows)
                    {
                        string maSP = row.Cells["MaSP"].Value.ToString();
                        int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                        decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                        decimal thanhTien = Convert.ToDecimal(row.Cells["ThanhTien"].Value);

                        // 0. Kiểm tra tồn kho
                        string sqlCheckTonKho = "SELECT soLuongTon FROM tt_sanpham WHERE maSanPham = @maSP";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheckTonKho, conn, tran);
                        cmdCheck.Parameters.AddWithValue("@maSP", maSP);
                        int soLuongTon = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (soLuong > soLuongTon)
                        {
                            throw new Exception($"Sản phẩm {maSP} không đủ tồn kho. Còn lại: {soLuongTon}, cần: {soLuong}");
                        }

                        // 1. Thêm chi tiết hóa đơn
                        string sqlCT = @"INSERT INTO tt_chitiet_hoadon 
        (maHoaDon, maSanPham, soLuong, donGiaBan, thanhTien) 
        VALUES (@maHD, @maSP, @soLuong, @donGia, @thanhTien)";
                        MySqlCommand cmdCT = new MySqlCommand(sqlCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@maHD", maHD);
                        cmdCT.Parameters.AddWithValue("@maSP", maSP);
                        cmdCT.Parameters.AddWithValue("@soLuong", soLuong);
                        cmdCT.Parameters.AddWithValue("@donGia", donGia);
                        cmdCT.Parameters.AddWithValue("@thanhTien", thanhTien);
                        cmdCT.ExecuteNonQuery();

                        // 2. Ghi vào bảng lịch sử
                        string sqlLS = @"INSERT INTO lichsu (maSanPham, soLuong, Loai, thoiGian, maHoaDon)
        VALUES (@maSP, @soLuong, @loai, @thoigian, @maHD)";
                        MySqlCommand cmdLS = new MySqlCommand(sqlLS, conn, tran);
                        cmdLS.Parameters.AddWithValue("@maSP", maSP);
                        cmdLS.Parameters.AddWithValue("@soLuong", soLuong);
                        cmdLS.Parameters.AddWithValue("@loai", "Tạo hóa đơn");
                        cmdLS.Parameters.AddWithValue("@thoigian", DateTime.Now);
                        cmdLS.Parameters.AddWithValue("@maHD", maHD);
                        cmdLS.ExecuteNonQuery();

                        // 3. Trừ tồn kho
                        string sqlUpdate = @"UPDATE tt_sanpham 
                         SET soLuongTon = soLuongTon - @soLuong 
                         WHERE maSanPham = @maSP";
                        MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn, tran);
                        cmdUpdate.Parameters.AddWithValue("@soLuong", soLuong);
                        cmdUpdate.Parameters.AddWithValue("@maSP", maSP);
                        cmdUpdate.ExecuteNonQuery();
                    }


                    tran.Commit();
                    MessageBox.Show("Tạo hóa đơn thành công!");

                    // Làm mới
                    dgvThongTinSanPham.Rows.Clear();
                    lblTongThanhTien.Text = "";
                    txtMaHd.Text = TaoMaHoaDonTuDong(); // Mã hóa đơn mới
                }
                catch (Exception ex)
                {
                    try
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            tran.Rollback(); // chỉ rollback nếu connection còn mở
                        }
                    }
                    catch (Exception rollbackEx)
                    {
                        MessageBox.Show("Lỗi khi rollback: " + rollbackEx.Message);
                    }

                    MessageBox.Show("Lỗi khi tạo hóa đơn: " + ex.Message);
                }

            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (dgvThongTinSanPham.SelectedRows.Count > 0)
            {
                dgvThongTinSanPham.Rows.RemoveAt(dgvThongTinSanPham.SelectedRows[0].Index);
                TinhTongTien(); // cập nhật lại tổng tiền sau khi xoá
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm cần xoá!");
            }
        }

        private void dgvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThongTinSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvThongTinSanPham.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                try
                {
                    int soLuong = Convert.ToInt32(dgvThongTinSanPham.Rows[e.RowIndex].Cells["SoLuong"].Value);
                    decimal donGia = Convert.ToDecimal(dgvThongTinSanPham.Rows[e.RowIndex].Cells["DonGia"].Value);
                    dgvThongTinSanPham.Rows[e.RowIndex].Cells["ThanhTien"].Value = soLuong * donGia;
                    TinhTongTien();
                }
                catch
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                }
            }
        }

        private void dgvThongTinSanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvThongTinSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void tsLichsubanhang_Click(object sender, EventArgs e)
        {
            FormLichSu lichSuForm = new FormLichSu();
            lichSuForm.ShowDialog();
        }

        private void doanhthu_Click(object sender, EventArgs e)
        {

        }

        private void tsDoanhthu_Click(object sender, EventArgs e)
        {
            FormDoanhThu f = new FormDoanhThu();
            f.ShowDialog();
        }
        private void ResetForm(bool reloadDataFromDB)
        {
            txtMaHd.Text = TaoMaHoaDonTuDong();

            if (reloadDataFromDB)
            {
                LoadKhachHang();
                LoadSanPham();
                LoadNhanVien();
            }

            dgvThongTinSanPham.Rows.Clear();
            lblTongThanhTien.Text = "";
            txtTenSanpham.Clear();
            txtDonGia.Clear();
            txtTonKho.Clear();
            nudsoluong.Value = 1;
            TaoCauTrucBang();

            // Đặt combobox về item đầu (nếu có)
            if (cbmakhachhang.Items.Count > 0) cbmakhachhang.SelectedIndex = 0;
            if (cbMasanpham.Items.Count > 0) cbMasanpham.SelectedIndex = 0;
            if (cbManv.Items.Count > 0) cbManv.SelectedIndex = 0;
        }

        private void tsLammoi_Click(object sender, EventArgs e)
        {
            ResetForm(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc chắn muốn hủy tạo đơn hiện tại không?",
        "Xác nhận hủy đơn",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ResetForm(false); // KHÔNG reload DB
                MessageBox.Show("Đã hủy đơn hàng.");
            }
        }
    }
}
