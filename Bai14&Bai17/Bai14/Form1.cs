namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu đang chọn ko?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn ko được phép nhập dữ liệu rỗng!", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTen.Focus(); // Đưa con trỏ nháy về TextBox
            }
            else
            {
                string strDuLieu = txtTen.Text;
                lstLopA.Items.Add(strDuLieu); // Thêm vào ListBox A
                txtTen.Clear(); // Xóa trắng TextBox
                txtTen.Focus();
            }
        }

        private void lstLopB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void chuyenDuLieu(ListBox lst1, ListBox lst2)
        {
            int i = 0;
            while (i < lst1.Items.Count)
            {
                if (lst1.GetSelected(i)) // Nếu phần tử thứ i được chọn
                {
                    string stDuLieu = lst1.Items[i].ToString();
                    lst2.Items.Add(stDuLieu); // Thêm sang danh sách 2
                    lst1.Items.RemoveAt(i);   // Xóa khỏi danh sách 1
                }
                else
                {
                    i++;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstLopB.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển những dữ liệu đang chọn ko?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenDuLieu(lstLopB, lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }
        void chuyenToanBo(ListBox lst1, ListBox lst2)
        {
            while (lst1.Items.Count != 0) // Lặp đến khi danh sách 1 trống
            {
                string stDuLieu = lst1.Items[0].ToString();
                lst2.Items.Add(stDuLieu);
                lst1.Items.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiChuyen = MessageBox.Show("Bạn có chắc chuyển toàn bộ dữ liệu đang chọn ko?",
                    "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiChuyen == DialogResult.Yes)
                {
                    chuyenToanBo(lstLopA, lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Danh sách hiện đang rỗng!", "Chú ý");
            }
        }
        void xoaDuLieu(ListBox lst)
        {
            int i = 0;
            while (i < lst.Items.Count)
            {
                if (lst.GetSelected(i))
                {
                    lst.Items.RemoveAt(i); // Xóa phần tử, các phần tử sau tự dồn lên nên không tăng i
                }
                else
                {
                    i++;
                }
            }
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopA);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                DialogResult hoiXoa = MessageBox.Show("Bạn có chắc xóa những phần tử này?", "Chú ý",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (hoiXoa == DialogResult.Yes)
                {
                    xoaDuLieu(lstLopB);
                }
            }
            else
            {
                MessageBox.Show("Hiện danh sách đang rỗng!", "Chú ý");
            }
        }

        private void lstLopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình được thiết kế và thực hiện bởi Quý.", "Thông Tin Tác Giả",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


