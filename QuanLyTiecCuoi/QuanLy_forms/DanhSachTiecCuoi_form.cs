using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BUS;
namespace QuanLyTiecCuoi.QuanLy_forms
{
    public partial class DanhSachTiecCuoi_form : Form
    {
        public DanhSachTiecCuoi_form()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable f;
            f = BUS_QuanLyLoaiSanh.GetLoaiSanhTable();
            dataGridView1.DataSource = f;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //something
        }
    }
}
