namespace Bai14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTen = new TextBox();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnCapNhat = new Button();
            btnXoaLopA = new Button();
            button7 = new Button();
            button8 = new Button();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(151, 46);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(413, 34);
            txtTen.TabIndex = 0;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(50, 114);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(203, 204);
            lstLopA.TabIndex = 1;
            lstLopA.SelectedIndexChanged += lstLopA_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(527, 114);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(216, 204);
            lstLopB.TabIndex = 2;
            lstLopB.SelectedIndexChanged += lstLopB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(95, 35);
            label1.TabIndex = 3;
            label1.Text = "Tên SV";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(346, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 4;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(346, 168);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(346, 223);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(346, 289);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(597, 49);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(146, 38);
            btnCapNhat.TabIndex = 8;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += button5_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(50, 353);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(167, 46);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xoá Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // button7
            // 
            button7.Location = new Point(292, 353);
            button7.Name = "button7";
            button7.Size = new Size(191, 46);
            button7.TabIndex = 10;
            button7.Text = "Kết thúc";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(558, 353);
            button8.Name = "button8";
            button8.Size = new Size(185, 46);
            button8.TabIndex = 11;
            button8.Text = "Xoá lớp B";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(17, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.BackColor = Color.Aqua;
            label4.Location = new Point(-1, 416);
            label4.Name = "label4";
            label4.Size = new Size(802, 30);
            label4.TabIndex = 15;
            label4.Text = "11/30/2011 10:51:52 AM Designed by Xavier";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Aqua;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtLớpAToolStripMenuItem, cậpNhậtLớpBToolStripMenuItem, chuyểnPhầnTửChọnSangLớpAToolStripMenuItem, chuyểnPhầnTửChọnSangLớpBToolStripMenuItem, chuyểnHếtDsSangLớpAToolStripMenuItem, chuyểnHếtDsSangLớpBToolStripMenuItem, xóaDanhSáchLớpAToolStripMenuItem, xóaDanhSáchLớpBToolStripMenuItem });
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(82, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(314, 26);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập Nhật Lớp A";
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            cậpNhậtLớpBToolStripMenuItem.Size = new Size(314, 26);
            cậpNhậtLớpBToolStripMenuItem.Text = "Cập Nhật Lớp B";
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new Size(314, 26);
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new Size(314, 26);
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpAToolStripMenuItem.Name = "chuyểnHếtDsSangLớpAToolStripMenuItem";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Size = new Size(314, 26);
            chuyểnHếtDsSangLớpAToolStripMenuItem.Text = "Chuyển hết ds sang lớp A";
            // 
            // chuyểnHếtDsSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpBToolStripMenuItem.Name = "chuyểnHếtDsSangLớpBToolStripMenuItem";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Size = new Size(314, 26);
            chuyểnHếtDsSangLớpBToolStripMenuItem.Text = "Chuyển Hết ds Sang lớp B";
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(314, 26);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa Danh Sách Lớp A";
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(314, 26);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa Danh Sách Lớp B";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, kếtThúcToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(224, 26);
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(224, 26);
            kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            kếtThúcToolStripMenuItem.Click += kếtThúcToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(txtTen);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnCapNhat;
        private Button btnXoaLopA;
        private Button button7;
        private Button button8;
        private LinkLabel linkLabel1;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpBToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}
