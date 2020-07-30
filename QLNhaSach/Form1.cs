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
    public partial class Form1 : Form
    {
        int counter = 0;
        int length = 0;
        string txt;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Hãy đăng nhập để có thể thực hiện mọi chức năng";
            txt = label2.Text;
            length = txt.Length;
            label2.Text = "";
            timer1.Start();
            msiDangNhap.Enabled = true;
            msiXoa.Enabled = false;
            msiDangXuat.Enabled = false;
            msiNXB1.Enabled = false;
            msiDauSach1.Enabled = false;
            msiTacGia1.Enabled = false;
            msiCuonSach1.Enabled = false;
            msiMuonTra1.Enabled = false;
            msiDocGia1.Enabled = false;
            msiNhanVien1.Enabled = false;
            msiDoiMatKhau.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void msiAccess(object sender, EventArgs e)
        {
            formDangNhap form = new formDangNhap();
            form.ShowDialog();
        }
        private void msiLogout(object sender, EventArgs e)
        {
            label2.Text = "Hãy đăng nhập để có thể thực hiện mọi chức năng";
            txt = label2.Text;
            length = txt.Length;
            label2.Text = "";
            FormCollection fc = Application.OpenForms;
            int n = fc.Count;
            label2.Text = n.ToString();
            for (int i = 0; i < fc.Count; i++)
            {
                if (!(fc[i] is Form1))
                {
                    fc[i].Close();
                    i--;
                }
            }
            cLogin.isLogin = false;
            msiDangNhap.Enabled = true;
            msiXoa.Enabled = false;
            msiDangXuat.Enabled = false;
            msiNXB1.Enabled = false;
            msiDauSach1.Enabled = false;
            msiTacGia1.Enabled = false;
            msiCuonSach1.Enabled = false;
            msiMuonTra1.Enabled = false;
            msiDocGia1.Enabled = false;
            msiNhanVien1.Enabled = false;
            msiDoiMatKhau.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void msiDelete(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có muốn xóa tài khoản không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                BLInfomation bl = new BLInfomation();
                bl.XoaTaiKhoan(cLogin.ID);
                msiLogout(sender, e);
            }
        }
        private void msiNXB(object sender, EventArgs e)
        {
            FormNXB form = new FormNXB();
            form.Show();
        }
        private void msiDauSach(object sender, EventArgs e)
        {
            formDauSach form = new formDauSach();
            form.Show();
        }
        private void msiTacGia(object sender, EventArgs e)
        {
            formTacGia form = new formTacGia();
            form.Show();
        }
        private void msiCuonSach(object sender, EventArgs e)
        {
            formCuonSach form = new formCuonSach();
            form.Show();
        }
        private void msiMuonTra(object sender, EventArgs e)
        {
            formMuonTra form = new formMuonTra();
            form.Show();
        }
        private void msiDocGia(object sender, EventArgs e)
        {
            formDocGia form = new formDocGia();
            form.Show();
        }
        private void msiNhanVien(object sender, EventArgs e)
        {
            formNhanVien form = new formNhanVien();
            form.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (cLogin.isLogin == true)
            {
                label2.Text = "Xin chào " + cLogin.ID;
                txt = label2.Text;
                length = txt.Length;
                label2.Text = "";
                msiDangNhap.Enabled = false;
                msiXoa.Enabled = true;
                msiDangXuat.Enabled = true;
                msiNXB1.Enabled = true;
                msiDauSach1.Enabled = true;
                msiTacGia1.Enabled = true;
                msiCuonSach1.Enabled = true;
                msiMuonTra1.Enabled = true;
                msiDocGia1.Enabled = true;
                msiNhanVien1.Enabled = true;
                msiDoiMatKhau.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > length)
            {
                counter = 0;
                label2.Text = "";
            }

            else
            {

                label2.Text = txt.Substring(0, counter);

                if (label2.ForeColor == Color.Black)
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;
            }
        }

        private void msiThoat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinĐôcGiảnMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report fr = new Report();
            fr.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan fr = new HuongDan();
            fr.ShowDialog();
        }


        private void msiDoiMatKhau_Click(object sender, EventArgs e)
        {
            formDoiMK form = new formDoiMK();
            form.ShowDialog();
        }
    }
}
