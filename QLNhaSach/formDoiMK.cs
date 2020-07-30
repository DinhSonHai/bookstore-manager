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
    public partial class formDoiMK : Form
    {
        BLInfomation db = new BLInfomation();
        public formDoiMK()
        {
            InitializeComponent();
        }
        private void formDoiMK_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = db.LayTaiKhoan();
            dataGridView1.Hide();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
            if (txtOld.Text != "" && txtNew.Text != "")
            {
                BLInfomation bl = new BLInfomation();
                if (bl.SearchTK(cLogin.ID.Trim(), this.txtOld.Text.Trim()))
                {
                    try
                    {
                        // Thực hiện lệnh
                        bl.CapNhatTaiKhoan(cLogin.ID.Trim(), this.txtNew.Text.Trim());
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã đổi mật khẩu!");
                        this.Close();
                        LoadData();
                    }
                    catch
                    {
                        MessageBox.Show("Không đổi được mật khẩu");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại sai!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
    }
}
