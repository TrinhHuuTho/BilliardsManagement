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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        abstract class dieuhuong
        {
            public abstract void Click();
        }
        class NhanVien : dieuhuong
        {
            public override void Click()
            {
                QuanLyNhanVien nv = new QuanLyNhanVien();
                nv.ShowDialog();
            }
        }
        class Bill : dieuhuong
        {
            public override void Click()
            {
                MBill mb = new MBill();
                mb.ShowDialog();
            }
        }
        class FAD : dieuhuong
        { 
            public override void Click()
            {
                Menu menu = new Menu();
                menu.ShowDialog();
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MFoodAndDrink mfad = new MFoodAndDrink();
            this.Hide();
            mfad.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dieuhuong FAD = new FAD();
            FAD.Click();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit thoat = new exit();
            thoat.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dieuhuong NV = new NhanVien();
            NV.Click();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dieuhuong bl = new Bill();
            bl.Click();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
