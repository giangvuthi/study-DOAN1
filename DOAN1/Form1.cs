using MySql.Data.MySqlClient;
using System.Data;

namespace DOAN1
{
    class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderButtonBackground(e);
            ToolStripButton button = e.Item as ToolStripButton;

            if (button != null)
            {
                if (button.Selected || button.Pressed)
                {
                    e.Graphics.FillRectangle(Brushes.LightBlue, e.Item.ContentRectangle);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.Item.ContentRectangle);
                }
            }
        }
    }
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=qlbanhang;charset=utf8";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void InitToolStripUI()
        {
            toolStrip1.Dock = DockStyle.Top;
            toolStrip1.Height = 70;
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(36, 36);
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Padding = new Padding(10, 5, 10, 5);

            // Đổi Renderer để có hiệu ứng hover
            toolStrip1.Renderer = new MyRenderer();

            int buttonWidth = this.Width / toolStrip1.Items.Count;

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton btn)
                {
                    btn.AutoSize = false;
                    btn.Width = buttonWidth;
                    btn.Height = 60;

                    btn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    btn.TextImageRelation = TextImageRelation.ImageAboveText;

                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    btn.ForeColor = Color.DarkSlateGray;
                    btn.BackColor = Color.Transparent;
                }
            }

            this.Resize += (s, e) =>
            {
                int newButtonWidth = this.Width / toolStrip1.Items.Count;
                foreach (ToolStripItem item in toolStrip1.Items)
                {
                    if (item is ToolStripButton btn)
                    {
                        btn.Width = newButtonWidth;
                    }
                }
            };
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            dgvHoaDon.SelectionChanged += dgvHoaDon_SelectionChanged;
            InitToolStripUI();
          
        }
       


        private void CauHinhDataGridViewDep(DataGridView dgv)
        {
            // Tự giãn chiều ngang (các cột chiếm đều hết bảng)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Giãn chiều cao theo nội dung (hoặc có thể bỏ nếu bạn muốn cố định)
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Không cho sửa trực tiếp trên lưới
            dgv.ReadOnly = true;

            // Font nội dung và tiêu đề
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // Căn giữa tiêu đề cột, căn trái nội dung
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Màu nền và viền
            dgv.GridColor = Color.LightGray;
            dgv.BackgroundColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;

            // Màu header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Viền gọn gàng
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Không cho chọn nhiều dòng
            dgv.MultiSelect = false;

            // Chọn cả dòng
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Cho phép bảng tự co giãn theo vùng chứa (nếu không dùng Dock = Fill)
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Không cho người dùng resize hàng (cho đẹp)
            dgv.AllowUserToResizeRows = false;

            // Không cho thêm dòng trống cuối bảng
            dgv.AllowUserToAddRows = false;
        }


        private void LoadHoaDon()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM hoadon";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    dgvHoaDon.DataSource = dt;
                    CauHinhDataGridViewDep(dgvHoaDon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadChiTietHoaDon(string maHD)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT maHoaDon, maSanPham, soLuong, donGiaBan, thanhTien FROM tt_chitiet_hoadon WHERE maHoaDon = @maHoaDon";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@maHoaDon", maHD);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChiTietHoaDon.DataSource = dt;
                    CauHinhDataGridViewDep(dgvChiTietHoaDon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chi tiết: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {

        }
        enum TrangDangXem { HoaDon, ChiTiet }
        TrangDangXem trangHienTai = TrangDangXem.HoaDon;

        private void tsThem_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.Focused)
            {
                // Thêm chi tiết hóa đơn
                if (dgvHoaDon.CurrentRow != null)
                {
                    string maHD = dgvHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();
                    FormThemChiTiet f = new FormThemChiTiet(maHD);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadChiTietHoaDon(maHD);
                    }
                }
            }
            else if (dgvHoaDon.Focused)
            {
                // Thêm hóa đơn
                FormThemHoaDon f = new FormThemHoaDon();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn lưới cần thêm (Hóa đơn hoặc Chi tiết).");
            }
        }

        private void tsChitiet_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                panelChiTiet.Visible = true;
                trangHienTai = TrangDangXem.ChiTiet;
                string maHD = dgvHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();
                LoadChiTietHoaDon(maHD);
            }
        }

        private void tsSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.Focused)
            {
                if (dgvChiTietHoaDon.CurrentRow != null)
                {
                    string maHD = dgvChiTietHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();
                    string maSP = dgvChiTietHoaDon.CurrentRow.Cells["maSanPham"].Value.ToString();

                    // Form sửa chi tiết
                    FormThemChiTiet f = new FormThemChiTiet(maHD, maSP); // cần thêm constructor này
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadChiTietHoaDon(maHD);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần sửa trong Chi tiết hóa đơn.");
                }
            }
            else if (dgvHoaDon.Focused)
            {
                if (dgvHoaDon.CurrentRow != null)
                {
                    string maHD = dgvHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();

                    // Form sửa hóa đơn
                    FormThemHoaDon f = new FormThemHoaDon(maHD); // cần thêm constructor này
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần sửa trong Hóa đơn.");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn bảng dữ liệu (Hóa đơn hoặc Chi tiết) để sửa.");
            }
        }

        private void CapNhatTongTienHoaDon(string maHD)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = @"
                UPDATE hoadon
                SET tongThanhTien = (
                    SELECT IFNULL(SUM(thanhTien), 0)
                    FROM tt_chitiet_hoadon
                    WHERE maHoaDon = @maHD
                )
                WHERE maHoaDon = @maHD;
            ";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật tổng tiền hóa đơn: " + ex.Message);
            }
        }


        private void tsXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHoaDon.Focused)
            {
                if (dgvChiTietHoaDon.CurrentRow != null)
                {
                    string maHD = dgvChiTietHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();
                    string maSP = dgvChiTietHoaDon.CurrentRow.Cells["maSanPham"].Value.ToString();
                    string soLuong = dgvChiTietHoaDon.CurrentRow.Cells["soLuong"].Value.ToString();
                    string donGia = dgvChiTietHoaDon.CurrentRow.Cells["donGiaBan"].Value.ToString();
                    string thanhTien = dgvChiTietHoaDon.CurrentRow.Cells["thanhTien"].Value.ToString();

                    var result = MessageBox.Show(
                        $"Xác nhận xóa chi tiết:\n" +
                        $"- Mã Hóa Đơn: {maHD}\n" +
                        $"- Mã Sản Phẩm: {maSP}\n" +
                        $"- Số Lượng: {soLuong}\n" +
                        $"- Đơn Giá: {donGia}\n" +
                        $"- Thành Tiền: {thanhTien}",
                        "⚠️ Xác nhận xóa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();
                                string query = "DELETE FROM tt_chitiet_hoadon WHERE maHoaDon = @maHD AND maSanPham = @maSP";
                                MySqlCommand cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("@maHD", maHD);
                                cmd.Parameters.AddWithValue("@maSP", maSP);
                                cmd.ExecuteNonQuery();
                            }

                            // ✅ Cập nhật lại tổng tiền hóa đơn
                            CapNhatTongTienHoaDon(maHD);

                            MessageBox.Show("✅ Đã xóa chi tiết hóa đơn thành công và cập nhật tổng tiền!");
                            LoadChiTietHoaDon(maHD);
                            LoadHoaDon(); // nếu bạn muốn cập nhật luôn bảng hóa đơn
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("❌ Lỗi khi xóa chi tiết: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa trong Chi tiết hóa đơn.");
                }
            }
            else if (dgvHoaDon.Focused)
            {
                if (dgvHoaDon.CurrentRow != null)
                {
                    string maHD = dgvHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();

                    var result = MessageBox.Show($"Bạn có chắc muốn xóa toàn bộ hóa đơn [{maHD}] và các chi tiết kèm theo?",
                                                 "⚠️ Xác nhận xóa hóa đơn",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(connectionString))
                            {
                                conn.Open();

                                // Xóa chi tiết hóa đơn
                                string deleteCT = "DELETE FROM tt_chitiet_hoadon WHERE maHoaDon = @maHD";
                                MySqlCommand cmdCT = new MySqlCommand(deleteCT, conn);
                                cmdCT.Parameters.AddWithValue("@maHD", maHD);
                                cmdCT.ExecuteNonQuery();

                                // Xóa hóa đơn
                                string deleteHD = "DELETE FROM hoadon WHERE maHoaDon = @maHD";
                                MySqlCommand cmdHD = new MySqlCommand(deleteHD, conn);
                                cmdHD.Parameters.AddWithValue("@maHD", maHD);
                                cmdHD.ExecuteNonQuery();
                            }


                            MessageBox.Show("✅ Đã xóa hóa đơn và toàn bộ chi tiết thành công!");
                            LoadHoaDon();
                            dgvChiTietHoaDon.DataSource = null;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("❌ Lỗi khi xóa hóa đơn: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa trong Hóa đơn.");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn bảng dữ liệu (Hóa đơn hoặc Chi tiết) để xóa.");
            }
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (panelChiTiet.Visible && dgvHoaDon.CurrentRow != null)
            {
                string maHD = dgvHoaDon.CurrentRow.Cells["maHoaDon"].Value.ToString();
                LoadChiTietHoaDon(maHD);
            }
        }
    }
}
