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
using static System.Windows.Forms.DataFormats;
using System.Diagnostics.Eventing.Reader;

namespace BilliardsManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        class error
        {
            public virtual void mess()
            {
                MessageBox.Show("...");
            }
        }
        class saimatkhau : error
        {
            public override void mess()
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu, Hãy Nhập Lại!!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();

        }

        public int sbd;
        private void button3_Click(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                List<QuanLy> ql = new List<QuanLy>();
                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Manager.Xml", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<QuanLy>));
                    ql = (List<QuanLy>)xs.Deserialize(fs);
                }

                int sbd = -1;

                string user = userText.Text;
                user = user.ToLower();

                bool checkUser = false;
                for (int i = 0; i < ql.Count; i++)
                {
                    if (ql[i].User == user)
                    {
                        sbd = i;
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
                        checkPass = Convert.ToBase64String(hashedPassword) == ql[sbd].Pass;
                    }
                }

                if (checkUser && checkPass)
                {
                    XTKQL.name = ql[sbd].Name;
                    RSPassQL.name = ql[sbd].Name;

                    Manager mn = new Manager();
                    this.Hide();
                    mn.ShowDialog();
                }
                else
                {
                    error smk = new saimatkhau();
                    smk.mess();
                }
            }
            else
            {
                List<NhanVienBanThoiGian> lnv = new List<NhanVienBanThoiGian>();
                using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
                    lnv = (List<NhanVienBanThoiGian>)xs.Deserialize(fs);
                }

                int sbd = -1;

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
                if (checkUser == true)
                {
                    using (SHA256Managed sha256 = new SHA256Managed())
                    {
                        byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(passText.Text));
                        checkPass = Convert.ToBase64String(hashedPassword) == lnv[sbd].Pass;
                    }
                }

                if (checkUser && checkPass)
                {
                    
                        DateTime now = DateTime.Now;
                        BilliardsManagement.gioluong = now.Hour;
                        BilliardsManagement.phutluong = now.Minute;
                        BilliardsManagement.giayluong = now.Second;
                        BilliardsManagement.name = lnv[sbd].Name;
                        BilliardsManagement.user = userText.Text;
                        BilliardsManagement bm = new BilliardsManagement();
                        this.Hide();
                        bm.ShowDialog();
                    
                }
                else
                {
                    error smk = new saimatkhau();
                    smk.mess();
                }
            }
        }

        private void userText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
