using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace BilliardsManagement
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            string dir = @"C:\Users\Public\BilliardManagement";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string managerXmlPath = Path.Combine(dir, "Manager.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Manager.Xml"))
            {
                XDocument managerDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfQuanLy",
                        new XElement("QuanLy",
                            new XElement("Name", "ADMIN"),
                            new XElement("Numb", "*********"),
                            new XElement("User", "admin"),
                            new XElement("Pass", "O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=")
                        )
                    )
                    );
                managerDoc.Save("C:\\Users\\Public\\BilliardManagement\\Manager.Xml");
            }

            string accountXmlPath = Path.Combine(dir, "Account.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Account.Xml"))
            {
                XDocument accountDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfNhanVienBanThoiGian"
                )
                );
                accountDoc.Save("C:\\Users\\Public\\BilliardManagement\\Account.Xml");
            }

            string banXmlPath = Path.Combine(dir, "Ban.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Ban.Xml"))
            {
                XDocument banDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBan",
                        new XElement("Ban",
                            new XElement("InOut", "Out"),
                            new XElement("Hour", "00"),
                            new XElement("Minute", "00"),
                            new XElement("Second", "00")
                        ),
                        new XElement("Ban",
                            new XElement("InOut", "Out"),
                            new XElement("Hour", "00"),
                            new XElement("Minute", "00"),
                            new XElement("Second", "00")
                        ),
                        new XElement("Ban",
                            new XElement("InOut", "Out"),
                            new XElement("Hour", "00"),
                            new XElement("Minute", "00"),
                            new XElement("Second", "00")
                        ),
                        new XElement("Ban",
                            new XElement("InOut", "Out"),
                            new XElement("Hour", "00"),
                            new XElement("Minute", "00"),
                            new XElement("Second", "00")
                        ),
                        new XElement("Ban",
                            new XElement("InOut", "Out"),
                            new XElement("Hour", "00"),
                            new XElement("Minute", "00"),
                            new XElement("Second", "00")
                        ),
                        new XElement("Ban",
                            new XElement("InOut", "Out"),
                            new XElement("Hour", "00"),
                            new XElement("Minute", "00"),
                            new XElement("Second", "00")
                        )
                    )
                    );
                banDoc.Save("C:\\Users\\Public\\BilliardManagement\\Ban.Xml");
            }

            string foodAndDrinkXmlPath = Path.Combine(dir, "FoodAndDrink.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfFoodAndDrink",
                        new XElement("FoodAndDrink",
                            new XElement("Name", "--Lựa Chọn Đồ Ăn--"),
                            new XElement("Type", "Đồ Ăn"),
                            new XElement("Price", "0")
                        ),
                        new XElement("FoodAndDrink",
                            new XElement("Name", "--Lựa Chọn Đồ Uống--"),
                            new XElement("Type", "Đồ Uống"),
                            new XElement("Price", "0")
                        ),
                        new XElement("FoodAndDrink",
                            new XElement("Name", "--Lựa Chọn Món Khác--"),
                            new XElement("Type", "Món Khác"),
                            new XElement("Price", "0")
                        )
                )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\FoodAndDrink.Xml");
            }

            string luongPath = Path.Combine(dir, "luong.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\luong.Xml"))
            {
                XDocument luongDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfluong",
                        new XElement("luong",
                            new XElement("User", ""),
                            new XElement("Name", ""),
                            new XElement("Hour", "0")
                        )
                )
                ) ;
                luongDoc.Save("C:\\Users\\Public\\BilliardManagement\\luong.Xml");
            }

            string nhatkybillPath = Path.Combine(dir, "NhatKyBill.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml"))
            {
                XDocument nhatkybillDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfNhatKyBill"
                )
                );
                nhatkybillDoc.Save("C:\\Users\\Public\\BilliardManagement\\NhatKyBill.Xml");
            }

            dir = @"C:\Users\Public\BilliardManagement\Bill";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string Ban1XmlPath = Path.Combine(dir, "Ban1.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBill"
                )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban1.Xml");
            }

            string Ban2XmlPath = Path.Combine(dir, "Ban2.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBill"
                )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban2.Xml");
            }

            string Ban3XmlPath = Path.Combine(dir, "Ban3.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBill"
                    )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban3.Xml");
            }

            string Ban4XmlPath = Path.Combine(dir, "Ban4.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBill"
                    )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban4.Xml");
            }

            string Ban5XmlPath = Path.Combine(dir, "Ban5.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBill"
                    )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban5.Xml");
            }

            string Ban6XmlPath = Path.Combine(dir, "Ban6.Xml");
            if (!File.Exists("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml"))
            {
                XDocument foodAndDrinkDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("ArrayOfBill"
                    )
                );
                foodAndDrinkDoc.Save("C:\\Users\\Public\\BilliardManagement\\Bill\\Ban6.Xml");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exit thoat = new exit();
            thoat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.ShowDialog();
        }
    }
}