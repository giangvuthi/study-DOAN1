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

namespace DOAN1.MOdels_Thống_Kê_Và_Báo_Cáo
{
    public partial class FormThongKeLuong : Form
    {
        public FormThongKeLuong()
        {
            InitializeComponent();
            LoadThangNam();

        }

        private void FormThongKeLuong_Load(object sender, EventArgs e)
        {

        }

        private void LoadThangNam()
        {
            for (int i = 1; i <= 12; i++)
                cbThang.Items.Add(i);
            cbThang.SelectedIndex = DateTime.Now.Month - 1;

            for (int year = 2020; year <= DateTime.Now.Year; year++)
                cbNam.Items.Add(year);
            cbNam.SelectedItem = DateTime.Now.Year;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int thang = Convert.ToInt32(cbThang.SelectedItem);
            int nam = Convert.ToInt32(cbNam.SelectedItem);
            ThongKeLuong(thang, nam);
        }
        private void ThongKeLuong(int thang, int nam)
        {
            dgvLuongNV.Rows.Clear();
            decimal tongLuong = 0;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=qlbanhang;password=;"))
            {
                conn.Open();

                string query = @"
                    SELECT nv.maNhanVien, nv.tenNhanVien, nv.chucVu,
                           SUM(CASE WHEN ca1 THEN 1 ELSE 0 END +
                               CASE WHEN ca2 THEN 1 ELSE 0 END +
                               CASE WHEN ca3 THEN 1 ELSE 0 END) AS tongCa,
                           CASE nv.chucVu 
                                WHEN 'Quản lý' THEN 300000 
                                WHEN 'Thu ngân' THEN 200000 
                                ELSE 150000 END AS luongCa
                    FROM tt_nhanvien nv
                    JOIN tt_chamcong cc ON nv.maNhanVien = cc.maNhanVien
                    WHERE MONTH(ngayChamCong) = @thang AND YEAR(ngayChamCong) = @nam
                    GROUP BY nv.maNhanVien, nv.tenNhanVien, nv.chucVu";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ma = reader.GetString("maNhanVien");
                    string ten = reader.GetString("tenNhanVien");
                    string chucVu = reader.GetString("chucVu");
                    int tongCa = reader.GetInt32("tongCa");
                    int luongCa = reader.GetInt32("luongCa");
                    int tong = tongCa * luongCa;
                    tongLuong += tong;

                    dgvLuongNV.Rows.Add(ma, ten, chucVu, tongCa, luongCa, tong);
                }
                reader.Close();
            }

            lblTongLuong.Text = $"Tổng lương: {tongLuong:N0} VNĐ";
        }
    }
}
