using System;
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

namespace QuanLyTiecCuoi.QuanLy_forms
{
    public partial class ThemDichVu_Form : Form
    {
        void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtTenDV.Text = "";
            txtDG.Text = "";

        }

        public void LoadDataGridView()
        {
            DgvDSDichVu.DataSource = BUS_QuanLyDichVu.GetDataTableDichVu();
            if (DgvDSDichVu.Columns.Count < 0)
                return;
            DgvDSDichVu.Columns[0].HeaderText = "Mã Dich vụ";
            DgvDSDichVu.Columns[1].HeaderText = "Tên Dịch Vụ";
            DgvDSDichVu.Columns[2].HeaderText = "Đơn Giá";
            DgvDSDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDSDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDSDichVu.ReadOnly = true;
            DgvDSDichVu.MultiSelect = false;
        }
        private String GetNewMaDV()
        {
            int bonus = 0;
            string ma = String.Format("MDV{0}", BUS_TiepNhanSanh.getDanhSachSanh().Length + 1 + bonus);
            while (BUS_TiepNhanSanh.getDanhSachSanh().Contains(ma))
            {
                bonus++;
                ma = String.Format("MDV{0}", BUS_TiepNhanSanh.getDanhSachSanh().Length + 1 + bonus);
            }
            return ma;
        }
        public ThemDichVu_Form()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "" || txtDG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_DichVu dv = new DTO.DTO_DichVu();
            dv.MA_DICH_VU = GetNewMaDV();
            dv.TEN_DICH_VU = txtTenDV.Text;
            dv.DON_GIA = int.Parse(txtDG.Text);
            if (BUS_QuanLyDichVu.themDV(dv) == true)
            {
                MessageBox.Show("Thêm Thành  Công!", "Thông Báo!");
                LoadDataGridView();
                ClearInputs();
                return;
            }
            MessageBox.Show("Thêm That Bai!", "Thông Báo!");
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ThemDichVu_Form_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void DgvDSDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = DgvDSDichVu.SelectedRows[0];
            txtTenDV.Text = dr.Cells[1].Value.ToString();
            txtDG.Text = dr.Cells[2].Value.ToString();
            string MaCa = dr.Cells[0].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtTenDV.Text == "" || txtDG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_DichVu dv = new DTO.DTO_DichVu();
            String MaDV = DgvDSDichVu.CurrentRow.Cells[0].Value.ToString();
            
            dv.MA_DICH_VU = MaDV;
            dv.TEN_DICH_VU = txtTenDV.Text;
            dv.DON_GIA = int.Parse(txtDG.Text);
            if (BUS_QuanLyDichVu.suaDV(dv) == true)
            {
                MessageBox.Show("Sửa Thành  Công!", "Thông Báo!");
                LoadDataGridView();
                ClearInputs();
                return;
            }
            MessageBox.Show("Sửa That Bai!", "Thông Báo!");
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            String MaDV = DgvDSDichVu.CurrentRow.Cells[0].Value.ToString();
            if (MaDV == "")
            {
                MessageBox.Show("Vui Lòng Chọn Loại Sảnh Cần Xóa!", "Thông Báo!");
                return;
            }
            DTO.DTO_DichVu dv = new DTO.DTO_DichVu();
            dv.MA_DICH_VU = MaDV;
            if (BUS_QuanLyDichVu.xoaDV(dv) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                LoadDataGridView();
                ClearInputs();
                return;
            }
            MessageBox.Show("Xóa Thất Bại!", "Thông Báo!");
        }
    }
}
