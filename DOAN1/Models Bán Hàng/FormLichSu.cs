using Microsoft.VisualBasic.Devices;
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
    public partial class FormLichSu : Form
    {
        string connectionString = "server=localhost;uid=root;pwd=;database=qlbanhang;";

        public FormLichSu()
        {
            InitializeComponent();
        }

        private void dgvLichsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            cbLoaitim.Items.AddRange(new string[] {
        "Tất cả", "Mã hóa đơn"
    });
            cbLoaitim.SelectedIndex = 0;

            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            LoadLichSu();
        }

        private void LoadLichSu(string keyword = "", string loaiTim = "Tất cả", DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM lichsu WHERE 1=1";

                if (!string.IsNullOrEmpty(keyword) && loaiTim == "Mã hóa đơn")
                {
                    query += " AND maHoaDon LIKE @kw";
                }

                if (tuNgay != null && denNgay != null)
                {
                    query += " AND thoiGian BETWEEN @from AND @to";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (!string.IsNullOrEmpty(keyword) && loaiTim == "Mã hóa đơn")
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                if (tuNgay != null && denNgay != null)
                {
                    cmd.Parameters.AddWithValue("@from", tuNgay.Value.Date);
                    cmd.Parameters.AddWithValue("@to", denNgay.Value.Date.AddDays(1).AddTicks(-1)); // đến cuối ngày
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLichsu.DataSource = dt;
            }
        }




        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTukhoa.Text.Trim();
            string loaiTim = cbLoaitim.SelectedItem?.ToString() ?? "Tất cả";
            DateTime? tuNgay = dtpTu.Value.Date;
            DateTime? denNgay = dtpDen.Value.Date;

            LoadLichSu(tuKhoa, loaiTim, tuNgay, denNgay);
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            txtTukhoa.Clear();
            cbLoaitim.SelectedIndex = 0;
            dtpTu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDen.Value = DateTime.Now;

            LoadLichSu();
        }
    }
}
