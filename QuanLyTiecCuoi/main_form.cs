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
    }
}
