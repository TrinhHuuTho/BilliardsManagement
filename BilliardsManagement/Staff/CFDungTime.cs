using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilliardsManagement
{
    public partial class CFDungTime : Form
    {
        public bool check = false;
        XmlSerializer xs;
        List<QuanLy> lnv;
        public CFDungTime()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void CFDungTime_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (passText.Text == "" || userText.Text == "")
            {
                MessageBox.Show("Hãy Nhập Tài Khoản Và Mật Khẩu Của Quản Lý Để Xóa!");
                return;
            }
            int sbd = -1;

            lnv = new List<QuanLy>();
            xs = new XmlSerializer(typeof(List<QuanLy>));

            FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Manager.Xml", FileMode.Open, FileAccess.Read);
            lnv = (List<QuanLy>)xs.Deserialize(fs);
            fs.Close();

            string user = userText.Text;
            user = user.ToLower();

            bool checkUser = false;
            for (int i = 0; i < lnv.Count; i++)
            {
                if (lnv[i].User == user)
                {
                    sbd = i;
                    checkUser = true;
                    break;
                }
            }

            bool checkPass = false;
            if (checkUser)
            {
                using (SHA256Managed sha256 = new SHA256Managed())
                {
                    byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(passText.Text));
                    checkPass = Convert.ToBase64String(hashedPassword) == lnv[sbd].Pass;
                }
            }

            if (checkUser && checkPass)
            {
                
                    check = true;
                    MessageBox.Show("Dừng Tính Giờ Thành Công!");
                    this.Hide();
                
            }
            else
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
