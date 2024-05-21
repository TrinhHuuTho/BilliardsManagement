using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilliardsManagement
{
    public partial class ThanhToan : Form
    {
        public static ThanhToan operator * (ThanhToan thanhToan, double discount)
        {
            return thanhToan * discount;
        }

        public int PriceBill;
        public bool myBool = false;
        public static string SDT;
        public static int j;
        public static int Hour;
        public static int Minute;
        public static int Second;
        private XmlDocument xmlDocument;
        public ThanhToan()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            SoLanKhachGhe();
            chayGrid();
            TinhGio();

            GioChoi.Text = "Khách Đã Chơi: " + TinhGio() + " Phút";

            ban.Text = "Bàn: " + j;

            sdtText.Text = SDT + "";
        }

        private void chayGrid()
        {
            if (j == 1)
            {
                List<Bill> bill = new List<Bill>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml", FileMode.Open, FileAccess.Read))
                {
                    bill = serial.Deserialize(fs) as List<Bill>;
                }
                dataGridView1.DataSource = bill;

                int total = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    total += bill[i].Price * bill[i].SL;
                }

                int tienGio = TinhTienGio();

                total += tienGio;

                TongTien.Text = total.ToString() + " VNĐ";

                if (sl >= 10)
                {
                    double discount = 0.9;
                    ThanhTien.Text = (total * discount).ToString() + " VNĐ";
                }
                else ThanhTien.Text = total.ToString() + " VND";
                PriceBill = total;
            }
            else if (j == 2)
            {
                List<Bill> bill = new List<Bill>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml", FileMode.Open, FileAccess.Read))
                {
                    bill = serial.Deserialize(fs) as List<Bill>;
                }
                dataGridView1.DataSource = bill;

                int total = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    total += bill[i].Price * bill[i].SL;
                }

                int tienGio = TinhTienGio();

                total += tienGio;

                TongTien.Text = total.ToString() + " VNĐ";

                if (sl >= 10)
                {
                    double discount = 0.9;
                    ThanhTien.Text = (total * discount).ToString() + " VNĐ";
                }
                else ThanhTien.Text = total.ToString() + " VND";
                PriceBill = total;
            }
            else if (j == 3)
            {
                List<Bill> bill = new List<Bill>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml", FileMode.Open, FileAccess.Read))
                {
                    bill = serial.Deserialize(fs) as List<Bill>;
                }
                dataGridView1.DataSource = bill;

                int total = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    total += bill[i].Price * bill[i].SL;
                }

                int tienGio = TinhTienGio();

                total += tienGio;

                TongTien.Text = total.ToString() + " VNĐ";

                if (sl >= 10)
                {
                    double discount = 0.9;
                    ThanhTien.Text = (total * discount).ToString() + " VNĐ";
                }
                else ThanhTien.Text = total.ToString() + " VND";
                PriceBill = total;
            }
            else if (j == 4)
            {
                List<Bill> bill = new List<Bill>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml", FileMode.Open, FileAccess.Read))
                {
                    bill = serial.Deserialize(fs) as List<Bill>;
                }
                dataGridView1.DataSource = bill;

                int total = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    total += bill[i].Price * bill[i].SL;
                }

                int tienGio = TinhTienGio();

                total += tienGio;

                TongTien.Text = total.ToString() + " VNĐ";

                if (sl >= 10)
                {
                    double discount = 0.9;
                    ThanhTien.Text = (total * discount).ToString() + " VNĐ";
                }
                else ThanhTien.Text = total.ToString() + " VND";
                PriceBill = total;
            }
            else if (j == 5)
            {
                List<Bill> bill = new List<Bill>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml", FileMode.Open, FileAccess.Read))
                {
                    bill = serial.Deserialize(fs) as List<Bill>;
                }
                dataGridView1.DataSource = bill;

                int total = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    total += bill[i].Price * bill[i].SL;
                }

                int tienGio = TinhTienGio();

                total += tienGio;

                TongTien.Text = total.ToString() + " VNĐ";

                if (sl >= 10)
                {
                    double discount = 0.9;
                    ThanhTien.Text = (total * discount).ToString() + " VNĐ";
                }
                else ThanhTien.Text = total.ToString() + " VND";
                PriceBill = total;
            }
            else if (j == 6)
            {
                List<Bill> bill = new List<Bill>();
                XmlSerializer serial = new XmlSerializer(typeof(List<Bill>));

                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml", FileMode.Open, FileAccess.Read))
                {
                    bill = serial.Deserialize(fs) as List<Bill>;
                }
                dataGridView1.DataSource = bill;

                int total = 0;
                for (int i = 0; i < bill.Count; i++)
                {
                    total += bill[i].Price * bill[i].SL;
                }

                int tienGio = TinhTienGio();

                total += tienGio;

                TongTien.Text = total.ToString() + " VNĐ";

                if (sl >= 10)
                {
                    double discount = 0.9;
                    ThanhTien.Text = (total * discount).ToString() + " VNĐ";
                }
                else ThanhTien.Text = total.ToString() + " VND";
                PriceBill = total;
            }
        }
        private int TinhGio()
        {
            DateTime now = DateTime.Now;
            int hour2 = now.Hour;
            int minute2 = now.Minute;
            int second2 = now.Second;

            int THour = hour2 - Hour;
            int TMinute = minute2 - Minute;
            int TSecond = second2 - Second;

            int distance = THour * 3600 + TMinute * 60 + TSecond;

            return distance;
        }
        
        private int TinhTienGio()
        {
            if (TinhGio() <= 15)
            {
                return 15000;
            }
            else
            {
                return TinhGio() * 670;
            }
        }
        int sl = 0;
        private void SoLanKhachGhe()
        {
            XmlDocument xmlDocument = new XmlDocument();

            try
            {
                xmlDocument.Load("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int soLanKhachGhe = 0;

            XmlNodeList nhatKyBills = xmlDocument.SelectNodes("//NhatKyBill[SDT='" + SDT + "']");

            soLanKhachGhe = nhatKyBills.Count + 1;

            sl = soLanKhachGhe;

            solanBox.Text = soLanKhachGhe.ToString() + " Lần";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userText_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do Là Phiên Bản Thử Nghiệm Nên 1s = 1p Với Thời Gian Thực Tế!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirm.price = TongTien.Text;
            confirm cf = new confirm();
            cf.ShowDialog();
            if (cf.myBool)
            {
                XmlDocument xmlDocument = new XmlDocument();

                try
                {
                    xmlDocument.Load("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                XmlElement newBillElement = xmlDocument.CreateElement("NhatKyBill");

                XmlElement sdtElement = xmlDocument.CreateElement("SDT");
                sdtElement.InnerText = sdtText.Text;
                newBillElement.AppendChild(sdtElement);

                DateTime now = DateTime.Now;
                XmlElement dateTimeElement = xmlDocument.CreateElement("DateTime");
                dateTimeElement.InnerText = now.ToString("dd/MM/yyyy HH:mm:ss");
                newBillElement.AppendChild(dateTimeElement);

                XmlElement priceElement = xmlDocument.CreateElement("Price");
                priceElement.InnerText = PriceBill.ToString();
                newBillElement.AppendChild(priceElement);

                xmlDocument.DocumentElement.AppendChild(newBillElement);

                try
                {
                    xmlDocument.Save("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Thanh toán thành công!");

                myBool = true;

                this.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
