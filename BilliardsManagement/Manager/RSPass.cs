using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilliardsManagement
{
    public partial class RSPass : Form
    {
        private List<string> NList;
        public RSPass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            NList = new List<string>();
            XDocument doc = XDocument.Load(@"C:\\Users\\Public\\BilliardManagement\\account.Xml");
            var Blist = doc.Root.Elements("NhanVienBanThoiGian").Elements("Name").SkipWhile(item => item.Parent.Element("Name").Value == "ADMIN");

            foreach (var name in Blist)
            {
                NList.Add(name.Value);
            }
            delBox.DataSource = NList;

            delBox.SelectedIndex = -1;

        }

        private void RSPass_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            string selectedItem = delBox.SelectedItem.ToString();

            List<NhanVienBanThoiGian> lnv = new List<NhanVienBanThoiGian>();
            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
                lnv = (List<NhanVienBanThoiGian>)xs.Deserialize(fs);
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

            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
                xs.Serialize(fs, lnv);
            }

            MessageBox.Show("Mật Khẩu Mới Của Tài Khoản Là: " + randomString.ToString() + "\nHãy Đổi Mật Khẩu Ở Lần Đăng Nhập Kế Tiếp!");

            RSPass rs = new RSPass();
            this.Close();
            rs.ShowDialog();
        }
    }
}
