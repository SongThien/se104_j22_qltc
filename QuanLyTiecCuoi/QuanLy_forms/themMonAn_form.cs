using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi.QuanLy_forms
{
    public partial class themMonAn_form : Form
    {
        public themMonAn_form()
        {
            InitializeComponent();
        }

        private void LoadDsMA()
        {
            dtMonAn.DataSource = BUS.BUS_QuanLyMonAn.getDsMonAn();
            if (dtMonAn.Columns.Count < 1)
                return;
            dtMonAn.Columns[0].HeaderText = "Mã Món ăn";
            dtMonAn.Columns[1].HeaderText = "Tên Món ăn";
            dtMonAn.Columns[2].HeaderText = "Đơn Giá";
            dtMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMonAn.ReadOnly = true;
            dtMonAn.MultiSelect = false;
        }

        private void ThemMonAn_form_Load(object sender, EventArgs e)
        {
            LoadDsMA();
        }

        private string GetNewMaMA()
        {
            int bonus = 0;
            String[] d = BUS.BUS_QuanLyMonAn.getDsMaMonAn();
            string ma = String.Format("KH{0}", d.Length + 1 + bonus);
            while (d.Contains(ma))
            {
                bonus++;
                ma = String.Format("KH{0}", d.Length + 1 + bonus);
            }
            return ma;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (lbTen.Text == "" || lbDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_MonAn ma = new DTO.DTO_MonAn();
            ma.MA_MON_AN = GetNewMaMA();
            ma.TEN_MON_AN = lbTen.Text;
            ma.DON_GIA = int.Parse(lbDonGia.Text);
            if (BUS.BUS_QuanLyMonAn.themMonAn(ma) == true)
            {
                MessageBox.Show("Thêm Thành  Công!", "Thông Báo!");
                LoadDsMA();
                return;
            }
            MessageBox.Show("Thêm That Bai!", "Thông Báo!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (lbTen.Text == "" || lbDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu!", "Thông Báo!");
                return;
            }
            DTO.DTO_MonAn ma = new DTO.DTO_MonAn();
            ma.MA_MON_AN = lbMa.Text;
            ma.TEN_MON_AN = lbTen.Text;
            ma.DON_GIA = int.Parse(lbDonGia.Text);
            if (BUS.BUS_QuanLyMonAn.suaMonAn(ma) == true)
            {
                MessageBox.Show("Sửa Thành  Công!", "Thông Báo!");
                LoadDsMA();
                return;
            }
            MessageBox.Show("Sửa That Bai!", "Thông Báo!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DTO.DTO_MonAn ma = new DTO.DTO_MonAn();
            ma.MA_MON_AN = dtMonAn.CurrentRow.Cells[0].Value.ToString();
            if (BUS.BUS_QuanLyMonAn.xoaMonAn(ma) == true)
            {
                MessageBox.Show("Xoá Thành  Công!", "Thông Báo!");
                LoadDsMA();
                return;
            }
            MessageBox.Show("Xoá That Bai!", "Thông Báo!");
        }

        private void DtMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbMa.Text = dtMonAn.CurrentRow.Cells[0].Value.ToString();
            lbTen.Text = dtMonAn.CurrentRow.Cells[1].Value.ToString();
            lbDonGia.Text = dtMonAn.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
