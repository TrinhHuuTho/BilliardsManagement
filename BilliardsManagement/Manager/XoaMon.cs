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
using System.Xml;

namespace BilliardsManagement
{
    public partial class XoaMon : Form
    {
        private List<string> delList;
        public XoaMon()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            delList = new List<string>();
            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
            var dellist2 = doc.Root.Elements("FoodAndDrink").Elements("Name").SkipWhile(item => item.Parent.Element("Name").Value == "--Lựa Chọn Đồ Ăn--");
            var dellist1 = dellist2.SkipWhile(item => item.Parent.Element("Name").Value == "--Lựa Chọn Đồ Uống--");
            var dellist = dellist1.SkipWhile(item => item.Parent.Element("Name").Value == "--Lựa Chọn Món Khác--");

            foreach (var name in dellist)
            {
                delList.Add(name.Value);
            }
            delBox.DataSource = delList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delBox.DataSource = delList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delBox.Text == "")
            {
                MessageBox.Show("Xin Hãy Chọn Món Cần Xóa!");
                return;
            }
            else
            {
                del d = new del();
                d.ShowDialog();
                if (d.myBool)
                {
                    string selectedItem = delBox.SelectedItem.ToString();

                    delList.Remove(selectedItem);

                    XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                    var dellist = doc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Parent.Element("Name")
                    .Value != "--Lựa Chọn Đồ Ăn--" && item.Parent.Element("Name").Value != "--Lựa Chọn Đồ Uống--" && item.Parent.Element("Name")
                    .Value != "--Lựa Chọn Món Khác--").ToList();

                    foreach (var name in dellist)
                    {
                        if (name.Value == selectedItem)
                        {
                            name.Parent.Remove();
                        }
                    }

                    MessageBox.Show("Xóa Món thành Công!");

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");

                    XoaMon rf = new XoaMon();
                    this.Close();
                    rf.ShowDialog();
                }
            }
        }

        private void XoaMon_Load(object sender, EventArgs e)
        {

        }
    }
}
