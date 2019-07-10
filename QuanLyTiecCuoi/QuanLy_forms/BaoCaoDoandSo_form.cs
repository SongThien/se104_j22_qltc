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
            lbMaBaoCao.Text = maBC;
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

        private void TinhTongDoanhThu()
        {
            int sum = 0;
            foreach (DataGridViewRow x in dgvBaoCao.Rows)
            {
                if (x.Cells[0].Value == null)
                    break;
                sum += int.Parse(x.Cells[2].Value.ToString());
            }
            lbTongDoanhthu.Text = sum.ToString();
        }

        private void BaoCaoDoandSo_form_Load(object sender, EventArgs e)
        {
            numThang.Value = DateTime.Today.Month;
            numNam.Value = DateTime.Today.Year;
            LoadBaoCao();
            TinhTongDoanhThu();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void UpdateBC()
        {
            string ma = lbMaBaoCao.Text.Trim();
            int Tong = int.Parse(lbTongDoanhthu.Text.ToString());
            DTO.DTO_BaoCaoDoanhSo s = new DTO.DTO_BaoCaoDoanhSo();
            s.MA_BAO_CAO = ma;
            s.THANG= numNam.Value.ToString() + "-" + numThang.Value.ToString();
            s.TONG_DOANH_THU = Tong;
            BUS.BUS_BaoCaoThang.capNhatBaoCao(s);
            CapNhatChiTiet();
        }

        private void CapNhatChiTiet()
        {
            string ma = lbMaBaoCao.Text.Trim();
            foreach (DataGridViewRow x in dgvBaoCao.Rows)
            {
                if (x.Cells[0].Value == null)
                    break;
                DTO.DTO_ChiTietBaoCao d =  new DTO.DTO_ChiTietBaoCao();
                d.MA_BAO_CAO = ma;
                d.NGAY = x.Cells[0].Value.ToString();
                d.SO_LUONG = int.Parse(x.Cells[1].Value.ToString());
                d.DOANH_THU = int.Parse(x.Cells[2].Value.ToString());
                if (BUS.BUS_BaoCaoThang.checkBaoCaoNgay(d))
                {
                    BUS.BUS_BaoCaoThang.capNhatBaoCaoNgay(d);
                }
                else
                {
                    BUS.BUS_BaoCaoThang.themBaoCaoNgay(d);
                }
            }
            MessageBox.Show("Luư thành công");
        }

        private void AddBC()
        {
            string ma = lbMaBaoCao.Text.Trim();
            int Tong = int.Parse(lbTongDoanhthu.Text.ToString());
            DTO.DTO_BaoCaoDoanhSo s = new DTO.DTO_BaoCaoDoanhSo();
            s.MA_BAO_CAO = ma;
            s.THANG = numNam.Value.ToString() + "-" + numThang.Value.ToString();
            s.TONG_DOANH_THU = Tong;
            BUS.BUS_BaoCaoThang.themBaoCao(s);
            CapNhatChiTiet();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int Tong = int.Parse(lbTongDoanhthu.Text.ToString());
            string ma = lbMaBaoCao.Text.Trim();
            if (BUS.BUS_LapHoaDon.getDanhSachMaBaoCao().Contains(ma))
            {
                UpdateBC();
            }
            else
            {
                AddBC();
            }
        }
    }
}
