namespace DOAN1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormBanhang());
            DialogResult result = MessageBox.Show(
                "Bạn muốn chạy chức năng Thống kê không?\n(Nhấn No để vào Bán hàng)",
                "Chọn chức năng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Run(new FormThongKe()); // Mở form thống kê
            }
            else
            {
                Application.Run(new FormBanhang()); // Mặc định vào bán hàng
            }
        }
    }
}