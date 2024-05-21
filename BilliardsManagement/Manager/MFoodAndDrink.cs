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
    public partial class MFoodAndDrink : Form
    {
        public MFoodAndDrink()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        abstract class dieuhuong
        {
            public abstract void Click();
        }
        class add : dieuhuong
        {
            public override void Click()
            {
                ThemMon tm = new ThemMon();
                tm.ShowDialog();
            }
        }

        class list : dieuhuong
        { 
            public override void Click()
            {
                LFoodAndDrink LFAD = new LFoodAndDrink();
                LFAD.ShowDialog();
            }
        }

        class del : dieuhuong
        {
            public override void Click()
            {
                XoaMon xm = new XoaMon();
                xm.ShowDialog();
            }
        }

        private void MFoodAndDrink_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager mn = new Manager();
            this.Hide();
            mn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dieuhuong del = new del();
            del.Click();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dieuhuong add = new add();
            add.Click();
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
            dieuhuong list = new list();
            list.Click();
        }
    }
}
