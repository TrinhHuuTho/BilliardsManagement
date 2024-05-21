using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BilliardsManagement
{
    public partial class LFoodAndDrink : Form
    {
        public LFoodAndDrink()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            List<FoodAndDrink> fad = new List<FoodAndDrink>();
            XmlSerializer serial = new XmlSerializer(typeof(List<FoodAndDrink>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.xml", FileMode.Open, FileAccess.Read))
            {
                fad = serial.Deserialize(fs) as List<FoodAndDrink>;
            }
            fad = fad.Where(f => f.Name != "--Lựa Chọn Đồ Ăn--" && f.Name != "--Lựa Chọn Đồ Uống--" && f.Name != "--Lựa Chọn Món Khác--").ToList();
            fad.Sort((f1, f2) => f1.Type.CompareTo(f2.Type));
            dataGridView1.DataSource = fad;
        }

        private void LFoodAndDrink_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
