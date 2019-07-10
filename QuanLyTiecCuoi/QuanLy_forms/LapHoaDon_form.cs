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
    public partial class LapHoaDon_form : Form
    {
        public LapHoaDon_form()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void LoadDs()
        {
            cmbMaTiecCuoi.Items.Clear();
            cmbMaTiecCuoi.Items.AddRange(BUS.BUS_LapHoaDon.getDsMaTiecCuoiChuaThanhToan());
            cmbMaTiecCuoi2.Items.Clear();
            cmbMaTiecCuoi2.Items.AddRange(BUS.BUS_LapHoaDon.getDsMaTiecCuoiDaThanhToan());
        }

        private void LapHoaDon_form_Load(object sender, EventArgs e)
        {
            LoadDs();
        }

        private void HienThiHoaDon(string ma)
        {

            DTO.DTO_TiecCuoi tc = BUS.BUS_LapHoaDon.getThongTinTiecCuoi(ma);
            DTO.DTO_KhachHang kh = BUS.BUS_LapHoaDon.getThongTinKhachHang(tc.MA_KHACH_HANG);
            DTO.DTO_Sanh sanh = BUS.BUS_LapHoaDon.getThongTinSanh(tc.MA_SANH);
            DTO.DTO_LoaiSanh ls = BUS.BUS_LapHoaDon.getThongTinLoaiSanh(sanh.MA_LOAI_SANH);

            lbTenChuRe.Text = kh.TEN_CHU_RE;
            lbTenCoDau.Text = kh.TEN_CO_DAU;
            lbSDT.Text = kh.SDT;

            lbSanh.Text = sanh.TEN_SANH;
            lbSLBan.Text = (tc.SL_BAN + tc.SL_BAN_DU_TRU).ToString();
            lbDonGia.Text = ls.DON_GIA_TOI_THIEU.ToString();
            lbNgayToChuc.Text = tc.NGAY_TO_CHUC.ToString().Split()[0];
            lbTienDatCoc.Text = tc.TIEN_DAT_COC.ToString();

            lbTongTienBan.Text = ((tc.SL_BAN + tc.SL_BAN_DU_TRU) * ls.DON_GIA_TOI_THIEU - tc.TIEN_DAT_COC).ToString();
            HienThiDsMonAn(tc.MA_TIEC_CUOI);
            HienThiDsDichVu(tc.MA_TIEC_CUOI);

            TinhTienPhat();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMaTiecCuoi.Text = cmbMaTiecCuoi.Text;
            HienThiHoaDon(lbMaTiecCuoi.Text);
            bttThanhToan.Enabled = true;
            cmbMaTiecCuoi2.Text = "";
        }

        private void TinhTienPhat()
        {
            if (lbMaTiecCuoi.Text == "")
                return;
            int tienAn = int.Parse(lbTienAn.Text);
            int tienban = int.Parse(lbTongTienBan.Text);
            int dichVu = int.Parse(lbTienDV.Text);


            DateTime x = DateTime.Parse(BUS.BUS_LapHoaDon.getThongTinTiecCuoi(lbMaTiecCuoi.Text).NGAY_TO_CHUC);
            int p = Convert.ToInt32((dtpNgayThanhToan.Value - x).TotalDays);
            if (p > 0)
            {
                cbPhat.Text = p.ToString() + "%";
            }
            else
            {
                cbPhat.Text = "0%";
            }
            if (cbPhat.Checked && p > 0)
            {
                
                lbTong.Text = ((tienAn + tienban + dichVu) * (100.0 + p) / 100).ToString();
            }
            else
            {
                lbTong.Text = (tienAn + tienban + dichVu).ToString();
            }
        }

        private void HienThiDsMonAn(String maTC)
        {
            dtMonAn.DataSource = BUS.BUS_LapHoaDon.getDsMonAnDaDat(maTC);
            if (dtMonAn.Columns.Count == 0)
                return;
            dtMonAn.Columns[0].HeaderText = "Mã Món ăn";
            dtMonAn.Columns[1].HeaderText = "Tên món ăn";
            dtMonAn.Columns[2].HeaderText = "Đơn giá";
            dtMonAn.Columns[3].HeaderText = "Ghi chú";
            dtMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMonAn.ReadOnly = true;
            dtMonAn.MultiSelect = false;
            TinhTienMonAn();
        }

        private void TinhTienMonAn()
        {
            int sum = 0;
            int u = BUS.BUS_LapHoaDon.getThongTinTiecCuoi(lbMaTiecCuoi.Text).SL_BAN;
            for (int i = 0; i < dtMonAn.Rows.Count - 1; i++)
            {
                sum += int.Parse(dtMonAn.Rows[i].Cells[2].Value.ToString().Trim());
            }
            sum *= u;
            lbTienAn.Text = sum.ToString();
        }

        private void HienThiDsDichVu(String maTC)
        {
            dtDichVu.DataSource = BUS.BUS_LapHoaDon.getDsDichVuDaDat(maTC);
            if (dtDichVu.Columns.Count == 0)
                return;
            dtDichVu.Columns[0].HeaderText = "Mã Dịch vụ";
            dtDichVu.Columns[1].HeaderText = "Tên Dịch vụ";
            dtDichVu.Columns[2].HeaderText = "Đơn giá";
            dtDichVu.Columns[3].HeaderText = "Số Lượng";
            dtDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtDichVu.ReadOnly = true;
            dtDichVu.MultiSelect = false;
            TinhTienDichVu();
        }

        private void TinhTienDichVu()
        {
            int sum = 0;
            for (int i = 0; i < dtDichVu.Rows.Count - 1; i++)
            {
                sum += int.Parse(dtDichVu.Rows[i].Cells[2].Value.ToString().Trim()) * int.Parse(dtDichVu.Rows[i].Cells[3].Value.ToString().Trim());
            }
            lbTienDV.Text = sum.ToString();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void CbPhat_CheckedChanged(object sender, EventArgs e)
        {
            TinhTienPhat();
        }

        private void DtpNgayThanhToan_ValueChanged(object sender, EventArgs e)
        {
            TinhTienPhat();
        }

        private string getNewMaHD()
        {
            int bonus = 0;
            String[] d = BUS.BUS_LapHoaDon.getDanhSachMaHoaDon();
            string ma = String.Format("HD{0}", d.Length + 1 + bonus);
            while (d.Contains(ma))
            {
                bonus++;
                ma = String.Format("HD{0}", d.Length + 1 + bonus);
            }
            return ma;
        }

        private void BttThanhToan_Click(object sender, EventArgs e)
        {
            DTO.DTO_HoaDonThanhToan hd = new DTO.DTO_HoaDonThanhToan();
            hd.MA_HOA_DON = getNewMaHD();
            hd.MA_TIEC_CUOI = lbMaTiecCuoi.Text;
            hd.NGAY_THANH_TOAN = dtpNgayThanhToan.Value.ToString("yyyy-MM-d");
            hd.TONG_TIEN_BAN = int.Parse(lbTongTienBan.Text) + int.Parse(lbTienDatCoc.Text);
            hd.TONG_TIEN_DICH_VU = int.Parse(lbTienAn.Text) + int.Parse(lbTienDV.Text);
            if (Math.Abs(int.Parse(lbTong.Text.Split('.')[0]) - int.Parse(lbTienThanhToan.Text)) > 1002)
            {
                MessageBox.Show("Số tiền xấp sỉ không được lớn hơn 1000");
                return;
            }
            hd.TONG_TIEN_HOA_DON = int.Parse(lbTienThanhToan.Text);
            bool state =  BUS.BUS_LapHoaDon.themHoaDon(hd);
            if (!state)
            {
                MessageBox.Show("Thanh toán không thành công!");
            }
            else
            {
                MessageBox.Show("Thanh toán thành công!");
                bttThanhToan.Enabled = false;
                lbTienThanhToan.Text = "0";
                LoadDs();
            }
        }

        private void LbMaTiecCuoi_Click(object sender, EventArgs e)
        {
            
        }

        private void CmbMaTiecCuoi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMaTiecCuoi.Text = cmbMaTiecCuoi2.Text;
            HienThiHoaDon(lbMaTiecCuoi.Text);
            bttThanhToan.Enabled = false;
            cmbMaTiecCuoi.Text = "";
        }

        private void LbTienThanhToan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
