﻿using System;
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
    public partial class formDocGia : Form
    {
        bool them;
        BLInfomation db = new BLInfomation();
        public formDocGia()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = db.LayDocGia();
                // Xóa trống các đối tượng trong Panel
                this.txtMaThe.ResetText();
                this.txtHoTen.ResetText();
                this.dtpNgaySinh.ResetText();
                this.dtpNgayCap.ResetText();
                this.dtpHanDung.ResetText();
                this.txtDiaChi.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                //Không chọn dòng nào
                dataGridView1_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table Đọc giả. Lỗi rồi!!!");
            }
        }

        private void formDocGia_Load(object sender, EventArgs e)
        {
            cmbSearch.SelectedIndex = 0;
            LoadData();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            them = true;
            // Xóa trống các đối tượng trong Panel 
            this.txtMaThe.ResetText();
            this.txtHoTen.ResetText();
            this.dtpNgaySinh.ResetText();
            this.dtpNgayCap.ResetText();
            this.dtpHanDung.ResetText();
            this.txtDiaChi.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtMaThe.Enabled = true;
            // Đưa con trỏ đến TextField
            this.txtMaThe.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            them = false;
            // Cho phép thao tác trên Panel
            this.panel1.Enabled = true;
            dataGridView1_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField
            this.txtMaThe.Enabled = false;
            this.txtHoTen.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            if (dataGridView1.Rows[r].Cells[0].Value.ToString() != "")
            {
                this.txtMaThe.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
                this.txtHoTen.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                this.dtpNgaySinh.Value = Convert.ToDateTime(dataGridView1.Rows[r].Cells[2].Value);
                this.dtpNgayCap.Value = Convert.ToDateTime(dataGridView1.Rows[r].Cells[3].Value);
                this.dtpHanDung.Value = Convert.ToDateTime(dataGridView1.Rows[r].Cells[4].Value);
                this.txtDiaChi.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            }
            else
            {
                this.txtMaThe.ResetText();
                this.txtHoTen.ResetText();
                this.dtpNgaySinh.ResetText();
                this.dtpNgayCap.ResetText();
                this.dtpHanDung.ResetText();
                this.txtDiaChi.ResetText();
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có muốn trở về trang chủ không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txtMaThe.ResetText();
            this.txtHoTen.ResetText();
            this.dtpNgaySinh.ResetText();
            this.dtpNgayCap.ResetText();
            this.dtpHanDung.ResetText();
            this.txtDiaChi.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel1.Enabled = false;
            dataGridView1_CellClick(null, null);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLInfomation bl = new BLInfomation();
                    bl.ThemDocGia(this.txtMaThe.Text.Trim(), this.txtHoTen.Text.Trim(), this.dtpNgaySinh.Value, this.dtpNgayCap.Value, this.dtpHanDung.Value,
                        this.txtDiaChi.Text.Trim());
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLInfomation bl = new BLInfomation();
                bl.CapNhatDocGia(this.txtMaThe.Text.Trim(), this.txtHoTen.Text.Trim(), this.dtpNgaySinh.Value, this.dtpNgayCap.Value, this.dtpHanDung.Value,
                        this.txtDiaChi.Text.Trim());
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dataGridView1.CurrentCell.RowIndex;
            // Lấy MaKH của record hiện hành
            string strMaThe = dataGridView1.Rows[r].Cells[0].Value.ToString();
            if (dataGridView1.Rows[r].Cells[0].Value.ToString() != "")
            {
                try
                {
                    // Thực hiện lệnh
                    // Viết câu lệnh SQL
                    // Hiện thông báo xác nhận việc xóa mẫu tin
                    // Khai báo biến traloi
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp
                    traloi = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không?
                    if (traloi == DialogResult.Yes)
                    {
                        db.XoaDocGia(strMaThe);
                        // Cập nhật lại DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        // Thông báo
                        MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dòng này do dữ liệu này có liên quan đến bảng khác, nếu muốn xóa hãy xóa dữ liệu trong những bảng kia trước!", "Thông báo!");
                }
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.ResetText();
            switch (cmbSearch.Text)
            {
                case "Mã Thẻ": cLogin.search = 0; break;
                case "Họ Tên": cLogin.search = 1; break;
                case "Ngày Sinh": cLogin.search = 2; break;
                case "Ngày Cấp": cLogin.search = 3; break;
                case "Hạn Dùng": cLogin.search = 4; break;
                case "Địa Chỉ": cLogin.search = 5; break;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (cLogin.search == 0)
                {
                    dataGridView1.DataSource = db.SearchDGMaThe(txtSearch.Text);
                }
                else if (cLogin.search == 1)
                {
                    dataGridView1.DataSource = db.SearchDGHoTen(txtSearch.Text);
                }
                else if (cLogin.search == 2)
                {
                    dataGridView1.DataSource = db.SearchDGNgaySinh(txtSearch.Text);
                }
                else if (cLogin.search == 3)
                {
                    dataGridView1.DataSource = db.SearchDGNgayCap(txtSearch.Text);
                }
                else if (cLogin.search == 4)
                {
                    dataGridView1.DataSource = db.SearchDGHanDung(txtSearch.Text);
                }
                else
                {
                    dataGridView1.DataSource = db.SearchDGDiaChi(txtSearch.Text);
                }
            }
            else LoadData();
        }

        private void btnStatictics_Click(object sender, EventArgs e)
        {
            formStaticticsDG form = new formStaticticsDG();
            form.ShowDialog();
        }
    }
}