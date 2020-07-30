using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhaSach.BSLayer;

namespace QLNhaSach
{
    public partial class formDangNhap : Form
    {
        BLInfomation db = new BLInfomation();
        public formDangNhap()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = db.LayTaiKhoan();
            dataGridView1.Hide();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtMK.Text != "")
            {
                BLInfomation bl = new BLInfomation();
                bl.DangNhap(txtTen.Text.Trim(), txtMK.Text.Trim());
                if (cLogin.isLogin == true)
                {
                    this.Close();
                    cLogin.ID = txtTen.Text.Trim();
                }
                if(cLogin.isLogin==false)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!");
            }
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtMK.Text != "")
            {
                try
                {
                    // Thực hiện lệnh
                    BLInfomation bl = new BLInfomation();
                    bl.ThemTaiKhoan(this.txtTen.Text.Trim(), this.txtMK.Text.Trim());
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã tạo tài khoản!");
                    txtTen.ResetText();
                    txtMK.ResetText();
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
    }
}
