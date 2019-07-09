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

namespace QuanLyTiecCuoi
{
    public partial class DatTiecCuoi_form : Form
    {
        private (String[], String[]) DsDV;
        private (String[], String[]) DsMA;
        public DatTiecCuoi_form()
        {
            InitializeComponent();
        }

        private void Label27_Click(object sender, EventArgs e)
        {

        }

        private void LoadKhachHang()
        {
            String[] s = BUS.BUS_DatTiecCuoi.getDanhSachMaKhachHang();
            if (s != null)
            {
                cmbMaKH.Items.AddRange(s);
            }
        }

        private void LoadDsMonAn()
        {
            DsMA = BUS.BUS_DatTiecCuoi.getDanhSachTenMonAn();
            if (DsMA.Item2 != null)
            {
                cmbDsMonAn.Items.AddRange(DsMA.Item2);
            }
        }
        private void LoadDTMonAn()
        {
            dtMA.Columns.Add("id", "Mã món ăn");
            dtMA.Columns.Add("name", "Tên món ăn");
            dtMA.Columns.Add("price", "Đơn giá");
            dtMA.Columns.Add("note", "Ghi chú");
            dtMA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMA.ReadOnly = true;
            dtMA.MultiSelect = false;
        }
        private void LoadDTDichVu()
        {
            dtDV.Columns.Add("id", "Mã dịch vụ");
            dtDV.Columns.Add("name", "Tên dịch vụ");
            dtDV.Columns.Add("price", "Số lượng");
            dtDV.Columns.Add("note", "Đơn giá");
            dtDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtDV.ReadOnly = true;
            dtDV.MultiSelect = false;
        }
        private void LoadDsDichVu()
        {
            DsDV = BUS.BUS_DatTiecCuoi.getDanhSachDichVu();
            if (DsDV.Item2 != null)
            {
                cmbDsDichVu.Items.AddRange(DsDV.Item2);
            }
        }
        private void LoadDsTiecCuoi()
        {
            cmbMaTiecCuoi.Items.AddRange(BUS_DatTiecCuoi.getDsMaTiecCuoi());
            cmbSanh.Items.AddRange(BUS_DatTiecCuoi.getDanhSachMaSanh());
            cmbCa.Items.AddRange(BUS_DatTiecCuoi.getDanhSachMaCa());

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadDsTiecCuoi();
            LoadDsMonAn();
            LoadDsDichVu();
        }
        
        private String GetNewMaKH()
        {
            int bonus = 0;
            string ma = String.Format("KH{0}", BUS_DatTiecCuoi.getDanhSachMaKhachHang().Length + 1 + bonus);
            while (BUS_DatTiecCuoi.getDanhSachMaKhachHang().Contains(ma))
            {
                bonus++;
                ma = String.Format("KH{0}", BUS_DatTiecCuoi.getDanhSachMaKhachHang().Length + 1 + bonus);
            }
            return ma;
        }

        private void ClearKHField()
        {
            tbTenChure.Text = "";
            tbTenCodau.Text = "";
            tbSDT.Text = "";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            cmbMaKH.Text = GetNewMaKH();
            ClearKHField();
        }

        private void HienThiThongTinKH(DTO.DTO_KhachHang s)
        {
            if (s != null)
            {
                cmbMaKH.Text = s.MA_KHACH_HANG;
                tbTenChure.Text = s.TEN_CHU_RE;
                tbTenCodau.Text = s.TEN_CO_DAU;
                tbSDT.Text = s.SDT;
            }
            else
            {
                ClearKHField();
            }
        }

        private void LoadThongTinKH(object sender, EventArgs e)
        {
            DTO.DTO_KhachHang s = BUS_DatTiecCuoi.getThongTinKhachHang(cmbMaKH.Text);
            HienThiThongTinKH(s);
        }

        private bool isAllFilledKH()
        {
            if (tbTenChure.Text.Trim() == "")
            {
                return false;
            }
            if (tbTenCodau.Text.Trim() == "")
            {
                return false;
            }
            if (tbSDT.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }


        private void CapNhatThongTinKH(object sender, EventArgs e)
        {
            String maKH = cmbMaKH.Text;
            String tenChure = tbTenChure.Text;
            String tenCoDau = tbTenCodau.Text;
            String sdt = tbSDT.Text;
            DTO.DTO_KhachHang newkh = new DTO.DTO_KhachHang(maKH, tenChure, tenCoDau, sdt);
            if (BUS_DatTiecCuoi.getDanhSachMaKhachHang().Contains(maKH))
            {
                bool state = BUS_DatTiecCuoi.capNhatThongTinKH(newkh);
                if (!state)
                {
                    MessageBox.Show("Không thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
            }
            else
            {
                if (isAllFilledKH())
                {
                    bool state = BUS_DatTiecCuoi.themKhachHang(newkh);
                    if (!state)
                    {
                        MessageBox.Show("Không thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thành công");
                        cmbMaKH.Items.Add(maKH);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin");
                }
            }

        }

        private DTO.DTO_MonAn GetCurMA()
        {
            int id = cmbDsMonAn.SelectedIndex;
            String maMA = DsMA.Item1[id];
            DTO.DTO_MonAn ma;
            ma = BUS.BUS_DatTiecCuoi.getThongTinMonAn(maMA);
            return ma;
        }

        private DTO.DTO_MonAn GetCurMATB()
        {
            String maMA = dtMA.Rows[dtMA.CurrentCell.RowIndex].Cells[0].Value.ToString().Trim();
            DTO.DTO_MonAn ma;
            ma = BUS.BUS_DatTiecCuoi.getThongTinMonAn(maMA);
            return ma;
        }

        private void CmbDsMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTO.DTO_MonAn ma = GetCurMA();            
            lbDonGia.Text = ma.DON_GIA.ToString();
        }

        private void BttThemMA_Click(object sender, EventArgs e)
        {
            if (cmbDsMonAn.SelectedIndex < 0)
                return;
            DTO.DTO_MonAn ma = GetCurMA();
            List<String> d = new List<String>();
            foreach(DataGridViewRow x in dtMA.Rows)
            {
                if (x.Cells[0].Value != null)
                    d.Add(x.Cells[0].Value.ToString().Trim());
            }
            if (d.Contains(ma.MA_MON_AN.Trim()))
            {
                MessageBox.Show("Món ăn đã có trong bảng.");
                return;

            }
            DTO.DTO_DatMonAn dma = new DTO.DTO_DatMonAn();
            dma.MA_TIEC_CUOI = cmbMaTiecCuoi.Text;
            dma.MA_MON_AN = ma.MA_MON_AN;
            dma.GHI_CHU = tbGhiChuMA.Text;
            bool state = BUS.BUS_DatTiecCuoi.themDatMonAn(dma);
            if (!state)
            {
                MessageBox.Show("Lỗi thêm món ăn.");
            }
            HienThiDsMonAn(cmbMaTiecCuoi.Text);


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DTO.DTO_MonAn ma = GetCurMATB();
            DTO.DTO_DatMonAn dma = new DTO.DTO_DatMonAn();
            dma.MA_TIEC_CUOI = cmbMaTiecCuoi.Text;
            dma.MA_MON_AN = ma.MA_MON_AN;
            BUS_DatTiecCuoi.xoaDatMonAn(dma);
            HienThiDsMonAn(cmbMaTiecCuoi.Text);
        }
        private void HienThiThongTinTC(DTO.DTO_TiecCuoi tc)
        {
            DTO.DTO_Sanh s = BUS_DatTiecCuoi.getThongTinSanh(tc.MA_SANH);
            DTO.DTO_Ca c = BUS_DatTiecCuoi.getThongTinCa(tc.MA_CA);
            dateTimePicker1.Text = tc.NGAY_TO_CHUC;
            cmbCa.Text = c.MA_CA;

        }

        private void HienThiDsMonAn(String maTC)
        {
            dtMA.DataSource = BUS_DatTiecCuoi.getDsMonAnDaDat(maTC);
            if (dtMA.Columns.Count == 0)
                return;
            dtMA.Columns[0].HeaderText = "Mã Món ăn";
            dtMA.Columns[1].HeaderText = "Tên món ăn";
            dtMA.Columns[2].HeaderText = "Đơn giá";
            dtMA.Columns[3].HeaderText = "Ghi chú";
            dtMA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMA.ReadOnly = true;
            dtMA.MultiSelect = false;
        }

        private void HienThiDsDichVu(String maTC)
        {
            dtDV.DataSource = BUS.BUS_DatTiecCuoi.getDsDichVuDaDat(maTC);
            if (dtDV.Columns.Count == 0)
                return;
            dtDV.Columns[0].HeaderText = "Mã Dịch vụ";
            dtDV.Columns[1].HeaderText = "Tên Dịch vụ";
            dtDV.Columns[2].HeaderText = "Số Lượng";
            dtDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtDV.ReadOnly = true;
            dtDV.MultiSelect = false;
        }

        private void CapNhatBtt(string maTC)
        {
            if (BUS_DatTiecCuoi.getDsMaTiecCuoi().Contains(maTC))
            {
                bttThemMA.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                bttThemMA.Enabled = false;
                button3.Enabled = false;
            }
        
        }

        private void CmbMaTiecCuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maTC = cmbMaTiecCuoi.Text;
            DTO.DTO_TiecCuoi tc = BUS_DatTiecCuoi.getThongTinTiecCuoi(maTC);
            DTO.DTO_KhachHang kh = BUS_DatTiecCuoi.getThongTinKhachHang(tc.MA_KHACH_HANG);
            cmbSanh.Text = tc.MA_SANH.Trim();
            cmbCa.Text = tc.MA_CA.Trim();
            numSLBan.Value = tc.SL_BAN;
            numSLDuTru.Value = tc.SL_BAN_DU_TRU;
            tbDatCoc.Text = tc.TIEN_DAT_COC.ToString();
            HienThiThongTinKH(kh);
            HienThiThongTinTC(tc);
            HienThiDsMonAn(maTC);
            HienThiDsDichVu(maTC);
            CapNhatBtt(maTC);

        }

        private void DtMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDsMonAn.Text = dtMA.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            lbDonGia.Text = dtMA.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbGhiChuMA.Text = dtMA.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TinhTienBan()
        {
            if (cmbSanh.Text == "")
                return;
            String maLs = BUS.BUS_DatTiecCuoi.getThongTinSanh(cmbSanh.Text).MA_LOAI_SANH;
            int dongia = BUS_DatTiecCuoi.getThongTinLoaiSanh(maLs).DON_GIA_TOI_THIEU;
            lbTienBan.Text = (dongia * numSLBan.Value).ToString() + " + " + (dongia * numSLDuTru.Value).ToString();
        }

        private void CmbSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTienBan();
        }

        private bool CheckThongTinTC()
        {
            if (cmbMaTiecCuoi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có mã tiệc cưới.");
                return false;
            }
            if (cmbMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn khách hàngi.");
                return false;
            }
            if (cmbSanh.Text.Trim() == "")
            {
                MessageBox.Show("Chưa Sảnh.");
                return false;
            }
            if (cmbCa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn ca.");
                return false;
            }
            if (dateTimePicker1.Value < DateTime.Today)
            {
                MessageBox.Show("Không được chọn ngày trong quá khứ.");
                return false;
            }
            if (int.Parse((numSLBan.Value + numSLDuTru.Value).ToString()) > BUS_DatTiecCuoi.getThongTinSanh(cmbSanh.Text).SO_LUONG_BAN)
            {
                MessageBox.Show("Số lượng bàn đã đặt vượt quá số lượng bàn của sảnh.");
                return false;
            }
            return true;
        }

        private void Button9_Click(object sender, EventArgs e)
        { 
            bool state = CheckThongTinTC();
            if (!state)
            {
                return;
            }
            String maTC = cmbMaTiecCuoi.Text;
            String maKH = cmbMaKH.Text;
            String maS = cmbSanh.Text;
            String maCa = cmbCa.Text;
            String ngayToChuc = dateTimePicker1.Value.ToString("yyyy-MM-dd"); ;
            int tienDatCoc = int.Parse(tbDatCoc.Text);
            int slBan = int.Parse(numSLBan.Value.ToString());
            int slDuTru = int.Parse(numSLDuTru.Value.ToString());
            DTO.DTO_TiecCuoi tc = new DTO.DTO_TiecCuoi(maTC,maKH,maS,ngayToChuc,maCa,tienDatCoc,slBan,slDuTru);
            if (BUS_DatTiecCuoi.getDsMaTiecCuoi().Contains(maTC))
            {
                if(BUS_DatTiecCuoi.capNhatThongTinTiecCuoi(tc))
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            else
            {
                if(BUS_DatTiecCuoi.themTiecCuoi(tc))
                {
                    MessageBox.Show("Thêm thành công.");
                    cmbMaTiecCuoi.Items.Add(maTC);
                    CapNhatBtt(maTC);
                    
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
            }
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<(String,String)> ds = new List<(String,String)>();

            foreach (DataGridViewRow x in dtMA.Rows)
            {
                if (x.Cells["id"].Value != null)
                    ds.Add((x.Cells["id"].Value.ToString(), x.Cells["note"].Value.ToString()));
            }



            foreach ((string x, string y) in ds)
            {
                DTO.DTO_DatMonAn dma = new DTO.DTO_DatMonAn();
                dma.MA_TIEC_CUOI = cmbMaTiecCuoi.Text;
                dma.MA_MON_AN = x;
                dma.GHI_CHU = y;
                bool state =  BUS.BUS_DatTiecCuoi.themDatMonAn(dma);
                if (!state)
                {
                    MessageBox.Show("Lỗi thêm món:"+ x);
                }
            }
            
        }

        private String GetNewMaTC()
        {
            int bonus = 0;
            string ma = String.Format("TC{0}", BUS_DatTiecCuoi.getDsMaTiecCuoi().Length + 1 + bonus);
            while (BUS_DatTiecCuoi.getDsMaTiecCuoi().Contains(ma))
            {
                bonus++;
                ma = String.Format("TC{0}", BUS_DatTiecCuoi.getDsMaTiecCuoi().Length + 1 + bonus);
            }
            return ma;
        }

        private void ClearTCField()
        {
            dateTimePicker1.Value = DateTime.Today;
            cmbCa.Text = "";
            numSLBan.Value = 0;
            numSLDuTru.Value = 0;
            cmbSanh.Text = "";
            tbDatCoc.Text = "0";
            lbConlai.Text = "0";
            lbTienBan.Text = "0";
        }

        private void BttThemDT_Click(object sender, EventArgs e)
        {
            String maTC = GetNewMaTC();
            cmbMaTiecCuoi.Text = maTC;
            ClearTCField();
            CapNhatBtt(maTC);
        }

        private void NumSLBan_ValueChanged(object sender, EventArgs e)
        {
            TinhTienBan();
        }

        private void NumSLDuTru_ValueChanged(object sender, EventArgs e)
        {
            TinhTienBan();
        }
        private DTO.DTO_DichVu GetCurDV()
        {
            int id = cmbDsDichVu.SelectedIndex;
            String maDV = DsDV.Item1[id];
            DTO.DTO_DichVu dv;
            dv = BUS.BUS_DatTiecCuoi.getThongTinDichVu(maDV);
            return dv;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (cmbDsDichVu.SelectedIndex < 0)
                return;
            DTO.DTO_DichVu dv = GetCurDV();
            List<String> d = new List<String>();
            foreach (DataGridViewRow x in dtDV.Rows)
            {
                if (x.Cells[0].Value != null)
                    d.Add(x.Cells[0].Value.ToString().Trim());
            }
            if (d.Contains(dv.MA_DICH_VU.Trim()))
            {
                MessageBox.Show("Dịch vụ đã có trong bảng.");
                return;

            }
            DTO.DTO_DatDichVu ddv = new DTO.DTO_DatDichVu();
            ddv.MA_TIEC_CUOI = cmbMaTiecCuoi.Text;
            ddv.MA_DICH_VU = dv.MA_DICH_VU;
            ddv.SO_LUONG = numericUpDown1.Text;
            bool state = BUS.BUS_DatTiecCuoi.themDatDichVu(ddv);
            if (!state)
            {
                MessageBox.Show("Lỗi thêm dịch vụ.");
            }
            HienThiDsDichVu(cmbMaTiecCuoi.Text);
        }
    }
}