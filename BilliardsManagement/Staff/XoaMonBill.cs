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
    public partial class XoaMonBill : Form
    {
        private List<string> delList;

        public static int j;
        public XoaMonBill()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            if (j == 1)
            {
                delList = new List<string>();
                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
                var dellist = doc.Root.Elements("Bill").Elements("Name");

                foreach (var name in dellist)
                {
                    delList.Add(name.Value);
                }
                delBox.DataSource = delList;
            }
            if (j == 2)
            {

                delList = new List<string>();
                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
                var dellist = doc.Root.Elements("Bill").Elements("Name");

                foreach (var name in dellist)
                {
                    delList.Add(name.Value);
                }
                delBox.DataSource = delList;
            }
            if (j == 3)
            {

                delList = new List<string>();
                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
                var dellist = doc.Root.Elements("Bill").Elements("Name");

                foreach (var name in dellist)
                {
                    delList.Add(name.Value);
                }
                delBox.DataSource = delList;
            }
            if (j == 4)
            {

                delList = new List<string>();
                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
                var dellist = doc.Root.Elements("Bill").Elements("Name");

                foreach (var name in dellist)
                {
                    delList.Add(name.Value);
                }
                delBox.DataSource = delList;
            }
            if (j == 5)
            {

                delList = new List<string>();
                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
                var dellist = doc.Root.Elements("Bill").Elements("Name");

                foreach (var name in dellist)
                {
                    delList.Add(name.Value);
                }
                delBox.DataSource = delList;
            }
            if (j == 6)
            {

                delList = new List<string>();
                XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");
                var dellist = doc.Root.Elements("Bill").Elements("Name");

                foreach (var name in dellist)
                {
                    delList.Add(name.Value);
                }
                delBox.DataSource = delList;
            }
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
            if (j == 1)
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
                        int SLT;
                        int sl = int.Parse(SoLuong.Text);

                        XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
                        var dellist = doc.Root.Elements("Bill").Elements("Name").ToList();

                        foreach (var name in dellist)
                        {
                            if (name.Value == selectedItem)
                            {
                                SLT = int.Parse(name.Parent.Element("SL").Value);

                                if (SLT == sl)
                                {
                                    name.Parent.Remove();
                                    MessageBox.Show("Xóa Món thành Công!");
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT > sl)
                                {
                                    SLT = SLT - sl;
                                    name.Parent.Element("SL").Value = SLT.ToString();
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT < sl)
                                {
                                    MessageBox.Show("Số Lượng Cần Xóa Đã Cao Hơn Số Lượng Đang Có!!!");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (j == 2)
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
                        int SLT;
                        int sl = int.Parse(SoLuong.Text);

                        XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
                        var dellist = doc.Root.Elements("Bill").Elements("Name").ToList();

                        foreach (var name in dellist)
                        {
                            if (name.Value == selectedItem)
                            {
                                SLT = int.Parse(name.Parent.Element("SL").Value);

                                if (SLT == sl)
                                {
                                    name.Parent.Remove();
                                    MessageBox.Show("Xóa Món thành Công!");
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT > sl)
                                {
                                    SLT = SLT - sl;
                                    name.Parent.Element("SL").Value = SLT.ToString();
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT < sl)
                                {
                                    MessageBox.Show("Số Lượng Cần Xóa Đã Cao Hơn Số Lượng Đang Có!!!");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            if (j == 3)
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
                        int SLT;
                        int sl = int.Parse(SoLuong.Text);

                        XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
                        var dellist = doc.Root.Elements("Bill").Elements("Name").ToList();

                        foreach (var name in dellist)
                        {
                            if (name.Value == selectedItem)
                            {
                                SLT = int.Parse(name.Parent.Element("SL").Value);

                                if (SLT == sl)
                                {
                                    name.Parent.Remove();
                                    MessageBox.Show("Xóa Món thành Công!");
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT > sl)
                                {
                                    SLT = SLT - sl;
                                    name.Parent.Element("SL").Value = SLT.ToString();
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT < sl)
                                {
                                    MessageBox.Show("Số Lượng Cần Xóa Đã Cao Hơn Số Lượng Đang Có!!!");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            if (j == 4)
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
                        int SLT;
                        int sl = int.Parse(SoLuong.Text);

                        XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
                        var dellist = doc.Root.Elements("Bill").Elements("Name").ToList();

                        foreach (var name in dellist)
                        {
                            if (name.Value == selectedItem)
                            {
                                SLT = int.Parse(name.Parent.Element("SL").Value);

                                if (SLT == sl)
                                {
                                    name.Parent.Remove();
                                    MessageBox.Show("Xóa Món thành Công!");
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT > sl)
                                {
                                    SLT = SLT - sl;
                                    name.Parent.Element("SL").Value = SLT.ToString();
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT < sl)
                                {
                                    MessageBox.Show("Số Lượng Cần Xóa Đã Cao Hơn Số Lượng Đang Có!!!");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            if (j == 5)
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
                        int SLT;
                        int sl = int.Parse(SoLuong.Text);

                        XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
                        var dellist = doc.Root.Elements("Bill").Elements("Name").ToList();

                        foreach (var name in dellist)
                        {
                            if (name.Value == selectedItem)
                            {
                                SLT = int.Parse(name.Parent.Element("SL").Value);

                                if (SLT == sl)
                                {
                                    name.Parent.Remove();
                                    MessageBox.Show("Xóa Món thành Công!");
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT > sl)
                                {
                                    SLT = SLT - sl;
                                    name.Parent.Element("SL").Value = SLT.ToString();
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT < sl)
                                {
                                    MessageBox.Show("Số Lượng Cần Xóa Đã Cao Hơn Số Lượng Đang Có!!!");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            if (j == 6)
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
                        int SLT;
                        int sl = int.Parse(SoLuong.Text);

                        XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");
                        var dellist = doc.Root.Elements("Bill").Elements("Name").ToList();

                        foreach (var name in dellist)
                        {
                            if (name.Value == selectedItem)
                            {
                                SLT = int.Parse(name.Parent.Element("SL").Value);

                                if (SLT == sl)
                                {
                                    name.Parent.Remove();
                                    MessageBox.Show("Xóa Món thành Công!");
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT > sl)
                                {
                                    SLT = SLT - sl;
                                    name.Parent.Element("SL").Value = SLT.ToString();
                                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ba6.Xml");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                                if (SLT < sl)
                                {
                                    MessageBox.Show("Số Lượng Cần Xóa Đã Cao Hơn Số Lượng Đang Có!!!");
                                    XoaMonBill rf = new XoaMonBill();
                                    this.Close();
                                    rf.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void XoaMonBill_Load(object sender, EventArgs e)
        {

        }
    }
}
