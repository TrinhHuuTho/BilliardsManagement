using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BilliardsManagement
{
    public partial class MBill : Form
    {
        public MBill()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        abstract class dieuhuong
        {
            public abstract void Click();
        }
        class LBil : dieuhuong
        {
            public override void Click()
            {
                LBill lb = new LBill();
                lb.ShowDialog();
            }
        }
        class RSBill : dieuhuong
        {
            public override void Click()
            {
                del d = new del();
                d.ShowDialog();
                if (d.myBool)
                {
                    XDocument nhatkybillDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("ArrayOfNhatKyBill"
                    )
                    );
                    nhatkybillDoc.Save("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml");
                    MessageBox.Show("Reset Bill Thành Công!!!");
                }
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Manager mn = new Manager();
            this.Hide();
            mn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dieuhuong lb = new LBil();
            lb.Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dieuhuong rs = new RSBill();
            rs.Click();
        }

        private void MBill_Load(object sender, EventArgs e)
        {

        }
    }
}
