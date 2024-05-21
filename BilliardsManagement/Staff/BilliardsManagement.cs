using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Xml.Serialization;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Xml;
using System.Security.AccessControl;
using System.Diagnostics;
using System.Xml.XPath;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;

namespace BilliardsManagement
{
    public partial class BilliardsManagement : Form
    {
        public static string name;
        public static string user;
        public int i;

        XmlSerializer xs;
        List<FoodAndDrink> FAD;

        Size _panel1Size;

        private List<string> foodNames;
        private List<string> drinkNames;
        private List<string> moreNames;

        public BilliardsManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            nameUser.Text = name;

            trangthai();

            foodNames = new List<string>();
            drinkNames = new List<string>();
            moreNames = new List<string>();

            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
            var foodnames = doc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Parent.Element("Type").Value == "Đồ Ăn");
            var drinknames = doc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Parent.Element("Type").Value == "Đồ Uống");
            var morenames = doc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Parent.Element("Type").Value == "Món Khác");

            foreach (var name in foodnames)
            {
                foodNames.Add(name.Value);
            }
            foreach (var name in drinknames)
            {
                drinkNames.Add(name.Value);
            }
            foreach (var name in morenames)
            {
                moreNames.Add(name.Value);
            }

            foodBox.DataSource = foodNames;
            drinkBox.DataSource = drinkNames;
            moreBox.DataSource = moreNames;

        }

        List<Ban> ban;
        private void trangthai()
        {
            ban = new List<Ban>();
            xs = new XmlSerializer(typeof(List<Ban>));

            FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Open, FileAccess.Read);
            ban = (List<Ban>)xs.Deserialize(fs);
            fs.Close();

            if (ban[0].InOut == "In")
            {
                Ban1.BackColor = Color.Red;
                hour[1] = ban[0].Hour;
                minute[1] = ban[0].Minute;
                second[1] = ban[0].Second;
            }

            if (ban[1].InOut == "In")
            {
                Ban2.BackColor = Color.Red;
                hour[2] = ban[1].Hour;
                minute[2] = ban[1].Minute;
                second[2] = ban[1].Second;
            }

            if (ban[2].InOut == "In")
            {
                Ban3.BackColor = Color.Red;
                hour[3] = ban[2].Hour;
                minute[3] = ban[2].Minute;
                second[3] = ban[2].Second;
            }

            if (ban[3].InOut == "In")
            {
                Ban4.BackColor = Color.Red;
                hour[4] = ban[3].Hour;
                minute[4] = ban[3].Minute;
                second[4] = ban[3].Second;
            }

            if (ban[4].InOut == "In")
            {
                Ban5.BackColor = Color.Red;
                hour[5] = ban[4].Hour;
                minute[5] = ban[4].Minute;
                second[5] = ban[4].Second;
            }

            if (ban[5].InOut == "In")
            {
                Ban6.BackColor = Color.Red;
                hour[6] = ban[5].Hour;
                minute[6] = ban[5].Minute;
                second[6] = ban[5].Second;
            }
        }

        private void BilliardsManagement_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit thoat = new exit();
            thoat.ShowDialog();
        }

        private void cáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đồĂnVàĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foodBox.DataSource = foodNames;
        }

        private void drinkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            drinkBox.DataSource = drinkNames;
        }

        private void moreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moreBox.DataSource = moreNames;
        }

        private void xóaMónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int[] hour = new int[7];
        int[] minute = new int[7];
        int[] second = new int[7];
        private void button9_Click(object sender, EventArgs e)
        {
            ban = new List<Ban>();
            xs = new XmlSerializer(typeof(List<Ban>));

            FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Open, FileAccess.Read);
            ban = (List<Ban>)xs.Deserialize(fs);
            fs.Close();

            if (i == 0)
            {
                MessageBox.Show("Hãy Chọn Bàn Để Bắt Đầu Tính Giờ Chơi!!!");
            }
            if (i == 1)
            {
                if (Ban1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bàn Đã Có Khách, Hãy Chọn Bàn Khác!");
                    return;
                }
                else
                    Ban1.BackColor = Color.Red;

                ban[0].InOut = "In";

                DateTime now = DateTime.Now;

                hour[1] = now.Hour;
                ban[0].Hour = hour[1];
                minute[1] = now.Minute;
                ban[0].Minute = minute[1];
                second[1] = now.Second;
                ban[0].Second = second[1];

                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
                Ban1_Click(sender, e);
            }
            if (i == 2)
            {
                if (Ban2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bàn Đã Có Khách, Hãy Chọn Bàn Khác!");
                    return;
                }
                else
                    Ban2.BackColor = Color.Red;

                ban[1].InOut = "In";

                DateTime now = DateTime.Now;

                hour[2] = now.Hour;
                ban[1].Hour = hour[2];
                minute[2] = now.Minute;
                ban[1].Minute = minute[2];
                second[2] = now.Second;
                ban[1].Second = second[2];

                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
                Ban2_Click(sender, e);
            }
            if (i == 3)
            {
                if (Ban3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bàn Đã Có Khách, Hãy Chọn Bàn Khác!");
                    return;
                }
                else
                    Ban3.BackColor = Color.Red;

                ban[2].InOut = "In";

                DateTime now = DateTime.Now;

                hour[3] = now.Hour;
                ban[2].Hour = hour[3];
                minute[3] = now.Minute;
                ban[2].Minute = minute[3];
                second[3] = now.Second;
                ban[2].Second = second[3];

                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
                Ban3_Click(sender, e);
            }
            if (i == 4)
            {
                if (Ban4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bàn Đã Có Khách, Hãy Chọn Bàn Khác!");
                    return;
                }
                else
                    Ban4.BackColor = Color.Red;

                ban[3].InOut = "In";

                DateTime now = DateTime.Now;

                hour[4] = now.Hour;
                ban[3].Hour = hour[4];
                minute[4] = now.Minute;
                ban[3].Minute = minute[4];
                second[4] = now.Second;
                ban[3].Second = second[4];

                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
                Ban4_Click(sender, e);
            }
            if (i == 5)
            {
                if (Ban5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bàn Đã Có Khách, Hãy Chọn Bàn Khác!");
                    return;
                }
                else
                    Ban5.BackColor = Color.Red;

                ban[4].InOut = "In";

                DateTime now = DateTime.Now;

                hour[5] = now.Hour;
                ban[4].Hour = hour[5];
                minute[5] = now.Minute;
                ban[4].Minute = minute[5];
                second[5] = now.Second;
                ban[4].Second = second[5];

                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
                Ban5_Click(sender, e);
            }
            if (i == 6)
            {
                if (Ban6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bàn Đã Có Khách, Hãy Chọn Bàn Khác!");
                    return;
                }
                else
                    Ban6.BackColor = Color.Red;

                ban[5].InOut = "In";

                DateTime now = DateTime.Now;

                hour[6] = now.Hour;
                ban[5].Hour = hour[6];
                minute[6] = now.Minute;
                ban[5].Minute = minute[6];
                second[6] = now.Second;
                ban[5].Second = second[6];

                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
                Ban6_Click(sender, e);
            }
        }

        private void Ban1_Click(object sender, EventArgs e)
        {
            i = 1;
            if (hour[1] == 0 && minute[1] == 0 && second[1] == 0)
            {
                startTime.Text = "Bàn " + i + " Trống";
            }
            else startTime.Text = "Bàn " + i + " Bắt Đầu Vào: " + hour[1] + "h" + minute[1] + "p" + second[1] + "s";

            List<Bill> bill = new List<Bill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml", FileMode.Open, FileAccess.Read))
            {
                bill = serial.Deserialize(fs) as List<Bill>;
            }
            dataGridView1.DataSource = bill;
        }

        private void Ban2_Click(object sender, EventArgs e)
        {
            i = 2;
            if (hour[2] == 0 && minute[2] == 0 && second[2] == 0)
            {
                startTime.Text = "Bàn " + i + " Trống";
            }
            else startTime.Text = "Bàn " + i + " Bắt Đầu Vào: " + hour[2] + "h" + minute[2] + "p" + second[2] + "s";

            List<Bill> bill = new List<Bill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml", FileMode.Open, FileAccess.Read))
            {
                bill = serial.Deserialize(fs) as List<Bill>;
            }
            dataGridView1.DataSource = bill;
        }

        private void Ban3_Click(object sender, EventArgs e)
        {
            i = 3;
            if (hour[3] == 0 && minute[3] == 0 && second[3] == 0)
            {
                startTime.Text = "Bàn " + i + " Trống";
            }
            else startTime.Text = "Bàn " + i + " Bắt Đầu Vào: " + hour[3] + "h" + minute[3] + "p" + second[3] + "s";

            List<Bill> bill = new List<Bill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml", FileMode.Open, FileAccess.Read))
            {
                bill = serial.Deserialize(fs) as List<Bill>;
            }
            dataGridView1.DataSource = bill;
        }

        private void Ban4_Click(object sender, EventArgs e)
        {
            i = 4;
            if (hour[4] == 0 && minute[4] == 0 && second[4] == 0)
            {
                startTime.Text = "Bàn " + i + " Trống";
            }
            else startTime.Text = "Bàn " + i + " Bắt Đầu Vào: " + hour[4] + "h" + minute[4] + "p" + second[4] + "s";

            List<Bill> bill = new List<Bill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml", FileMode.Open, FileAccess.Read))
            {
                bill = serial.Deserialize(fs) as List<Bill>;
            }
            dataGridView1.DataSource = bill;
        }

        private void Ban5_Click(object sender, EventArgs e)
        {
            i = 5;
            if (hour[5] == 0 && minute[5] == 0 && second[5] == 0)
            {
                startTime.Text = "Bàn " + i + " Trống";
            }
            else startTime.Text = "Bàn " + i + " Bắt Đầu Vào: " + hour[5] + "h" + minute[5] + "p" + second[5] + "s";

            List<Bill> bill = new List<Bill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml", FileMode.Open, FileAccess.Read))
            {
                bill = serial.Deserialize(fs) as List<Bill>;
            }
            dataGridView1.DataSource = bill;
        }

        private void Ban6_Click(object sender, EventArgs e)
        {
            i = 6;
            if (hour[6] == 0 && minute[6] == 0 && second[6] == 0)
            {
                startTime.Text = "Bàn " + i + " Trống";
            }
            else startTime.Text = "Bàn " + i + " Bắt Đầu Vào: " + hour[6] + "h" + minute[6] + "p" + second[6] + "s";

            List<Bill> bill = new List<Bill>();
            XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml", FileMode.Open, FileAccess.Read))
            {
                bill = serial.Deserialize(fs) as List<Bill>;
            }
            dataGridView1.DataSource = bill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Hãy Chọn Bàn Để Thêm Món!!!");
                return;
            }
            if (foodBox.Text == "--Lựa Chọn Đồ Ăn--" && drinkBox.Text == "--Lựa Chọn Đồ Uống--" && moreBox.Text == "--Lựa Chọn Món Khác--")
            {
                MessageBox.Show("Hãy Chọn Món Để Thêm Món!!!");
                return;
            }
            if (foodBox.Text != "--Lựa Chọn Đồ Ăn--")
            {
                if (i == 1)
                {
                    if (Ban1.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string foodName = foodBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == foodName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongF.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = foodName;
                        billNode.AppendChild(nameNode);

                        XDocument foodDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var foodItem = foodDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == foodName).FirstOrDefault();
                        var price = foodItem.Parent.Element("Price").Value;
                        var type = foodItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongF.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    foodBox.SelectedIndex = 0;

                    SoLuongF.Value = 1;

                    Ban1_Click(sender, e);
                }
                if (i == 2)
                {
                    if (Ban2.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string foodName = foodBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == foodName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongF.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = foodName;
                        billNode.AppendChild(nameNode);

                        XDocument foodDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var foodItem = foodDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == foodName).FirstOrDefault();
                        var price = foodItem.Parent.Element("Price").Value;
                        var type = foodItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongF.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    foodBox.SelectedIndex = 0;

                    SoLuongF.Value = 1;

                    Ban2_Click(sender, e);
                }
                if (i == 3)
                {
                    if (Ban3.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string foodName = foodBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == foodName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongF.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = foodName;
                        billNode.AppendChild(nameNode);

                        XDocument foodDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var foodItem = foodDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == foodName).FirstOrDefault();
                        var price = foodItem.Parent.Element("Price").Value;
                        var type = foodItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongF.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    foodBox.SelectedIndex = 0;

                    SoLuongF.Value = 1;

                    Ban3_Click(sender, e);
                }
                if (i == 4)
                {
                    if (Ban4.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string foodName = foodBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == foodName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongF.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = foodName;
                        billNode.AppendChild(nameNode);

                        XDocument foodDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var foodItem = foodDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == foodName).FirstOrDefault();
                        var price = foodItem.Parent.Element("Price").Value;
                        var type = foodItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongF.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    foodBox.SelectedIndex = 0;

                    SoLuongF.Value = 1;

                    Ban4_Click(sender, e);
                }
                if (i == 5)
                {
                    if (Ban5.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string foodName = foodBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == foodName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongF.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = foodName;
                        billNode.AppendChild(nameNode);

                        XDocument foodDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var foodItem = foodDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == foodName).FirstOrDefault();
                        var price = foodItem.Parent.Element("Price").Value;
                        var type = foodItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongF.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    foodBox.SelectedIndex = 0;

                    SoLuongF.Value = 1;

                    Ban5_Click(sender, e);
                }
                if (i == 6)
                {
                    if (Ban6.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string foodName = foodBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == foodName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongF.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = foodName;
                        billNode.AppendChild(nameNode);

                        XDocument foodDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var foodItem = foodDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == foodName).FirstOrDefault();
                        var price = foodItem.Parent.Element("Price").Value;
                        var type = foodItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongF.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    foodBox.SelectedIndex = 0;

                    SoLuongF.Value = 1;

                    Ban6_Click(sender, e);
                }
            }
            if (drinkBox.Text != "--Lựa Chọn Đồ Uống--")
            {
                if (i == 1)
                {
                    if (Ban1.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string drinkName = drinkBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == drinkName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongD.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = drinkName;
                        billNode.AppendChild(nameNode);

                        XDocument drinkDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var drinkItem = drinkDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == drinkName).FirstOrDefault();
                        var price = drinkItem.Parent.Element("Price").Value;
                        var type = drinkItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongD.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    drinkBox.SelectedIndex = 0;

                    SoLuongD.Value = 1;

                    Ban1_Click(sender, e);
                }
                if (i == 2)
                {
                    if (Ban2.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string drinkName = drinkBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == drinkName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongD.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = drinkName;
                        billNode.AppendChild(nameNode);

                        XDocument drinkDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var drinkItem = drinkDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == drinkName).FirstOrDefault();
                        var price = drinkItem.Parent.Element("Price").Value;
                        var type = drinkItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongD.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    drinkBox.SelectedIndex = 0;

                    SoLuongD.Value = 1;

                    Ban2_Click(sender, e);
                }
                if (i == 3)
                {
                    if (Ban3.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string drinkName = drinkBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == drinkName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongD.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = drinkName;
                        billNode.AppendChild(nameNode);

                        XDocument drinkDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var drinkItem = drinkDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == drinkName).FirstOrDefault();
                        var price = drinkItem.Parent.Element("Price").Value;
                        var type = drinkItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongD.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    drinkBox.SelectedIndex = 0;

                    SoLuongD.Value = 1;

                    Ban3_Click(sender, e);
                }
                if (i == 4)
                {
                    if (Ban4.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string drinkName = drinkBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == drinkName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongD.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = drinkName;
                        billNode.AppendChild(nameNode);

                        XDocument drinkDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var drinkItem = drinkDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == drinkName).FirstOrDefault();
                        var price = drinkItem.Parent.Element("Price").Value;
                        var type = drinkItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongD.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    drinkBox.SelectedIndex = 0;

                    SoLuongD.Value = 1;

                    Ban4_Click(sender, e);
                }
                if (i == 5)
                {
                    if (Ban5.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string drinkName = drinkBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == drinkName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongD.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = drinkName;
                        billNode.AppendChild(nameNode);

                        XDocument drinkDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var drinkItem = drinkDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == drinkName).FirstOrDefault();
                        var price = drinkItem.Parent.Element("Price").Value;
                        var type = drinkItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongD.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    drinkBox.SelectedIndex = 0;

                    SoLuongD.Value = 1;

                    Ban5_Click(sender, e);
                }
                if (i == 6)
                {
                    if (Ban6.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string drinkName = drinkBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == drinkName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongD.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = drinkName;
                        billNode.AppendChild(nameNode);

                        XDocument drinkDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var drinkItem = drinkDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == drinkName).FirstOrDefault();
                        var price = drinkItem.Parent.Element("Price").Value;
                        var type = drinkItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongD.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    drinkBox.SelectedIndex = 0;

                    SoLuongD.Value = 1;

                    Ban6_Click(sender, e);
                }
            }
            if (moreBox.Text != "--Lựa Chọn Món Khác--")
            {
                if (i == 1)
                {
                    if (Ban1.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string moreName = moreBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == moreName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongM.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = moreName;
                        billNode.AppendChild(nameNode);

                        XDocument moreDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var moreItem = moreDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == moreName).FirstOrDefault();
                        var price = moreItem.Parent.Element("Price").Value;
                        var type = moreItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongM.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    moreBox.SelectedIndex = 0;

                    SoLuongM.Value = 1;

                    Ban1_Click(sender, e);
                }
                if (i == 2)
                {
                    if (Ban2.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string moreName = moreBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == moreName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongM.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = moreName;
                        billNode.AppendChild(nameNode);

                        XDocument moreDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var moreItem = moreDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == moreName).FirstOrDefault();
                        var price = moreItem.Parent.Element("Price").Value;
                        var type = moreItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongM.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    moreBox.SelectedIndex = 0;

                    SoLuongM.Value = 1;

                    Ban2_Click(sender, e);
                }
                if (i == 3)
                {
                    if (Ban3.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string moreName = moreBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == moreName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongM.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = moreName;
                        billNode.AppendChild(nameNode);

                        XDocument moreDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var moreItem = moreDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == moreName).FirstOrDefault();
                        var price = moreItem.Parent.Element("Price").Value;
                        var type = moreItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongM.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    moreBox.SelectedIndex = 0;

                    SoLuongM.Value = 1;

                    Ban3_Click(sender, e);
                }
                if (i == 4)
                {
                    if (Ban4.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string moreName = moreBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == moreName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongM.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = moreName;
                        billNode.AppendChild(nameNode);

                        XDocument moreDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var moreItem = moreDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == moreName).FirstOrDefault();
                        var price = moreItem.Parent.Element("Price").Value;
                        var type = moreItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongM.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    moreBox.SelectedIndex = 0;

                    SoLuongM.Value = 1;

                    Ban4_Click(sender, e);
                }
                if (i == 5)
                {
                    if (Ban5.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string moreName = moreBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == moreName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongM.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = moreName;
                        billNode.AppendChild(nameNode);

                        XDocument moreDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var moreItem = moreDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == moreName).FirstOrDefault();
                        var price = moreItem.Parent.Element("Price").Value;
                        var type = moreItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongM.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    moreBox.SelectedIndex = 0;

                    SoLuongM.Value = 1;

                    Ban5_Click(sender, e);
                }
                if (i == 6)
                {
                    if (Ban6.BackColor == Color.Gray)
                    {
                        MessageBox.Show("Bàn Trống, Không Thể Thêm Món!");
                        return;
                    }

                    string moreName = moreBox.SelectedItem.ToString();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");

                    XmlNode rootNode = doc.DocumentElement;

                    bool found = false;
                    foreach (XmlNode billNode in rootNode.ChildNodes)
                    {
                        if (billNode.Name == "Bill")
                        {
                            XmlNode nameNode = billNode.FirstChild;
                            if (nameNode.InnerText == moreName)
                            {
                                XmlNode slNode = billNode.LastChild;
                                int currentSL = Convert.ToInt32(slNode.InnerText);
                                int newSL = currentSL + Convert.ToInt32(SoLuongM.Value);
                                slNode.InnerText = Convert.ToString(newSL);
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        XmlNode billNode = doc.CreateElement("Bill");

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = moreName;
                        billNode.AppendChild(nameNode);

                        XDocument moreDoc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
                        var moreItem = moreDoc.Root.Elements("FoodAndDrink").Elements("Name").Where(item => item.Value == moreName).FirstOrDefault();
                        var price = moreItem.Parent.Element("Price").Value;
                        var type = moreItem.Parent.Element("Type").Value;

                        XmlNode priceNode = doc.CreateElement("Price");
                        priceNode.InnerText = price;
                        billNode.AppendChild(priceNode);

                        XmlNode typeNode = doc.CreateElement("Type");
                        typeNode.InnerText = type;
                        billNode.AppendChild(typeNode);

                        XmlNode slNode = doc.CreateElement("SL");
                        slNode.InnerText = Convert.ToString(SoLuongM.Value);
                        billNode.AppendChild(slNode);

                        rootNode.AppendChild(billNode);
                    }

                    doc.Save(@"C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");

                    MessageBox.Show("Thêm Món Thành Công!!!");

                    moreBox.SelectedIndex = 0;

                    SoLuongM.Value = 1;

                    Ban6_Click(sender, e);
                }
            }
        }
        private void XoaMon_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Hãy Chọn Bàn!!!");
                return;
            }
            if (i == 1)
            {
                if (Ban1.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Xóa Món!");
                    return;
                }
            }
            if (i == 2)
            {
                if (Ban2.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Xóa Món!");
                    return;
                }
            }
            if (i == 3)
            {
                if (Ban3.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Xóa Món!");
                    return;
                }
            }
            if (i == 4)
            {
                if (Ban4.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Xóa Món!");
                    return;
                }
            }
            if (i == 5)
            {
                if (Ban5.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Xóa Món!");
                    return;
                }
            }
            if (i == 6)
            {
                if (Ban6.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Xóa Món!");
                    return;
                }
            }

            XoaMonBill.j = i;
            XoaMonBill xm = new XoaMonBill();
            xm.ShowDialog();
            if (i == 1)
            {
                Ban1_Click(sender, e);
            }
            if (i == 2)
            {
                Ban2_Click(sender, e);
            }
            if (i == 3)
            {
                Ban3_Click(sender, e);
            }
            if (i == 4)
            {
                Ban4_Click(sender, e);
            }
            if (i == 5)
            {
                Ban5_Click(sender, e);
            }
            if (i == 6)
            {
                Ban6_Click(sender, e);
            }
        }

        private void sauthanhtoan()
        {
            ban = new List<Ban>();
            xs = new XmlSerializer(typeof(List<Ban>));

            FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Open, FileAccess.Read);
            ban = (List<Ban>)xs.Deserialize(fs);
            fs.Close();

            if (i == 1)
            {
                ban[0].InOut = "Out";
                ban[0].Hour = 0;
                ban[0].Minute = 0;
                ban[0].Second = 0;
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
            }
            if (i == 2)
            {
                ban[1].InOut = "Out";
                ban[1].Hour = 0;
                ban[1].Minute = 0;
                ban[1].Second = 0;
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
            }
            if (i == 3)
            {
                ban[2].InOut = "Out";
                ban[2].Hour = 0;
                ban[2].Minute = 0;
                ban[2].Second = 0;
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
            }
            if (i == 4)
            {
                ban[3].InOut = "Out";
                ban[3].Hour = 0;
                ban[3].Minute = 0;
                ban[3].Second = 0;
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
            }
            if (i == 5)
            {
                ban[4].InOut = "Out";
                ban[4].Hour = 0;
                ban[4].Minute = 0;
                ban[4].Second = 0;
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
            }
            if (i == 6)
            {
                ban[5].InOut = "Out";
                ban[5].Hour = 0;
                ban[5].Minute = 0;
                ban[5].Second = 0;
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Ban.Xml", FileMode.Create, FileAccess.Write);
                xs.Serialize(fs, ban);
                fs.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Hãy Chọn Bàn!!!");
                return;
            }
            string value = SDTBox.Text;

            if (i == 1)
            {
                if (Ban1.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Thanh Toán!");
                    return;
                }
                if (SDTBox.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                    return;
                }
                if (!int.TryParse(value, out int number))
                {
                    MessageBox.Show("Vui Lòng Nhập Số!");
                    SDTBox.Text = "";
                    return;
                }
                if (int.Parse(SDTBox.Text) < 100000000)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                    SDTBox.Text = "";
                    return;
                }
                ThanhToan.SDT = SDTBox.Text;
                ThanhToan.Hour = hour[1];
                ThanhToan.Minute = minute[1];
                ThanhToan.Second = second[1];
                ThanhToan.j = i;
                ThanhToan tt = new ThanhToan();
                tt.ShowDialog();
                if (tt.myBool)
                {
                    Ban1.BackColor = Color.Gray;
                    hour[1] = 0;
                    minute[1] = 0;
                    second[1] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
                    sauthanhtoan();
                    Ban1_Click(sender, e);
                }
            }
            if (i == 2)
            {
                if (Ban2.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Thanh Toán!");
                    return;
                }
                if (SDTBox.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                    return;
                }
                if (!int.TryParse(value, out int number))
                {
                    MessageBox.Show("Vui Lòng Nhập Số!");
                    SDTBox.Text = "";
                    return;
                }
                if (int.Parse(SDTBox.Text) < 100000000)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                    SDTBox.Text = "";
                    return;
                }
                ThanhToan.SDT = SDTBox.Text;
                ThanhToan.Hour = hour[2];
                ThanhToan.Minute = minute[2];
                ThanhToan.Second = second[2];
                ThanhToan.j = i;
                ThanhToan tt = new ThanhToan();
                tt.ShowDialog();
                if (tt.myBool)
                {
                    Ban2.BackColor = Color.Gray;
                    hour[2] = 0;
                    minute[2] = 0;
                    second[2] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
                    sauthanhtoan();
                    Ban2_Click(sender, e);
                }
            }
            if (i == 3)
            {
                if (Ban3.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Thanh Toán!");
                    return;
                }
                if (SDTBox.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                    return;
                }
                if (!int.TryParse(value, out int number))
                {
                    MessageBox.Show("Vui Lòng Nhập Số!");
                    SDTBox.Text = "";
                    return;
                }
                if (int.Parse(SDTBox.Text) < 100000000)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                    SDTBox.Text = "";
                    return;
                }
                ThanhToan.SDT = SDTBox.Text;
                ThanhToan.Hour = hour[3];
                ThanhToan.Minute = minute[3];
                ThanhToan.Second = second[3];
                ThanhToan.j = i;
                ThanhToan tt = new ThanhToan();
                tt.ShowDialog();
                if (tt.myBool)
                {
                    Ban3.BackColor = Color.Gray;
                    hour[3] = 0;
                    minute[3] = 0;
                    second[3] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
                    sauthanhtoan();
                    Ban3_Click(sender, e);
                }
            }
            if (i == 4)
            {
                if (Ban4.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Thanh Toán!");
                    return;
                }
                if (SDTBox.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                    return;
                }
                if (!int.TryParse(value, out int number))
                {
                    MessageBox.Show("Vui Lòng Nhập Số!");
                    SDTBox.Text = "";
                    return;
                }
                if (int.Parse(SDTBox.Text) < 100000000)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                    SDTBox.Text = "";
                    return;
                }
                ThanhToan.SDT = SDTBox.Text;
                ThanhToan.Hour = hour[4];
                ThanhToan.Minute = minute[4];
                ThanhToan.Second = second[4];
                ThanhToan.j = i;
                ThanhToan tt = new ThanhToan();
                tt.ShowDialog();
                if (tt.myBool)
                {
                    Ban4.BackColor = Color.Gray;
                    hour[4] = 0;
                    minute[4] = 0;
                    second[4] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
                    sauthanhtoan();
                    Ban4_Click(sender, e);
                }
            }
            if (i == 5)
            {
                if (Ban5.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Thanh Toán!");
                    return;
                }
                if (SDTBox.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                    return;
                }
                if (!int.TryParse(value, out int number))
                {
                    MessageBox.Show("Vui Lòng Nhập Số!");
                    SDTBox.Text = "";
                    return;
                }
                if (int.Parse(SDTBox.Text) < 100000000)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                    SDTBox.Text = "";
                    return;
                }
                ThanhToan.SDT = SDTBox.Text;
                ThanhToan.Hour = hour[5];
                ThanhToan.Minute = minute[5];
                ThanhToan.Second = second[5];
                ThanhToan.j = i;
                ThanhToan tt = new ThanhToan();
                tt.ShowDialog();
                if (tt.myBool)
                {
                    Ban5.BackColor = Color.Gray;
                    hour[5] = 0;
                    minute[5] = 0;
                    second[5] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
                    sauthanhtoan();
                    Ban5_Click(sender, e);
                }
            }
            if (i == 6)
            {
                if (Ban6.BackColor == Color.Gray)
                {
                    MessageBox.Show("Bàn Trống, Không Thể Thanh Toán!");
                    return;
                }
                if (SDTBox.Text == "")
                {
                    MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                    return;
                }
                if (!int.TryParse(value, out int number))
                {
                    MessageBox.Show("Vui Lòng Nhập Số!");
                    SDTBox.Text = "";
                    return;
                }
                if (int.Parse(SDTBox.Text) < 100000000)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                    SDTBox.Text = "";
                    return;
                }
                ThanhToan.SDT = SDTBox.Text;
                ThanhToan.Hour = hour[6];
                ThanhToan.Minute = minute[6];
                ThanhToan.Second = second[6];
                ThanhToan.j = i;
                ThanhToan tt = new ThanhToan();
                tt.ShowDialog();
                if (tt.myBool)
                {
                    Ban6.BackColor = Color.Gray;
                    hour[6] = 0;
                    minute[6] = 0;
                    second[6] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");
                    sauthanhtoan();
                    Ban6_Click(sender, e);
                }
            }
        }

        private void SoLuongF_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CFDungTime cf = new CFDungTime();
            if (i == 0)
            {
                MessageBox.Show("Hãy Chọn Bàn!");
                return;
            }
            if (i == 1)
            {
                if (Ban1.BackColor == Color.Gray)
                {
                    MessageBox.Show("Hãy Chọn Bàn Đang Tính Giờ!");
                    return;
                }
                cf.ShowDialog();
                if (cf.check)
                {
                    Ban1.BackColor = Color.Gray;
                    hour[1] = 0;
                    minute[1] = 0;
                    second[1] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
                    sauthanhtoan();
                    Ban1_Click(sender, e);
                }
            }
            if (i == 2)
            {
                if (Ban2.BackColor == Color.Gray)
                {
                    MessageBox.Show("Hãy Chọn Bàn Đang Tính Giờ!");
                    return;
                }
                cf.ShowDialog();
                if (cf.check)
                {
                    Ban2.BackColor = Color.Gray;
                    hour[2] = 0;
                    minute[2] = 0;
                    second[2] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
                    sauthanhtoan();
                    Ban2_Click(sender, e);
                }
            }
            if (i == 3)
            {
                if (Ban3.BackColor == Color.Gray)
                {
                    MessageBox.Show("Hãy Chọn Bàn Đang Tính Giờ!");
                    return;
                }
                cf.ShowDialog();
                if (cf.check)
                {
                    Ban3.BackColor = Color.Gray;
                    hour[3] = 0;
                    minute[3] = 0;
                    second[3] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
                    sauthanhtoan();
                    Ban3_Click(sender, e);
                }
            }
            if (i == 4)
            {
                if (Ban4.BackColor == Color.Gray)
                {
                    MessageBox.Show("Hãy Chọn Bàn Đang Tính Giờ!");
                    return;
                }
                cf.ShowDialog();
                if (cf.check)
                {
                    Ban4.BackColor = Color.Gray;
                    hour[4] = 0;
                    minute[4] = 0;
                    second[4] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
                    sauthanhtoan();
                    Ban4_Click(sender, e);
                }
            }
            if (i == 5)
            {
                if (Ban5.BackColor == Color.Gray)
                {
                    MessageBox.Show("Hãy Chọn Bàn Đang Tính Giờ!");
                    return;
                }
                cf.ShowDialog();
                if (cf.check)
                {
                    Ban5.BackColor = Color.Gray;
                    hour[5] = 0;
                    minute[5] = 0;
                    second[5] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
                    sauthanhtoan();
                    Ban5_Click(sender, e);
                }
            }
            if (i == 6)
            {
                if (Ban6.BackColor == Color.Gray)
                {
                    MessageBox.Show("Hãy Chọn Bàn Đang Tính Giờ!");
                    return;
                }
                cf.ShowDialog();
                if (cf.check)
                {
                    Ban6.BackColor = Color.Gray;
                    hour[6] = 0;
                    minute[6] = 0;
                    second[6] = 0;
                    SDTBox.Text = "";
                    XDocument foodAndDrinkDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfBill"
                    )
                    );
                    foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");
                    sauthanhtoan();
                    Ban6_Click(sender, e);
                }
            }
        }
        public static int gioluong, phutluong, giayluong;

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int NHour = now.Hour;
            int NMinute = now.Minute;
            int NSecond = now.Second;

            NHour -= gioluong;
            NMinute -= phutluong;
            NSecond -= giayluong;

            int distance = (NHour * 3600 + NMinute * 60 + NSecond) / 60;

            if (distance < 1)
            {
                MessageBox.Show("Chưa Làm Đủ Hoặc Hơn 1 Tiếng Để Điểm Danh!");
                return;
            }

            user = user.ToLower();

            XmlDocument doc = new XmlDocument();

            doc.Load(@"C:\\Users\\Public\\BilliardManagement\\luong.Xml");

            XmlNode rootNode = doc.DocumentElement;

            bool foundUser = false;
            foreach (XmlNode luongNode in rootNode.ChildNodes)
            {
                if (luongNode.Name == "luong")
                {
                    if (luongNode.FirstChild.InnerText == user)
                    {
                        foundUser = true;

                        int hour = Convert.ToInt32(luongNode.LastChild.InnerText);
                        hour += distance;
                        luongNode.LastChild.InnerText = Convert.ToString(hour);
                        break;
                    }
                }
            }

            if (!foundUser)
            {
                XmlNode luongNode = doc.CreateElement("luong");

                XmlNode userNode = doc.CreateElement("User");
                userNode.InnerText = user;
                luongNode.AppendChild(userNode);

                XmlNode nameNode = doc.CreateElement("Name");
                nameNode.InnerText = name;
                luongNode.AppendChild(nameNode);

                XmlNode hourNode = doc.CreateElement("Hour");
                hourNode.InnerText = Convert.ToString(distance);
                luongNode.AppendChild(hourNode);

                rootNode.AppendChild(luongNode);
            }

            doc.Save(@"C:\\Users\\Public\\BilliardManagement\\luong.Xml");

            MessageBox.Show("Điểm Danh Thành Công!!!");

            gioluong = now.Hour;
            phutluong = now.Minute;
            giayluong = now.Second;
        }

    }
}