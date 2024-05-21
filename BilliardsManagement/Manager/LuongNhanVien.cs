using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BilliardsManagement
{
    public partial class LuongNhanVien : Form
    {
        private List<string> BList;
        public LuongNhanVien()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            BList = new List<string>();
            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\luong.Xml");
            var Blist = doc.Root.Elements("luong").Elements("Name");

            foreach (var name in Blist)
            {
                BList.Add(name.Value);
            }
            delBox.DataSource = BList;

            delBox.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = delBox.SelectedItem.ToString();

            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\luong.Xml");

            var element = doc.Root.Elements("luong").Where(x => x.Element("Name").Value == selectedItem).FirstOrDefault();

            string soGioLam = element.Element("Hour").Value;

            SoGiolam.Text = soGioLam + " Giờ";

            LuongTra.Text = (int.Parse(soGioLam) * 20000).ToString() + " VNĐ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delBox.Text == "")
            {
                MessageBox.Show("Xin Hãy Chọn Nhân Viên Cần Trả Lương!");
                return;
            }
            else
            {
                string selectedItem = delBox.SelectedItem.ToString();

                BList.Remove(selectedItem);

                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\luong.Xml");
                var dellist = doc.Root.Elements("luong").Elements("Name").ToList();

                foreach (var name in dellist)
                {
                    if (name.Value == selectedItem)
                    {
                        name.Parent.Remove();
                    }
                }

                MessageBox.Show("Trả Lương thành Công!");

                doc.Save(@"C:\\Users\\Public\\BilliardManagement\\luong.Xml");

                LuongNhanVien rf = new LuongNhanVien();
                this.Close();
                rf.ShowDialog();
            }
        }

        private void TongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void LuongTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void LuongNhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
