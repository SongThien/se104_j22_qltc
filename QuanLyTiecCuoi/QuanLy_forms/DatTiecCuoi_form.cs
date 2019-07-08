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
        private void LoadDsDichVu()
        {
            DsDV = BUS.BUS_DatTiecCuoi.getDanhSachDichVu();
            if (DsDV.Item2 != null)
            {
                cmbDsDichVu.Items.AddRange(DsDV.Item2);
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadDsMonAn();
            LoadDsDichVu();
            LoadDTMonAn();
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
            tbSNCR.Text = "";
            tbSNCD.Text = "";
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

        private void HienThiThongTiKH(object sender, EventArgs e)
        {
            DTO.DTO_KhachHang s = BUS_DatTiecCuoi.getThongTinKhachHang(cmbMaKH.Text);
            if (s != null)
            {
                tbTenChure.Text = s.TEN_CHU_RE;
                tbTenCodau.Text = s.TEN_CO_DAU;
                tbSNCR.Text = s.NS_CHU_RE;
                tbSNCD.Text = s.NS_CO_DAU;
                tbSDT.Text = s.SDT;
            }
            else
            {
                ClearKHField();
            }
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
            if (tbSNCR.Text.Trim() == "")
            {
                return false;
            }
            if (tbSNCD.Text.Trim() == "")
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
            String snChuRe = tbSNCR.Text;
            String snCoDau = tbSNCD.Text;
            String sdt = tbSDT.Text;
            DTO.DTO_KhachHang newkh = new DTO.DTO_KhachHang(maKH, tenChure, tenCoDau,snChuRe, snCoDau, sdt);
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
            dtMA.Rows.Add(ma.MA_MON_AN, ma.TEN_MON_AN, ma.DON_GIA, tbGhiChuMA.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dtMA.Rows.Remove(dtMA.CurrentRow);
        }

        private void CmbMaTiecCuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            String maTC = cmbMaTiecCuoi.SelectedText;

        }
    }
}