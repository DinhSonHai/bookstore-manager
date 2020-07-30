namespace QLNhaSach
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msiHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.msiXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.msiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.msiQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCuonSach1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDauSach1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNXB1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTacGia1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMuonTra1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDocGia1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNhanVien1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÀ SÁCH";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiHeThong,
            this.msiQuanLy,
            this.reportToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // msiHeThong
            // 
            this.msiHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDangNhap,
            this.msiDangXuat,
            this.msiDoiMatKhau,
            this.msiXoa,
            this.msiThoat});
            this.msiHeThong.Name = "msiHeThong";
            this.msiHeThong.Size = new System.Drawing.Size(106, 32);
            this.msiHeThong.Text = "Hệ thống";
            // 
            // msiDangNhap
            // 
            this.msiDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msiDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("msiDangNhap.Image")));
            this.msiDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msiDangNhap.Name = "msiDangNhap";
            this.msiDangNhap.Size = new System.Drawing.Size(207, 32);
            this.msiDangNhap.Text = "Đăng Nhập";
            this.msiDangNhap.Click += new System.EventHandler(this.msiAccess);
            // 
            // msiDangXuat
            // 
            this.msiDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("msiDangXuat.Image")));
            this.msiDangXuat.Name = "msiDangXuat";
            this.msiDangXuat.Size = new System.Drawing.Size(207, 32);
            this.msiDangXuat.Text = "Đăng Xuất";
            this.msiDangXuat.Click += new System.EventHandler(this.msiLogout);
            // 
            // msiDoiMatKhau
            // 
            this.msiDoiMatKhau.Name = "msiDoiMatKhau";
            this.msiDoiMatKhau.Size = new System.Drawing.Size(207, 32);
            this.msiDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.msiDoiMatKhau.Click += new System.EventHandler(this.msiDoiMatKhau_Click);
            // 
            // msiXoa
            // 
            this.msiXoa.Name = "msiXoa";
            this.msiXoa.Size = new System.Drawing.Size(207, 32);
            this.msiXoa.Text = "Xóa Tài Khoản";
            this.msiXoa.Click += new System.EventHandler(this.msiDelete);
            // 
            // msiThoat
            // 
            this.msiThoat.Image = ((System.Drawing.Image)(resources.GetObject("msiThoat.Image")));
            this.msiThoat.Name = "msiThoat";
            this.msiThoat.Size = new System.Drawing.Size(207, 32);
            this.msiThoat.Text = "Thoát";
            this.msiThoat.Click += new System.EventHandler(this.msiThoat_Click);
            // 
            // msiQuanLy
            // 
            this.msiQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiCuonSach1,
            this.msiDauSach1,
            this.msiNXB1,
            this.msiTacGia1,
            this.msiMuonTra1,
            this.msiDocGia1,
            this.msiNhanVien1});
            this.msiQuanLy.Name = "msiQuanLy";
            this.msiQuanLy.Size = new System.Drawing.Size(184, 32);
            this.msiQuanLy.Text = "Danh Mục Quản Lí";
            // 
            // msiCuonSach1
            // 
            this.msiCuonSach1.Image = ((System.Drawing.Image)(resources.GetObject("msiCuonSach1.Image")));
            this.msiCuonSach1.Name = "msiCuonSach1";
            this.msiCuonSach1.Size = new System.Drawing.Size(209, 32);
            this.msiCuonSach1.Text = "Cuốn sách";
            this.msiCuonSach1.Click += new System.EventHandler(this.msiCuonSach);
            // 
            // msiDauSach1
            // 
            this.msiDauSach1.Image = ((System.Drawing.Image)(resources.GetObject("msiDauSach1.Image")));
            this.msiDauSach1.Name = "msiDauSach1";
            this.msiDauSach1.Size = new System.Drawing.Size(209, 32);
            this.msiDauSach1.Text = "Đầu sách";
            this.msiDauSach1.Click += new System.EventHandler(this.msiDauSach);
            // 
            // msiNXB1
            // 
            this.msiNXB1.Image = ((System.Drawing.Image)(resources.GetObject("msiNXB1.Image")));
            this.msiNXB1.Name = "msiNXB1";
            this.msiNXB1.Size = new System.Drawing.Size(209, 32);
            this.msiNXB1.Text = "Nhà xuất bản";
            this.msiNXB1.Click += new System.EventHandler(this.msiNXB);
            // 
            // msiTacGia1
            // 
            this.msiTacGia1.Image = ((System.Drawing.Image)(resources.GetObject("msiTacGia1.Image")));
            this.msiTacGia1.Name = "msiTacGia1";
            this.msiTacGia1.Size = new System.Drawing.Size(209, 32);
            this.msiTacGia1.Text = "Tác giả";
            this.msiTacGia1.Click += new System.EventHandler(this.msiTacGia);
            // 
            // msiMuonTra1
            // 
            this.msiMuonTra1.Image = ((System.Drawing.Image)(resources.GetObject("msiMuonTra1.Image")));
            this.msiMuonTra1.Name = "msiMuonTra1";
            this.msiMuonTra1.Size = new System.Drawing.Size(209, 32);
            this.msiMuonTra1.Text = "Mượn trả sách";
            this.msiMuonTra1.Click += new System.EventHandler(this.msiMuonTra);
            // 
            // msiDocGia1
            // 
            this.msiDocGia1.Image = ((System.Drawing.Image)(resources.GetObject("msiDocGia1.Image")));
            this.msiDocGia1.Name = "msiDocGia1";
            this.msiDocGia1.Size = new System.Drawing.Size(209, 32);
            this.msiDocGia1.Text = "Độc giả";
            this.msiDocGia1.Click += new System.EventHandler(this.msiDocGia);
            // 
            // msiNhanVien1
            // 
            this.msiNhanVien1.Image = ((System.Drawing.Image)(resources.GetObject("msiNhanVien1.Image")));
            this.msiNhanVien1.Name = "msiNhanVien1";
            this.msiNhanVien1.Size = new System.Drawing.Size(209, 32);
            this.msiNhanVien1.Text = "Nhân viên";
            this.msiNhanVien1.Click += new System.EventHandler(this.msiNhanVien);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // thôngTinĐôcGiảnMượnSáchToolStripMenuItem
            // 
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinĐôcGiảnMượnSáchToolStripMenuItem.Image")));
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem.Name = "thôngTinĐôcGiảnMượnSáchToolStripMenuItem";
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem.Size = new System.Drawing.Size(349, 32);
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem.Text = "Thông Tin Đôc Giả Mượn Sách";
            this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trợGiúpToolStripMenuItem.Image")));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hướngDẫnToolStripMenuItem.Image")));
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(21, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 285);
            this.panel1.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(551, 155);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 108);
            this.button9.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button9, "Trợ Giúp");
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(421, 155);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 108);
            this.button8.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button8, "Thông Tin Mượn Sách Của Độc Gỉa");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.thôngTinĐôcGiảnMượnSáchToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(352, 32);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 108);
            this.button7.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button7, "Độc Gỉa");
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.msiDocGia);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(218, 32);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 108);
            this.button6.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button6, "Đầu Sách");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.msiDauSach);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(154, 155);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 108);
            this.button4.TabIndex = 4;
            this.button4.Text = "Tác Gỉa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.msiTacGia);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(88, 32);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 108);
            this.button5.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button5, "Cuốn Sách");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.msiCuonSach);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(21, 155);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 108);
            this.button3.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button3, "Nhà Xuất Bản");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.msiNXB);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(287, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 108);
            this.button2.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button2, "Nhân Viên");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.msiNhanVien);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(480, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 108);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "Mượn Trả");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.msiMuonTra);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản Lí Nhà Sách";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiHeThong;
        private System.Windows.Forms.ToolStripMenuItem msiQuanLy;
        private System.Windows.Forms.ToolStripMenuItem msiDangNhap;
        private System.Windows.Forms.ToolStripMenuItem msiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem msiXoa;
        private System.Windows.Forms.ToolStripMenuItem msiNXB1;
        private System.Windows.Forms.ToolStripMenuItem msiDauSach1;
        private System.Windows.Forms.ToolStripMenuItem msiTacGia1;
        private System.Windows.Forms.ToolStripMenuItem msiCuonSach1;
        private System.Windows.Forms.ToolStripMenuItem msiMuonTra1;
        private System.Windows.Forms.ToolStripMenuItem msiDocGia1;
        private System.Windows.Forms.ToolStripMenuItem msiNhanVien1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem msiThoat;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐôcGiảnMượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem msiDoiMatKhau;
    }
}

