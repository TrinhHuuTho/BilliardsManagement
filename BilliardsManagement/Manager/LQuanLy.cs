using System;
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
    public partial class LQuanLy : Form
    {
        public LQuanLy()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            QuanLy quanLy = new QuanLy();
            List<NhanVien> ql = quanLy.GetNV();

            dataGridView1.DataSource = ql;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
