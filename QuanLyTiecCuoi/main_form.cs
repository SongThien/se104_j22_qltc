using QuanLyTiecCuoi.QuanLy_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {
            BUS.BUS_Main.taoKetNoi();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatTiecCuoi_Click(object sender, EventArgs e)
        {
            Form datTiecCuoi = new DatTiecCuoi_form();
            datTiecCuoi.MdiParent = this;
            datTiecCuoi.Show();
        }

        private void TiepNhanSanh_Click(object sender, EventArgs e)
        {
            Form x = new TiepNhanSanh_form();
            x.MdiParent = this;
            x.Show();
        }

        private void LapHoaDon_Click(object sender, EventArgs e)
        {
            Form x = new LapHoaDon_form();
            x.MdiParent = this;
            x.Show();
        }

        private void TraTiệcCướiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new DanhSachTiecCuoi_form();
            x.MdiParent = this;
            x.Show();
        }

        private void DichVu_Click(object sender, EventArgs e)
        {
            Form x = new ThemDichVu_Form();
            x.MdiParent = this;
            x.Show();
        }

        private void MonAn_Click(object sender, EventArgs e)
        {
            Form x = new themMonAn_form();
            x.MdiParent = this;
            x.Show();
        }

        private void Ca_Click(object sender, EventArgs e)
        {
            Form x = new ThemCa_form();
            x.MdiParent = this;
            x.Show();
        }

        private void BaoCao_Click(object sender, EventArgs e)
        {
            Form x = new BaoCaoDoandSo_form();
            x.MdiParent = this;
            x.Show();
        }

        private void ThửKếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = BUS.BUS_Main.thuKetNoi();
            if (state)
            {
                MessageBox.Show("Kết nối thành công");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }
    }
}
