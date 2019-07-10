namespace QuanLyTiecCuoi
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tVu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tC = new System.Windows.Forms.ToolStripMenuItem();
            this.TiepNhanSanh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DatTiecCuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.traTiệcCướiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.dV = new System.Windows.Forms.ToolStripMenuItem();
            this.DichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.qL = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.Ca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tVu,
            this.tC,
            this.dV,
            this.qL});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // tVu
            // 
            this.tVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.tVu.Name = "tVu";
            this.tVu.Size = new System.Drawing.Size(53, 20);
            this.tVu.Text = "Tác vụ";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(105, 22);
            this.Exit.Text = "Thoát";
            this.Exit.Click += new System.EventHandler(this.exitProgram);
            // 
            // tC
            // 
            this.tC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TiepNhanSanh,
            this.toolStripSeparator1,
            this.DatTiecCuoi,
            this.traTiệcCướiToolStripMenuItem,
            this.toolStripSeparator2,
            this.LapHoaDon});
            this.tC.Name = "tC";
            this.tC.Size = new System.Drawing.Size(67, 20);
            this.tC.Text = "Tiệc cưới";
            // 
            // TiepNhanSanh
            // 
            this.TiepNhanSanh.Name = "TiepNhanSanh";
            this.TiepNhanSanh.Size = new System.Drawing.Size(155, 22);
            this.TiepNhanSanh.Text = "Tiếp nhận sảnh";
            this.TiepNhanSanh.Click += new System.EventHandler(this.TiepNhanSanh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // DatTiecCuoi
            // 
            this.DatTiecCuoi.Name = "DatTiecCuoi";
            this.DatTiecCuoi.Size = new System.Drawing.Size(155, 22);
            this.DatTiecCuoi.Text = "Đặt tiệc cưới";
            this.DatTiecCuoi.Click += new System.EventHandler(this.DatTiecCuoi_Click);
            // 
            // traTiệcCướiToolStripMenuItem
            // 
            this.traTiệcCướiToolStripMenuItem.Name = "traTiệcCướiToolStripMenuItem";
            this.traTiệcCướiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.traTiệcCướiToolStripMenuItem.Text = "Tra tiệc cưới";
            this.traTiệcCướiToolStripMenuItem.Click += new System.EventHandler(this.TraTiệcCướiToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // LapHoaDon
            // 
            this.LapHoaDon.Name = "LapHoaDon";
            this.LapHoaDon.Size = new System.Drawing.Size(155, 22);
            this.LapHoaDon.Text = "Lập hoá đơn";
            this.LapHoaDon.Click += new System.EventHandler(this.LapHoaDon_Click);
            // 
            // dV
            // 
            this.dV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DichVu,
            this.MonAn});
            this.dV.Name = "dV";
            this.dV.Size = new System.Drawing.Size(59, 20);
            this.dV.Text = "Dịch vu";
            // 
            // DichVu
            // 
            this.DichVu.Name = "DichVu";
            this.DichVu.Size = new System.Drawing.Size(115, 22);
            this.DichVu.Text = "Dịch vụ";
            this.DichVu.Click += new System.EventHandler(this.DichVu_Click);
            // 
            // MonAn
            // 
            this.MonAn.Name = "MonAn";
            this.MonAn.Size = new System.Drawing.Size(115, 22);
            this.MonAn.Text = "Món ăn";
            this.MonAn.Click += new System.EventHandler(this.MonAn_Click);
            // 
            // qL
            // 
            this.qL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaoCao,
            this.Ca});
            this.qL.Name = "qL";
            this.qL.Size = new System.Drawing.Size(60, 20);
            this.qL.Text = "Quản lý";
            // 
            // BaoCao
            // 
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Size = new System.Drawing.Size(180, 22);
            this.BaoCao.Text = "Báo cáo tháng";
            this.BaoCao.Click += new System.EventHandler(this.BaoCao_Click);
            // 
            // Ca
            // 
            this.Ca.Name = "Ca";
            this.Ca.Size = new System.Drawing.Size(180, 22);
            this.Ca.Text = "Quản lý ca";
            this.Ca.Click += new System.EventHandler(this.Ca_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 721);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_form";
            this.Text = "Quản lý Tiệc cưới";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tVu;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem tC;
        private System.Windows.Forms.ToolStripMenuItem TiepNhanSanh;
        private System.Windows.Forms.ToolStripMenuItem DatTiecCuoi;
        private System.Windows.Forms.ToolStripMenuItem LapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem dV;
        private System.Windows.Forms.ToolStripMenuItem DichVu;
        private System.Windows.Forms.ToolStripMenuItem MonAn;
        private System.Windows.Forms.ToolStripMenuItem qL;
        private System.Windows.Forms.ToolStripMenuItem BaoCao;
        private System.Windows.Forms.ToolStripMenuItem Ca;
        private System.Windows.Forms.ToolStripMenuItem traTiệcCướiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}