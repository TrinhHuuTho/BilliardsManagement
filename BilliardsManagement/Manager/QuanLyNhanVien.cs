using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardsManagement
{
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager mn = new Manager();
            this.Hide();
            mn.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DMKCF dmk = new DMKCF();
            dmk.ShowDialog();
            if (dmk.choose == "Nhân Viên")
            {
                LNhanVien lnv = new LNhanVien();
                lnv.ShowDialog();
            }
            if (dmk.choose == "Quản Lý")
            {
                LQuanLy lql = new LQuanLy();
                lql.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DMKCF dmk = new DMKCF();
            dmk.ShowDialog();
            if (dmk.choose == "Nhân Viên")
            {
                XoaTaiKhoan xtk = new XoaTaiKhoan();
                xtk.ShowDialog();
            }
            if (dmk.choose == "Quản Lý")
            {
                XTKQL xtkql = new XTKQL();
                xtkql.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DMKCF dmk = new DMKCF();
            dmk.ShowDialog();
            if (dmk.choose == "Nhân Viên")
            {
                DoiMatKhau dmknv = new DoiMatKhau();
                dmknv.ShowDialog();
            }
            if (dmk.choose == "Quản Lý")
            {
                DMKQL dmkql = new DMKQL();
                dmkql.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThemQuanLy ql = new ThemQuanLy();
            ql.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LuongNhanVien nv = new LuongNhanVien();
            nv.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DMKCF dmk = new DMKCF();
            dmk.ShowDialog();
            if (dmk.choose == "Nhân Viên")
            {
                RSPass rp = new RSPass();
                rp.ShowDialog();
            }
            if (dmk.choose == "Quản Lý")
            {
                RSPassQL rp = new RSPassQL();
                rp.ShowDialog();
            }
        }
    }
}
