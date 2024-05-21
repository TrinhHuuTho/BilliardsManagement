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

namespace BilliardsManagement
{
    public partial class SignUp : Form
    {
        XmlSerializer xs;
        List<NhanVienBanThoiGian> lnv;
        public SignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            lnv = new List<NhanVienBanThoiGian>();
            xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
        }

        class error
        {
            public virtual void mess()
            {
                MessageBox.Show("...");
            }
        }
        class thieuthongtin : error
        {
            public override void mess()
            {
                MessageBox.Show("Hãy Điền Đầy Đủ Thông Tin Để Đăng Ký!");
            }
        }

        class matkhaukhonggiongnhau : error
        {
            public override void mess()
            {
                MessageBox.Show("Mật Khẩu Không Giống Nhau, Xin Hãy Nhập Lại!");
            }
        }

        class tendangnhaptontai : error
        {
            public override void mess()
            {
                MessageBox.Show("Tên Đăng Nhập Đã Tồn Tại, Xin Hãy Nhập Tên Đăng Nhập Khác!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userText.Text == "" || numbText.Text == "" || passText.Text == "")
            {
                error ttt = new thieuthongtin();
                ttt.mess();
                return;
            }
            if (numbText.Text == "")
            {
                MessageBox.Show("Hãy Nhập Số Điện Thoại Của Khách Hàng!");
                return;
            }
            string value = numbText.Text;

            if (!int.TryParse(value, out int number))
            {
                MessageBox.Show("Vui Lòng Nhập Số Điện Thoại!");
                numbText.Text = "";
                return;
            }
            if (int.Parse(numbText.Text) < 100000000)
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Số!");
                numbText.Text = "";
                return;
            }
            else
            {
                if (passAText.Text != passText.Text)
                {
                    error mmkgn = new matkhaukhonggiongnhau();
                    mmkgn.mess();
                    return;
                }
                else
                {
                    if (passText.Text.Length < 8 || !passText.Text.Any(char.IsUpper))
                    {
                        MessageBox.Show("Mặt Khẩu Phải trên 8 Kí Tự Và Có Ít Nhất 1 Chữ Viết Hoa!");
                        return;
                    }
                    else
                    {
                        List<NhanVienBanThoiGian> lnv = new List<NhanVienBanThoiGian>();
                        using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Open, FileAccess.Read))
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
                            lnv = (List<NhanVienBanThoiGian>)xs.Deserialize(fs);
                        }

                        bool check = false;
                        for (int i = 0; i < lnv.Count; i++)
                        {
                            if (lnv[i].User == userText.Text)
                            {
                                check = true;
                                break;
                            }
                        }

                        if (check)
                        {
                            error tdntt = new tendangnhaptontai();
                            tdntt.mess();
                            return;
                        }

                        string user = userText.Text;
                        user = user.ToLower();

                        NhanVienBanThoiGian nv = new NhanVienBanThoiGian();
                        nv.Name = nameText.Text;
                        nv.Numb = numbText.Text;
                        nv.User = user;

                        using (SHA256Managed sha256 = new SHA256Managed())
                        {
                            byte[] hashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(passText.Text));
                            nv.Pass = Convert.ToBase64String(hashedPassword);
                        }


                        lnv.Add(nv);

                        using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.Xml", FileMode.Create, FileAccess.Write))
                        {
                            XmlSerializer xs = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
                            xs.Serialize(fs, lnv);
                        }

                        MessageBox.Show("Đăng Ký Thành Công!!!");

                        Menu menu = new Menu();
                        this.Hide();
                        menu.ShowDialog();
                    }
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}