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
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;

namespace BilliardsManagement
{
    public partial class LBill : Form
    {
        public LBill()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            List<NhatKyBill> nk = new List<NhatKyBill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<NhatKyBill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml", FileMode.Open, FileAccess.Read))
            {
                nk = serial.Deserialize(fs) as List<NhatKyBill>;
            }
            nk.Sort((f0, f1) => f0.DateTime.CompareTo(f1.DateTime));
            dataGridView1.DataSource = nk;

            int total = 0;
            for (int i = 0; i < nk.Count; i++)
            {
                total += nk[i].Price;
            }
            ThanhTien.Text = total.ToString() + " VNĐ";
        }
        private void LBill_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ThanhTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
