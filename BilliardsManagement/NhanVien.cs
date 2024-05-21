using BilliardsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BilliardsManagement
{
    public class NhanVien
    {
        public string Name { get; set; }
        public string Numb { get; set; }
        public string User {  get; set; }  
        public string Pass {  get; set; }
        public NhanVien(string Name, string Numb, string Pass)
        {
            this.Name = Name;
            this.Numb = Numb;
            this.Pass = Pass;
        }
        public NhanVien() { }
    }

    public class NhanVienBanThoiGian : NhanVien
    {
        public NhanVienBanThoiGian(string Name, string Numb, string Pass) : base(Name, Numb, Pass)
        {
        }
        public NhanVienBanThoiGian() { }
        List<NhanVienBanThoiGian> lnv = new List<NhanVienBanThoiGian>();
        XmlSerializer serial = new XmlSerializer(typeof(List<NhanVienBanThoiGian>));
        public List<NhanVienBanThoiGian> GetNV()
        {
            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Account.xml", FileMode.Open, FileAccess.Read))
            {
                lnv = serial.Deserialize(fs) as List<NhanVienBanThoiGian>;
            }
            lnv = lnv.Select(f => new NhanVienBanThoiGian
            {
                Name = f.Name,
                Numb = f.Numb,
                User = f.User,
                Pass = "******"
            }).ToList();
            List<NhanVienBanThoiGian> result = lnv.Cast<NhanVienBanThoiGian>().ToList();
            return result;
        }
    }

    public class QuanLy : NhanVien 
    {
        public QuanLy(string Name, string Numb, string Pass) : base(Name, Numb, Pass)
        {
        }
        public QuanLy() { } 
        List<QuanLy> lnv = new List<QuanLy>();
        XmlSerializer serial = new XmlSerializer(typeof(List<QuanLy>));
        public List<NhanVien> GetNV()
        {
            using (FileStream fs = new FileStream("C:\\Users\\Public\\BilliardManagement\\Manager.xml", FileMode.Open, FileAccess.Read))
            {
                lnv = serial.Deserialize(fs) as List<QuanLy>;
            }
            lnv = lnv.Select(f => new QuanLy
            {
                Name = f.Name,
                Numb = f.Numb,
                User = f.User,
                Pass = "******"
            }).ToList();
            List<NhanVien> result = lnv.Cast<NhanVien>().ToList();
            return result;
        }
    }

    public class Luong
    {
        public string User { get; set; }
        public string Name { get; set; }
        public int Hour { get; set; }
    }

}
