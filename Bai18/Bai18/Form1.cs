namespace Bai18
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // T?o m?t th?c th? (instance) m?i c?a form con
            frmChild f = new frmChild();

            // Gán Form cha c?a form con này chính là Form hi?n t?i (this)
            f.MdiParent = this;

            // ??t tên cho form con (tùy ch?n)
            f.Text = "New Document";

            // Hi?n th? form con
            f.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
