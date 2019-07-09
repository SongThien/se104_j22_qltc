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
    public partial class ThemCa_form : Form
    {
        public ThemCa_form()
        {
            InitializeComponent();
        }
        void ClearInputs()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtBD.Text = "";
            txtKT.Text = "";

        }

        public void LoadDataGridView()
        {
            DgvDSCa.DataSource = BUS_QuanLyCa.GetDataTableCa();
            if (DgvDSCa.Columns.Count < 0)
                return;
            DgvDSCa.Columns[0].HeaderText = "Mã Ca";
            DgvDSCa.Columns[1].HeaderText = "Thời Gian Bắt Đầu";
            DgvDSCa.Columns[2].HeaderText = "Thời Gian Kết Thúc";
            DgvDSCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDSCa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDSCa.ReadOnly = true;
            DgvDSCa.MultiSelect = false;
        }
        private String GetNewMaCa()
        {
            int bonus = 0;
            String[] d = BUS_TiepNhanSanh.getDanhSachSanh();
            string ma = String.Format("MCa{0}", d.Length + 1 + bonus);
            while (d.Contains(ma))
            {
                bonus++;
                ma = String.Format("MCa{0}", d.Length + 1 + bonus);
            }
            return ma;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (txtBD.Text == "" || txtKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_Ca ca = new DTO.DTO_Ca();
            ca.MA_CA = GetNewMaCa();
            ca.TG_BAT_DAU = txtBD.Text;
            ca.TG_KET_THUC = txtKT.Text;
            if (BUS_QuanLyCa.themCa(ca) == true)
            {
                MessageBox.Show("Thêm Thành  Công!", "Thông Báo!");
                LoadDataGridView();
                ClearInputs();
                return;
            }
            MessageBox.Show("Thêm That Bai!", "Thông Báo!");
        }

        private void DgvDSCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = DgvDSCa.SelectedRows[0];
            txtBD.Text = dr.Cells[1].Value.ToString();
            txtKT.Text = dr.Cells[2].Value.ToString();
            string MaCa = dr.Cells[0].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtBD.Text == "" || txtKT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_Ca ca = new DTO.DTO_Ca();
            String MaCa = DgvDSCa.CurrentRow.Cells[0].Value.ToString();
            ca.MA_CA = MaCa;
            ca.TG_BAT_DAU = txtBD.Text;
            ca.TG_KET_THUC = txtKT.Text;
            if (BUS_QuanLyCa.suaCa(ca) == true)
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
            String MaCa = DgvDSCa.CurrentRow.Cells[0].Value.ToString();
            if (MaCa == "")
            {
                MessageBox.Show("Vui Lòng Chọn Loại Sảnh Cần Xóa!", "Thông Báo!");
                return;
            }
            DTO.DTO_Ca ca = new DTO.DTO_Ca();
            ca.MA_CA = MaCa;
            if (BUS_QuanLyCa.xoaCa(ca) == true)
            {
                MessageBox.Show("Xóa Thành Công!", "Thông Báo!");
                LoadDataGridView();
                ClearInputs();
                return;
            }
            MessageBox.Show("Xóa Thất Bại!", "Thông Báo!");
        }

        private void ThemCa_form_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
