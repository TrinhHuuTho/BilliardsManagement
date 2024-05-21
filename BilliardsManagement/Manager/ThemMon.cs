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
    public partial class ThemMon : Form
    {
        XmlSerializer xs;
        List<FoodAndDrink> FAD;
        public ThemMon()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;



            FAD = new List<FoodAndDrink>();
            xs = new XmlSerializer(typeof(List<FoodAndDrink>));


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = priceText.Text;
            if (!int.TryParse(value, out int number))
            {
                MessageBox.Show("Vui Lòng Nhập Giá Món Ăn!");
                priceText.Text = "";
                return;
            }    
            if (nameText.Text == "" || typeBox.Text == "" || priceText.Text == "")
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin Món Cần Thêm!!!");
                return;
            }
            FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml", FileMode.Open, FileAccess.Read);
            FAD = (List<FoodAndDrink>)xs.Deserialize(fs);
            fs.Close();

            bool check = false;
            for (int i = 0; i < FAD.Count; i++)
            {
                if (FAD[i].Name == nameText.Text)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                MessageBox.Show("Tên Món Đã Tồn Tại, Xin Hãy Nhập Tên Món Khác!");
                return;
            }

            FoodAndDrink fd = new FoodAndDrink();
            fd.Name = nameText.Text;
            fd.Type = typeBox.Text;
            fd.Price = int.Parse(priceText.Text);
            fd.SL = 1;

            FAD.Add(fd);

            fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, FAD);
            fs.Close();

            MessageBox.Show("Thêm Món Thành Công!!!");

            nameText.Clear();
            priceText.Clear();
            typeBox.SelectedIndex = -1;
        }

        private void ThemMon_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
