using MySql.Data.MySqlClient;
using System.Data;

namespace DOAN1
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=qlbanhang;charset=utf8";
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // first commit 
            conn = new MySqlConnection(connectionString);
            LoadHoaDon();


        }
        private void LoadHoaDon()
        {
            
        }

        private void LoadChiTietHoaDon(string maHD)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {

        }
        

        private void tsThem_Click(object sender, EventArgs e)
        {
            
        }

        private void tsChitiet_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtMahd.Text = "";
        }
    }
}
