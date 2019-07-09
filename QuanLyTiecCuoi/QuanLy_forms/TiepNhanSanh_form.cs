﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace QuanLyTiecCuoi
{
    public partial class TiepNhanSanh_form : Form
    {
        public TiepNhanSanh_form()
        {
            InitializeComponent();
        }
        public void LoadDataGridView()
        {
            /*DgvDanhSachSanh.Columns.Add("id", "Mã Sảnh");
            DgvDanhSachSanh.Columns.Add("name", "Tên Sảnh");
            DgvDanhSachSanh.Columns.Add("mls", "Mã Loại Sảnh");
            DgvDanhSachSanh.Columns.Add("sl", "Số lượng bàn");*/
            DgvDanhSachSanh.DataSource = BUS_TiepNhanSanh.GetDataSanhTable();
            if (DgvDanhSachSanh.Columns.Count < 0)
                return;
            DgvDanhSachSanh.Columns[0].HeaderText = "Mã Sảnh";
            DgvDanhSachSanh.Columns[1].HeaderText = "Tên Sảnh";
            DgvDanhSachSanh.Columns[2].HeaderText = "Mã Loại Sảnh";
            DgvDanhSachSanh.Columns[3].HeaderText = "Số lượng bàn";
            DgvDanhSachSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDanhSachSanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDanhSachSanh.ReadOnly = true;
            DgvDanhSachSanh.MultiSelect = false;
        }

        public void LoadDataGridViewLoaiSanh()
        {
           /* DgvLoaiSanh.Columns.Add("id", "Mã Loại Sảnh");
            DgvLoaiSanh.Columns.Add("name", "Tên Loại Sảnh");
            DgvLoaiSanh.Columns.Add("price", "Đơn giá");*/
            DgvLoaiSanh.DataSource = BUS_TiepNhanSanh.GetLoaiSanhTable();
            if (DgvDanhSachSanh.Columns.Count < 0)
                return;
            DgvLoaiSanh.Columns[0].HeaderText = "Ma Loai Sanh";
            DgvLoaiSanh.Columns[1].HeaderText = "Ten Loai Sanh";
            DgvLoaiSanh.Columns[2].HeaderText = "Don Gia";
            DgvLoaiSanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLoaiSanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvLoaiSanh.ReadOnly = true;
            DgvLoaiSanh.MultiSelect = false;
        }
        void ClearInputs()
        {
            btnThemLoai.Enabled = true;
            btnSuaLoai.Enabled = true;
            btnXoaloai.Enabled = true;
            txtTenLoaiSanh.Text = "";
            txtDonGia.Text = "";
           
        }
        private void loadLoaiSanh()
        {
            String[] s;
            LoaiSanh.Items.Clear();
            s = BUS.BUS_TiepNhanSanh.getDanhSachLoaiSanh();
            if (s != null)
            {
                LoaiSanh.Items.AddRange(s);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadDataGridViewLoaiSanh();
            loadLoaiSanh();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow drs = DgvDanhSachSanh.SelectedRows[0];
            txtTenSanh.Text = drs.Cells[1].Value.ToString();
            LoaiSanh.Text = drs.Cells[2].Value.ToString();
            soLuongban.Value = Decimal.Parse(drs.Cells[3].Value.ToString()); 
            
        }
        private String GetNewMaS()
        {
            int bonus = 0;
            string ma = String.Format("MS{0}", BUS_TiepNhanSanh.getDanhSachSanh().Length + 1 + bonus);
            while (BUS_TiepNhanSanh.getDanhSachSanh().Contains(ma))
            {
                bonus++;
                ma = String.Format("MS{0}", BUS_TiepNhanSanh.getDanhSachSanh().Length + 1 + bonus);
            }
            return ma;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == "" || LoaiSanh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_Sanh s = new DTO.DTO_Sanh();
            s.MA_SANH = GetNewMaS();
            s.TEN_SANH = txtTenSanh.Text;
            s.MA_LOAI_SANH = LoaiSanh.Text;
            s.SO_LUONG_BAN = int.Parse(soLuongban.Value.ToString());
            s.GHI_CHU = ghiChu.Text;
            if (BUS_TiepNhanSanh.themSanh(s) == true)
            {
                MessageBox.Show("Thêm Thành  Công!", "Thông Báo!");
                LoadDataGridView();
                loadLoaiSanh();
                LoadDataGridViewLoaiSanh();
                ClearInputs();
                return;
            }
            MessageBox.Show("Thêm That Bai!", "Thông Báo!");
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = DgvLoaiSanh.SelectedRows[0];
            txtTenLoaiSanh.Text = dr.Cells[1].Value.ToString();
            txtDonGia.Text = dr.Cells[2].Value.ToString();
            string MaLS = dr.Cells[0].Value.ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDonGia.Text = BUS_TiepNhanSanh.getThongTinLoaiSanh(LoaiSanh.Text).DON_GIA_TOI_THIEU.ToString();
        }
        private String GetNewMaLS()
        {
            int bonus = 0;
            string ma = String.Format("LS{0}", BUS_TiepNhanSanh.getDanhSachLoaiSanh().Length + 1 + bonus);
            while (BUS_TiepNhanSanh.getDanhSachLoaiSanh().Contains(ma))
            {
                bonus++;
                ma = String.Format("LS{0}", BUS_TiepNhanSanh.getDanhSachLoaiSanh().Length + 1 + bonus);
            }
            return ma;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiSanh.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_LoaiSanh ls = new DTO.DTO_LoaiSanh();
            ls.MA_LOAI_SANH = GetNewMaLS();
            ls.TEN_LOAI_SANH = txtTenLoaiSanh.Text;
            ls.DON_GIA_TOI_THIEU = int.Parse(txtDonGia.Text);
            if (BUS_TiepNhanSanh.themLoaiSanh(ls) == true)
            {
                MessageBox.Show("Thêm Thành  Công!", "Thông Báo!");
                LoadDataGridView();
                loadLoaiSanh();
                LoadDataGridViewLoaiSanh();
                ClearInputs();
                return;
            }
            MessageBox.Show("Thêm That Bai!", "Thông Báo!");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSuaLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiSanh.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập Dữ Liệu!", "Thông Báo");
                return;
            }
            DTO.DTO_LoaiSanh ls = new DTO.DTO_LoaiSanh();
            String MaLS = DgvLoaiSanh.CurrentRow.Cells[0].Value.ToString();
            ls.MA_LOAI_SANH = MaLS;
            ls.TEN_LOAI_SANH = txtTenLoaiSanh.Text;
            ls.DON_GIA_TOI_THIEU = int.Parse(txtDonGia.Text);
            if (BUS_TiepNhanSanh.suaLoaiSanh(ls) == true)
            {
                MessageBox.Show("Sửa Thành Công!", "Thông Báo!");
                LoadDataGridView();
                loadLoaiSanh();
                LoadDataGridViewLoaiSanh();
                ClearInputs();
                return;
            }
            MessageBox.Show("Sửa Thất Bại!", "Thông Báo!");
        }

        private void BtnXoaloai_Click(object sender, EventArgs e)
        {
            String MaLS = DgvLoaiSanh.CurrentRow.Cells[0].Value.ToString();
            if(MaLS == "")
            {
                MessageBox.Show("Vui Lòng Chọn Loại Sảnh Cần Xóa!", "Thông Báo!");
                return;
            }
            DTO.DTO_LoaiSanh ls = new DTO.DTO_LoaiSanh();
            ls.MA_LOAI_SANH = MaLS;
            if (BUS_TiepNhanSanh.xoaLoaiSanh(ls) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                LoadDataGridView();
                loadLoaiSanh();
                LoadDataGridViewLoaiSanh();
                ClearInputs();
                return;
            }
            MessageBox.Show("Xóa Thất Bại!", "Thông Báo!");
        }

        private void BtnSuaSanh_Click(object sender, EventArgs e)
        {
            if (txtTenSanh.Text == "" || LoaiSanh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_Sanh s = new DTO.DTO_Sanh();
            String MaS = DgvDanhSachSanh.CurrentRow.Cells[0].Value.ToString();
            s.MA_SANH = MaS;
            s.TEN_SANH = txtTenSanh.Text;
            s.MA_LOAI_SANH = LoaiSanh.Text;
            s.SO_LUONG_BAN = int.Parse(soLuongban.Value.ToString());
            if (BUS_TiepNhanSanh.suaSanh(s) == true)
            {
                MessageBox.Show("Sửa Thành  Công!", "Thông Báo!");
                LoadDataGridView();
                loadLoaiSanh();
                LoadDataGridViewLoaiSanh();
                ClearInputs();
                return;
            }
            MessageBox.Show("Sửa Thất Bại!", "Thông Báo!");
        }

        private void BtnXoaSanh_Click(object sender, EventArgs e)
        {
            String MaS = DgvDanhSachSanh.CurrentRow.Cells[0].Value.ToString();
            if (MaS == "")
            {
                MessageBox.Show("Vui Lòng Chọn Sảnh Cần Xóa!", "Thông Báo!");
                return;
            }
            DTO.DTO_Sanh s = new DTO.DTO_Sanh();
            s.MA_SANH = MaS;
            if (BUS_TiepNhanSanh.xoaSanh(s) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                LoadDataGridView();
                loadLoaiSanh();
                LoadDataGridViewLoaiSanh();
                ClearInputs();
                return;
            }
            MessageBox.Show("Xóa Thất Bại!", "Thông Báo!");
        }
    }
}
