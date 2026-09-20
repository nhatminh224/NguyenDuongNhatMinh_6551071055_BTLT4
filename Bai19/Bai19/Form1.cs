using System;
using System.Windows.Forms;

namespace Bai19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo hiển thị giờ ngay khi mở Form, không cần chờ 1 giây
            CapNhatThoiGian();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGian();
        }

        private void CapNhatThoiGian()
        {
            // Định dạng: Sunday, June 09, 2024
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            // Định dạng: 9:56 PM
            lblTime.Text = DateTime.Now.ToString("h:mm tt");
        }
    }
}