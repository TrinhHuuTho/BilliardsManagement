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
    public partial class XoaTaiKhoan : Form
    {
        private List<string> delList;
        public XoaTaiKhoan()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            delList = new List<string>();
            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Account.Xml");
            var dellist = doc.Root.Elements("NhanVienBanThoiGian").Elements("Name").SkipWhile(item => item.Parent.Element("User").Value == "admin");

            foreach (var name in dellist)
            {
                delList.Add(name.Value);
            }
            delBox.DataSource = delList;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (delBox.Text == "")
            {
                MessageBox.Show("Xin Hãy Chọn Tài Khoản Cần Xóa!");
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

                    XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Account.Xml");
                    var dellist = doc.Root.Elements("NhanVienBanThoiGian").Elements("Name").SkipWhile(item => item.Parent.Element("User").Value == "admin");

                    foreach (var name in dellist)
                    {
                        if (name.Value == selectedItem)
                        {
                            name.Parent.Remove();
                        }
                    }

                    MessageBox.Show("Xóa Tài Khoản thành Công!");

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Account.Xml");

                    XoaTaiKhoan rf = new XoaTaiKhoan();
                    this.Close();
                    rf.ShowDialog();
                }
            }
        }
    }
}
