namespace Bai19
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuEdit = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            rtbContent = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1 = new ToolStrip();
            newToolStripButton1 = new ToolStripButton();
            openToolStripButton1 = new ToolStripButton();
            saveToolStripButton1 = new ToolStripButton();
            printToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cutToolStripButton1 = new ToolStripButton();
            copyToolStripButton1 = new ToolStripButton();
            pasteToolStripButton1 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            helpToolStripButton1 = new ToolStripButton();
            mnuMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuEdit, mnuFormat, mnuHelp });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(10, 4, 0, 4);
            mnuMain.Size = new Size(750, 37);
            mnuMain.TabIndex = 0;
            // 
            // mnuFile
            // 
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(54, 29);
            mnuFile.Text = "File";
            // 
            // mnuEdit
            // 
            mnuEdit.Name = "mnuEdit";
            mnuEdit.Size = new Size(58, 29);
            mnuEdit.Text = "Edit";
            // 
            // mnuFormat
            // 
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(85, 29);
            mnuFormat.Text = "Format";
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(65, 29);
            mnuHelp.Text = "Help";
            // 
            // rtbContent
            // 
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbContent.Location = new Point(0, 66);
            rtbContent.Margin = new Padding(5, 6, 5, 6);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(750, 476);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDate, lblTime });
            statusStrip1.Location = new Point(0, 542);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 24, 0);
            statusStrip1.Size = new Size(750, 36);
            statusStrip1.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(644, 29);
            lblDate.Spring = true;
            lblDate.Text = "Sunday, June 09, 2002";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            lblTime.BorderSides = ToolStripStatusLabelBorderSides.Left;
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(81, 29);
            lblTime.Text = "9:56 PM";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton1, openToolStripButton1, saveToolStripButton1, printToolStripButton1, toolStripSeparator1, cutToolStripButton1, copyToolStripButton1, pasteToolStripButton1, toolStripSeparator2, helpToolStripButton1 });
            toolStrip1.Location = new Point(0, 37);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(750, 29);
            toolStrip1.TabIndex = 1;
            // 
            // newToolStripButton1
            // 
            newToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton1.Image = (Image)resources.GetObject("newToolStripButton1.Image");
            newToolStripButton1.ImageTransparentColor = Color.Magenta;
            newToolStripButton1.Name = "newToolStripButton1";
            newToolStripButton1.Size = new Size(34, 24);
            newToolStripButton1.Text = "&New";
            // 
            // openToolStripButton1
            // 
            openToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton1.Image = (Image)resources.GetObject("openToolStripButton1.Image");
            openToolStripButton1.ImageTransparentColor = Color.Magenta;
            openToolStripButton1.Name = "openToolStripButton1";
            openToolStripButton1.Size = new Size(34, 24);
            openToolStripButton1.Text = "&Open";
            // 
            // saveToolStripButton1
            // 
            saveToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton1.Image = (Image)resources.GetObject("saveToolStripButton1.Image");
            saveToolStripButton1.ImageTransparentColor = Color.Magenta;
            saveToolStripButton1.Name = "saveToolStripButton1";
            saveToolStripButton1.Size = new Size(34, 24);
            saveToolStripButton1.Text = "&Save";
            // 
            // printToolStripButton1
            // 
            printToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton1.Image = (Image)resources.GetObject("printToolStripButton1.Image");
            printToolStripButton1.ImageTransparentColor = Color.Magenta;
            printToolStripButton1.Name = "printToolStripButton1";
            printToolStripButton1.Size = new Size(34, 24);
            printToolStripButton1.Text = "&Print";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 29);
            // 
            // cutToolStripButton1
            // 
            cutToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton1.Image = (Image)resources.GetObject("cutToolStripButton1.Image");
            cutToolStripButton1.ImageTransparentColor = Color.Magenta;
            cutToolStripButton1.Name = "cutToolStripButton1";
            cutToolStripButton1.Size = new Size(34, 24);
            cutToolStripButton1.Text = "C&ut";
            // 
            // copyToolStripButton1
            // 
            copyToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton1.Image = (Image)resources.GetObject("copyToolStripButton1.Image");
            copyToolStripButton1.ImageTransparentColor = Color.Magenta;
            copyToolStripButton1.Name = "copyToolStripButton1";
            copyToolStripButton1.Size = new Size(34, 24);
            copyToolStripButton1.Text = "&Copy";
            // 
            // pasteToolStripButton1
            // 
            pasteToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton1.Image = (Image)resources.GetObject("pasteToolStripButton1.Image");
            pasteToolStripButton1.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton1.Name = "pasteToolStripButton1";
            pasteToolStripButton1.Size = new Size(34, 24);
            pasteToolStripButton1.Text = "&Paste";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 29);
            // 
            // helpToolStripButton1
            // 
            helpToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton1.Image = (Image)resources.GetObject("helpToolStripButton1.Image");
            helpToolStripButton1.ImageTransparentColor = Color.Magenta;
            helpToolStripButton1.Name = "helpToolStripButton1";
            helpToolStripButton1.Size = new Size(34, 24);
            helpToolStripButton1.Text = "He&lp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 578);
            Controls.Add(rtbContent);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(mnuMain);
            MainMenuStrip = mnuMain;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_21";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton1;
        private ToolStripButton openToolStripButton1;
        private ToolStripButton saveToolStripButton1;
        private ToolStripButton printToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton cutToolStripButton1;
        private ToolStripButton copyToolStripButton1;
        private ToolStripButton pasteToolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton helpToolStripButton1;
    }
}