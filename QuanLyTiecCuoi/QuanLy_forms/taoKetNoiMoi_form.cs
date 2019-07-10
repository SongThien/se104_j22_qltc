using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiecCuoi.QuanLy_forms
{
    public partial class taoKetNoiMoi_form : Form
    {
        public taoKetNoiMoi_form()
        {
            InitializeComponent();
        }

        private void Loadtb()
        {
            if (cmbAuthen.Text == "Windows Authentication")
            {
                tbUser.Enabled = false;
                tbPass.Enabled = false;
            }
            else
            {
                tbUser.Enabled = true;
                tbPass.Enabled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadtb();
        }

        private void LoadConfig()
        {
            string cnnstring = File.ReadAllText("CONNECTION_STRING.ini");
            Match m = Regex.Match(cnnstring, "Data Source=(.*?);Initial Catalog=(.*?);");
            if (m.Success)
            {
                tbSever.Text = m.Groups[1].Value;
                tbDatabase.Text = m.Groups[2].Value;
                if (m.Groups.Count > 3)
                {
                    MessageBox.Show(m.Groups[0].Value);
                    cmbAuthen.Text = "SQL Sever Authentication";
                    tbUser.Text = m.Groups[3].Value;
                    tbPass.Text = m.Groups[4].Value;
                }
                else
                {
                    cmbAuthen.Text = "Windows Authentication";
                }
            }
            m = Regex.Match(cnnstring, "User ID=(.*?);Password=(.+)");
            if (m.Success)
            {
                cmbAuthen.Text = "SQL Sever Authentication";
                tbUser.Text = m.Groups[1].Value;
                tbPass.Text = m.Groups[2].Value;
            }
            else
            {
                cmbAuthen.Text = "Windows Authentication";
            }




        }

        private void TaoKetNoiMoi_form_Load(object sender, EventArgs e)
        {
            cmbAuthen.Text = "Windows Authentication";
            LoadConfig();
        }


        private void BttUpdate_Click(object sender, EventArgs e)
        {
            if (cmbAuthen.Text == "Windows Authentication")
            {
                string cnnstring = String.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", tbSever.Text.Trim(), tbDatabase.Text.Trim());
                File.WriteAllText("CONNECTION_STRING.ini", cnnstring);
            }
            else
            {
                string cnnstring = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", tbSever.Text.Trim(), tbDatabase.Text.Trim(),tbUser.Text.Trim(),tbPass.Text.Trim());
                File.WriteAllText("CONNECTION_STRING.ini", cnnstring);
            }
            bool state = BUS.BUS_Main.thuKetNoi();
            if (state)
            {
                MessageBox.Show("Kết nối thành công!");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại!");
            }
        }
        private void BttTest_Click(object sender, EventArgs e)
        {
            
        }

        private void TbSever_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
