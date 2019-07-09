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

namespace QuanLyTiecCuoi
{
    public partial class DatTiecCuoi_form : Form
    {
        private int bonus;
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
            String[] s = BUS.BUS_DatTiecCuoi.getDanhSachKhachHang();
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
            String[] s = BUS_DatTiecCuoi.getDsMaTiecCuoi();
            cmbMaTiecCuoi.Items.AddRange(s);

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
            LoadDTMonAn();
            LoadDTDichVu();
        }
        
        private String GetNewMaKH(bool neww=false)
        {
            if (neww)
            {
                bonus ++;
                return String.Format("KH{0}", BUS_DatTiecCuoi.getDanhSachKhachHang().Length + 1 + bonus);
            }
            return String.Format("KH{0}", BUS_DatTiecCuoi.getDanhSachKhachHang().Length + 1);
        }

        private void ClearKHField()
        {
            tbTenChure.Text = "";
            tbTenCodau.Text = "";
            tbSDT.Text = "";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            String maKH;
            maKH = GetNewMaKH();
            while (BUS_DatTiecCuoi.getDanhSachKhachHang().Contains(maKH))
            {
                maKH = GetNewMaKH(true);
            }
            bonus = 0;
            cmbMaKH.Text = maKH;
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
            if (BUS_DatTiecCuoi.getDanhSachKhachHang().Contains(maKH))
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
                if (x.Cells["id"].Value != null)
                    d.Add(x.Cells["id"].Value.ToString());
            }
            if (d.Contains(ma.MA_MON_AN))
            {
                MessageBox.Show("Món ăn đã có trong bảng.");
                return;
            }
            dtMA.Rows.Add(ma.MA_MON_AN, ma.TEN_MON_AN, ma.DON_GIA, tbGhiChuMA.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dtMA.Rows.Remove(dtMA.CurrentRow);
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
        }

        private void HienThiDsDichVu(String maTC)
        {

        }

        private void CmbMaTiecCuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maTC = cmbMaTiecCuoi.Text;
            DTO.DTO_TiecCuoi tc = BUS_DatTiecCuoi.getThongTinTiecCuoi(maTC);
            DTO.DTO_KhachHang kh = BUS_DatTiecCuoi.getThongTinKhachHang(tc.MA_KHACH_HANG);
            DTO.DTO_Sanh s = BUS_DatTiecCuoi.getThongTinSanh(tc.MA_SANH);
            cmbSanh.Text = s.MA_LOAI_SANH;
            numSLBan.Value = tc.SL_BAN;
            numSLDuTru.Value = tc.SL_BAN_DU_TRU;
            tbDatCoc.Text = tc.TIEN_DAT_COC.ToString();
            HienThiThongTinKH(kh);
            HienThiThongTinTC(tc);
            HienThiDsMonAn(maTC);
            HienThiDsDichVu(maTC);

        }

        private void DtMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDsMonAn.Text = dtMA.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbDonGia.Text = dtMA.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbGhiChuMA.Text = dtMA.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbSanh_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            MessageBox.Show(ngayToChuc);
            int tienDatCoc = int.Parse(tbDatCoc.Text);
            int slBan = int.Parse(numSLBan.Value.ToString());
            int slDuTru = int.Parse(numSLDuTru.ToString());
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
                bool state =  BUS.BUS_DatTiecCuoi.themDatMonAn(cmbMaTiecCuoi.Text, x, y);
                if (!state)
                {
                    MessageBox.Show("Lỗi thêm món:"+ x);
                }
            }
            
        }
    }
}