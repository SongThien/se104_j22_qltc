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
    public partial class BaoCaoDoandSo_form : Form
    {
        public BaoCaoDoandSo_form()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void LoadBaoCao()
        {
            string maBC = "BC" + numNam.Value.ToString() + "-" + numThang.Value.ToString();
            dgvBaoCao.DataSource = BUS.BUS_BaoCaoThang.getHoaDonTrongThang(numNam.Value.ToString(),numThang.Value.ToString());
            if (dgvBaoCao.Columns.Count < 1)
                return;
            dgvBaoCao.Columns[0].HeaderText = "Ngày";
            dgvBaoCao.Columns[1].HeaderText = "Số lượng tiệc cưới ";
            dgvBaoCao.Columns[2].HeaderText = "Doanh thu";
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.MultiSelect = false;
        }

        private void BaoCaoDoandSo_form_Load(object sender, EventArgs e)
        {
            numThang.Value = DateTime.Today.Month;
            numNam.Value = DateTime.Today.Year;
            LoadBaoCao();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
