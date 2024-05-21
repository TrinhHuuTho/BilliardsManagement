using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BilliardsManagement
{
    public partial class RSPassQL : Form
    {
        public static string name;
        private List<string> NList;

        public RSPassQL()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            NList = new List<string>();
            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\Manager.Xml");
            var Blist = doc.Root.Elements("QuanLy").Elements("Name");

            foreach (var name in Blist)
            {
                NList.Add(name.Value);
            }
            delBox.DataSource = NList;

            delBox.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = delBox.SelectedItem.ToString();

            if (name == selectedItem)
            {
                MessageBox.Show("Không Thể Reset Mật Khẩu Tài Khoản Đang Đăng Nhập!");
                return;
            }
            if (delBox.SelectedIndex <= -1)
            {
                MessageBox.Show("Hãy Chọn tài Khoản Để Reset Mật Khẩu!");
                return;
            }
            Random random = new Random();

            StringBuilder randomString = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                int randomChar = random.Next(36);

                if (randomChar < 26)
                {
                    randomString.Append((char)('A' + randomChar));
                }
                else
                {
                    randomString.Append((char)('0' + (randomChar - 26)));
                }
            }


            List<QuanLy> lnv = new List<QuanLy>();
            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Manager.Xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<QuanLy>));
                lnv = (List<QuanLy>)xs.Deserialize(fs);
            }

            for (int i = 0; i < lnv.Count; i++)
            {
                if (lnv[i].Name == selectedItem)
                {
                    using (SHA256Managed sha256 = new SHA256Managed())
                    {
                        byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(randomString.ToString()));
                        lnv[i].Pass = Convert.ToBase64String(hashedPassword);
                    }
                    break;
                }
            }

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Manager.Xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<QuanLy>));
                xs.Serialize(fs, lnv);
            }

            MessageBox.Show("Mật Khẩu Mới Của Tài Khoản Là: " + randomString.ToString() + "\nHãy Đổi Mật Khẩu Ở Lần Đăng Nhập Kế Tiếp!");

            RSPassQL rs = new RSPassQL();
            this.Close();
            rs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
