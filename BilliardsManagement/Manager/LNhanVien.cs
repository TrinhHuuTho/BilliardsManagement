﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BilliardsManagement
{
    public partial class LNhanVien : Form
    {
        public LNhanVien()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            NhanVienBanThoiGian nv = new NhanVienBanThoiGian();
            List<NhanVienBanThoiGian> lnv = nv.GetNV();

            dataGridView1.DataSource = lnv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
