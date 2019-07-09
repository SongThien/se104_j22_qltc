namespace QuanLyTiecCuoi
{
    partial class TiepNhanSanh_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvLoaiSanh = new System.Windows.Forms.DataGridView();
            this.btnXoaloai = new System.Windows.Forms.Button();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.btnSuaLoai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenLoaiSanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvDanhSachSanh = new System.Windows.Forms.DataGridView();
            this.btnXoaSanh = new System.Windows.Forms.Button();
            this.btnSuaSanh = new System.Windows.Forms.Button();
            this.btnThemSanh = new System.Windows.Forms.Button();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.soLuongban = new System.Windows.Forms.NumericUpDown();
            this.ghiChu = new System.Windows.Forms.TextBox();
            this.LoaiSanh = new System.Windows.Forms.ComboBox();
            this.txtTenSanh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLoaiSanh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongban)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvLoaiSanh);
            this.groupBox1.Controls.Add(this.btnXoaloai);
            this.groupBox1.Controls.Add(this.btnThemLoai);
            this.groupBox1.Controls.Add(this.btnSuaLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenLoaiSanh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(590, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại sảnh";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // DgvLoaiSanh
            // 
            this.DgvLoaiSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLoaiSanh.Location = new System.Drawing.Point(21, 148);
            this.DgvLoaiSanh.Name = "DgvLoaiSanh";
            this.DgvLoaiSanh.Size = new System.Drawing.Size(240, 160);
            this.DgvLoaiSanh.TabIndex = 9;
            this.DgvLoaiSanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // btnXoaloai
            // 
            this.btnXoaloai.Location = new System.Drawing.Point(183, 97);
            this.btnXoaloai.Name = "btnXoaloai";
            this.btnXoaloai.Size = new System.Drawing.Size(75, 23);
            this.btnXoaloai.TabIndex = 8;
            this.btnXoaloai.Text = "Xoá";
            this.btnXoaloai.UseVisualStyleBackColor = true;
            this.btnXoaloai.Click += new System.EventHandler(this.BtnXoaloai_Click);
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(21, 97);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(75, 23);
            this.btnThemLoai.TabIndex = 7;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Location = new System.Drawing.Point(102, 97);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLoai.TabIndex = 6;
            this.btnSuaLoai.Text = "Cập nhật";
            this.btnSuaLoai.UseVisualStyleBackColor = true;
            this.btnSuaLoai.Click += new System.EventHandler(this.BtnSuaLoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(96, 66);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(162, 20);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtTenLoaiSanh
            // 
            this.txtTenLoaiSanh.Location = new System.Drawing.Point(96, 39);
            this.txtTenLoaiSanh.Name = "txtTenLoaiSanh";
            this.txtTenLoaiSanh.Size = new System.Drawing.Size(162, 20);
            this.txtTenLoaiSanh.TabIndex = 1;
            this.txtTenLoaiSanh.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvDanhSachSanh);
            this.groupBox2.Controls.Add(this.btnXoaSanh);
            this.groupBox2.Controls.Add(this.btnSuaSanh);
            this.groupBox2.Controls.Add(this.btnThemSanh);
            this.groupBox2.Controls.Add(this.lbDonGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.soLuongban);
            this.groupBox2.Controls.Add(this.ghiChu);
            this.groupBox2.Controls.Add(this.LoaiSanh);
            this.groupBox2.Controls.Add(this.txtTenSanh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 489);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhận sảnh";
            // 
            // DgvDanhSachSanh
            // 
            this.DgvDanhSachSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDanhSachSanh.Location = new System.Drawing.Point(24, 231);
            this.DgvDanhSachSanh.Name = "DgvDanhSachSanh";
            this.DgvDanhSachSanh.Size = new System.Drawing.Size(494, 235);
            this.DgvDanhSachSanh.TabIndex = 19;
            this.DgvDanhSachSanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnXoaSanh
            // 
            this.btnXoaSanh.Location = new System.Drawing.Point(443, 97);
            this.btnXoaSanh.Name = "btnXoaSanh";
            this.btnXoaSanh.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSanh.TabIndex = 18;
            this.btnXoaSanh.Text = "Xoá";
            this.btnXoaSanh.UseVisualStyleBackColor = true;
            this.btnXoaSanh.Click += new System.EventHandler(this.BtnXoaSanh_Click);
            // 
            // btnSuaSanh
            // 
            this.btnSuaSanh.Location = new System.Drawing.Point(443, 67);
            this.btnSuaSanh.Name = "btnSuaSanh";
            this.btnSuaSanh.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSanh.TabIndex = 17;
            this.btnSuaSanh.Text = "Cập nhật";
            this.btnSuaSanh.UseVisualStyleBackColor = true;
            this.btnSuaSanh.Click += new System.EventHandler(this.BtnSuaSanh_Click);
            // 
            // btnThemSanh
            // 
            this.btnThemSanh.Location = new System.Drawing.Point(443, 36);
            this.btnThemSanh.Name = "btnThemSanh";
            this.btnThemSanh.Size = new System.Drawing.Size(75, 23);
            this.btnThemSanh.TabIndex = 16;
            this.btnThemSanh.Text = "Thêm";
            this.btnThemSanh.UseVisualStyleBackColor = true;
            this.btnThemSanh.Click += new System.EventHandler(this.Button4_Click);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(304, 73);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(13, 13);
            this.lbDonGia.TabIndex = 15;
            this.lbDonGia.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Đơn giá: ";
            // 
            // soLuongban
            // 
            this.soLuongban.Location = new System.Drawing.Point(127, 113);
            this.soLuongban.Name = "soLuongban";
            this.soLuongban.Size = new System.Drawing.Size(85, 20);
            this.soLuongban.TabIndex = 13;
            this.soLuongban.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // ghiChu
            // 
            this.ghiChu.Location = new System.Drawing.Point(127, 148);
            this.ghiChu.Multiline = true;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(391, 60);
            this.ghiChu.TabIndex = 12;
            // 
            // LoaiSanh
            // 
            this.LoaiSanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiSanh.FormattingEnabled = true;
            this.LoaiSanh.Location = new System.Drawing.Point(127, 70);
            this.LoaiSanh.Name = "LoaiSanh";
            this.LoaiSanh.Size = new System.Drawing.Size(115, 21);
            this.LoaiSanh.TabIndex = 11;
            this.LoaiSanh.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // txtTenSanh
            // 
            this.txtTenSanh.Location = new System.Drawing.Point(127, 40);
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(290, 20);
            this.txtTenSanh.TabIndex = 7;
            this.txtTenSanh.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng bàn tối đa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại sảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sảnh";
            // 
            // TiepNhanSanh_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TiepNhanSanh_form";
            this.Text = "Tiếp  nhận sảnh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLoaiSanh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDanhSachSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenLoaiSanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.Button btnSuaLoai;
        private System.Windows.Forms.Button btnXoaloai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaSanh;
        private System.Windows.Forms.Button btnSuaSanh;
        private System.Windows.Forms.Button btnThemSanh;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown soLuongban;
        private System.Windows.Forms.TextBox ghiChu;
        private System.Windows.Forms.ComboBox LoaiSanh;
        private System.Windows.Forms.TextBox txtTenSanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvLoaiSanh;
        private System.Windows.Forms.DataGridView DgvDanhSachSanh;
    }
}

