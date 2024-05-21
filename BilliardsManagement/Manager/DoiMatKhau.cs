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
using System.Xml.Serialization;

namespace BilliardsManagement
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        interface error
        {
            void mess();
        }

        class giongPass : error
        {
            public void mess()
            {
                MessageBox.Show("Mật Khẩu Mới Và Cũ Giống Nhau, Xin Hãy Nhập Lại!");
            }
        }

        class thieuthongtin : error
        {
            public void mess()
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin Để Đổi Mật Khẩu!");
            }
        }

        class khacPass : error
        {
            public void mess()
            {
                MessageBox.Show("Mật Khẩu Không Giống Nhau, Xin Hãy Nhập Lại!");
            }
        }

        class sai : error
        {
            public void mess()
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu, Hãy Nhập Lại!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int tam;
        private void button1_Click(object sender, EventArgs e)
        {

            List<NhanVienBanThoiGian> lnv = new List<NhanVienBanThoiGian>();
            XmlSerializer xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
            if (userText.Text == "" || passText.Text == "" || passAText.Text == "" || passAAText.Text == "")
            {
                error ttt = new thieuthongtin();
                ttt.mess();
                return;
            }

            if (passText.Text == passAText.Text)
            {
                error gp = new giongPass();
                gp.mess();
                return;
            }
            FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Open, FileAccess.Read);
            lnv = (List<NhanVienBanThoiGian>)xs.Deserialize(fs);
            fs.Close();

            if (passAAText.Text != passAText.Text)
            {
                error kp = new khacPass();
                kp.mess();
                return;
            }

            if (passAText.Text.Length < 8 || !passAText.Text.Any(char.IsUpper))
            {
                MessageBox.Show("Mặt Khẩu Phải trên 8 Kí Tự Và Có Ít Nhất 1 Chữ Viết Hoa!");
                return;
            }

            string user = userText.Text;
            user = user.ToLower();

            bool checkUser = false;
            for (int i = 0; i < lnv.Count; i++)
            {
                if (lnv[i].User == user)
                {
                    tam = i;
                    checkUser = true;
                    break;
                }
            }

            bool checkPass = false;
            if (checkUser == true)
            {
                using (SHA256Managed sha256 = new SHA256Managed())
                {
                    byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(passText.Text));
                    checkPass = Convert.ToBase64String(hashedPassword) == lnv[tam].Pass;
                }
            }

            if (checkUser && checkPass)
            {
                using (SHA256Managed sha256 = new SHA256Managed())
                {
                    byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(passAText.Text));
                    lnv[tam].Pass = Convert.ToBase64String(hashedPassword);
                }
                fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Open, FileAccess.Write);
                xs.Serialize(fs, lnv);
                fs.Close();

                MessageBox.Show("Đổi Mặt Khẩu Thành Công!!!");

                userText.Clear();
                passText.Clear();
                passAText.Clear();
                passAAText.Clear();
            }
            else
            {
                error sai = new sai();
                sai.mess();
            }

        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
