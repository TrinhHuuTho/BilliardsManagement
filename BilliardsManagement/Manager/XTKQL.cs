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

namespace BilliardsManagement
{
    public partial class XTKQL : Form
    {
        public static string name;
        private List<string> delList;

        public XTKQL()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            delList = new List<string>();
            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Manager.Xml");
            var dellist = doc.Root.Elements("QuanLy").Elements("Name");

            foreach (var name in dellist)
            {
                delList.Add(name.Value);
            }
            delBox.DataSource = delList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = delBox.SelectedItem.ToString();

            if (name == selectedItem)
            {
                MessageBox.Show("Không Thể Xóa Tài Khoản Đang Đăng Nhập!");
                return;
            }
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

                    delList.Remove(selectedItem);

                    XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Manager.Xml");
                    var dellist = doc.Root.Elements("QuanLy").Elements("Name");

                    foreach (var name in dellist)
                    {
                        if (name.Value == selectedItem)
                        {
                            name.Parent.Remove();
                        }
                    }

                    MessageBox.Show("Xóa Tài Khoản thành Công!");

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Manager.Xml");

                    XTKQL rf = new XTKQL();
                    this.Close();
                    rf.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
