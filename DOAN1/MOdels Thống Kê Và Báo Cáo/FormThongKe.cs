using Microsoft.Reporting.WinForms;
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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            LoadReport();

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }
        private void LoadReport()
        {
            // Tạo ReportViewer
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.ProcessingMode = ProcessingMode.Local;
            this.Controls.Add(reportViewer);

            // Load dữ liệu từ MySQL
            string connStr = "server=localhost;user id=root;password=;database=qlbanhang";
            string query = "SELECT * FROM hoadon";  // bảng hóa đơn của bạn

            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            // Gán dữ liệu vào ReportViewer
            ReportDataSource rds = new ReportDataSource("DS_HoaDon", dt);
            reportViewer.LocalReport.ReportPath = "ReportHoaDon.rdlc"; // Tên file báo cáo
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);

            reportViewer.RefreshReport();
        }
    }
}
