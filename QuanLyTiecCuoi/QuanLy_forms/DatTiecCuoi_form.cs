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

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        
        private String GetNewMaKH(bool neww=false)
        {
            if (true)
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

        private void HienThiThongTiKH(object sender, EventArgs e)
        {
            DTO.DTO_KhachHang s = BUS_DatTiecCuoi.getThongTinKhachHang(cmbMaKH.Text);
            if (s != null)
            {
                tbTenChure.Text = s.TEN_CHU_RE;
                tbTenCodau.Text = s.TEN_CO_DAU;
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
                MessageBox.Show("Khach hang da ton tai");
            }
            else
            {
                if (isAllFilledKH())
                {
                    bool state = BUS_DatTiecCuoi.themKhachHang(newkh);
                    if (!state)
                    {
                        MessageBox.Show("Khong Thang Cong");
                    }
                    else
                    {
                        MessageBox.Show("Thang Cong");
                        cmbMaKH.Items.Add(maKH);
                    }
                }
                else
                {
                    MessageBox.Show("Hay dien day du thong tin");
                }
            }

        }
    }
}